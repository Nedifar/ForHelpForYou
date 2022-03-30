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
    /// Логика взаимодействия для AddingPeopleForm.xaml
    /// </summary>
    public partial class AddingPeopleForm : Window
    {
        Models.People people = new Models.People();
        public AddingPeopleForm(Models.People _people)
        {
            InitializeComponent();
            if (_people != null)
                people = _people;
            DataContext = people;
            //cbGender.ItemsSource = Models.context.GetContext().Genders.ToList();
            cbGender.ItemsSource = new string[] { "Россия", "Америка", "Англия" };
        }

        private void clAdd(object sender, RoutedEventArgs e)
        {
            if (people.idPeople == 0)
            {
                Models.context.GetContext().Peoples.Add(people);
                MessageBox.Show("Успешно добавлено");
            }
            else
            {
                MessageBox.Show("Успешно изменено");
            }
            Models.context.GetContext().SaveChanges();
            Close();
        }
    }
}
