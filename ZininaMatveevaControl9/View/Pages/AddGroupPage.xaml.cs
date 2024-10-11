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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZininaMatveevaControl9.AppData;
using ZininaMatveevaControl9.Model;

namespace ZininaMatveevaControl9.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        private LagerZininaMatveevaEntities1 context = App.GetContext();
        public AddGroupPage()
        {
            InitializeComponent();

            SpecializationCmb.ItemsSource = context.Specialization.ToList();
            SpecializationCmb.DisplayMemberPath = "Name";
            SpecializationCmb.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(GroupNameTb.Text))
            {
                MessageBox.Show("Введите название группы");
            }
            else
            {
                Group newGroup = new Group()
                {
                    Name = GroupNameTb.Text,
                    Specialization = SpecializationCmb.SelectedItem as Specialization
                };
                MessageBox.Show("Группа добавлена");
                FrameHelper.FrameMenu.Navigate(new StartPage());
            }
        }
    }
}
