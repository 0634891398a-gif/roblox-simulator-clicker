```csharp
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RobloxAutoClicker
{
    public partial class MainForm : Form
    {
        private const string RobloxProcessName = "RobloxPlayerBeta"; // Assuming this is the process name
        private bool isClicking;
        private Timer processCheckTimer;

        public MainForm()
        {
            InitializeComponent();
            InitializeAdditionalComponents();
        }

        private void InitializeAdditionalComponents()
        {
            processCheckTimer = new Timer();
            processCheckTimer.Interval = 1000; // Check every second
            processCheckTimer.Tick += ProcessCheckTimer_Tick;
            processCheckTimer.Start();

            isClicking = false;
        }

        private void ProcessCheckTimer_Tick(object sender, EventArgs e)
        {
            if (!IsRobloxRunning())
            {
                StopClicking();
                MessageBox.Show("Roblox is not running. Please start Roblox to use the auto clicker.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsRobloxRunning()
        {
            Process[] processes = Process.GetProcessesByName(RobloxProcessName);
            return processes.Length > 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (IsRobloxRunning())
            {
                StartClicking();
            }
            else
            {
                MessageBox.Show("Roblox must be running to start the auto clicker.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopClicking();
        }

        private void StartClicking()
        {
            if (!isClicking)
            {
                isClicking = true;
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                // Start auto clicking logic (e.g., using a BackgroundWorker or similar)
            }
        }

        private void StopClicking()
        {
            if (isClicking)
            {
                isClicking = false;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                // Stop auto clicking logic here
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopClicking();
        }
    }
}
```