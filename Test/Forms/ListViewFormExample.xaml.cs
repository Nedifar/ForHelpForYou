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

namespace Test.Forms
{
    /// <summary>
    /// Логика взаимодействия для ListViewFormExample.xaml
    /// </summary>
    public partial class ListViewFormExample : Window
    {
        public ListViewFormExample()
        {
            InitializeComponent();
            lvPeoples.ItemsSource = Models.context.GetContext().Peoples.ToList();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            lvPeoples.ItemsSource = Models.context.GetContext().Peoples.Where(p=>p.Gender.Name =="Муж").ToList();
        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            lvPeoples.ItemsSource = Models.context.GetContext().Peoples.Where(p => p.Gender.Name == "Жен").ToList();
        }
    }
}
