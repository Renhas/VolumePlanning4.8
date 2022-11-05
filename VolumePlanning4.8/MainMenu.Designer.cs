using System.Windows.Forms;

namespace VolumePlanning
{
    partial class MainMenu
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
            this.MotzkinButton = new System.Windows.Forms.Button();
            this.GeneralButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MotzkinButton
            // 
            this.MotzkinButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MotzkinButton.Location = new System.Drawing.Point(0, 0);
            this.MotzkinButton.Name = "MotzkinButton";
            this.MotzkinButton.Size = new System.Drawing.Size(129, 220);
            this.MotzkinButton.TabIndex = 0;
            this.MotzkinButton.Text = "Налево пойдёшь - Моцкина встретишь";
            this.MotzkinButton.UseVisualStyleBackColor = true;
            this.MotzkinButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MotzkinButton_MouseClick);
            // 
            // GeneralButton
            // 
            this.GeneralButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.GeneralButton.Location = new System.Drawing.Point(127, 0);
            this.GeneralButton.Name = "GeneralButton";
            this.GeneralButton.Size = new System.Drawing.Size(129, 220);
            this.GeneralButton.TabIndex = 1;
            this.GeneralButton.Text = "Направо пойдёшь - общий вид увидишь\r\n";
            this.GeneralButton.UseVisualStyleBackColor = true;
            this.GeneralButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GeneralButton_MouseClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 220);
            this.Controls.Add(this.MotzkinButton);
            this.Controls.Add(this.GeneralButton);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.Text = "Распутье";
            this.ResumeLayout(false);

        }

        #endregion

        private Button MotzkinButton;
        private Button GeneralButton;
    }
}