using System.Windows.Forms;

namespace VolumePlanning
{
    partial class MotzkinForm
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
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.SystemRichBox = new System.Windows.Forms.RichTextBox();
            this.AlgorythRunButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.EpsilonNumeric = new System.Windows.Forms.NumericUpDown();
            this.StepsNumeric = new System.Windows.Forms.NumericUpDown();
            this.StepsLabel = new System.Windows.Forms.Label();
            this.EpsilonLabel = new System.Windows.Forms.Label();
            this.AlgorythmPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.OverlayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OverlayChange = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.EpsilonNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsNumeric)).BeginInit();
            this.AlgorythmPanel.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Location = new System.Drawing.Point(12, 32);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(107, 25);
            this.FileSelectButton.TabIndex = 0;
            this.FileSelectButton.Text = "Выбрать файл";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileSelectButton_MouseClick);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(125, 32);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.ReadOnly = true;
            this.FilePathTextBox.Size = new System.Drawing.Size(350, 23);
            this.FilePathTextBox.TabIndex = 1;
            this.FilePathTextBox.TextChanged += new System.EventHandler(this.FilePathTextBox_TextChanged);
            // 
            // SystemRichBox
            // 
            this.SystemRichBox.BackColor = System.Drawing.SystemColors.Window;
            this.SystemRichBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SystemRichBox.Enabled = false;
            this.SystemRichBox.Location = new System.Drawing.Point(12, 63);
            this.SystemRichBox.Name = "SystemRichBox";
            this.SystemRichBox.ReadOnly = true;
            this.SystemRichBox.Size = new System.Drawing.Size(199, 361);
            this.SystemRichBox.TabIndex = 2;
            this.SystemRichBox.Text = "";
            this.SystemRichBox.Visible = false;
            this.SystemRichBox.WordWrap = false;
            // 
            // AlgorythRunButton
            // 
            this.AlgorythRunButton.Location = new System.Drawing.Point(3, 3);
            this.AlgorythRunButton.Name = "AlgorythRunButton";
            this.AlgorythRunButton.Size = new System.Drawing.Size(120, 23);
            this.AlgorythRunButton.TabIndex = 3;
            this.AlgorythRunButton.Text = "Запуск алгоритма";
            this.AlgorythRunButton.UseVisualStyleBackColor = true;
            this.AlgorythRunButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AlgorythRunButton_MouseClick);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTextBox.Location = new System.Drawing.Point(3, 32);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(337, 50);
            this.ResultTextBox.TabIndex = 4;
            this.ResultTextBox.Text = "";
            this.ResultTextBox.WordWrap = false;
            // 
            // EpsilonNumeric
            // 
            this.EpsilonNumeric.DecimalPlaces = 3;
            this.EpsilonNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.EpsilonNumeric.Location = new System.Drawing.Point(272, 3);
            this.EpsilonNumeric.Name = "EpsilonNumeric";
            this.EpsilonNumeric.Size = new System.Drawing.Size(68, 23);
            this.EpsilonNumeric.TabIndex = 5;
            this.EpsilonNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // StepsNumeric
            // 
            this.StepsNumeric.Location = new System.Drawing.Point(151, 3);
            this.StepsNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.StepsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StepsNumeric.Name = "StepsNumeric";
            this.StepsNumeric.Size = new System.Drawing.Size(93, 23);
            this.StepsNumeric.TabIndex = 6;
            this.StepsNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // StepsLabel
            // 
            this.StepsLabel.Location = new System.Drawing.Point(129, 3);
            this.StepsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.StepsLabel.Name = "StepsLabel";
            this.StepsLabel.Size = new System.Drawing.Size(16, 23);
            this.StepsLabel.TabIndex = 7;
            this.StepsLabel.Text = "N";
            this.StepsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EpsilonLabel
            // 
            this.EpsilonLabel.Location = new System.Drawing.Point(250, 3);
            this.EpsilonLabel.Margin = new System.Windows.Forms.Padding(3);
            this.EpsilonLabel.Name = "EpsilonLabel";
            this.EpsilonLabel.Size = new System.Drawing.Size(16, 23);
            this.EpsilonLabel.TabIndex = 8;
            this.EpsilonLabel.Text = "E";
            this.EpsilonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlgorythmPanel
            // 
            this.AlgorythmPanel.Controls.Add(this.AlgorythRunButton);
            this.AlgorythmPanel.Controls.Add(this.StepsLabel);
            this.AlgorythmPanel.Controls.Add(this.StepsNumeric);
            this.AlgorythmPanel.Controls.Add(this.EpsilonLabel);
            this.AlgorythmPanel.Controls.Add(this.EpsilonNumeric);
            this.AlgorythmPanel.Controls.Add(this.ResultTextBox);
            this.AlgorythmPanel.Enabled = false;
            this.AlgorythmPanel.Location = new System.Drawing.Point(217, 63);
            this.AlgorythmPanel.Name = "AlgorythmPanel";
            this.AlgorythmPanel.Size = new System.Drawing.Size(352, 86);
            this.AlgorythmPanel.TabIndex = 9;
            this.AlgorythmPanel.Visible = false;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OverlayMenu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 10;
            this.Menu.Text = "menuStrip1";
            // 
            // OverlayMenu
            // 
            this.OverlayMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OverlayChange});
            this.OverlayMenu.Name = "OverlayMenu";
            this.OverlayMenu.Size = new System.Drawing.Size(48, 20);
            this.OverlayMenu.Text = "Окно";
            // 
            // OverlayChange
            // 
            this.OverlayChange.Name = "OverlayChange";
            this.OverlayChange.Size = new System.Drawing.Size(172, 22);
            this.OverlayChange.Text = "Поверх всех окон";
            this.OverlayChange.CheckedChanged += new System.EventHandler(this.OverlayChange_CheckedChanged);
            this.OverlayChange.Click += new System.EventHandler(this.OverlayChange_Click);
            // 
            // MotzkinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.AlgorythmPanel);
            this.Controls.Add(this.SystemRichBox);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.FileSelectButton);
            this.MainMenuStrip = this.Menu;
            this.Name = "MotzkinForm";
            this.ShowIcon = false;
            this.Text = "Агмон-Моцкин";
            ((System.ComponentModel.ISupportInitialize)(this.EpsilonNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsNumeric)).EndInit();
            this.AlgorythmPanel.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FileSelectButton;
        private TextBox FilePathTextBox;
        private Label StepsLabel;
        private Label EpsilonLabel;
        protected RichTextBox ResultTextBox;
        protected FlowLayoutPanel AlgorythmPanel;
        protected RichTextBox SystemRichBox;
        private Button AlgorythRunButton;
        protected NumericUpDown EpsilonNumeric;
        protected NumericUpDown StepsNumeric;
        private MenuStrip Menu;
        private ToolStripMenuItem OverlayMenu;
        private ToolStripMenuItem OverlayChange;
    }
}