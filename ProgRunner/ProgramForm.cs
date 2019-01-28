using System.IO;
using System.Windows.Forms;

namespace ProgRunner
{
    public partial class ProgramForm : Form
    {
        public ProgramForm(string processName, string arguments = null, string name = null)
        {
            InitializeComponent();
            InnerRunner.Process = processName;
            Text = name ?? Path.GetFileName(processName);
        }

        public bool IsRunning => InnerRunner.IsRunning;

        public void Start()
        {
            if (!InnerRunner.IsRunning)
                InnerRunner.Start();
        }

        public void Stop()
        {
            if (InnerRunner.IsRunning)
                InnerRunner.Stop();
        }

        private void ProgramForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InnerRunner.Stop();
        }
    }
}
