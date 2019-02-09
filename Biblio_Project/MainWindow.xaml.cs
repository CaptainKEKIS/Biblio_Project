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

namespace Biblio_Project
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                Reader reader1 = new Reader { FirstName = "Vasya", LastName = "Pupkin" };

                db.Readers.Add(reader1);
                db.SaveChanges();

                var Readers = db.Readers.ToList();
                lbReadersFirstName.ItemsSource = Readers;
                lbReadersLastName.ItemsSource = Readers;
            }
        }
    }
}