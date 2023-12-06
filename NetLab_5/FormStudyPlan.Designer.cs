namespace NetLab_5
{
    partial class FormStudyPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStudent = new System.Windows.Forms.Label();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(12, 15);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(50, 13);
            this.labelStudent.TabIndex = 0;
            this.labelStudent.Text = "Студент:";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(105, 12);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(282, 21);
            this.comboBoxStudent.TabIndex = 1;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(105, 39);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(282, 21);
            this.comboBoxSubject.TabIndex = 2;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(14, 42);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(55, 13);
            this.labelSubject.TabIndex = 3;
            this.labelSubject.Text = "Предмет:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.Location = new System.Drawing.Point(260, 72);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(100, 23);
            this.labelEndDate.TabIndex = 13;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(312, 82);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormStudyPlan
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 117);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.labelStudent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudyPlan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Учебный план";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Button buttonSave;
    }
}