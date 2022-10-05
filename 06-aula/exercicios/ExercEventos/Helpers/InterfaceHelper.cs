using System.Windows.Forms;

namespace ExercEventos
{
    internal class InterfaceHelper
    {
        public static void ClearAllTextBoxs(Control.ControlCollection controls)
        {
            foreach (Control textBox in controls)
            {
                if (textBox is TextBox)
                {
                    (textBox as TextBox).Clear();
                }
            }
        }

    }
}
