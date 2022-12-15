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

namespace PracticeTRPO
{
    /// <summary>
    /// Логика взаимодействия для EmployerWindow.xaml
    /// </summary>
    public partial class EmployerWindow : Window
    {
        public Employer Employer { get; private set; }
        public EmployerWindow(Employer employer)
        {
            InitializeComponent();
            Employer = employer;
            DataContext = Employer;
        }
        void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
