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

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clSign(object sender, RoutedEventArgs e)
        {
            var people = Models.context.GetContext().Peoples.Where(p => p.Login == Log.Text && p.pwd == Pass.Password).FirstOrDefault();
            if (people != null)
            {
                MessageBox.Show("Отлично.");
                Forms.ListForm list = new Forms.ListForm();
                list.Show();
                Close();
            }
            else
                MessageBox.Show("Что-то пошло не так)");
        }

        private void clListView(object sender, RoutedEventArgs e)
        {
            Forms.ListViewFormExample formExample = new Forms.ListViewFormExample();
            formExample.Show();
            Close();
        }
    }
}
