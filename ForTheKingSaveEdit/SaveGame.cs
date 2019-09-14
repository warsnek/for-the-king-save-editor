using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace ForTheKingSaveEdit
{
  public class SaveGame
  {
    private readonly string _saveGameFilePath;
    private JObject _rawSaveGameData;
    private Dictionary<string, CharacterInfo> _characters = new Dictionary<string, CharacterInfo>();

    public IReadOnlyCollection<string> CharacterIds => _characters.Keys;

    public SaveGame(string saveGameFilePath, JObject rawSaveGameData)
    {
      _saveGameFilePath = saveGameFilePath;
      _rawSaveGameData = rawSaveGameData;

      var gameInfo = (JObject)rawSaveGameData["m_GameInfo"];
      var playedWith = (JArray)gameInfo["m_PlayedWith"];
      var playedWithClass = (JArray)gameInfo["m_PlayedWithClass"];
      var playedWithLevel = (JArray)gameInfo["m_PlayedWithLevel"];
      var playerSerialize = (JArray)rawSaveGameData["m_PlayerSerialize"];

      for (int i = 0; i < playedWith.Count; i++)
      {
        var characterId = $"{playedWith[i].Value<string>()} ({playedWithClass[i].Value<string>()} - level {playedWithLevel[i].Value<int>()})";
        var characterInfo = new CharacterInfo((JObject)playerSerialize[i]);
        _characters.Add(characterId, characterInfo);
      } 
    }

    public CharacterInfo GetCharacterInfo(string characterId)
    {
      return _characters[characterId];
    }

    public static bool TryLoadSaveGame(string saveGameFilePath, out SaveGame saveGame)
    {      
      try
      {
        byte[] b = File.ReadAllBytes(saveGameFilePath);
        string content = GZip.Decompress(b);
        saveGame = new SaveGame(saveGameFilePath, JObject.Parse(content));
        return true;
      }
      catch
      {
        saveGame = null;
        return false;
      }
    }

    public void Save()
    {
      foreach (var characterInfo in _characters.Values)
      {
        characterInfo.ApplyChanges();
      }

      string content = _rawSaveGameData.ToString(Formatting.None);
      File.WriteAllBytes(_saveGameFilePath, GZip.Compress(content));
    }
  }
}
