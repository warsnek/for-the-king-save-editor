namespace ForTheKingSaveEdit
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.loreLabel = new System.Windows.Forms.Label();
      this.loreNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.currentGameGroupBox = new System.Windows.Forms.GroupBox();
      this.characterInfoPanel = new System.Windows.Forms.Panel();
      this.maxHealthNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label16 = new System.Windows.Forms.Label();
      this.maxFocusNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label15 = new System.Windows.Forms.Label();
      this.luckNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label14 = new System.Windows.Forms.Label();
      this.talentNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label13 = new System.Windows.Forms.Label();
      this.vitalityNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label12 = new System.Windows.Forms.Label();
      this.quicknessNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label11 = new System.Windows.Forms.Label();
      this.fortitudeNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label10 = new System.Windows.Forms.Label();
      this.awarenessNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label9 = new System.Windows.Forms.Label();
      this.toughnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label8 = new System.Windows.Forms.Label();
      this.evadeRatingNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label7 = new System.Windows.Forms.Label();
      this.damageMagicalNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label6 = new System.Windows.Forms.Label();
      this.damagePhysicalNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label5 = new System.Windows.Forms.Label();
      this.defenseMagicNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.defensePhysicalNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.goldNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.selectCharacterComboBox = new System.Windows.Forms.ComboBox();
      this.SaveButton = new System.Windows.Forms.Button();
      this.closeButton = new System.Windows.Forms.Button();
      this.unlockButton = new System.Windows.Forms.Button();
      this.label17 = new System.Windows.Forms.Label();
      this.saveGameComboBox = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.loreNumericUpDown)).BeginInit();
      this.currentGameGroupBox.SuspendLayout();
      this.characterInfoPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.maxHealthNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.maxFocusNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.luckNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.talentNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.vitalityNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.quicknessNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fortitudeNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.awarenessNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.toughnessNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.evadeRatingNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.damageMagicalNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.damagePhysicalNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.defenseMagicNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.defensePhysicalNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.goldNumericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // loreLabel
      // 
      this.loreLabel.AutoSize = true;
      this.loreLabel.Location = new System.Drawing.Point(12, 13);
      this.loreLabel.Name = "loreLabel";
      this.loreLabel.Size = new System.Drawing.Size(63, 13);
      this.loreLabel.TabIndex = 0;
      this.loreLabel.Text = "Lore Points:";
      // 
      // loreNumericUpDown
      // 
      this.loreNumericUpDown.Location = new System.Drawing.Point(78, 11);
      this.loreNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.loreNumericUpDown.Name = "loreNumericUpDown";
      this.loreNumericUpDown.Size = new System.Drawing.Size(80, 20);
      this.loreNumericUpDown.TabIndex = 1;
      this.loreNumericUpDown.ValueChanged += new System.EventHandler(this.LoreNumericUpDown_ValueChanged);
      // 
      // currentGameGroupBox
      // 
      this.currentGameGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.currentGameGroupBox.Controls.Add(this.characterInfoPanel);
      this.currentGameGroupBox.Controls.Add(this.label1);
      this.currentGameGroupBox.Controls.Add(this.selectCharacterComboBox);
      this.currentGameGroupBox.Location = new System.Drawing.Point(12, 78);
      this.currentGameGroupBox.Name = "currentGameGroupBox";
      this.currentGameGroupBox.Size = new System.Drawing.Size(393, 475);
      this.currentGameGroupBox.TabIndex = 2;
      this.currentGameGroupBox.TabStop = false;
      this.currentGameGroupBox.Text = "Save Game";
      // 
      // characterInfoPanel
      // 
      this.characterInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.characterInfoPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.characterInfoPanel.Controls.Add(this.maxHealthNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label16);
      this.characterInfoPanel.Controls.Add(this.maxFocusNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label15);
      this.characterInfoPanel.Controls.Add(this.luckNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label14);
      this.characterInfoPanel.Controls.Add(this.talentNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label13);
      this.characterInfoPanel.Controls.Add(this.vitalityNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label12);
      this.characterInfoPanel.Controls.Add(this.quicknessNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label11);
      this.characterInfoPanel.Controls.Add(this.fortitudeNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label10);
      this.characterInfoPanel.Controls.Add(this.awarenessNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label9);
      this.characterInfoPanel.Controls.Add(this.toughnessNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label8);
      this.characterInfoPanel.Controls.Add(this.evadeRatingNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label7);
      this.characterInfoPanel.Controls.Add(this.damageMagicalNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label6);
      this.characterInfoPanel.Controls.Add(this.damagePhysicalNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label5);
      this.characterInfoPanel.Controls.Add(this.defenseMagicNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label4);
      this.characterInfoPanel.Controls.Add(this.defensePhysicalNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label3);
      this.characterInfoPanel.Controls.Add(this.goldNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.label2);
      this.characterInfoPanel.Enabled = false;
      this.characterInfoPanel.Location = new System.Drawing.Point(19, 49);
      this.characterInfoPanel.Name = "characterInfoPanel";
      this.characterInfoPanel.Size = new System.Drawing.Size(353, 403);
      this.characterInfoPanel.TabIndex = 2;
      // 
      // maxHealthNumericUpDown
      // 
      this.maxHealthNumericUpDown.Location = new System.Drawing.Point(162, 373);
      this.maxHealthNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.maxHealthNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
      this.maxHealthNumericUpDown.Name = "maxHealthNumericUpDown";
      this.maxHealthNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.maxHealthNumericUpDown.TabIndex = 31;
      this.maxHealthNumericUpDown.ValueChanged += new System.EventHandler(this.MaxHealthNumericUpDown_ValueChanged);
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(13, 375);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(115, 13);
      this.label16.TabIndex = 30;
      this.label16.Text = "AugmentedMaxHealth:";
      // 
      // maxFocusNumericUpDown
      // 
      this.maxFocusNumericUpDown.Location = new System.Drawing.Point(162, 347);
      this.maxFocusNumericUpDown.Name = "maxFocusNumericUpDown";
      this.maxFocusNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.maxFocusNumericUpDown.TabIndex = 29;
      this.maxFocusNumericUpDown.ValueChanged += new System.EventHandler(this.MaxFocusNumericUpDown_ValueChanged);
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(13, 349);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(113, 13);
      this.label15.TabIndex = 28;
      this.label15.Text = "AugmentedMaxFocus:";
      // 
      // luckNumericUpDown
      // 
      this.luckNumericUpDown.Location = new System.Drawing.Point(162, 321);
      this.luckNumericUpDown.Name = "luckNumericUpDown";
      this.luckNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.luckNumericUpDown.TabIndex = 27;
      this.luckNumericUpDown.ValueChanged += new System.EventHandler(this.LuckNumericUpDown_ValueChanged);
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(13, 323);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(88, 13);
      this.label14.TabIndex = 26;
      this.label14.Text = "AugmentedLuck:";
      // 
      // talentNumericUpDown
      // 
      this.talentNumericUpDown.Location = new System.Drawing.Point(162, 295);
      this.talentNumericUpDown.Name = "talentNumericUpDown";
      this.talentNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.talentNumericUpDown.TabIndex = 25;
      this.talentNumericUpDown.ValueChanged += new System.EventHandler(this.TalentNumericUpDown_ValueChanged);
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(13, 297);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(94, 13);
      this.label13.TabIndex = 24;
      this.label13.Text = "AugmentedTalent:";
      // 
      // vitalityNumericUpDown
      // 
      this.vitalityNumericUpDown.Location = new System.Drawing.Point(162, 269);
      this.vitalityNumericUpDown.Name = "vitalityNumericUpDown";
      this.vitalityNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.vitalityNumericUpDown.TabIndex = 23;
      this.vitalityNumericUpDown.ValueChanged += new System.EventHandler(this.VitalityNumericUpDown_ValueChanged);
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(13, 271);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(94, 13);
      this.label12.TabIndex = 22;
      this.label12.Text = "AugmentedVitality:";
      // 
      // quicknessNumericUpDown
      // 
      this.quicknessNumericUpDown.Location = new System.Drawing.Point(162, 243);
      this.quicknessNumericUpDown.Name = "quicknessNumericUpDown";
      this.quicknessNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.quicknessNumericUpDown.TabIndex = 21;
      this.quicknessNumericUpDown.ValueChanged += new System.EventHandler(this.QuicknessNumericUpDown_ValueChanged);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(13, 245);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(114, 13);
      this.label11.TabIndex = 20;
      this.label11.Text = "AugmentedQuickness:";
      // 
      // fortitudeNumericUpDown
      // 
      this.fortitudeNumericUpDown.Location = new System.Drawing.Point(162, 217);
      this.fortitudeNumericUpDown.Name = "fortitudeNumericUpDown";
      this.fortitudeNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.fortitudeNumericUpDown.TabIndex = 19;
      this.fortitudeNumericUpDown.ValueChanged += new System.EventHandler(this.FortitudeNumericUpDown_ValueChanged);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(13, 219);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(105, 13);
      this.label10.TabIndex = 18;
      this.label10.Text = "AugmentedFortitude:";
      // 
      // awarenessNumericUpDown
      // 
      this.awarenessNumericUpDown.Location = new System.Drawing.Point(162, 191);
      this.awarenessNumericUpDown.Name = "awarenessNumericUpDown";
      this.awarenessNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.awarenessNumericUpDown.TabIndex = 17;
      this.awarenessNumericUpDown.ValueChanged += new System.EventHandler(this.AwarenessNumericUpDown_ValueChanged);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(13, 193);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(116, 13);
      this.label9.TabIndex = 16;
      this.label9.Text = "AugmentedAwareness:";
      // 
      // toughnessNumericUpDown
      // 
      this.toughnessNumericUpDown.Location = new System.Drawing.Point(162, 166);
      this.toughnessNumericUpDown.Name = "toughnessNumericUpDown";
      this.toughnessNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.toughnessNumericUpDown.TabIndex = 15;
      this.toughnessNumericUpDown.ValueChanged += new System.EventHandler(this.ThoughnessNumericUpDown_ValueChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(13, 168);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(117, 13);
      this.label8.TabIndex = 14;
      this.label8.Text = "AugmentedToughness:";
      // 
      // evadeRatingNumericUpDown
      // 
      this.evadeRatingNumericUpDown.Location = new System.Drawing.Point(162, 140);
      this.evadeRatingNumericUpDown.Name = "evadeRatingNumericUpDown";
      this.evadeRatingNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.evadeRatingNumericUpDown.TabIndex = 13;
      this.evadeRatingNumericUpDown.ValueChanged += new System.EventHandler(this.EvadeRatingNumericUpDown_ValueChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(13, 142);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(126, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "AugmentedEvadeRating:";
      // 
      // damageMagicalNumericUpDown
      // 
      this.damageMagicalNumericUpDown.Location = new System.Drawing.Point(162, 62);
      this.damageMagicalNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.damageMagicalNumericUpDown.Name = "damageMagicalNumericUpDown";
      this.damageMagicalNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.damageMagicalNumericUpDown.TabIndex = 11;
      this.damageMagicalNumericUpDown.ValueChanged += new System.EventHandler(this.DamageMagicalNumericUpDown_ValueChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(13, 64);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(133, 13);
      this.label6.TabIndex = 10;
      this.label6.Text = "AugmentedDamageMagic:";
      // 
      // damagePhysicalNumericUpDown
      // 
      this.damagePhysicalNumericUpDown.Location = new System.Drawing.Point(162, 36);
      this.damagePhysicalNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.damagePhysicalNumericUpDown.Name = "damagePhysicalNumericUpDown";
      this.damagePhysicalNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.damagePhysicalNumericUpDown.TabIndex = 9;
      this.damagePhysicalNumericUpDown.ValueChanged += new System.EventHandler(this.DamagePhysicalNumericUpDown_ValueChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(13, 38);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(143, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "AugmentedDamagePhysical:";
      // 
      // defenseMagicNumericUpDown
      // 
      this.defenseMagicNumericUpDown.Location = new System.Drawing.Point(162, 114);
      this.defenseMagicNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.defenseMagicNumericUpDown.Name = "defenseMagicNumericUpDown";
      this.defenseMagicNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.defenseMagicNumericUpDown.TabIndex = 7;
      this.defenseMagicNumericUpDown.ValueChanged += new System.EventHandler(this.DefenseMagicNumericUpDown_ValueChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 116);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(133, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "AugmentedDefenseMagic:";
      // 
      // defensePhysicalNumericUpDown
      // 
      this.defensePhysicalNumericUpDown.Location = new System.Drawing.Point(162, 88);
      this.defensePhysicalNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.defensePhysicalNumericUpDown.Name = "defensePhysicalNumericUpDown";
      this.defensePhysicalNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.defensePhysicalNumericUpDown.TabIndex = 5;
      this.defensePhysicalNumericUpDown.ValueChanged += new System.EventHandler(this.DefensePhysicalNumericUpDown_ValueChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 90);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(143, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "AugmentedDefensePhysical:";
      // 
      // goldNumericUpDown
      // 
      this.goldNumericUpDown.Location = new System.Drawing.Point(162, 10);
      this.goldNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
      this.goldNumericUpDown.Name = "goldNumericUpDown";
      this.goldNumericUpDown.Size = new System.Drawing.Size(90, 20);
      this.goldNumericUpDown.TabIndex = 3;
      this.goldNumericUpDown.ValueChanged += new System.EventHandler(this.GoldNumericUpDown_ValueChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Gold:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Select Character:";
      // 
      // selectCharacterComboBox
      // 
      this.selectCharacterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.selectCharacterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.selectCharacterComboBox.Enabled = false;
      this.selectCharacterComboBox.FormattingEnabled = true;
      this.selectCharacterComboBox.Location = new System.Drawing.Point(101, 19);
      this.selectCharacterComboBox.Name = "selectCharacterComboBox";
      this.selectCharacterComboBox.Size = new System.Drawing.Size(272, 21);
      this.selectCharacterComboBox.TabIndex = 0;
      this.selectCharacterComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectCharacterComboBox_SelectedIndexChanged);
      // 
      // SaveButton
      // 
      this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.SaveButton.Location = new System.Drawing.Point(187, 559);
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(95, 23);
      this.SaveButton.TabIndex = 3;
      this.SaveButton.Text = "Save and close";
      this.SaveButton.UseVisualStyleBackColor = true;
      this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
      // 
      // closeButton
      // 
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.Location = new System.Drawing.Point(288, 559);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(117, 23);
      this.closeButton.TabIndex = 4;
      this.closeButton.Text = "Close without saving";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // unlockButton
      // 
      this.unlockButton.Location = new System.Drawing.Point(164, 8);
      this.unlockButton.Name = "unlockButton";
      this.unlockButton.Size = new System.Drawing.Size(158, 23);
      this.unlockButton.TabIndex = 5;
      this.unlockButton.Text = "Enable Lore Store Options";
      this.unlockButton.UseVisualStyleBackColor = true;
      this.unlockButton.Click += new System.EventHandler(this.UnlockButton_Click);
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(17, 54);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(99, 13);
      this.label17.TabIndex = 4;
      this.label17.Text = "Select Save Game:";
      // 
      // saveGameComboBox
      // 
      this.saveGameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.saveGameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.saveGameComboBox.FormattingEnabled = true;
      this.saveGameComboBox.Location = new System.Drawing.Point(113, 51);
      this.saveGameComboBox.Name = "saveGameComboBox";
      this.saveGameComboBox.Size = new System.Drawing.Size(272, 21);
      this.saveGameComboBox.TabIndex = 3;
      this.saveGameComboBox.SelectedIndexChanged += new System.EventHandler(this.SaveGameComboBox_SelectedIndexChanged);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Silver;
      this.ClientSize = new System.Drawing.Size(417, 591);
      this.Controls.Add(this.label17);
      this.Controls.Add(this.unlockButton);
      this.Controls.Add(this.saveGameComboBox);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.SaveButton);
      this.Controls.Add(this.currentGameGroupBox);
      this.Controls.Add(this.loreNumericUpDown);
      this.Controls.Add(this.loreLabel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "For The King!";
      ((System.ComponentModel.ISupportInitialize)(this.loreNumericUpDown)).EndInit();
      this.currentGameGroupBox.ResumeLayout(false);
      this.currentGameGroupBox.PerformLayout();
      this.characterInfoPanel.ResumeLayout(false);
      this.characterInfoPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.maxHealthNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.maxFocusNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.luckNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.talentNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.vitalityNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.quicknessNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fortitudeNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.awarenessNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.toughnessNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.evadeRatingNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.damageMagicalNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.damagePhysicalNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.defenseMagicNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.defensePhysicalNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.goldNumericUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label loreLabel;
    private System.Windows.Forms.NumericUpDown loreNumericUpDown;
    private System.Windows.Forms.GroupBox currentGameGroupBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox selectCharacterComboBox;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.Panel characterInfoPanel;
    private System.Windows.Forms.NumericUpDown goldNumericUpDown;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown defenseMagicNumericUpDown;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown defensePhysicalNumericUpDown;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown talentNumericUpDown;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.NumericUpDown vitalityNumericUpDown;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.NumericUpDown quicknessNumericUpDown;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.NumericUpDown fortitudeNumericUpDown;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.NumericUpDown awarenessNumericUpDown;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.NumericUpDown toughnessNumericUpDown;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.NumericUpDown evadeRatingNumericUpDown;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.NumericUpDown damageMagicalNumericUpDown;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown damagePhysicalNumericUpDown;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown maxHealthNumericUpDown;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.NumericUpDown maxFocusNumericUpDown;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.NumericUpDown luckNumericUpDown;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.Button unlockButton;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.ComboBox saveGameComboBox;
  }
}

