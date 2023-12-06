using System;
using System.Windows.Forms;
using ClassLibraryFacultatives;

namespace NetLab_5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var student = new Student();
            FormStudent formStudent = new FormStudent(student);
            if (formStudent.ShowDialog() == DialogResult.OK)
            {
                Facultatives.Students.Add(student.StudentId, student);
                UpdateStudentsList();
            }
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var student = listViewStudents.SelectedItems[0].Tag as Student;
            FormStudent formStudent = new FormStudent(student);
            if (formStudent.ShowDialog() == DialogResult.OK)
            {
                UpdateStudentsList();
            }
        }

        private void UpdateStudentsList()
        {
            listViewStudents.Items.Clear();
            foreach (var item in Facultatives.Students)
            {
                var student = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = student,
                    Text = student.ToString()
                };
                listViewStudents.Items.Add(listViewItem);
            }
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var subject = new Subject();
            FormSubject formSubject = new FormSubject(subject);
            if (formSubject.ShowDialog() == DialogResult.OK)
            {
                Facultatives.Subjects.Add(subject.SubjectId, subject);
                UpdateSubjectsList();
            }
        }

        private void editSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var subject = listViewSubjects.SelectedItems[0].Tag as Subject;
            FormSubject formSubject = new FormSubject(subject);
            if (formSubject.ShowDialog() == DialogResult.OK)
            {
                UpdateSubjectsList();
            }
        }

        private void UpdateSubjectsList()
        {
            listViewSubjects.Items.Clear();
            foreach (var item in Facultatives.Subjects)
            {
                var subject = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = subject,
                    Text = subject.ToString()
                };
                listViewSubjects.Items.Add(listViewItem);
            }
        }

        private void addStudyPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studyPlan = new StudyPlan();
            FormStudyPlan formStudyPlan = new FormStudyPlan(studyPlan);
            if (formStudyPlan.ShowDialog() == DialogResult.OK)
            {
                Facultatives.StudyPlans.Add(studyPlan);
                UpdateStudyPlanList();
            }
        }

        private void editStudyPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studyPlan = listViewStudyPlans.SelectedItems[0].Tag as StudyPlan;
            FormStudyPlan formStudyPlan = new FormStudyPlan(studyPlan);
            if (formStudyPlan.ShowDialog() == DialogResult.OK)
            {
                UpdateStudyPlanList();
            }
        }

        private void UpdateStudyPlanList()
        {
            listViewStudyPlans.Items.Clear();
            foreach (var studyPlan in Facultatives.StudyPlans)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = studyPlan,
                    Text = studyPlan.Student.ToString()
                };
                listViewItem.SubItems.Add(studyPlan.Subject.Title.ToString());
                listViewItem.SubItems.Add(studyPlan.Subject.Lectures.ToString());
                listViewItem.SubItems.Add(studyPlan.Subject.Practices.ToString());
                listViewItem.SubItems.Add(studyPlan.Subject.LaboratoryWorks.ToString());
                //listViewItem.SubItems.Add(studyPlan.StartDate.ToShortDateString());
                //listViewItem.SubItems.Add(studyPlan.EndDate.ToShortDateString());
                listViewStudyPlans.Items.Add(listViewItem);
            }
        }
    }
}