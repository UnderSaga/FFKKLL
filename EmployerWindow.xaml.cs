using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
