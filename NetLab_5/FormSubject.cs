using System;
using ClassLibraryFacultatives;
using System.Windows.Forms;

namespace NetLab_5
{
    public partial class FormSubject : Form
    {
        public Subject Subject { get; }
        public FormSubject(Subject subject)
        {
            InitializeComponent();
            Subject = subject;
            textBoxTitle.Text = subject.Title;
            numericUpDownLectures.Value = Subject.Lectures;
            numericUpDownPractices.Value = Subject.Practices;
            numericUpDownLaboratorys.Value = Subject.LaboratoryWorks;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Subject.Title = textBoxTitle.Text;
            Subject.Lectures = (int)numericUpDownLectures.Value;
            Subject.Practices = (int)numericUpDownPractices.Value;
            Subject.LaboratoryWorks = (int)numericUpDownLaboratorys.Value;
        }
    }
}