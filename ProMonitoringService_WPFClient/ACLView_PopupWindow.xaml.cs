using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProMonitoringService_WPFClient
{
    /// <summary>
    /// Interaction logic for ACLView_PopupWindow.xaml
    /// </summary>
    public partial class ACLView_PopupWindow : Window
    {
        public ACLView_PopupWindow(string title, UserControl content)
        {
            InitializeComponent();
            Title_TextBlock.Text = title;
            ContentPlaceholder_ContentControl.Content = content;
        }

        private void CloseWhindow_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();

            e.Handled = true;
        }
    }
}
