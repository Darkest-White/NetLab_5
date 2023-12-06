namespace ClassLibraryFacultatives
{
    /// <summary>
    /// Студент
    /// </summary>
    public class Student : IValidatable
    {
        private static int _newStudentId;

        private static int NewStudentId
        {
            get
            {
                _newStudentId++;
                return _newStudentId;
            }
        }
        /// <summary>
        /// Уникальный идентификатор студента
        /// </summary>
        public int StudentId { get; }
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; } = "";

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; } = "";
        /// <summary>
        /// Паспортные данные
        /// </summary>
        public AdressInfo Adress { get; set; } = new AdressInfo();

        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName)) return false;
                if (string.IsNullOrWhiteSpace(MiddleName)) return false;
                if (string.IsNullOrWhiteSpace(LastName)) return false;
                if (Adress == null) return false;
                return true;
            }
        }

        public Student()
        {
            StudentId = NewStudentId;
        }

        public Student(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            StudentId = NewStudentId;
        }

        public override string ToString()
        {
            return $"Фамилия: {LastName}\r\nИмя: {FirstName}\r\nОтчество: {MiddleName}\r\nАдрес: {Adress}\r\n";
        }
    }
}
