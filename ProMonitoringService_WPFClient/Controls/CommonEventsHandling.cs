using System.Windows.Controls;
using System.Windows.Input;

namespace ProMonitoringService_WPFClient.Controls
{
    public static class CommonEventsHandling
    {
        public static void GotMouseCapture(object sender, MouseEventArgs e)
        {
            var inputTextBox = (sender as TextBox);
            inputTextBox.Select(0, inputTextBox.Text.Length);

            e.Handled = true;
        }
    }
}
