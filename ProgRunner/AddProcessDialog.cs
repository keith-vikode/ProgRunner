using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgRunner
{
    public partial class AddProcessDialog : Form
    {
        public AddProcessDialog()
        {
            InitializeComponent();
            ProcessPath.Focus();
        }

        public string Path { get; set; }

        public string Arguments { get; set; }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Path = @ProcessPath.Text;
            Arguments = ArgumentsText.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                var result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ProcessPath.Text = dlg.FileName;
                }
            }
        }
    }
}
