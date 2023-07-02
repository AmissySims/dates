using DocumentFormat.OpenXml.Office2013.Word;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для grids.xaml
    /// </summary>
    public partial class grids : Page
    {
        ObservableCollection<Person> persons { get; set; }
        public grids()
        {
            InitializeComponent();
            persons = new ObservableCollection<Person>();
            Person pers = new Person { Name = "fff", Age=4 };
            persons.Add(pers);
            Person pers1 = new Person { Name = "fff", Age = 4 };
            persons.Add(pers1);
            Person pers2 = new Person { Name = "fff", Age = 4 };
            persons.Add(pers2);
            Person pers3 = new Person { Name = "fff", Age = 4 };
            persons.Add(pers3);
            Data.DataContext = this;
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
       
        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            Data.ItemsSource = persons;

           

            
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(NameTb.Text))
                {
                    MessageBox.Show("null name");
                    return;
                }
                if (string.IsNullOrEmpty(AgeTb.Text))
                {
                    MessageBox.Show("null age");
                    return;
                }
                else
                {
                    Person pers = new Person { Name = NameTb.Text, Age = int.Parse(AgeTb.Text) };
                    
                    persons.Append(pers);
                   

                }
                
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NameTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!Char.IsLetter(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void AgeTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
