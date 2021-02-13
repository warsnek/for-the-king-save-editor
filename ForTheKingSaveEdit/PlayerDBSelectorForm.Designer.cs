namespace ForTheKingSaveEdit
{
  partial class PlayerDBSelectorForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerDBSelectorForm));
      this.selectLoreFileComboBox = new System.Windows.Forms.ComboBox();
      this.confirmButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // selectLoreFileComboBox
      // 
      this.selectLoreFileComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.selectLoreFileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.selectLoreFileComboBox.FormattingEnabled = true;
      this.selectLoreFileComboBox.Location = new System.Drawing.Point(30, 82);
      this.selectLoreFileComboBox.Name = "selectLoreFileComboBox";
      this.selectLoreFileComboBox.Size = new System.Drawing.Size(843, 21);
      this.selectLoreFileComboBox.TabIndex = 0;
      // 
      // confirmButton
      // 
      this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.confirmButton.Location = new System.Drawing.Point(798, 109);
      this.confirmButton.Name = "confirmButton";
      this.confirmButton.Size = new System.Drawing.Size(75, 23);
      this.confirmButton.TabIndex = 1;
      this.confirmButton.Text = "Confirm";
      this.confirmButton.UseVisualStyleBackColor = true;
      this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(27, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(846, 39);
      this.label1.TabIndex = 2;
      this.label1.Text = resources.GetString("label1.Text");
      // 
      // PlayerDBSelectorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(900, 148);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.confirmButton);
      this.Controls.Add(this.selectLoreFileComboBox);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(916, 187);
      this.Name = "PlayerDBSelectorForm";
      this.Text = "For The King! - Select Lore File plz";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ComboBox selectLoreFileComboBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label1;
    }
}