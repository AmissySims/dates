using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frame1.Navigate(new dates());
            
            
           
        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(new dates());
        }


        //        public class Person
        //        {
        //            public string Name { get; set; }
        //            public int Age { get; set; }
        //        }
        //        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        //        {
        //            List<Person> people = new List<Person>();
        //            people.Add(new Person { Name = "jjj", Age = 34 });
        //            people.Add(new Person { Name = "jjj", Age = 34 });
        //            people.Add(new Person { Name = "jjj", Age = 34 });
        //            people.Add(new Person { Name = "jjj", Age = 34 });
        //            people.Add(new Person { Name = "jjj", Age = 34 });
        //            Data.ItemsSource = people;

        //;
        //        }




    }
}
