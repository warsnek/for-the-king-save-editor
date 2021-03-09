using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ForTheKingSaveEdit
{
  public partial class MainForm : Form
  {
    private string _playerDbFilePath;
    private long _originalLorePoints;
    private long _lorePoints;

    private Dictionary<string, SaveGame> _saveGames = new Dictionary<string, SaveGame>();
    
    private Dictionary<string, long> _playerStatisticsToUpdate = new Dictionary<string, long>();

    private string FindPlayerDbFilePath(string saveDirectoryPath)
    {
      var playerDbFiles = Directory.EnumerateFiles(saveDirectoryPath, "player.db", SearchOption.AllDirectories).OrderBy(p => p.Length).ToArray();
      if(playerDbFiles.Length == 0)
      {
        return null;
      }
      else if(playerDbFiles.Length == 1)
      {
        return playerDbFiles[0];
      }

      var selectionForm = new PlayerDBSelectorForm(playerDbFiles);
      selectionForm.ShowDialog();
      return selectionForm.SelectedFile;
    }

    public MainForm(string saveDirectoryPath)
    {
      InitializeComponent();

      _playerDbFilePath = FindPlayerDbFilePath(saveDirectoryPath);
      if(_playerDbFilePath == null)
      {
        MessageBox.Show($"Unable to find the player.db file.", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Environment.Exit(1);
      }      

      _lorePoints = GetLorePointsFromDb();
      _originalLorePoints = _lorePoints;

      if(_lorePoints > 5000) { _lorePoints = 5000; }
      if(_lorePoints < 0) { _lorePoints = 0; }

      loreNumericUpDown.Value = _lorePoints;

      // Load the .run file in the save directory (current gameinfo)

      foreach(var runFilePath in Directory.EnumerateFiles(saveDirectoryPath, "*.run", SearchOption.AllDirectories))
      {
        if(SaveGame.TryLoadSaveGame(runFilePath, out SaveGame saveGame))
        {
          string runFileName = Path.GetFileName(runFilePath);

          var label = GetSaveFileLabel(runFileName);
          _saveGames.Add(label, saveGame);
          saveGameComboBox.Items.Add(label);
        }
      }
      
      string GetSaveFileLabel(string runFileName)
      {
        string label = runFileName;
        int i = 2;
        while(_saveGames.ContainsKey(label))
        {
          label = $"{runFileName} ({i})";
          i++;
        }

        return label;
      }
    }

    private SQLiteConnection CreatePlayerDbConnection()
    {
      return new SQLiteConnection($"Data Source={_playerDbFilePath}; Version=3;");
    }

    private long GetLorePointsFromDb()
    {
      long result;
      using(var playerDbCon = CreatePlayerDbConnection())
      {
        playerDbCon.Open();

        using (var command = new SQLiteCommand("SELECT VALUE FROM sPlayerStatistic WHERE Name = 'STAT_LU_TOTAL_LORE'", playerDbCon))
        {
          result = (long)command.ExecuteScalar();
        }

        playerDbCon.Close();
      }
      return result;
    }

    private void SaveToPlayerDb()
    {
      using (var playerDbCon = CreatePlayerDbConnection())
      {
        playerDbCon.Open();
        
        if(_originalLorePoints != _lorePoints)
        {
          UpdatePlayerStatistic(playerDbCon, "STAT_LU_TOTAL_LORE", _lorePoints);
        }

        foreach(var playerStatistic in _playerStatisticsToUpdate)
        {
          UpdatePlayerStatistic(playerDbCon, playerStatistic.Key, playerStatistic.Value);
        }

        playerDbCon.Close();
      }

      void UpdatePlayerStatistic(SQLiteConnection connection, string name, long value)
      {
        using (var command = new SQLiteCommand("UPDATE sPlayerStatistic SET Value = @value WHERE Name = @name", connection))
        {
          command.Parameters.AddWithValue("@name", name);
          command.Parameters.AddWithValue("@value", value);
          command.ExecuteNonQuery();
        }
      }
    }

    private void SelectCharacterComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      var characterInfo = GetActiveCharacterInfo();
      if (characterInfo == null)
      {
        characterInfoPanel.Enabled = false;
      }
      else
      {
        characterInfoPanel.Enabled = true;
        goldNumericUpDown.Value = characterInfo.Gold;
        damagePhysicalNumericUpDown.Value = characterInfo.AugmentedDamagePhysical;
        damageMagicalNumericUpDown.Value = characterInfo.AugmentedDamageMagic;
        defensePhysicalNumericUpDown.Value = characterInfo.AugmentedDefensePhysical;
        defenseMagicNumericUpDown.Value = characterInfo.AugmentedDefenseMagic;
        evadeRatingNumericUpDown.Value = Convert.ToDecimal(characterInfo.AugmentedEvadeRating);
        toughnessNumericUpDown.Value = Convert.ToDecimal(characterInfo.AugmentedToughness);
        awarenessNumericUpDown.Value = Convert.ToDecimal(characterInfo.AugmentedAwareness);
        fortitudeNumericUpDown.Value = Convert.ToDecimal(characterInfo.AugmentedFortitude);
        quicknessNumericUpDown.Value = Convert.ToDecimal(characterInfo.AugmentedQuickness);
        vitalityNumericUpDown.Value = Convert.ToDecimal(characterInfo.AugmentedVitality);
        talentNumericUpDown.Value = Convert.ToDecimal(characterInfo.AugmentedTalent);
        luckNumericUpDown.Value = Convert.ToDecimal(characterInfo.AugmentedLuck);
        maxFocusNumericUpDown.Value = Convert.ToDecimal(characterInfo.AugmentedMaxFocus);
        maxHealthNumericUpDown.Value = Convert.ToDecimal(characterInfo.AugmentedMaxHealth);
      }
    }

    private void GoldNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().Gold = Convert.ToInt32(goldNumericUpDown.Value);
    }

    private void DamagePhysicalNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedDamagePhysical = Convert.ToInt32(damagePhysicalNumericUpDown.Value);
    }

    private void DamageMagicalNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedDamageMagic = Convert.ToInt32(damageMagicalNumericUpDown.Value);
    }

    private void DefensePhysicalNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedDefensePhysical = Convert.ToInt32(defensePhysicalNumericUpDown.Value);
    }

    private void DefenseMagicNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedDefenseMagic = Convert.ToInt32(defenseMagicNumericUpDown.Value);
    }

    private void EvadeRatingNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedEvadeRating = Convert.ToInt32(evadeRatingNumericUpDown.Value);
    }

    private void ThoughnessNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedToughness = Convert.ToInt32(toughnessNumericUpDown.Value);
    }

    private void AwarenessNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedAwareness = Convert.ToInt32(awarenessNumericUpDown.Value);
    }

    private void FortitudeNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedFortitude = Convert.ToInt32(fortitudeNumericUpDown.Value);
    }

    private void QuicknessNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedQuickness = Convert.ToInt32(quicknessNumericUpDown.Value);
    }

    private void VitalityNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedVitality = Convert.ToInt32(vitalityNumericUpDown.Value);
    }

    private void TalentNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedTalent = Convert.ToInt32(talentNumericUpDown.Value);
    }

    private void LuckNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedLuck = Convert.ToInt32(luckNumericUpDown.Value);
    }

    private void MaxFocusNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedMaxFocus = Convert.ToInt32(maxFocusNumericUpDown.Value);
    }

    private void MaxHealthNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedMaxHealth = Convert.ToInt32(maxHealthNumericUpDown.Value);
    }

    private SaveGame GetActiveSaveGame()
    {
      var saveGameId = (string)saveGameComboBox.SelectedItem;
      if (saveGameId == null)
      {
        return null;
      }

      return _saveGames[saveGameId];
    }

    private CharacterInfo GetActiveCharacterInfo()
    {
      var characterId = (string)selectCharacterComboBox.SelectedItem;
      if (characterId == null)
      {
        return null;
      }

      return GetActiveSaveGame().GetCharacterInfo(characterId);
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      try
      {
        if(_originalLorePoints != _lorePoints || _playerStatisticsToUpdate.Count > 0)
        {
          SaveToPlayerDb();
        }

        foreach(var saveGame in _saveGames.Values)
        {
          saveGame.Save();
        }
        MessageBox.Show("Saved succesfully!", "MAH QWEEN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Save failed: {ex}", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      Close();
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void LoreNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      var lorePoints = Convert.ToInt64(loreNumericUpDown.Value);
      if(lorePoints > 5000)
      {
        lorePoints = 5000;
      }

      _lorePoints = lorePoints;
    }

    private void UnlockButton_Click(object sender, EventArgs e)
    {
      var unlockOptions = new Dictionary<string, long>()
      {
        { "STAT_LU_SKINUNDEAD_REVEAL", 1 },
        { "STAT_LU_SKINCAT_REVEAL", 1 },
        { "STAT_LU_PIRATE_REVEAL", 1 },
        { "STAT_LU_HELMETWINTER_REVEAL", 1 },
        { "STAT_LU_HELMETTOPHAT_REVEAL", 1 },
        { "STAT_LU_HELMETPUMPKIN_REVEAL", 1 },
        { "STAT_LU_HELMETMOOSE_REVEAL", 1 },
        { "STAT_LU_HELMETKS_REVEAL", 1 },
        { "STAT_LU_HELMETEXPLORER_REVEAL", 1 },
        { "STAT_LU_HELMETBUCKET_REVEAL", 1 },
        { "STAT_LU_BACKPACKWARRIOR_REVEAL", 1 },
        { "STAT_LU_BACKPACKQUIVER_REVEAL", 1 },
        { "STAT_LU_BACKPACKPUMPKIN_REVEAL", 1 },
        { "STAT_LU_BACKPACKMERCHANT_REVEAL", 1 },
        { "STAT_LU_BACKPACKKS_REVEAL", 1 },
        { "STAT_LU_BACKPACKBASKET_REVEAL", 1 },
        { "STAT_LU_BACKPACKBARREL_REVEAL", 1 },
        { "STAT_LU_ARMORPUMPKIN_REVEAL", 1 },
        { "STAT_LU_HOBO_CHARITY", 1 },
        { "STAT_LU_MONK_RESCUE", 1 },
        { "STAT_LU_PROGRESS_ACTI", 1 },
        { "STAT_LU_PROGRESS_ACTII", 1 },
        { "STAT_LU_PROGRESS_ACTIII", 1 },
        { "STAT_LU_PROGRESS_ACTIV", 1 },
        { "STAT_DEATH_AT_SEA", 1 },
        { "STAT_PRISMATIC_FISH", 1 },
        { "STAT_SANCTUMS_DEVOTED", 8 },
        { "STAT_SANCTUM01_DEVOTED", 8 },
        { "STAT_SANCTUM02_DEVOTED", 8 },
        { "STAT_SANCTUM03_DEVOTED", 8 },
        { "STAT_SANCTUM04_DEVOTED", 8 },
        { "STAT_SANCTUM05_DEVOTED", 8 },
        { "STAT_SANCTUM06_DEVOTED", 8 },
        { "STAT_SANCTUM07_DEVOTED", 8 },
        { "STAT_SANCTUM08_DEVOTED", 8 },
        { "STAT_SANCTUM09_DEVOTED", 8 },
        { "STAT_LU_STONE_HERO_TRIBUTES", 50 },
        { "STAT_PARTY_WIPES", 3 },
        { "STAT_NIGHT_MARKET_PURCHASES", 10 },
        { "STAT_CELLAR_LEVEL_DEPTH", 9 },
        { "STAT_SHIPWRECKS", 1 },
        { "STAT_BEATCULTISTCAMP", 1 },
        { "STAT_LU_HELMETSANTA", 1 },
        { "STAT_LU_BACKPACKSANTA", 1 },
        { "STAT_LU_SKINFISH", 1 },
        { "STAT_LU_HELMETNEWYEAR", 1 },
        { "STAT_LU_BACKPACKVALENTINE", 1 },
        { "STAT_LU_HELMETSTPATRICK", 1 },
        { "STAT_LU_ARMORSTPATRICK", 1 },
        { "STAT_LU_HELMETEASTER", 1 },
        { "STAT_TREASURE_BOATS_DEFEATED", 1 }, // Golden Gun unlock condition
        // { "STAT_LU_ITEMGOLDENGUN", 1 }, // Golden Gun unlock
        { "STAT_KILLED_FISH", 15 }, // Bone Harpoon unlock condition
        //{ "STAT_LU_ITEMBONEHARPOON", 1 }, // Bone Harpoon unlock
        { "STAT_LU_GLADIATOR_REVEAL", 1 },
        { "STAT_LU_ASTRONOMER_REVEAL", 1 },
        { "STAT_LU_ARMORMONKEY", 1 },        
        { "STAT_LU_BACKPACKBOBBLE_REVEAL", 1 },        
        { "STAT_LU_HELMETMONKEY", 1 },
        { "STAT_USED_CANDIES", 50 }, // Lolli wand unlock condition
        //{ "STAT_LU_ITEMWANDLOLLI", 1 }, // Lolli wand unlock
        { "STAT_AMBUSHSUCCESSES", 10 }, // Sais unlock condition
        { "STAT_USEDORBGROUPSHIELDS", 5 }, // Starfire wand unlock condition
        //{ "STAT_LU_ITEMSTARFIRE", 1 }, // Starfire wand unlock
        { "STAT_NUM_TIMES_DISEASED", 1 }, // Immunity Amulet unlock condition and Disease Healer (location) unlock condition
        //{ "STAT_LU_AMULETIMMUNITY", 1 }, // Immunity Amulet unlock
        { "STAT_LU_LOCALARENA_REVEAL", 1 },
        //{ "STAT_LU_BACKERSDLC", 1 },
        //{ "STAT_LU_BACKERSPLUSDLC", 1 },
        { "STAT_KILLED_SKELETONS", 150 },
        { "STAT_TREASURE_CHESTS_OPENED", 5 },
        { "STAT_LU_QUEENSGUARDREVEAL", 1}, // Queens Guard set unlock condition
        //{ "STAT_LU_ARMORQUEENSGUARD", 1}, // Queens Guard Armor unlock
        //{ "STAT_LU_HELMETQUEENSGUARD", 1} // Queens Guard Helmet unlock    
        { "STAT_LU_LORESTORESTORE_REVEAL", 1 }, // Lore Store Store condition
        { "STAT_KILLED_WARRIORS", 50 }, // Feathered banner unlock condition
        //{ "STAT_LU_BACKPACKAZTEC", 1 }, // Feathered banner unlock
        { "STAT_USED_SCROLLS", 50 }, // Scroll pack unlock condition
        //{ "STAT_LU_BACKPACKSCROLLS", 1 }, // Scroll pack unlock
      };

      try
      {
        using (var playerDbCon = CreatePlayerDbConnection())
        {
          playerDbCon.Open();

          foreach (var unlockOption in unlockOptions)
          {
            var value = GetValue(playerDbCon, unlockOption.Key);
            if(value != null && value < unlockOption.Value)
            {
              _playerStatisticsToUpdate[unlockOption.Key] = unlockOption.Value;
            }
          }

          playerDbCon.Close();
        }

        MessageBox.Show(_playerStatisticsToUpdate.Count > 0 ? "Unlocked a bunch of new items!" : "No new items unlocked :(", "Unlock Completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

      }
      catch(Exception ex)
      {
        MessageBox.Show($"Unlock failed: {ex}", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }


      long? GetValue(SQLiteConnection connection, string name)
      {
        using (var command = new SQLiteCommand("SELECT VALUE FROM sPlayerStatistic WHERE Name = @name", connection))
        {
          command.Parameters.AddWithValue("@name", name);

          using (var reader = command.ExecuteReader())
          {
            if (reader.HasRows)
            {
              reader.Read();
              return reader.GetInt64(0);
            }
          }
        }

        return null;
      }
    }

    private void SaveGameComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      var saveGame = GetActiveSaveGame();

      selectCharacterComboBox.Items.Clear();
      foreach(var characterId in saveGame.CharacterIds)
      {        
        selectCharacterComboBox.Items.Add(characterId);
      }
      selectCharacterComboBox.Enabled = true;
    }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
          throw new System.NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
          throw new System.NotImplementedException();
        }

        private void maxHealthLabel_Click(object sender, EventArgs e)
        {
          throw new System.NotImplementedException();
        }

        private void loreLabel_Click(object sender, EventArgs e)
        {
          throw new System.NotImplementedException();
        }
  }
}
