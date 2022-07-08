namespace TestApp
{
    partial class PersonDataForm
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
            this.NameText = new System.Windows.Forms.TextBox();
            this.InnLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.LabelInn = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.InnText = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.Birth = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BirthText = new System.Windows.Forms.TextBox();
            this.AddButton1 = new System.Windows.Forms.Button();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(164)))), ((int)(((byte)(148)))));
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(186, 30);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(203, 26);
            this.NameText.TabIndex = 1;
            // 
            // InnLabel
            // 
            this.InnLabel.AutoSize = true;
            this.InnLabel.BackColor = System.Drawing.Color.Transparent;
            this.InnLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InnLabel.Location = new System.Drawing.Point(51, -2);
            this.InnLabel.Name = "InnLabel";
            this.InnLabel.Size = new System.Drawing.Size(50, 24);
            this.InnLabel.TabIndex = 1;
            this.InnLabel.Text = "Имя";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.InnLabel);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 26);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SurnameLabel);
            this.panel2.Location = new System.Drawing.Point(12, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 26);
            this.panel2.TabIndex = 3;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.SurnameLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(34, -3);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(96, 24);
            this.SurnameLabel.TabIndex = 5;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // SurnameText
            // 
            this.SurnameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(164)))), ((int)(((byte)(148)))));
            this.SurnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameText.Location = new System.Drawing.Point(186, 69);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(203, 26);
            this.SurnameText.TabIndex = 2;
            // 
            // LabelInn
            // 
            this.LabelInn.AutoSize = true;
            this.LabelInn.BackColor = System.Drawing.Color.Transparent;
            this.LabelInn.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInn.Location = new System.Drawing.Point(49, -2);
            this.LabelInn.Name = "LabelInn";
            this.LabelInn.Size = new System.Drawing.Size(55, 24);
            this.LabelInn.TabIndex = 5;
            this.LabelInn.Text = "ИНН";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LabelInn);
            this.panel3.Location = new System.Drawing.Point(12, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 26);
            this.panel3.TabIndex = 5;
            // 
            // InnText
            // 
            this.InnText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(164)))), ((int)(((byte)(148)))));
            this.InnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InnText.Location = new System.Drawing.Point(186, 107);
            this.InnText.Name = "InnText";
            this.InnText.Size = new System.Drawing.Size(203, 26);
            this.InnText.TabIndex = 3;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.GenderLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderLabel.Location = new System.Drawing.Point(55, -3);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(46, 24);
            this.GenderLabel.TabIndex = 5;
            this.GenderLabel.Text = "Пол";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.GenderLabel);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(12, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 28);
            this.panel4.TabIndex = 6;
            // 
            // GenderBox
            // 
            this.GenderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(164)))), ((int)(((byte)(148)))));
            this.GenderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Муж.",
            "Жен."});
            this.GenderBox.Location = new System.Drawing.Point(186, 146);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(203, 28);
            this.GenderBox.TabIndex = 7;
            this.GenderBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Birth
            // 
            this.Birth.AutoSize = true;
            this.Birth.BackColor = System.Drawing.Color.Transparent;
            this.Birth.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birth.Location = new System.Drawing.Point(4, -2);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(154, 24);
            this.Birth.TabIndex = 5;
            this.Birth.Text = "Дата рождения";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Birth);
            this.panel5.Location = new System.Drawing.Point(12, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(156, 26);
            this.panel5.TabIndex = 8;
            // 
            // BirthText
            // 
            this.BirthText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(164)))), ((int)(((byte)(148)))));
            this.BirthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthText.Location = new System.Drawing.Point(186, 188);
            this.BirthText.Name = "BirthText";
            this.BirthText.Size = new System.Drawing.Size(203, 26);
            this.BirthText.TabIndex = 9;
            // 
            // AddButton1
            // 
            this.AddButton1.BackColor = System.Drawing.Color.Teal;
            this.AddButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton1.Location = new System.Drawing.Point(12, 304);
            this.AddButton1.Name = "AddButton1";
            this.AddButton1.Size = new System.Drawing.Size(154, 32);
            this.AddButton1.TabIndex = 12;
            this.AddButton1.Text = "Добавить";
            this.AddButton1.UseVisualStyleBackColor = false;
            this.AddButton1.Click += new System.EventHandler(this.AddButton1_Click);
            // 
            // PhoneText
            // 
            this.PhoneText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(164)))), ((int)(((byte)(148)))));
            this.PhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneText.Location = new System.Drawing.Point(186, 223);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(203, 26);
            this.PhoneText.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Телефон";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(12, 223);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(156, 26);
            this.panel7.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Teal;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(12, 258);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(156, 26);
            this.panel8.TabIndex = 15;
            // 
            // EmailText
            // 
            this.EmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(164)))), ((int)(((byte)(148)))));
            this.EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailText.Location = new System.Drawing.Point(186, 258);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(203, 26);
            this.EmailText.TabIndex = 16;
            // 
            // PersonDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(407, 348);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.AddButton1);
            this.Controls.Add(this.BirthText);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.InnText);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SurnameText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.panel1);
            this.Name = "PersonDataForm";
            this.Text = "PersonDataForm";
            this.Load += new System.EventHandler(this.PersonDataForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox NameText;
        public System.Windows.Forms.Label InnLabel;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label SurnameLabel;
        public System.Windows.Forms.TextBox SurnameText;
        public System.Windows.Forms.Label LabelInn;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox InnText;
        public System.Windows.Forms.Label GenderLabel;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.ComboBox GenderBox;
        public System.Windows.Forms.Label Birth;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox BirthText;
        public System.Windows.Forms.Button AddButton1;
        public System.Windows.Forms.TextBox PhoneText;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox EmailText;
    }
}