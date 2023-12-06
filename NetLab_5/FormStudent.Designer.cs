namespace NetLab_5
{
    partial class FormStudent
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
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxFlat = new System.Windows.Forms.TextBox();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.labelHouse = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.groupBoxAdress = new System.Windows.Forms.GroupBox();
            this.labelFlat = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxAdress.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 16);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(59, 13);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Фамилия:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(79, 13);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(132, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(79, 39);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(132, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 42);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(32, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Имя:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(79, 65);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(132, 20);
            this.textBoxMiddleName.TabIndex = 5;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(12, 68);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(57, 13);
            this.labelMiddleName.TabIndex = 4;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // textBoxFlat
            // 
            this.textBoxFlat.Location = new System.Drawing.Point(92, 77);
            this.textBoxFlat.Name = "textBoxFlat";
            this.textBoxFlat.Size = new System.Drawing.Size(145, 20);
            this.textBoxFlat.TabIndex = 7;
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.AllowDrop = true;
            this.textBoxHouse.Location = new System.Drawing.Point(92, 51);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(145, 20);
            this.textBoxHouse.TabIndex = 11;
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Location = new System.Drawing.Point(6, 54);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(33, 13);
            this.labelHouse.TabIndex = 10;
            this.labelHouse.Text = "Дом:";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(92, 25);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(145, 20);
            this.textBoxStreet.TabIndex = 13;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(6, 28);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(42, 13);
            this.labelStreet.TabIndex = 12;
            this.labelStreet.Text = "Улица:";
            // 
            // groupBoxAdress
            // 
            this.groupBoxAdress.Controls.Add(this.labelStreet);
            this.groupBoxAdress.Controls.Add(this.textBoxStreet);
            this.groupBoxAdress.Controls.Add(this.textBoxFlat);
            this.groupBoxAdress.Controls.Add(this.textBoxHouse);
            this.groupBoxAdress.Controls.Add(this.labelFlat);
            this.groupBoxAdress.Controls.Add(this.labelHouse);
            this.groupBoxAdress.Location = new System.Drawing.Point(217, 12);
            this.groupBoxAdress.Name = "groupBoxAdress";
            this.groupBoxAdress.Size = new System.Drawing.Size(243, 135);
            this.groupBoxAdress.TabIndex = 14;
            this.groupBoxAdress.TabStop = false;
            this.groupBoxAdress.Text = "Адрес";
            // 
            // labelFlat
            // 
            this.labelFlat.AutoSize = true;
            this.labelFlat.Location = new System.Drawing.Point(6, 80);
            this.labelFlat.Name = "labelFlat";
            this.labelFlat.Size = new System.Drawing.Size(58, 13);
            this.labelFlat.TabIndex = 8;
            this.labelFlat.Text = "Квартира:";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(361, 153);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 30);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormStudent
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 195);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxAdress);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Студент";
            this.Controls.SetChildIndex(this.labelLastName, 0);
            this.Controls.SetChildIndex(this.textBoxLastName, 0);
            this.Controls.SetChildIndex(this.labelFirstName, 0);
            this.Controls.SetChildIndex(this.textBoxFirstName, 0);
            this.Controls.SetChildIndex(this.labelMiddleName, 0);
            this.Controls.SetChildIndex(this.textBoxMiddleName, 0);
            this.Controls.SetChildIndex(this.groupBoxAdress, 0);
            this.Controls.SetChildIndex(this.buttonSave, 0);
            this.groupBoxAdress.ResumeLayout(false);
            this.groupBoxAdress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxFlat;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.GroupBox groupBoxAdress;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelFlat;
    }
}