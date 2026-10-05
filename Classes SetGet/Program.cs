using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Classes_SetGet
{
    //1
    class Student
    {
        private string address;
        private string phone;
        private string email;
        private int course;
        private string group;
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public string Patronymic { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string RecordBook { get; private set; }

        public string Address
        {
            get { return address; }
            set { address = Check(value, @"^[^,]+,[^,]+,[^,]+$", "Адрес должен быть в формате: город, улица, № дома"); }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = Check(value, @"^\+?\d{10,12}$", "Телефон должен содержать от 10 до 12 цифр"); }
        }

        public string Email
        {
            get { return email; }
            set { email = Check(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", "Неверный формат электронного адреса"); }
        }

        public int Course
        {
            get { return course; }
            set
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentException("Курс должен быть числом от 1 до 6");
                }
                course = value;
            }
        }

        public string Group
        {
            get { return group; }
            set { group = Check(value, @"^[А-ЯЁа-яё]{2}-\d{2}$", "Группа должна быть в формате БукваБуква-ЦифраЦифра (кириллица)"); }
        }

        public Student()
        {
            Surname = "Неизвестно";
            Name = "Неизвестно";
            Patronymic = "";
            BirthDate = new DateTime(2000, 1, 1);
            RecordBook = "№0000";
            address = "не указан";
            phone = "не указан";
            email = "не указан";
            course = 1;
            group = "АА-00";
        }

        public Student(string surname, string name, string birthDate, string recordBook) : this()
        {
            Surname = Check(surname, @"^[А-ЯЁа-яёA-Za-z\-]+$", "Неверная фамилия");
            Name = Check(name, @"^[А-ЯЁа-яёA-Za-z\-]+$", "Неверное имя");
            BirthDate = ParseDate(birthDate);
            RecordBook = Check(recordBook, @"^№\d{4}$", "Номер зачетной книжки должен быть в формате №0000");
        }

        public Student(string surname, string name, string birthDate, string address, string phone,
            string email, int course, string group, string recordBook)
            : this(surname, name, "", birthDate, address, phone, email, course, group, recordBook)
        {
        }

        public Student(string surname, string name, string patronymic, string birthDate, string address,
            string phone, string email, int course, string group, string recordBook)
            : this(surname, name, birthDate, recordBook)
        {
            if (!string.IsNullOrWhiteSpace(patronymic))
            {
                Patronymic = Check(patronymic, @"^[А-ЯЁа-яёA-Za-z\-]+$", "Неверное отчество");
            }
            Address = address;
            Phone = phone;
            Email = email;
            Course = course;
            Group = group;
        }

        private static string Check(string value, string pattern, string message)
        {
            if (value == null || !Regex.IsMatch(value.Trim(), pattern))
            {
                throw new ArgumentException(message);
            }
            return value.Trim();
        }

        private static DateTime ParseDate(string value)
        {
            DateTime date;
            if (!DateTime.TryParseExact(value, "dd-MM-yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date)
                || date > DateTime.Today)
            {
                throw new ArgumentException("Дата рождения должна быть в формате дд-мм-гг");
            }
            return date;
        }

        public int CompareTo(Student other, string property)
        {
            switch (property.ToLower())
            {
                case "surname":
                    return string.Compare(Surname, other.Surname, StringComparison.OrdinalIgnoreCase);
                case "name":
                    return string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
                case "patronymic":
                    return string.Compare(Patronymic, other.Patronymic, StringComparison.OrdinalIgnoreCase);
                case "birthdate":
                    return BirthDate.CompareTo(other.BirthDate);
                case "address":
                    return string.Compare(Address, other.Address, StringComparison.OrdinalIgnoreCase);
                case "phone":
                    return string.Compare(Phone, other.Phone, StringComparison.Ordinal);
                case "email":
                    return string.Compare(Email, other.Email, StringComparison.OrdinalIgnoreCase);
                case "course":
                    return Course.CompareTo(other.Course);
                case "group":
                    return string.Compare(Group, other.Group, StringComparison.OrdinalIgnoreCase);
                case "recordbook":
                    return string.Compare(RecordBook, other.RecordBook, StringComparison.Ordinal);
                default:
                    throw new ArgumentException("Неизвестное свойство: " + property);
            }
        }

        public bool EqualsBy(Student other, string property)
        {
            return CompareTo(other, property) == 0;
        }

        public override string ToString()
        {
            string fullName = (Surname + " " + Name + " " + Patronymic).Trim();
            return string.Format("{0}, дата рождения: {1:dd-MM-yy}, адрес: {2}, телефон: {3}, e-mail: {4}, курс: {5}, группа: {6}, зачетная книжка: {7}",
                fullName, BirthDate, Address, Phone, Email, Course, Group, RecordBook);
        }
    }

    //2
    class Patient
    {
        private string surname;
        private string name;
        private string patronymic;
        private string address;
        private int cardNumber;
        private string diagnosis;

        public Patient()
        {
            surname = "";
            name = "";
            patronymic = "";
            address = "";
            cardNumber = 0;
            diagnosis = "";
        }

        public Patient(string surname, string name, string patronymic, string address, int cardNumber, string diagnosis)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.address = address;
            this.cardNumber = cardNumber;
            this.diagnosis = diagnosis;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPatronymic(string patronymic)
        {
            this.patronymic = patronymic;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetCardNumber(int cardNumber)
        {
            this.cardNumber = cardNumber;
        }

        public void SetDiagnosis(string diagnosis)
        {
            this.diagnosis = diagnosis;
        }

        public string GetSurname()
        {
            return surname;
        }

        public string GetName()
        {
            return name;
        }

        public string GetPatronymic()
        {
            return patronymic;
        }

        public string GetAddress()
        {
            return address;
        }

        public int GetCardNumber()
        {
            return cardNumber;
        }

        public string GetDiagnosis()
        {
            return diagnosis;
        }

        public void Show()
        {
            Console.WriteLine("{0} {1} {2}, адрес: {3}, номер медицинской карты: {4}, диагноз: {5}",
                surname, name, patronymic, address, cardNumber, diagnosis);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Задача 1");
            Task1();
            Console.WriteLine();
            Console.WriteLine("Задача 2");
            Task2();
        }

        static void Task1()
        {
            Student first = new Student("Иванов", "Иван", "Иванович", "15-03-05", "Москва, Ленина, 10",
                "+79161234567", "ivanov@mail.ru", 2, "ИС-21", "№1234");
            Student second = new Student("Петрова", "Анна", "20-07-04", "Казань, Баумана, 5",
                "+79270001122", "petrova@mail.ru", 2, "ИС-22", "№5678");
            Student third = new Student();

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);

            Console.WriteLine("Одинаковый курс: " + first.EqualsBy(second, "Course"));
            Console.WriteLine("Одинаковая группа: " + first.EqualsBy(second, "Group"));
            Console.WriteLine("Сравнение по фамилии: " + first.CompareTo(second, "Surname"));
            Console.WriteLine("Сравнение по дате рождения: " + first.CompareTo(second, "BirthDate"));

            first.Course = 3;
            first.Group = "ИС-31";
            first.Phone = "+79169998877";
            Console.WriteLine(first);

            try
            {
                first.Group = "IS-31";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        static void Task2()
        {
            Patient[] patients =
            {
                new Patient("Сидоров", "Петр", "Игоревич", "Москва, Мира, 3", 101, "Грипп"),
                new Patient("Кузнецова", "Ольга", "Сергеевна", "Тула, Ленина, 15", 205, "Ангина"),
                new Patient("Орлов", "Андрей", "Павлович", "Омск, Кирова, 8", 150, "Грипп"),
                new Patient("Смирнова", "Мария", "Ивановна", "Казань, Победы, 21", 320, "Гастрит"),
                new Patient("Волков", "Дмитрий", "Олегович", "Пермь, Союзная, 7", 180, "Ангина"),
                new Patient("Беляева", "Елена", "Андреевна", "Сочи, Горная, 12", 99, "Грипп")
            };

            Console.WriteLine("Все пациенты:");
            foreach (Patient patient in patients)
            {
                patient.Show();
            }

            Console.Write("Введите диагноз: ");
            string diagnosis = (Console.ReadLine() ?? "").Trim();
            Console.WriteLine("Пациенты с диагнозом " + diagnosis + ":");
            bool found = false;
            foreach (Patient patient in patients)
            {
                if (string.Equals(patient.GetDiagnosis(), diagnosis, StringComparison.OrdinalIgnoreCase))
                {
                    patient.Show();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Пациентов не найдено");
            }

            int from = ReadInt("Введите начало интервала номеров медицинских карт: ");
            int to = ReadInt("Введите конец интервала номеров медицинских карт: ");
            if (from > to)
            {
                int temp = from;
                from = to;
                to = temp;
            }
            Console.WriteLine("Пациенты с номером карты от " + from + " до " + to + ":");
            found = false;
            foreach (Patient patient in patients)
            {
                if (patient.GetCardNumber() >= from && patient.GetCardNumber() <= to)
                {
                    patient.Show();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Пациентов не найдено");
            }
        }

        static int ReadInt(string message)
        {
            int value;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Введите целое число: ");
            }
            return value;
        }
    }
}
