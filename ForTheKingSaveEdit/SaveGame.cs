using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace ForTheKingSaveEdit
{
  public class SaveGame
  {
    private JObject _rawSaveGameData;
    private Dictionary<string, CharacterInfo> _characters = new Dictionary<string, CharacterInfo>();

    public IReadOnlyCollection<string> CharacterIds => _characters.Keys;

    public SaveGame(JObject rawSaveGameData)
    {
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

    public static bool TryLoadSaveGame(string saveFilePath, out SaveGame saveGame)
    {      
      try
      {
        byte[] b = File.ReadAllBytes(saveFilePath);
        string content = GZip.Decompress(b);
        saveGame = new SaveGame(JObject.Parse(content));
        return true;
      }
      catch
      {
        saveGame = null;
        return false;
      }
    }

    public void Save(string saveFilePath)
    {
      foreach (var characterInfo in _characters.Values)
      {
        characterInfo.ApplyChanges();
      }

      string content = _rawSaveGameData.ToString(Formatting.None);
      File.WriteAllBytes(saveFilePath, GZip.Compress(content));
    }
  }
}
