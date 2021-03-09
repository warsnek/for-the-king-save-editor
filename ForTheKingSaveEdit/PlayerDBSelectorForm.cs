using System;
using System.Windows.Forms;

namespace ForTheKingSaveEdit
{
  public partial class PlayerDBSelectorForm : Form
  {
    public string SelectedFile { get; private set; }

    public PlayerDBSelectorForm(string[] playerDbFiles)
    {
      InitializeComponent();

      SelectedFile = playerDbFiles[0];
      selectLoreFileComboBox.Items.AddRange(playerDbFiles);
      selectLoreFileComboBox.SelectedIndex = 0;
    }

    private void ConfirmButton_Click(object sender, EventArgs e)
    {
      SelectedFile = (string)selectLoreFileComboBox.SelectedItem;
      Close();
    }

    private void selectLoreFileComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      throw new System.NotImplementedException();
    }
  }
}
