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

namespace Что_то_на_казахском
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        ApplicationContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }

        private void Button_AddEmpl_Click(object sender, RoutedEventArgs e)
        {
            string first_name = First_Name.Text.Trim();
            string second_name = Second_Name.Text.Trim();
            string third_name = Third_Name.Text.Trim();
            string phone = Phone.Text.Trim();
            string birthday = Birthday.Text.Trim();
            string departament = Departament.Text.Trim();

            if (first_name.Length < 1)
            {
                First_Name.ToolTip = "Поле не должно быть пустым!";
                First_Name.Background = Brushes.IndianRed;
            }
            else if (second_name.Length < 1)
            {
                Second_Name.ToolTip = "Поле не должно быть пустым!";
                Second_Name.Background = Brushes.IndianRed;
            }
            else if (phone.Length < 1)
            {
                Phone.ToolTip = "Поле не должно быть пустым!";
                Phone.Background = Brushes.IndianRed;
            }
            else if (birthday.Length < 1)
            {
                Birthday.ToolTip = "Поле не должно быть пустым!";
                Birthday.Background = Brushes.IndianRed;
            }
            else if (departament.Length < 1)
            {
                Departament.ToolTip = "Поле не должно быть пустым!";
                Departament.Background = Brushes.IndianRed;
            }
            else
            {
                First_Name.ToolTip = "";
                First_Name.Background = Brushes.Transparent;
                Second_Name.ToolTip = "";
                Second_Name.Background = Brushes.Transparent;
                Phone.ToolTip = "";
                Phone.Background = Brushes.Transparent;
                Birthday.ToolTip = "";
                Birthday.Background = Brushes.Transparent;
                Departament.ToolTip = "";
                Departament.Background = Brushes.Transparent;

                MessageBox.Show("Пользователь успешно добавлен.");
                Employer employer = new(first_name, second_name, third_name, phone, birthday, departament);

                db.Employers.Add(employer);
                db.SaveChanges();
            }
        }
    }

}
