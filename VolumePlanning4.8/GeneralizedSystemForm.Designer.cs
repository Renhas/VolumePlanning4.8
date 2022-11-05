namespace VolumePlanning
{
    partial class GeneralizedSystemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlgorythmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EpsilonNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Size = new System.Drawing.Size(275, 80);
            this.ResultTextBox.Visible = false;
            // 
            // AlgorythmPanel
            // 
            this.AlgorythmPanel.Location = new System.Drawing.Point(481, 32);
            this.AlgorythmPanel.Size = new System.Drawing.Size(345, 124);
            // 
            // SystemRichBox
            // 
            this.SystemRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemRichBox.Size = new System.Drawing.Size(814, 375);
            // 
            // GeneralizedSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Name = "GeneralizedSystemForm";
            this.Text = "Общий случай задачи планирования";
            this.AlgorythmPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EpsilonNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}