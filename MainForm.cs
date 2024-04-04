using System;
using System.Windows.Forms;

namespace SymbiotResultStatus
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Updates all flag checkboxes
        /// </summary>
        private void UpdateFlags()
        {
            var txt = this.StatusTextBox.Text;
            if (String.IsNullOrEmpty(txt))
            {
                ClearForm();
                return;
            }

            long status = 0;
            ErrorLabel.Text = "";

            if (!long.TryParse(txt,out status))
            {
                ErrorLabel.Text = "Invalid code value";
                return;
            };


            foreach(var control in FlagsGroupBox.Controls)
            {
                CheckBox cb = (CheckBox)control;
                long mask = long.Parse(cb.Tag.ToString());
                cb.Checked =  (mask & status) == mask;
            }
        }

        private void ClearForm()
        {
            StatusTextBox.Text = "";
            ErrorLabel.Text = "";
            foreach (var control in FlagsGroupBox.Controls)
            {
                ((CheckBox)control).Checked = false;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void StatusTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateFlags();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
