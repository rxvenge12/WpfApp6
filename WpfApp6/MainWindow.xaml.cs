using System; // Подключение пространства имен System, которое содержит базовые типы данных и функциональность .NET Framework.
using System.Windows; // Подключение пространства имен System.Windows, которое содержит классы для создания приложений Windows.

namespace WpfApp6 // Определение пространства имен WpfApp6, где содержится класс MainWindow.
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window // Определение класса MainWindow, который наследуется от класса Window.
    {
        public MainWindow() // Конструктор класса MainWindow.
        {
            InitializeComponent(); // Инициализация компонентов окна.
        }

        private void btnSave_Click(object sender, RoutedEventArgs e) // Обработчик события нажатия кнопки "Сохранить".
        {
            // Создаем объект адреса
            Address address = new Address // Создание нового объекта класса Address и инициализация его свойств.
            {
                City = txtCity.Text, // Присваивание свойству City значение из текстового поля txtCity.
                ZipCode = txtZipCode.Text, // Присваивание свойству ZipCode значение из текстового поля txtZipCode.
                Street = txtStreet.Text, // Присваивание свойству Street значение из текстового поля txtStreet.
                HouseNumber = txtHouseNumber.Text, // Присваивание свойству HouseNumber значение из текстового поля txtHouseNumber.
                ApartmentNumber = txtApartmentNumber.Text // Присваивание свойству ApartmentNumber значение из текстового поля txtApartmentNumber.
            };

            // Создаем объект студента
            Student student = new Student // Создание нового объекта класса Student и инициализация его свойств.
            {
                FullName = txtFullName.Text, // Присваивание свойству FullName значение из текстового поля txtFullName.
                Age = int.Parse(txtAge.Text), // Присваивание свойству Age значение, преобразованное из строки в целое число из текстового поля txtAge.
                Specialty = txtSpecialty.Text, // Присваивание свойству Specialty значение из текстового поля txtSpecialty.
                DateOfBirth = datePickerDOB.SelectedDate ?? DateTime.MinValue, // Присваивание свойству DateOfBirth значение из выбранной даты в datePickerDOB.
                Course = int.Parse(txtCourse.Text), // Присваивание свойству Course значение, преобразованное из строки в целое число из текстового поля txtCourse.
                Group = txtGroup.Text, // Присваивание свойству Group значение из текстового поля txtGroup.
                AverageScore = double.Parse(txtAverageScore.Text), // Присваивание свойству AverageScore значение, преобразованное из строки в число с плавающей запятой из текстового поля txtAverageScore.
                Gender = cmbGender.SelectedItem.ToString(), // Присваивание свойству Gender значение из выбранного элемента в cmbGender, преобразованное в строку.
                Address = address // Присваивание свойству Address значение объекта address, созданного выше.
            };

            // Здесь можно выполнить дополнительные действия, например, сохранить студента в базу данных или отобразить информацию о нем

            MessageBox.Show("Студент сохранен успешно!"); // Вывод сообщения об успешном сохранении студента.
        }
    }

    // Класс для адреса
    public class Address // Определение класса Address для хранения данных об адресе студента.
    {
        public string City { get; set; } // Свойство для хранения названия города.
        public string ZipCode { get; set; } // Свойство для хранения почтового индекса.
        public string Street { get; set; } // Свойство для хранения названия улицы.
        public string HouseNumber { get; set; } // Свойство для хранения номера дома.
        public string ApartmentNumber { get; set; } // Свойство для хранения номера квартиры.
    }

    // Класс для студента
    public class Student // Определение класса Student для хранения данных о студенте.
    {
        public string FullName { get; set; } // Свойство для хранения ФИО студента.
        public int Age { get; set; } // Свойство для хранения возраста студента.
        public string Specialty { get; set; } // Свойство для хранения специальности студента.
        public DateTime DateOfBirth { get; set; } // Свойство для хранения даты рождения студента.
        public int Course { get; set; } // Свойство для хранения курса студента.
        public string Group { get; set; } // Свойство для хранения группы студента.
        public double AverageScore { get; set; } // Свойство для хранения среднего балла студента.
        public string Gender { get; set; } // Свойство для хранения пола студента.
        public Address Address { get; set; } // Свойство для хранения адреса студента.
    }
}
