using ProgRunner.Config;
using System;
using System.Windows.Forms;

namespace ProgRunner
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void AddProcessButton_Click(object sender, EventArgs e)
        {
            PromptForNewProcess(out var path, out var args);

            AddNewProcess(path, args);
        }

        private static void PromptForNewProcess(out string path, out string arguments)
        {
            path = null;
            arguments = null;

            using (var dlg = new AddProcessDialog())
            {
                var result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    path = dlg.Path;
                    arguments = dlg.Arguments;
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TileWindowsButton_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void RunAllButton_Click(object sender, EventArgs e)
        {
            if (MdiChildren == null)
                return;

            foreach (var win in MdiChildren)
            {
                if (win is ProgramForm pf && !pf.IsRunning)
                {
                    pf.Start();
                }
            }
        }

        private void StopAllButton_Click(object sender, EventArgs e)
        {
            if (MdiChildren == null)
                return;

            foreach (var win in MdiChildren)
            {
                if (win is ProgramForm pf && pf.IsRunning)
                {
                    pf.Stop();
                }
            }
        }

        private void AddNewProcess(string path, string args)
        {
            if (!string.IsNullOrWhiteSpace(path))
            {
                var pf = new ProgramForm(path, args)
                {
                    MdiParent = this
                };
                pf.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var processes = StartupConfig.GetStartupProcesses();
            foreach (var process in processes)
            {
                AddNewProcess(process.FileName, process.Arguments);
            }
        }
    }
}
