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
      this.unlockButton = new System.Windows.Forms.Button();
      this.label17 = new System.Windows.Forms.Label();
      this.characterInfoPanel = new System.Windows.Forms.Panel();
      this.damagePhysicalNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.maxHealthNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.maxHealthLabel = new System.Windows.Forms.Label();
      this.maxFocusNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.damagePhysicalLabel = new System.Windows.Forms.Label();
      this.maxFocusLabel = new System.Windows.Forms.Label();
      this.luckNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.luckLabel = new System.Windows.Forms.Label();
      this.talentNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.talentLabel = new System.Windows.Forms.Label();
      this.vitalityNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.vitalityLabel = new System.Windows.Forms.Label();
      this.quicknessNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.quicknessLabel = new System.Windows.Forms.Label();
      this.fortitudeNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.fortitudeLabel = new System.Windows.Forms.Label();
      this.awarenessNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.awarenessLabel = new System.Windows.Forms.Label();
      this.toughnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.toughnessLabel = new System.Windows.Forms.Label();
      this.evadeRatingNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.evadeRatingLabel = new System.Windows.Forms.Label();
      this.damageMagicalNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.damageMagicLabel = new System.Windows.Forms.Label();
      this.defenseMagicNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.defenseMagicLabel = new System.Windows.Forms.Label();
      this.defensePhysicalNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.defensePhysicalLabel = new System.Windows.Forms.Label();
      this.goldNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.goldLabel = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.saveGameComboBox = new System.Windows.Forms.ComboBox();
      this.selectCharacterComboBox = new System.Windows.Forms.ComboBox();
      this.SaveButton = new System.Windows.Forms.Button();
      this.closeButton = new System.Windows.Forms.Button();
      this.FTKTitle = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize) (this.loreNumericUpDown)).BeginInit();
      this.currentGameGroupBox.SuspendLayout();
      this.characterInfoPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.damagePhysicalNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.maxHealthNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.maxFocusNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.luckNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.talentNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.vitalityNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.quicknessNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.fortitudeNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.awarenessNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.toughnessNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.evadeRatingNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.damageMagicalNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.defenseMagicNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.defensePhysicalNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.goldNumericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // loreLabel
      // 
      this.loreLabel.Location = new System.Drawing.Point(19, 19);
      this.loreLabel.Name = "loreLabel";
      this.loreLabel.Size = new System.Drawing.Size(63, 20);
      this.loreLabel.TabIndex = 0;
      this.loreLabel.Text = "Lore Points:";
      this.loreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.loreLabel.Click += new System.EventHandler(this.loreLabel_Click);
      // 
      // loreNumericUpDown
      // 
      this.loreNumericUpDown.Location = new System.Drawing.Point(88, 19);
      this.loreNumericUpDown.Maximum = new decimal(new int[] {10000, 0, 0, 0});
      this.loreNumericUpDown.Name = "loreNumericUpDown";
      this.loreNumericUpDown.Size = new System.Drawing.Size(51, 20);
      this.loreNumericUpDown.TabIndex = 1;
      this.loreNumericUpDown.ValueChanged += new System.EventHandler(this.LoreNumericUpDown_ValueChanged);
      // 
      // currentGameGroupBox
      // 
      this.currentGameGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.currentGameGroupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.currentGameGroupBox.Controls.Add(this.unlockButton);
      this.currentGameGroupBox.Controls.Add(this.label17);
      this.currentGameGroupBox.Controls.Add(this.loreNumericUpDown);
      this.currentGameGroupBox.Controls.Add(this.characterInfoPanel);
      this.currentGameGroupBox.Controls.Add(this.loreLabel);
      this.currentGameGroupBox.Controls.Add(this.label1);
      this.currentGameGroupBox.Controls.Add(this.saveGameComboBox);
      this.currentGameGroupBox.Controls.Add(this.selectCharacterComboBox);
      this.currentGameGroupBox.Controls.Add(this.SaveButton);
      this.currentGameGroupBox.Controls.Add(this.closeButton);
      this.currentGameGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.currentGameGroupBox.Location = new System.Drawing.Point(800, 250);
      this.currentGameGroupBox.Name = "currentGameGroupBox";
      this.currentGameGroupBox.Size = new System.Drawing.Size(320, 591);
      this.currentGameGroupBox.TabIndex = 2;
      this.currentGameGroupBox.TabStop = false;
      this.currentGameGroupBox.Text = "For The King";
      // 
      // unlockButton
      // 
      this.unlockButton.BackColor = System.Drawing.Color.DarkRed;
      this.unlockButton.Location = new System.Drawing.Point(158, 19);
      this.unlockButton.Name = "unlockButton";
      this.unlockButton.Size = new System.Drawing.Size(141, 20);
      this.unlockButton.TabIndex = 5;
      this.unlockButton.Text = "Enable Lore Store Options";
      this.unlockButton.UseVisualStyleBackColor = false;
      this.unlockButton.Click += new System.EventHandler(this.UnlockButton_Click);
      // 
      // label17
      // 
      this.label17.Location = new System.Drawing.Point(19, 64);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(101, 21);
      this.label17.TabIndex = 4;
      this.label17.Text = "Select Save Game:";
      this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // characterInfoPanel
      // 
      this.characterInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.characterInfoPanel.BackColor = System.Drawing.Color.Transparent;
      this.characterInfoPanel.Controls.Add(this.damagePhysicalNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.maxHealthNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.maxHealthLabel);
      this.characterInfoPanel.Controls.Add(this.maxFocusNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.damagePhysicalLabel);
      this.characterInfoPanel.Controls.Add(this.maxFocusLabel);
      this.characterInfoPanel.Controls.Add(this.luckNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.luckLabel);
      this.characterInfoPanel.Controls.Add(this.talentNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.talentLabel);
      this.characterInfoPanel.Controls.Add(this.vitalityNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.vitalityLabel);
      this.characterInfoPanel.Controls.Add(this.quicknessNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.quicknessLabel);
      this.characterInfoPanel.Controls.Add(this.fortitudeNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.fortitudeLabel);
      this.characterInfoPanel.Controls.Add(this.awarenessNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.awarenessLabel);
      this.characterInfoPanel.Controls.Add(this.toughnessNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.toughnessLabel);
      this.characterInfoPanel.Controls.Add(this.evadeRatingNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.evadeRatingLabel);
      this.characterInfoPanel.Controls.Add(this.damageMagicalNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.damageMagicLabel);
      this.characterInfoPanel.Controls.Add(this.defenseMagicNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.defenseMagicLabel);
      this.characterInfoPanel.Controls.Add(this.defensePhysicalNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.defensePhysicalLabel);
      this.characterInfoPanel.Controls.Add(this.goldNumericUpDown);
      this.characterInfoPanel.Controls.Add(this.goldLabel);
      this.characterInfoPanel.Enabled = false;
      this.characterInfoPanel.Location = new System.Drawing.Point(49, 147);
      this.characterInfoPanel.Name = "characterInfoPanel";
      this.characterInfoPanel.Size = new System.Drawing.Size(222, 376);
      this.characterInfoPanel.TabIndex = 2;
      // 
      // damagePhysicalNumericUpDown
      // 
      this.damagePhysicalNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.damagePhysicalNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.damagePhysicalNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.damagePhysicalNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.damagePhysicalNumericUpDown.Location = new System.Drawing.Point(163, 36);
      this.damagePhysicalNumericUpDown.Maximum = new decimal(new int[] {1000, 0, 0, 0});
      this.damagePhysicalNumericUpDown.Name = "damagePhysicalNumericUpDown";
      this.damagePhysicalNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.damagePhysicalNumericUpDown.TabIndex = 32;
      // 
      // maxHealthNumericUpDown
      // 
      this.maxHealthNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.maxHealthNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.maxHealthNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.maxHealthNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.maxHealthNumericUpDown.Location = new System.Drawing.Point(163, 348);
      this.maxHealthNumericUpDown.Maximum = new decimal(new int[] {1000, 0, 0, 0});
      this.maxHealthNumericUpDown.Minimum = new decimal(new int[] {1000, 0, 0, -2147483648});
      this.maxHealthNumericUpDown.Name = "maxHealthNumericUpDown";
      this.maxHealthNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.maxHealthNumericUpDown.TabIndex = 31;
      this.maxHealthNumericUpDown.ValueChanged += new System.EventHandler(this.MaxHealthNumericUpDown_ValueChanged);
      // 
      // maxHealthLabel
      // 
      this.maxHealthLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.maxHealthLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.maxHealthLabel.Location = new System.Drawing.Point(15, 348);
      this.maxHealthLabel.Name = "maxHealthLabel";
      this.maxHealthLabel.Size = new System.Drawing.Size(195, 16);
      this.maxHealthLabel.TabIndex = 30;
      this.maxHealthLabel.Text = "AugmentedMaxHealth:";
      this.maxHealthLabel.Click += new System.EventHandler(this.maxHealthLabel_Click);
      // 
      // maxFocusNumericUpDown
      // 
      this.maxFocusNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.maxFocusNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.maxFocusNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.maxFocusNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.maxFocusNumericUpDown.Location = new System.Drawing.Point(162, 324);
      this.maxFocusNumericUpDown.Name = "maxFocusNumericUpDown";
      this.maxFocusNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.maxFocusNumericUpDown.TabIndex = 29;
      this.maxFocusNumericUpDown.ValueChanged += new System.EventHandler(this.MaxFocusNumericUpDown_ValueChanged);
      // 
      // damagePhysicalLabel
      // 
      this.damagePhysicalLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.damagePhysicalLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.damagePhysicalLabel.Location = new System.Drawing.Point(15, 36);
      this.damagePhysicalLabel.Name = "damagePhysicalLabel";
      this.damagePhysicalLabel.Size = new System.Drawing.Size(195, 16);
      this.damagePhysicalLabel.TabIndex = 8;
      this.damagePhysicalLabel.Text = "AugmentedDamagePhysical:";
      this.damagePhysicalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.damagePhysicalLabel.Click += new System.EventHandler(this.label5_Click);
      // 
      // maxFocusLabel
      // 
      this.maxFocusLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.maxFocusLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.maxFocusLabel.Location = new System.Drawing.Point(15, 324);
      this.maxFocusLabel.Name = "maxFocusLabel";
      this.maxFocusLabel.Size = new System.Drawing.Size(195, 16);
      this.maxFocusLabel.TabIndex = 28;
      this.maxFocusLabel.Text = "AugmentedMaxFocus:";
      // 
      // luckNumericUpDown
      // 
      this.luckNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.luckNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.luckNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.luckNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.luckNumericUpDown.Location = new System.Drawing.Point(162, 300);
      this.luckNumericUpDown.Name = "luckNumericUpDown";
      this.luckNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.luckNumericUpDown.TabIndex = 27;
      this.luckNumericUpDown.ValueChanged += new System.EventHandler(this.LuckNumericUpDown_ValueChanged);
      // 
      // luckLabel
      // 
      this.luckLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.luckLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.luckLabel.Location = new System.Drawing.Point(15, 300);
      this.luckLabel.Name = "luckLabel";
      this.luckLabel.Size = new System.Drawing.Size(195, 16);
      this.luckLabel.TabIndex = 26;
      this.luckLabel.Text = "AugmentedLuck:";
      // 
      // talentNumericUpDown
      // 
      this.talentNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.talentNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.talentNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.talentNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.talentNumericUpDown.Location = new System.Drawing.Point(162, 276);
      this.talentNumericUpDown.Name = "talentNumericUpDown";
      this.talentNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.talentNumericUpDown.TabIndex = 25;
      this.talentNumericUpDown.ValueChanged += new System.EventHandler(this.TalentNumericUpDown_ValueChanged);
      // 
      // talentLabel
      // 
      this.talentLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.talentLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.talentLabel.Location = new System.Drawing.Point(15, 276);
      this.talentLabel.Name = "talentLabel";
      this.talentLabel.Size = new System.Drawing.Size(195, 16);
      this.talentLabel.TabIndex = 24;
      this.talentLabel.Text = "AugmentedTalent:";
      // 
      // vitalityNumericUpDown
      // 
      this.vitalityNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.vitalityNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.vitalityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.vitalityNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.vitalityNumericUpDown.Location = new System.Drawing.Point(162, 252);
      this.vitalityNumericUpDown.Name = "vitalityNumericUpDown";
      this.vitalityNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.vitalityNumericUpDown.TabIndex = 23;
      this.vitalityNumericUpDown.ValueChanged += new System.EventHandler(this.VitalityNumericUpDown_ValueChanged);
      // 
      // vitalityLabel
      // 
      this.vitalityLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.vitalityLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.vitalityLabel.Location = new System.Drawing.Point(15, 252);
      this.vitalityLabel.Name = "vitalityLabel";
      this.vitalityLabel.Size = new System.Drawing.Size(195, 16);
      this.vitalityLabel.TabIndex = 22;
      this.vitalityLabel.Text = "AugmentedVitality:";
      // 
      // quicknessNumericUpDown
      // 
      this.quicknessNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.quicknessNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.quicknessNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.quicknessNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.quicknessNumericUpDown.Location = new System.Drawing.Point(162, 228);
      this.quicknessNumericUpDown.Name = "quicknessNumericUpDown";
      this.quicknessNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.quicknessNumericUpDown.TabIndex = 21;
      this.quicknessNumericUpDown.ValueChanged += new System.EventHandler(this.QuicknessNumericUpDown_ValueChanged);
      // 
      // quicknessLabel
      // 
      this.quicknessLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.quicknessLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.quicknessLabel.Location = new System.Drawing.Point(15, 228);
      this.quicknessLabel.Name = "quicknessLabel";
      this.quicknessLabel.Size = new System.Drawing.Size(195, 16);
      this.quicknessLabel.TabIndex = 20;
      this.quicknessLabel.Text = "AugmentedQuickness:";
      // 
      // fortitudeNumericUpDown
      // 
      this.fortitudeNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.fortitudeNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.fortitudeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.fortitudeNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.fortitudeNumericUpDown.Location = new System.Drawing.Point(162, 204);
      this.fortitudeNumericUpDown.Name = "fortitudeNumericUpDown";
      this.fortitudeNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.fortitudeNumericUpDown.TabIndex = 19;
      this.fortitudeNumericUpDown.ValueChanged += new System.EventHandler(this.FortitudeNumericUpDown_ValueChanged);
      // 
      // fortitudeLabel
      // 
      this.fortitudeLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.fortitudeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.fortitudeLabel.Location = new System.Drawing.Point(15, 204);
      this.fortitudeLabel.Name = "fortitudeLabel";
      this.fortitudeLabel.Size = new System.Drawing.Size(195, 16);
      this.fortitudeLabel.TabIndex = 18;
      this.fortitudeLabel.Text = "AugmentedFortitude:";
      // 
      // awarenessNumericUpDown
      // 
      this.awarenessNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.awarenessNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.awarenessNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.awarenessNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.awarenessNumericUpDown.Location = new System.Drawing.Point(162, 180);
      this.awarenessNumericUpDown.Name = "awarenessNumericUpDown";
      this.awarenessNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.awarenessNumericUpDown.TabIndex = 17;
      this.awarenessNumericUpDown.ValueChanged += new System.EventHandler(this.AwarenessNumericUpDown_ValueChanged);
      // 
      // awarenessLabel
      // 
      this.awarenessLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.awarenessLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.awarenessLabel.Location = new System.Drawing.Point(15, 180);
      this.awarenessLabel.Name = "awarenessLabel";
      this.awarenessLabel.Size = new System.Drawing.Size(195, 16);
      this.awarenessLabel.TabIndex = 16;
      this.awarenessLabel.Text = "AugmentedAwareness:";
      // 
      // toughnessNumericUpDown
      // 
      this.toughnessNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.toughnessNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.toughnessNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.toughnessNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.toughnessNumericUpDown.Location = new System.Drawing.Point(162, 156);
      this.toughnessNumericUpDown.Name = "toughnessNumericUpDown";
      this.toughnessNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.toughnessNumericUpDown.TabIndex = 15;
      this.toughnessNumericUpDown.ValueChanged += new System.EventHandler(this.ThoughnessNumericUpDown_ValueChanged);
      // 
      // toughnessLabel
      // 
      this.toughnessLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.toughnessLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.toughnessLabel.Location = new System.Drawing.Point(15, 156);
      this.toughnessLabel.Name = "toughnessLabel";
      this.toughnessLabel.Size = new System.Drawing.Size(195, 16);
      this.toughnessLabel.TabIndex = 14;
      this.toughnessLabel.Text = "AugmentedToughness:";
      // 
      // evadeRatingNumericUpDown
      // 
      this.evadeRatingNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.evadeRatingNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.evadeRatingNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.evadeRatingNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.evadeRatingNumericUpDown.Location = new System.Drawing.Point(162, 132);
      this.evadeRatingNumericUpDown.Name = "evadeRatingNumericUpDown";
      this.evadeRatingNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.evadeRatingNumericUpDown.TabIndex = 13;
      this.evadeRatingNumericUpDown.ValueChanged += new System.EventHandler(this.EvadeRatingNumericUpDown_ValueChanged);
      // 
      // evadeRatingLabel
      // 
      this.evadeRatingLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.evadeRatingLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.evadeRatingLabel.Location = new System.Drawing.Point(15, 132);
      this.evadeRatingLabel.Name = "evadeRatingLabel";
      this.evadeRatingLabel.Size = new System.Drawing.Size(195, 16);
      this.evadeRatingLabel.TabIndex = 12;
      this.evadeRatingLabel.Text = "AugmentedEvadeRating:";
      // 
      // damageMagicalNumericUpDown
      // 
      this.damageMagicalNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.damageMagicalNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.damageMagicalNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.damageMagicalNumericUpDown.Location = new System.Drawing.Point(162, 60);
      this.damageMagicalNumericUpDown.Maximum = new decimal(new int[] {1000, 0, 0, 0});
      this.damageMagicalNumericUpDown.Name = "damageMagicalNumericUpDown";
      this.damageMagicalNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.damageMagicalNumericUpDown.TabIndex = 11;
      this.damageMagicalNumericUpDown.ValueChanged += new System.EventHandler(this.DamageMagicalNumericUpDown_ValueChanged);
      // 
      // damageMagicLabel
      // 
      this.damageMagicLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.damageMagicLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.damageMagicLabel.Location = new System.Drawing.Point(15, 60);
      this.damageMagicLabel.Name = "damageMagicLabel";
      this.damageMagicLabel.Size = new System.Drawing.Size(195, 18);
      this.damageMagicLabel.TabIndex = 10;
      this.damageMagicLabel.Text = "AugmentedDamageMagic:";
      // 
      // defenseMagicNumericUpDown
      // 
      this.defenseMagicNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.defenseMagicNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.defenseMagicNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.defenseMagicNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.defenseMagicNumericUpDown.Location = new System.Drawing.Point(162, 108);
      this.defenseMagicNumericUpDown.Maximum = new decimal(new int[] {1000, 0, 0, 0});
      this.defenseMagicNumericUpDown.Name = "defenseMagicNumericUpDown";
      this.defenseMagicNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.defenseMagicNumericUpDown.TabIndex = 7;
      this.defenseMagicNumericUpDown.ValueChanged += new System.EventHandler(this.DefenseMagicNumericUpDown_ValueChanged);
      // 
      // defenseMagicLabel
      // 
      this.defenseMagicLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.defenseMagicLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.defenseMagicLabel.Location = new System.Drawing.Point(15, 108);
      this.defenseMagicLabel.Name = "defenseMagicLabel";
      this.defenseMagicLabel.Size = new System.Drawing.Size(195, 16);
      this.defenseMagicLabel.TabIndex = 6;
      this.defenseMagicLabel.Text = "AugmentedDefenseMagic:";
      // 
      // defensePhysicalNumericUpDown
      // 
      this.defensePhysicalNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.defensePhysicalNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.defensePhysicalNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.defensePhysicalNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.defensePhysicalNumericUpDown.Location = new System.Drawing.Point(162, 84);
      this.defensePhysicalNumericUpDown.Maximum = new decimal(new int[] {1000, 0, 0, 0});
      this.defensePhysicalNumericUpDown.Name = "defensePhysicalNumericUpDown";
      this.defensePhysicalNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.defensePhysicalNumericUpDown.TabIndex = 5;
      this.defensePhysicalNumericUpDown.ValueChanged += new System.EventHandler(this.DefensePhysicalNumericUpDown_ValueChanged);
      // 
      // defensePhysicalLabel
      // 
      this.defensePhysicalLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.defensePhysicalLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.defensePhysicalLabel.Location = new System.Drawing.Point(15, 84);
      this.defensePhysicalLabel.Name = "defensePhysicalLabel";
      this.defensePhysicalLabel.Size = new System.Drawing.Size(195, 16);
      this.defensePhysicalLabel.TabIndex = 4;
      this.defensePhysicalLabel.Text = "AugmentedDefensePhysical:";
      // 
      // goldNumericUpDown
      // 
      this.goldNumericUpDown.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.goldNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.goldNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.goldNumericUpDown.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.goldNumericUpDown.Location = new System.Drawing.Point(162, 12);
      this.goldNumericUpDown.Maximum = new decimal(new int[] {10000000, 0, 0, 0});
      this.goldNumericUpDown.Name = "goldNumericUpDown";
      this.goldNumericUpDown.Size = new System.Drawing.Size(45, 16);
      this.goldNumericUpDown.TabIndex = 3;
      this.goldNumericUpDown.ValueChanged += new System.EventHandler(this.GoldNumericUpDown_ValueChanged);
      // 
      // goldLabel
      // 
      this.goldLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.goldLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.goldLabel.Location = new System.Drawing.Point(15, 12);
      this.goldLabel.Name = "goldLabel";
      this.goldLabel.Size = new System.Drawing.Size(195, 16);
      this.goldLabel.TabIndex = 2;
      this.goldLabel.Text = "Gold:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label1.Location = new System.Drawing.Point(20, 108);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Select Character:";
      // 
      // saveGameComboBox
      // 
      this.saveGameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.saveGameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.saveGameComboBox.FormattingEnabled = true;
      this.saveGameComboBox.Location = new System.Drawing.Point(126, 64);
      this.saveGameComboBox.Name = "saveGameComboBox";
      this.saveGameComboBox.Size = new System.Drawing.Size(173, 21);
      this.saveGameComboBox.TabIndex = 3;
      this.saveGameComboBox.SelectedIndexChanged += new System.EventHandler(this.SaveGameComboBox_SelectedIndexChanged);
      // 
      // selectCharacterComboBox
      // 
      this.selectCharacterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
      this.selectCharacterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.selectCharacterComboBox.Enabled = false;
      this.selectCharacterComboBox.FormattingEnabled = true;
      this.selectCharacterComboBox.Location = new System.Drawing.Point(126, 105);
      this.selectCharacterComboBox.Name = "selectCharacterComboBox";
      this.selectCharacterComboBox.Size = new System.Drawing.Size(173, 21);
      this.selectCharacterComboBox.TabIndex = 0;
      this.selectCharacterComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectCharacterComboBox_SelectedIndexChanged);
      // 
      // SaveButton
      // 
      this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.SaveButton.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.SaveButton.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.SaveButton.Location = new System.Drawing.Point(179, 529);
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(120, 45);
      this.SaveButton.TabIndex = 3;
      this.SaveButton.Text = "Save and close";
      this.SaveButton.UseVisualStyleBackColor = false;
      this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
      // 
      // closeButton
      // 
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.closeButton.Location = new System.Drawing.Point(19, 529);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(120, 45);
      this.closeButton.TabIndex = 4;
      this.closeButton.Text = "Close without saving";
      this.closeButton.UseVisualStyleBackColor = false;
      this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // FTKTitle
      // 
      this.FTKTitle.BackColor = System.Drawing.Color.Transparent;
      this.FTKTitle.Image = ((System.Drawing.Image) (resources.GetObject("FTKTitle.Image")));
      this.FTKTitle.Location = new System.Drawing.Point(660, 0);
      this.FTKTitle.Name = "FTKTitle";
      this.FTKTitle.Size = new System.Drawing.Size(600, 200);
      this.FTKTitle.TabIndex = 3;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Silver;
      this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(1904, 1041);
      this.Controls.Add(this.FTKTitle);
      this.Controls.Add(this.currentGameGroupBox);
      this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "For The King!";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize) (this.loreNumericUpDown)).EndInit();
      this.currentGameGroupBox.ResumeLayout(false);
      this.currentGameGroupBox.PerformLayout();
      this.characterInfoPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize) (this.damagePhysicalNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.maxHealthNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.maxFocusNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.luckNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.talentNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.vitalityNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.quicknessNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.fortitudeNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.awarenessNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.toughnessNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.evadeRatingNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.damageMagicalNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.defenseMagicNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.defensePhysicalNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.goldNumericUpDown)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label FTKTitle;

    private System.Windows.Forms.Label awarenessLabel;
    private System.Windows.Forms.Label damageMagicLabel;
    private System.Windows.Forms.Label damagePhysicalLabel;
    private System.Windows.Forms.Label defenseMagicLabel;
    private System.Windows.Forms.Label defensePhysicalLabel;
    private System.Windows.Forms.Label evadeRatingLabel;
    private System.Windows.Forms.Label fortitudeLabel;
    private System.Windows.Forms.Label goldLabel;
    private System.Windows.Forms.Label luckLabel;
    private System.Windows.Forms.Label maxFocusLabel;
    private System.Windows.Forms.Label maxHealthLabel;
    private System.Windows.Forms.Label quicknessLabel;
    private System.Windows.Forms.Label talentLabel;
    private System.Windows.Forms.Label toughnessLabel;
    private System.Windows.Forms.Label vitalityLabel;

    #endregion

    private System.Windows.Forms.Label loreLabel;
    private System.Windows.Forms.NumericUpDown loreNumericUpDown;
    private System.Windows.Forms.GroupBox currentGameGroupBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox selectCharacterComboBox;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.Panel characterInfoPanel;
    private System.Windows.Forms.NumericUpDown goldNumericUpDown;
    private System.Windows.Forms.NumericUpDown defenseMagicNumericUpDown;
    private System.Windows.Forms.NumericUpDown defensePhysicalNumericUpDown;
    private System.Windows.Forms.NumericUpDown talentNumericUpDown;
    private System.Windows.Forms.NumericUpDown vitalityNumericUpDown;
    private System.Windows.Forms.NumericUpDown quicknessNumericUpDown;
    private System.Windows.Forms.NumericUpDown fortitudeNumericUpDown;
    private System.Windows.Forms.NumericUpDown awarenessNumericUpDown;
    private System.Windows.Forms.NumericUpDown toughnessNumericUpDown;
    private System.Windows.Forms.NumericUpDown evadeRatingNumericUpDown;
    private System.Windows.Forms.NumericUpDown damageMagicalNumericUpDown;
    private System.Windows.Forms.NumericUpDown damagePhysicalNumericUpDown;
    private System.Windows.Forms.NumericUpDown maxHealthNumericUpDown;
    private System.Windows.Forms.NumericUpDown maxFocusNumericUpDown;
    private System.Windows.Forms.NumericUpDown luckNumericUpDown;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.Button unlockButton;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.ComboBox saveGameComboBox;
  }
}

