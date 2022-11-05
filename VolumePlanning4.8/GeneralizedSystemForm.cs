using GeneralizedSystem;
using SLAN;
using System.Windows.Forms;

namespace VolumePlanning
{
    public partial class GeneralizedSystemForm : MotzkinForm
    {
        public GeneralizedSystemForm()
        {
            InitializeComponent();
            reader = new MyReader();
        }

        protected override void AlgorythRunButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || system as BilateralInequalitySystem == null) return;
            MyVector vector = VolumePlanningAlgorythm.Run(system as BilateralInequalitySystem, (int)StepsNumeric.Value, (float)EpsilonNumeric.Value);
            SystemRichBox.Text = system.ToString();
            if (vector is null)
                SystemRichBox.Text += "\nСистема не совместна";
            else
                SystemRichBox.Text += $"\nРешение: {vector}";
        }
    }
}
