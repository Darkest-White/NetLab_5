using System.Collections.Generic;

namespace ClassLibraryFacultatives
{
    /// <summary>
    /// Факультативы
    /// </summary>
    public class Facultatives
    {
        /// <summary>
        /// Словарь студентов
        /// </summary>
        public static Dictionary<int, Student> Students { get; } = new Dictionary<int, Student>();
        /// <summary>
        /// Словарь предметов
        /// </summary>
        public static Dictionary<int, Subject> Subjects { get; } = new Dictionary<int, Subject>();
        /// <summary>
        /// Спосок учебных планов
        /// </summary>
        public static List<StudyPlan> StudyPlans { get; } = new List<StudyPlan>();
    }
}
