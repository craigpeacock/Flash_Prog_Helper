using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace Programmer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bHexFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Hex Files (*.hex)|*.hex";
            saveFileDialog.FileName = tbHexFileName.Text;
            saveFileDialog.OverwritePrompt = false;
            saveFileDialog.ShowDialog();
            tbHexFileName.Text = saveFileDialog.FileName;
        }

        private void bModemFWFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Zip Files (*.zip)|*.zip";
            saveFileDialog.FileName = tbModemFWFileName.Text;
            saveFileDialog.OverwritePrompt = false;
            saveFileDialog.ShowDialog();
            tbModemFWFileName.Text = saveFileDialog.FileName;
        }

        private void bProgExecFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Exe Files (*.exe)|*.exe";
            saveFileDialog.FileName = tbProgExecFileName.Text;
            saveFileDialog.OverwritePrompt = false;
            saveFileDialog.ShowDialog();
            tbProgExecFileName.Text = saveFileDialog.FileName;
        }

        private void bProgram_Click(object sender, EventArgs e)
        {
            if (cbEnableModemFW.Checked)
            {
                tsStatusLabel.Text = "Programming Modem Firmware";
                Program("-f NRF91 --program \"" + tbModemFWFileName.Text + "\" --chiperase --verify --reset");
            }

            if (cbEnableHex.Checked)
            {
                tsStatusLabel.Text = "Programming Hex File";
                Program("-f NRF91 --program \"" + tbHexFileName.Text + "\" --chiperase --verify --reset");
            }
        }
        private void bReset_Click(object sender, EventArgs e)
        {
            tsStatusLabel.Text = "Resetting MCU";
            Program("-f NRF91 --reset");
        }

        private void Program(string arguments)
        {
            int exitCode;

            ProcessStartInfo start = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            start.Arguments = arguments;
            // Enter the executable to run, including the complete path
            start.FileName = tbProgExecFileName.Text;
            // Do you want to show a console window?
            if (cbShowCommandWindow.Checked)
            {
                start.WindowStyle = ProcessWindowStyle.Normal;
                start.CreateNoWindow = false;
            }
            else
            {
                start.WindowStyle = ProcessWindowStyle.Hidden;
                start.CreateNoWindow = true;
            }

            // Run the external process & wait for it to finish
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();

                // Retrieve the app's exit code
                exitCode = proc.ExitCode;
            }

        // Nordic Semiconductor list return codes for nrfjprog at:
        https://docs.nordicsemi.com/bundle/ug_nrf_cltools/page/UG/cltools/nrf_nrfjprogexe_return_codes.html

            switch (exitCode)
            {
                case 0:
                    tsStatusLabel.Text = "Success";
                    break;

                case 33:
                    tsStatusLabel.Text = " JLinkARMDllError. Check SWD connection with target";
                    break;

                case 41:
                    tsStatusLabel.Text = "There are no debuggers connected to the PC.";
                    break;

                case 51:
                    tsStatusLabel.Text = "File not found.";
                    break;

                case 43:
                    tsStatusLabel.Text = "Low voltage detected at target device.";
                    break;

                case 64:
                    tsStatusLabel.Text = "An operation timed out.";
                    break;

                default:
                    tsStatusLabel.Text = "Error " + exitCode.ToString();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey key;

            try
            {
                key = Registry.CurrentUser.OpenSubKey("Software\\BeyondLogic\\FlashProgrammingHelper");
                if (key != null)
                {
                    tbHexFileName.Text = (string)key.GetValue("Hex File 1");
                    cbEnableHex.Checked = Convert.ToBoolean(key.GetValue("Enable Hex File 1"));
                    tbModemFWFileName.Text = (string)(key.GetValue("Modem Firmware"));
                    cbEnableModemFW.Checked = Convert.ToBoolean(key.GetValue("Enable Modem Firmware"));
                    tbProgExecFileName.Text = (string)key.GetValue("Programmer Executable");
                    cbShowCommandWindow.Checked = Convert.ToBoolean(key.GetValue("Show Window"));
                    if (key.GetValue("Left") != null)
                        this.Left = (int)key.GetValue("Left");
                    if (key.GetValue("Top") != null)
                        this.Top = (int)key.GetValue("Top");
                    key.Close();
                }
            } catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryKey key;
            key = Registry.CurrentUser.CreateSubKey("Software\\BeyondLogic\\FlashProgrammingHelper");
            key.SetValue("Hex File 1", tbHexFileName.Text);
            key.SetValue("Enable Hex File 1", cbEnableHex.Checked);
            key.SetValue("Modem Firmware", tbModemFWFileName.Text);
            key.SetValue("Enable Modem Firmware", cbEnableModemFW.Checked);
            key.SetValue("Programmer Executable", tbProgExecFileName.Text);
            key.SetValue("Show Window", cbShowCommandWindow.Checked);
            key.SetValue("Left", this.Left);
            key.SetValue("Top", this.Top);
            key.Close();
        }
    }
}
