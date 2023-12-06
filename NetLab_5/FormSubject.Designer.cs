namespace NetLab_5
{
    partial class FormSubject
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLectures = new System.Windows.Forms.Label();
            this.numericUpDownPractices = new System.Windows.Forms.NumericUpDown();
            this.labelPractices = new System.Windows.Forms.Label();
            this.numericUpDownLaboratorys = new System.Windows.Forms.NumericUpDown();
            this.labelLaboratorys = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.numericUpDownLectures = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPractices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLaboratorys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLectures)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(147, 137);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 28);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(93, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Идентификатор: ";
            // 
            // labelLectures
            // 
            this.labelLectures.AutoSize = true;
            this.labelLectures.Location = new System.Drawing.Point(12, 43);
            this.labelLectures.Name = "labelLectures";
            this.labelLectures.Size = new System.Drawing.Size(48, 13);
            this.labelLectures.TabIndex = 3;
            this.labelLectures.Text = "Лекции:";
            // 
            // numericUpDownPractices
            // 
            this.numericUpDownPractices.Location = new System.Drawing.Point(126, 67);
            this.numericUpDownPractices.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownPractices.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPractices.Name = "numericUpDownPractices";
            this.numericUpDownPractices.Size = new System.Drawing.Size(106, 20);
            this.numericUpDownPractices.TabIndex = 6;
            this.numericUpDownPractices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPractices.ThousandsSeparator = true;
            this.numericUpDownPractices.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPractices
            // 
            this.labelPractices.AutoSize = true;
            this.labelPractices.Location = new System.Drawing.Point(12, 69);
            this.labelPractices.Name = "labelPractices";
            this.labelPractices.Size = new System.Drawing.Size(62, 13);
            this.labelPractices.TabIndex = 5;
            this.labelPractices.Text = "Практики: ";
            // 
            // numericUpDownLaboratorys
            // 
            this.numericUpDownLaboratorys.Location = new System.Drawing.Point(126, 93);
            this.numericUpDownLaboratorys.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownLaboratorys.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLaboratorys.Name = "numericUpDownLaboratorys";
            this.numericUpDownLaboratorys.Size = new System.Drawing.Size(106, 20);
            this.numericUpDownLaboratorys.TabIndex = 8;
            this.numericUpDownLaboratorys.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownLaboratorys.ThousandsSeparator = true;
            this.numericUpDownLaboratorys.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelLaboratorys
            // 
            this.labelLaboratorys.AutoSize = true;
            this.labelLaboratorys.Location = new System.Drawing.Point(12, 95);
            this.labelLaboratorys.Name = "labelLaboratorys";
            this.labelLaboratorys.Size = new System.Drawing.Size(85, 13);
            this.labelLaboratorys.TabIndex = 7;
            this.labelLaboratorys.Text = "Лабораторные:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(126, 16);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(106, 20);
            this.textBoxTitle.TabIndex = 9;
            // 
            // numericUpDownLectures
            // 
            this.numericUpDownLectures.Location = new System.Drawing.Point(126, 42);
            this.numericUpDownLectures.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLectures.Name = "numericUpDownLectures";
            this.numericUpDownLectures.Size = new System.Drawing.Size(106, 20);
            this.numericUpDownLectures.TabIndex = 10;
            this.numericUpDownLectures.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownLectures.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormSubject
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 177);
            this.Controls.Add(this.numericUpDownLectures);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.numericUpDownLaboratorys);
            this.Controls.Add(this.labelLaboratorys);
            this.Controls.Add(this.numericUpDownPractices);
            this.Controls.Add(this.labelPractices);
            this.Controls.Add(this.labelLectures);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSubject";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Предмет";
            this.Controls.SetChildIndex(this.buttonSave, 0);
            this.Controls.SetChildIndex(this.labelTitle, 0);
            this.Controls.SetChildIndex(this.labelLectures, 0);
            this.Controls.SetChildIndex(this.labelPractices, 0);
            this.Controls.SetChildIndex(this.numericUpDownPractices, 0);
            this.Controls.SetChildIndex(this.labelLaboratorys, 0);
            this.Controls.SetChildIndex(this.numericUpDownLaboratorys, 0);
            this.Controls.SetChildIndex(this.textBoxTitle, 0);
            this.Controls.SetChildIndex(this.numericUpDownLectures, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPractices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLaboratorys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLectures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLectures;
        private System.Windows.Forms.NumericUpDown numericUpDownPractices;
        private System.Windows.Forms.Label labelPractices;
        private System.Windows.Forms.NumericUpDown numericUpDownLaboratorys;
        private System.Windows.Forms.Label labelLaboratorys;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownLectures;
    }
}