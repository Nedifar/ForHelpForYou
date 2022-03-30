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
    /// Логика взаимодействия для ListForm.xaml
    /// </summary>
    public partial class ListForm : Window
    {
        public ListForm()
        {
            InitializeComponent();
            dgUsers.ItemsSource = Models.context.GetContext().Peoples.ToList();
        }

        private void clAdd(object sender, RoutedEventArgs e)
        {
            Forms.AddingPeopleForm adding = new AddingPeopleForm(null);
            adding.IsVisibleChanged += Adding_IsVisibleChanged;
            adding.Show();
        }

        private void Adding_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            dgUsers.ItemsSource = Models.context.GetContext().Peoples.ToList();
        }

        private void clEdit(object sender, RoutedEventArgs e)
        {
            var selectedPeople = dgUsers.SelectedItem as Models.People;
            if(dgUsers.SelectedItems.Count==1)
            {
                Forms.AddingPeopleForm adding = new AddingPeopleForm(selectedPeople);
                adding.IsVisibleChanged += Adding_IsVisibleChanged;
                adding.Show();
            }
        }

        private void clDelete(object sender, RoutedEventArgs e)
        {
            var selectedPeople = dgUsers.SelectedItem as Models.People;

            if (dgUsers.SelectedItems.Count==1)
            {
                Models.context.GetContext().Peoples.Remove(selectedPeople);
                Models.context.GetContext().SaveChanges();
                dgUsers.ItemsSource = Models.context.GetContext().Peoples.ToList();
                MessageBox.Show("Удаление успешно выполнено.");
            }
        }
    }
}
