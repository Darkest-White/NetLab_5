namespace NetLab_5
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studyPlansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudyPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudyPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.columnHeaderStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.listViewSubjects = new System.Windows.Forms.ListView();
            this.columnHeaderSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageSettlements = new System.Windows.Forms.TabPage();
            this.listViewStudyPlans = new System.Windows.Forms.ListView();
            this.columnHeaderStudentFio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSubjectsNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLectures = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPractices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLaboratoryWorks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageClients.SuspendLayout();
            this.tabPageRooms.SuspendLayout();
            this.tabPageSettlements.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.subjectsToolStripMenuItem,
            this.studyPlansToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(542, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.editStudentoolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.studentsToolStripMenuItem.Text = "Студенты";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addStudentToolStripMenuItem.Text = "Добавить";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // editStudentoolStripMenuItem
            // 
            this.editStudentoolStripMenuItem.Name = "editStudentoolStripMenuItem";
            this.editStudentoolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editStudentoolStripMenuItem.Text = "Редактировать";
            this.editStudentoolStripMenuItem.Click += new System.EventHandler(this.editStudentToolStripMenuItem_Click);
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSubjectToolStripMenuItem,
            this.editSubjectToolStripMenuItem});
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.subjectsToolStripMenuItem.Text = "Предметы";
            // 
            // addSubjectToolStripMenuItem
            // 
            this.addSubjectToolStripMenuItem.Name = "addSubjectToolStripMenuItem";
            this.addSubjectToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addSubjectToolStripMenuItem.Text = "Добавить";
            this.addSubjectToolStripMenuItem.Click += new System.EventHandler(this.addSubjectToolStripMenuItem_Click);
            // 
            // editSubjectToolStripMenuItem
            // 
            this.editSubjectToolStripMenuItem.Name = "editSubjectToolStripMenuItem";
            this.editSubjectToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editSubjectToolStripMenuItem.Text = "Редактировать";
            this.editSubjectToolStripMenuItem.Click += new System.EventHandler(this.editSubjectToolStripMenuItem_Click);
            // 
            // studyPlansToolStripMenuItem
            // 
            this.studyPlansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudyPlanToolStripMenuItem,
            this.editStudyPlanToolStripMenuItem});
            this.studyPlansToolStripMenuItem.Name = "studyPlansToolStripMenuItem";
            this.studyPlansToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.studyPlansToolStripMenuItem.Text = "Учебные планы";
            // 
            // addStudyPlanToolStripMenuItem
            // 
            this.addStudyPlanToolStripMenuItem.Name = "addStudyPlanToolStripMenuItem";
            this.addStudyPlanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addStudyPlanToolStripMenuItem.Text = "Добавить";
            this.addStudyPlanToolStripMenuItem.Click += new System.EventHandler(this.addStudyPlanToolStripMenuItem_Click);
            // 
            // editStudyPlanToolStripMenuItem
            // 
            this.editStudyPlanToolStripMenuItem.Name = "editStudyPlanToolStripMenuItem";
            this.editStudyPlanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editStudyPlanToolStripMenuItem.Text = "Редактировать";
            this.editStudyPlanToolStripMenuItem.Click += new System.EventHandler(this.editStudyPlanToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageClients);
            this.tabControlMain.Controls.Add(this.tabPageRooms);
            this.tabControlMain.Controls.Add(this.tabPageSettlements);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(542, 243);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.listViewStudents);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(534, 217);
            this.tabPageClients.TabIndex = 0;
            this.tabPageClients.Text = "Студенты";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStudent});
            this.listViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStudents.FullRowSelect = true;
            this.listViewStudents.GridLines = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(3, 3);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(528, 211);
            this.listViewStudents.TabIndex = 1;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStudent
            // 
            this.columnHeaderStudent.Text = "ФИО студента";
            this.columnHeaderStudent.Width = 456;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Controls.Add(this.listViewSubjects);
            this.tabPageRooms.Location = new System.Drawing.Point(4, 22);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRooms.Size = new System.Drawing.Size(534, 217);
            this.tabPageRooms.TabIndex = 1;
            this.tabPageRooms.Text = "Предметы";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            // 
            // listViewSubjects
            // 
            this.listViewSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSubject});
            this.listViewSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSubjects.FullRowSelect = true;
            this.listViewSubjects.GridLines = true;
            this.listViewSubjects.HideSelection = false;
            this.listViewSubjects.Location = new System.Drawing.Point(3, 3);
            this.listViewSubjects.Name = "listViewSubjects";
            this.listViewSubjects.Size = new System.Drawing.Size(528, 211);
            this.listViewSubjects.TabIndex = 2;
            this.listViewSubjects.UseCompatibleStateImageBehavior = false;
            this.listViewSubjects.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSubject
            // 
            this.columnHeaderSubject.Text = "Название предмета";
            this.columnHeaderSubject.Width = 456;
            // 
            // tabPageSettlements
            // 
            this.tabPageSettlements.Controls.Add(this.listViewStudyPlans);
            this.tabPageSettlements.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettlements.Name = "tabPageStudyPlans";
            this.tabPageSettlements.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettlements.Size = new System.Drawing.Size(534, 217);
            this.tabPageSettlements.TabIndex = 2;
            this.tabPageSettlements.Text = "Учебный план";
            this.tabPageSettlements.UseVisualStyleBackColor = true;
            // 
            // listViewStudyPlans
            // 
            this.listViewStudyPlans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStudentFio,
            this.columnHeaderSubjectsNumber,
            this.columnHeaderLectures,
            this.columnHeaderPractices,
            this.columnHeaderLaboratoryWorks});
            this.listViewStudyPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStudyPlans.FullRowSelect = true;
            this.listViewStudyPlans.GridLines = true;
            this.listViewStudyPlans.HideSelection = false;
            this.listViewStudyPlans.Location = new System.Drawing.Point(3, 3);
            this.listViewStudyPlans.Name = "listViewStudyPlans";
            this.listViewStudyPlans.Size = new System.Drawing.Size(528, 211);
            this.listViewStudyPlans.TabIndex = 2;
            this.listViewStudyPlans.UseCompatibleStateImageBehavior = false;
            this.listViewStudyPlans.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStudentFio
            // 
            this.columnHeaderStudentFio.Text = "ФИО студента";
            this.columnHeaderStudentFio.Width = 216;
            // 
            // columnHeaderSubjectsNumber
            // 
            this.columnHeaderSubjectsNumber.Text = "Предмет";
            this.columnHeaderSubjectsNumber.Width = 81;
            // 
            // columnHeaderLectures
            // 
            this.columnHeaderLectures.Text = "Лекции";
            this.columnHeaderLectures.Width = 62;
            // 
            // columnHeaderPractices
            // 
            this.columnHeaderPractices.Text = "Практики";
            this.columnHeaderPractices.Width = 69;
            // 
            // columnHeaderLaboratoryWorks
            // 
            this.columnHeaderLaboratoryWorks.Text = "Лабораторные";
            this.columnHeaderLaboratoryWorks.Width = 124;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 267);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Факультативы";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageClients.ResumeLayout(false);
            this.tabPageRooms.ResumeLayout(false);
            this.tabPageSettlements.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studyPlansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudyPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudyPlanToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.TabPage tabPageSettlements;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader columnHeaderStudent;
        private System.Windows.Forms.ListView listViewSubjects;
        private System.Windows.Forms.ColumnHeader columnHeaderSubject;
        private System.Windows.Forms.ListView listViewStudyPlans;
        private System.Windows.Forms.ColumnHeader columnHeaderStudentFio;
        private System.Windows.Forms.ColumnHeader columnHeaderSubjectsNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderLectures;
        private System.Windows.Forms.ColumnHeader columnHeaderPractices;
        private System.Windows.Forms.ColumnHeader columnHeaderLaboratoryWorks;
    }
}

