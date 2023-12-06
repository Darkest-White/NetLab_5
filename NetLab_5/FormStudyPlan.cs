using System;
using System.Windows.Forms;
using ClassLibraryFacultatives;

namespace NetLab_5
{
    public partial class FormStudyPlan : Form
    {
        public StudyPlan StudyPlan { get; }
        public FormStudyPlan(StudyPlan studyPlan)
        {
            InitializeComponent();
            StudyPlan = studyPlan;
            foreach (var item in Facultatives.Students)
            {
                var student = item.Value;
                comboBoxStudent.Items.Add(student);
            }
            foreach (var item in Facultatives.Subjects)
            {
                var subject = item.Value;
                comboBoxSubject.Items.Add(subject);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StudyPlan.Student = comboBoxStudent.SelectedItem as Student;
            StudyPlan.Subject = comboBoxSubject.SelectedItem as Subject;
        }
    }
}
