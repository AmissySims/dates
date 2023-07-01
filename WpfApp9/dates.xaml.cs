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
    /// Логика взаимодействия для dates.xaml
    /// </summary>
    public partial class dates : Page
    {
        public dates()
        {
            InitializeComponent();
        }
        private void NameTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsLetter(e.Text, 0))
                e.Handled = true;
        }

        private void DateTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) && (e.Text != "."))
                e.Handled = true;
        }

        private void GenBt_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTb.Text;
            string dateBirth = DateTb.Text;
            try
            {
                if (Regex.IsMatch(dateBirth, @"^(?:31|[0-3](?(?<=0)[1-9]|(?(?<=3)[01]|\d)))[.][01](?(?<=1)[0-2]|(?(?<=0)[1-9]|\d))[.][12](?(?<=1)9\d{2}|\d{3})$"))
                {
                    string login = GenLogin(name, dateBirth);
                    Logintb.Text = login;
                    string pas = GenPas();
                    Pastb.Text = pas;
                }
                else
                {
                    MessageBox.Show("Incorrect date");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string GenLogin(string name, string dateBirth)
        {

            string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            int sumDig = dateBirth.Where(char.IsDigit).Sum(x => int.Parse(x.ToString()));
            string login = string.Concat(name.ToLower().Select(c =>
            {
                if (char.IsLetter(c))
                {
                    int pos = alph.IndexOf(c) + 1;
                    return pos.ToString();
                }
                return c.ToString();
            }));
            login += sumDig.ToString();
            return login;

        }
        public string GenPas()
        {
            string[] chars = { "'", "=", "(", "!", "*", "+", "%", "&", "^", "@", "0", "]", "[", "#", "_" };
            Random rb = new Random();
            StringBuilder sb = new StringBuilder();
            string charss = chars[rb.Next(chars.Length)];
            sb.Append(charss);
            for (int i = 0; i < 9; i++)
            {
                sb.Append(rb.Next(10));
            }
            string pas = new string(sb.ToString().OrderBy(x => rb.Next()).ToArray());
            return pas;

        }
    }
}
