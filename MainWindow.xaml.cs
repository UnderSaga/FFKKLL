using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Text.Json;
using System.IO;
using System;

namespace PracticeTRPO
{
    public partial class MainWindow : Window
    {
        ApplicationContext db = new ApplicationContext();
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        // при загрузке окна
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // гарантируем, что база данных создана
            db.Database.EnsureCreated();
            // загружаем данные из БД
            db.Employers.Load();
            // и устанавливаем данные в качестве контекста
            DataContext = db.Employers.Local.ToObservableCollection();
        }

        // добавление
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            EmployerWindow EmployerWindow = new EmployerWindow(new Employer());
            if (EmployerWindow.ShowDialog() == true)
            {
                Employer Employer = EmployerWindow.Employer;
                db.Employers.Add(Employer);
                db.SaveChanges();
            }
        }
        // редактирование
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // получаем выделенный объект
            Employer? employer = employersList.SelectedItem as Employer;
            // если ни одного объекта не выделено, выходим
            if (employer is null) return;

            EmployerWindow EmployerWindow = new EmployerWindow(new Employer
            {
                Id = employer.Id,
                FirstName = employer.FirstName,
                SecondName = employer.SecondName,
                ThirdName = employer.ThirdName,
                Phone = employer.Phone,
                Birthday = employer.Birthday,
                Departament = employer.Departament
            });

            if (EmployerWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                employer = db.Employers.Find(EmployerWindow.Employer.Id);
                if (employer != null)
                {
                    employer.Id = EmployerWindow.Employer.Id;
                    employer.FirstName = EmployerWindow.Employer.FirstName;
                    employer.SecondName = EmployerWindow.Employer.SecondName;
                    employer.ThirdName = EmployerWindow.Employer.ThirdName;
                    employer.Phone = EmployerWindow.Employer.Phone;
                    employer.Birthday = EmployerWindow.Employer.Birthday;
                    employer.Departament = EmployerWindow.Employer.Departament;
                    db.SaveChanges();
                    employersList.Items.Refresh();
                }
            }
        }
        // удаление
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // получаем выделенный объект
            Employer? employer = employersList.SelectedItem as Employer;
            // если ни одного объекта не выделено, выходим
            if (employer is null) return;
            db.Employers.Remove(employer);
            db.SaveChanges();
        }

        private void SaveAs_Click(object sender, RoutedEventArgs e)
        {

            string fileName = "Employer.json";
            string jsonString = JsonSerializer.Serialize(db.Employers);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));

        }
    }
}
