using System.Windows.Forms;

namespace WOIHelper.Services
{
    public class MessageBoxService
    {
        public void ShowErrorMessageBox(string message, string title = "")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}