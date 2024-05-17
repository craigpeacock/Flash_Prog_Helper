namespace Programmer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbHexFileName = new TextBox();
            bHexFileDialog = new Button();
            saveFileDialog = new SaveFileDialog();
            tbProgExecFileName = new TextBox();
            bProgExecFileDialog = new Button();
            bProgram = new Button();
            statusStrip1 = new StatusStrip();
            tsStatusLabel = new ToolStripStatusLabel();
            lHexFileName = new Label();
            label1 = new Label();
            lModemFWFileName = new Label();
            bModemFWFileDialog = new Button();
            tbModemFWFileName = new TextBox();
            cbShowCommandWindow = new CheckBox();
            cbEnableHex = new CheckBox();
            cbEnableModemFW = new CheckBox();
            bReset = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbHexFileName
            // 
            tbHexFileName.Location = new Point(173, 29);
            tbHexFileName.Name = "tbHexFileName";
            tbHexFileName.Size = new Size(497, 23);
            tbHexFileName.TabIndex = 0;
            // 
            // bHexFileDialog
            // 
            bHexFileDialog.Location = new Point(676, 29);
            bHexFileDialog.Name = "bHexFileDialog";
            bHexFileDialog.Size = new Size(35, 23);
            bHexFileDialog.TabIndex = 1;
            bHexFileDialog.Text = "...";
            bHexFileDialog.UseVisualStyleBackColor = true;
            bHexFileDialog.Click += bHexFileDialog_Click;
            // 
            // tbProgExecFileName
            // 
            tbProgExecFileName.Location = new Point(174, 111);
            tbProgExecFileName.Name = "tbProgExecFileName";
            tbProgExecFileName.Size = new Size(497, 23);
            tbProgExecFileName.TabIndex = 2;
            // 
            // bProgExecFileDialog
            // 
            bProgExecFileDialog.Location = new Point(677, 111);
            bProgExecFileDialog.Name = "bProgExecFileDialog";
            bProgExecFileDialog.Size = new Size(35, 23);
            bProgExecFileDialog.TabIndex = 3;
            bProgExecFileDialog.Text = "...";
            bProgExecFileDialog.UseVisualStyleBackColor = true;
            bProgExecFileDialog.Click += bProgExecFileDialog_Click;
            // 
            // bProgram
            // 
            bProgram.Location = new Point(327, 195);
            bProgram.Name = "bProgram";
            bProgram.Size = new Size(134, 46);
            bProgram.TabIndex = 4;
            bProgram.Text = "Program";
            bProgram.UseVisualStyleBackColor = true;
            bProgram.Click += bProgram_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsStatusLabel });
            statusStrip1.Location = new Point(0, 265);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsStatusLabel
            // 
            tsStatusLabel.Name = "tsStatusLabel";
            tsStatusLabel.Size = new Size(39, 17);
            tsStatusLabel.Text = "Ready";
            // 
            // lHexFileName
            // 
            lHexFileName.AutoSize = true;
            lHexFileName.Location = new Point(15, 33);
            lHexFileName.Name = "lHexFileName";
            lHexFileName.Size = new Size(79, 15);
            lHexFileName.TabIndex = 6;
            lHexFileName.Text = "Hex Filename";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 115);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 7;
            label1.Text = "Programmer Executable";
            // 
            // lModemFWFileName
            // 
            lModemFWFileName.AutoSize = true;
            lModemFWFileName.Location = new Point(15, 62);
            lModemFWFileName.Name = "lModemFWFileName";
            lModemFWFileName.Size = new Size(152, 15);
            lModemFWFileName.TabIndex = 10;
            lModemFWFileName.Text = "Modem Firmware Filename";
            // 
            // bModemFWFileDialog
            // 
            bModemFWFileDialog.Location = new Point(676, 58);
            bModemFWFileDialog.Name = "bModemFWFileDialog";
            bModemFWFileDialog.Size = new Size(35, 23);
            bModemFWFileDialog.TabIndex = 9;
            bModemFWFileDialog.Text = "...";
            bModemFWFileDialog.UseVisualStyleBackColor = true;
            bModemFWFileDialog.Click += bModemFWFileDialog_Click;
            // 
            // tbModemFWFileName
            // 
            tbModemFWFileName.Location = new Point(173, 58);
            tbModemFWFileName.Name = "tbModemFWFileName";
            tbModemFWFileName.Size = new Size(497, 23);
            tbModemFWFileName.TabIndex = 8;
            // 
            // cbShowCommandWindow
            // 
            cbShowCommandWindow.AutoSize = true;
            cbShowCommandWindow.Location = new Point(176, 145);
            cbShowCommandWindow.Name = "cbShowCommandWindow";
            cbShowCommandWindow.Size = new Size(285, 19);
            cbShowCommandWindow.TabIndex = 11;
            cbShowCommandWindow.Text = "Show Command Window (Useful for debugging)";
            cbShowCommandWindow.UseVisualStyleBackColor = true;
            // 
            // cbEnableHex
            // 
            cbEnableHex.AutoSize = true;
            cbEnableHex.Location = new Point(727, 33);
            cbEnableHex.Name = "cbEnableHex";
            cbEnableHex.Size = new Size(61, 19);
            cbEnableHex.TabIndex = 12;
            cbEnableHex.Text = "Enable";
            cbEnableHex.UseVisualStyleBackColor = true;
            // 
            // cbEnableModemFW
            // 
            cbEnableModemFW.AutoSize = true;
            cbEnableModemFW.Location = new Point(727, 61);
            cbEnableModemFW.Name = "cbEnableModemFW";
            cbEnableModemFW.Size = new Size(61, 19);
            cbEnableModemFW.TabIndex = 13;
            cbEnableModemFW.Text = "Enable";
            cbEnableModemFW.UseVisualStyleBackColor = true;
            // 
            // bReset
            // 
            bReset.Location = new Point(481, 203);
            bReset.Name = "bReset";
            bReset.Size = new Size(88, 30);
            bReset.TabIndex = 14;
            bReset.Text = "Reset MCU";
            bReset.UseVisualStyleBackColor = true;
            bReset.Click += bReset_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 287);
            Controls.Add(bReset);
            Controls.Add(cbEnableModemFW);
            Controls.Add(cbEnableHex);
            Controls.Add(cbShowCommandWindow);
            Controls.Add(lModemFWFileName);
            Controls.Add(bModemFWFileDialog);
            Controls.Add(tbModemFWFileName);
            Controls.Add(label1);
            Controls.Add(lHexFileName);
            Controls.Add(statusStrip1);
            Controls.Add(bProgram);
            Controls.Add(bProgExecFileDialog);
            Controls.Add(tbProgExecFileName);
            Controls.Add(bHexFileDialog);
            Controls.Add(tbHexFileName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "nRFjprog Helper";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbHexFileName;
        private Button bHexFileDialog;
        private SaveFileDialog saveFileDialog;
        private TextBox tbProgExecFileName;
        private Button bProgExecFileDialog;
        private Button bProgram;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsStatusLabel;
        private Label lHexFileName;
        private Label label1;
        private Label lModemFWFileName;
        private Button bModemFWFileDialog;
        private TextBox tbModemFWFileName;
        private CheckBox cbShowCommandWindow;
        private CheckBox cbEnableHex;
        private CheckBox cbEnableModemFW;
        private Button bReset;
    }
}
