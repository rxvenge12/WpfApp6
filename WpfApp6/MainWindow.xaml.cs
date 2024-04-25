using System;
using System.Windows;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Создаем объект адреса
            Address address = new Address
            {
                City = txtCity.Text,
                ZipCode = txtZipCode.Text,
                Street = txtStreet.Text,
                HouseNumber = txtHouseNumber.Text,
                ApartmentNumber = txtApartmentNumber.Text
            };

            // Создаем объект студента
            Student student = new Student
            {
                FullName = txtFullName.Text,
                Age = int.Parse(txtAge.Text),
                Specialty = txtSpecialty.Text,
                DateOfBirth = datePickerDOB.SelectedDate ?? DateTime.MinValue,
                Course = int.Parse(txtCourse.Text),
                Group = txtGroup.Text,
                AverageScore = double.Parse(txtAverageScore.Text),
                Gender = cmbGender.SelectedItem.ToString(),
                Address = address
            };

            // Здесь можно выполнить дополнительные действия, например, сохранить студента в базу данных или отобразить информацию о нем

            MessageBox.Show("Студент сохранен успешно!");
        }
    }

    // Класс для адреса
    public class Address
    {
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
    }

    // Класс для студента
    public class Student
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Specialty { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }
        public double AverageScore { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }
    }
}
