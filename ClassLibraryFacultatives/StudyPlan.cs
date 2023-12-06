using ClassLibraryFacultatives;
using System;

namespace ClassLibraryFacultatives
{
    /// <summary>
    /// Учебный план
    /// </summary>
    public class StudyPlan : IValidatable
    {
        /// <summary>
        /// Студент
        /// </summary>
        public Student Student { get; set; }
        /// <summary>
        /// Предмет
        /// </summary>
        public Subject Subject { get; set; }

        public bool IsValid
        {
            get
            {
                if (Student == null) return false;
                if (Subject == null) return false;
                return true;
            }
        }

        public StudyPlan()
        {

        }

        public StudyPlan(Student student, Subject subject)
        {
            Student = student;
            Subject = subject;
        }

        public override string ToString()
        {
            return $"Студент - {Student}\r\nПредмет - {Subject}\r\n";
        }
    }
}
