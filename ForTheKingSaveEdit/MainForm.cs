using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ForTheKingSaveEdit
{
  public partial class MainForm : Form
  {
    private string _saveDirectoryPath;
    private string _saveGameFilePath;
    private long _originalLorePoints;
    private long _lorePoints;
    private SaveGame _saveGame;

    public MainForm(string saveDirectoryPath)
    {
      InitializeComponent();

      _saveDirectoryPath = saveDirectoryPath;

      _lorePoints = GetLorePointsFromDb();
      _originalLorePoints = _lorePoints;
      loreNumericUpDown.Value = _lorePoints;

      // Load the .run file in the save directory (current gameinfo)
      var runFilePath = Directory.EnumerateFiles(saveDirectoryPath, "*.run").FirstOrDefault();
      if (runFilePath != null && SaveGame.TryLoadSaveGame(runFilePath, out SaveGame saveGame))
      {
        _saveGameFilePath = runFilePath;
        _saveGame = saveGame;

        foreach (var characterId in _saveGame.CharacterIds)
        {
          selectCharacterComboBox.Items.Add(characterId);
        }
      }
      else
      {
        selectCharacterComboBox.Enabled = false;
        selectCharacterComboBox.Items.Add("-no game in progress-");
      }
    }

    private SQLiteConnection CreatePlayerDbConnection()
    {
      string dbFilePath = Path.Combine(_saveDirectoryPath, "player.db");
      return new SQLiteConnection($"Data Source={dbFilePath}; Version=3;");
    }

    private long GetLorePointsFromDb()
    {
      long result;
      using(var playerDbCon = CreatePlayerDbConnection())
      {
        playerDbCon.Open();

        var command = new SQLiteCommand("SELECT VALUE FROM sPlayerStatistic WHERE Name = 'STAT_LU_TOTAL_LORE'", playerDbCon);
        result = (long)command.ExecuteScalar();

        playerDbCon.Close();
      }
      return result;
    }

    private void SaveLorePointsToDb()
    {
      using (var playerDbCon = CreatePlayerDbConnection())
      {
        playerDbCon.Open();

        var command = new SQLiteCommand("UPDATE sPlayerStatistic SET Value = @loreValue WHERE Name = 'STAT_LU_TOTAL_LORE'", playerDbCon);
        command.Parameters.AddWithValue("@loreValue", _lorePoints);

        command.ExecuteNonQuery();
        playerDbCon.Close();
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
      GetActiveCharacterInfo().AugmentedEvadeRating = Convert.ToSingle(evadeRatingNumericUpDown.Value);
    }

    private void ThoughnessNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedToughness = Convert.ToSingle(toughnessNumericUpDown.Value);
    }

    private void AwarenessNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedAwareness = Convert.ToSingle(awarenessNumericUpDown.Value);
    }

    private void FortitudeNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedFortitude = Convert.ToSingle(fortitudeNumericUpDown.Value);
    }

    private void QuicknessNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedQuickness = Convert.ToSingle(quicknessNumericUpDown.Value);
    }

    private void VitalityNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedVitality = Convert.ToSingle(vitalityNumericUpDown.Value);
    }

    private void TalentNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedTalent = Convert.ToSingle(talentNumericUpDown.Value);
    }

    private void LuckNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedLuck = Convert.ToSingle(luckNumericUpDown.Value);
    }

    private void MaxFocusNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedMaxFocus = Convert.ToSingle(maxFocusNumericUpDown.Value);
    }

    private void MaxHealthNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      GetActiveCharacterInfo().AugmentedMaxHealth = Convert.ToSingle(maxHealthNumericUpDown.Value);
    }

    private CharacterInfo GetActiveCharacterInfo()
    {
      var characterId = (string)selectCharacterComboBox.SelectedItem;
      if (characterId == null)
      {
        return null;
      }

      return _saveGame.GetCharacterInfo(characterId);
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      try
      {
        if(_originalLorePoints != _lorePoints)
        {
          SaveLorePointsToDb();
        }

        if (_saveGame != null)
        {
          _saveGame.Save(_saveGameFilePath);
          MessageBox.Show("Saved succesfully!", "MAH QWEEN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
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
      _lorePoints = Convert.ToInt64(loreNumericUpDown.Value);
    }
  }
}
