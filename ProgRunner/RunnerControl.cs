using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ProgRunner
{
    public partial class RunnerControl : UserControl
    {
        public RunnerControl()
        {
            InitializeComponent();
            ToggleState(false);
        }

        public bool IsRunning { get; private set; }

        public string Process
        {
            get
            {
                return TargetProcess.StartInfo.FileName;
            }

            set
            {
                ProcessNameLabel.Text = value;
                TargetProcess.StartInfo.FileName = value;
                TargetProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(value);
            }
        }

        public string Arguments
        {
            get => TargetProcess.StartInfo.Arguments;
            set => TargetProcess.StartInfo.Arguments = value;
        }

        public void Start()
        {
            StartTargetProcess();
            ToggleState(IsRunning);
        }

        public void Stop()
        {
            StopTargetProcess();
            ToggleState(IsRunning);
        }

        private void TargetProcess_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                WriteToLog(e.Data);
            }
        }

        private void TargetProcess_Exited(object sender, EventArgs e)
        {
            ToggleState(false);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTargetProcess();
            ToggleState(true);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopTargetProcess();
            ToggleState(false);
        }

        private void CopyOutputButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LogOutput.GetText());
        }

        private void ClearOutputButton_Click(object sender, EventArgs e)
        {
            LogOutput.Clear();
        }

        private void StartTargetProcess()
        {
            try
            {
                TargetProcess.Start();
                TargetProcess.BeginOutputReadLine();
                IsRunning = true;
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void StopTargetProcess()
        {
            try
            {
                if (IsRunning)
                {
                    var pid = Convert.ToUInt32(TargetProcess.Id);

                    ConsoleUtils.AttachConsole(pid); // attach to process console
                    ConsoleUtils.SetConsoleCtrlHandler(null, true); // disable Control+C handling for our app
                    ConsoleUtils.GenerateConsoleCtrlEvent(ConsoleUtils.CtrlTypes.CTRL_C_EVENT, 0); // generate Control+C event
                    ConsoleUtils.FreeConsole();
                    
                    // must close the output read before closing the process
                    TargetProcess.CancelOutputRead();
                    TargetProcess.Close();

                    IsRunning = false;
                }
            }
            catch (InvalidOperationException ex)
            {
            }
        }

        private void ToggleState(bool running)
        {
            StartButton.Enabled = !running;
            StopButton.Enabled = running;
            StatusProgressBar.Visible = running;
        }

        private void WriteToLog(string line)
        {
            LogOutput.AddItem(line);
        }

        private void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
