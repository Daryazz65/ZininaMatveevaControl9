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
using ZininaMatveevaControl9.AppData;
using ZininaMatveevaControl9.View.Pages;

namespace ZininaMatveevaControl9.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();

            FrameHelper.FrameMenu = MainFrm;
            MainFrm.Navigate(new StartPage());
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new AddGroupPage());
        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new AddSorevPage());

        }

        private void Hyperlink_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new Journal  Page());

        }
    }
}
