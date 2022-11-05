using Agmon_Motzkin;
using SLAN;
using System.Windows.Forms;
using System;

namespace VolumePlanning
{
    public partial class MotzkinForm : Form
    {
        protected InequalitySystem system;
        protected IMyReader reader;
        public MotzkinForm()
        {
            InitializeComponent();
            system = null;
            reader = new MyReader();
        }

        private void FilePathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox box) 
            {
                if (box.Text == "")
                {
                    SystemRichBox.Enabled = SystemRichBox.Visible = false;
                    AlgorythmPanel.Enabled = AlgorythmPanel.Visible = false;
                }
                else 
                {
                    SystemRichBox.Enabled = SystemRichBox.Visible = true;
                    AlgorythmPanel.Enabled = AlgorythmPanel.Visible = true;
                }
            }
        }

        private void FileSelectButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Текстовый файл (*.txt) | *.txt",
                Title = "Открыть файл"
            };

            if (dialog.ShowDialog() != DialogResult.OK) return;

            try
            {

                reader.Read(dialog.FileName);
                FilePathTextBox.Text = dialog.FileName;
                system = reader.Read(dialog.FileName);
                SystemRichBox.Text = system.ToString();
            }
            catch
            {
                MessageBox.Show("Проверьте корректность данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FilePathTextBox.Text = ResultTextBox.Text = SystemRichBox.Text = "";
            }
            ResultTextBox.Text = "";
        }

        protected virtual void AlgorythRunButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || system == null) return;
            MyVector answer;
            bool IsCompatible = Algorythm.Run(system, (int)StepsNumeric.Value, (float)EpsilonNumeric.Value, out answer);
            ResultTextBox.Text = $"Система {(IsCompatible ? " ": "не" )} совместна\n";
            if (IsCompatible) ResultTextBox.Text += answer.ToString();

        }

        private void OverlayChange_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = OverlayChange.Checked;
        }

        private void OverlayChange_Click(object sender, EventArgs e)
        {
            OverlayChange.Checked = !OverlayChange.Checked;
        }
    }
}