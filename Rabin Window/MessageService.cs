using System.Windows.Forms;

namespace Rabin_Window
{
    public class MessageService
    {
        public void ShowMessage (string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
