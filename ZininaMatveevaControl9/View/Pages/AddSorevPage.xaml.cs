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
    /// Логика взаимодействия для AddSorevPage.xaml
    /// </summary>
    public partial class AddSorevPage : Page
    {
        private LagerZininaMatveevaEntities1 context = App.GetContext();
        public AddSorevPage()
        {
            InitializeComponent();

            TypeSorevCmb.ItemsSource = context.Direction.ToList();
            TypeSorevCmb.DisplayMemberPath = "Name";
            TypeSorevCmb.SelectedIndex = 0;
        }

        private void AddSorevBtn_Click(object sender, RoutedEventArgs e)
        {
            //if (string.IsNullOrEmpty(SorevNameTb.Text))
            //{
            //    TypeCompetition newTypeCompetition = new TypeCompetition()
            //    {
            //        Name = SorevNameTb.Text,
            //        Direction = TypeSorevCmb.SelectedItem as Direction
            //    };
            //    context.TypeCompetition.Add(newTypeCompetition);
            //    context.SaveChanges();
            //    MessageBox.Show("Соревнование добавлено.");
            //    FrameHelper.FrameMenu.Navigate(new StartPage());

                if (string.IsNullOrEmpty(SorevNameTb.Text))
                {
                    MessageBox.Show("Введите название соревнования");
                }
                else
                {

                TypeCompetition newTypeCompetition = new TypeCompetition()
                    {
                        Name = SorevNameTb.Text,
                        Direction = TypeSorevCmb.SelectedItem as Direction
                    };
                    context.TypeCompetition.Add(newTypeCompetition);
                    context.SaveChanges();
                    MessageBox.Show("Соревнование добавлено");
                    FrameHelper.FrameMenu.Navigate(new StartPage());

                }
        }
    }
}
