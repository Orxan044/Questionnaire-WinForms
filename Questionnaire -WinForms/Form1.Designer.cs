namespace Questionnaire__WinForms
{
    partial class Questionnaire
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtBoxName = new TextBox();
            txtBoxSurname = new TextBox();
            label3 = new Label();
            txtBoxEmail = new TextBox();
            label4 = new Label();
            txtBoxPhone = new TextBox();
            label5 = new Label();
            dateTimeBrithday = new DateTimePicker();
            listBoxUsers = new ListBox();
            btnSaveAndUpdate = new Button();
            txtBoxFileName = new TextBox();
            btnLoad = new Button();
            btnSave = new Button();
            btnClearListBox = new Button();
            btnCleartxtBoxes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(104, 31);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxName.Location = new Point(130, 15);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(271, 31);
            txtBoxName.TabIndex = 0;
            txtBoxName.TextChanged += txtBoxName_TextChanged;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxSurname.Location = new Point(130, 68);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(271, 31);
            txtBoxSurname.TabIndex = 1;
            txtBoxSurname.TextChanged += txtBoxSurname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(17, 130);
            label3.Name = "label3";
            label3.Size = new Size(80, 31);
            label3.TabIndex = 4;
            label3.Text = "E-Mail";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxEmail.Location = new Point(130, 130);
            txtBoxEmail.Multiline = true;
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(271, 27);
            txtBoxEmail.TabIndex = 2;
            txtBoxEmail.TextChanged += txtBoxEmail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(19, 195);
            label4.Name = "label4";
            label4.Size = new Size(78, 31);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxPhone.Location = new Point(130, 195);
            txtBoxPhone.Multiline = true;
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Size = new Size(271, 27);
            txtBoxPhone.TabIndex = 3;
            txtBoxPhone.TextChanged += txtBoxPhone_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(19, 254);
            label5.Name = "label5";
            label5.Size = new Size(99, 31);
            label5.TabIndex = 8;
            label5.Text = "Brithday";
            // 
            // dateTimeBrithday
            // 
            dateTimeBrithday.Location = new Point(130, 256);
            dateTimeBrithday.MaxDate = new DateTime(2024, 3, 25, 23, 59, 59, 0);
            dateTimeBrithday.Name = "dateTimeBrithday";
            dateTimeBrithday.Size = new Size(271, 27);
            dateTimeBrithday.TabIndex = 4;
            dateTimeBrithday.Value = new DateTime(2024, 3, 25, 23, 59, 59, 0);
            // 
            // listBoxUsers
            // 
            listBoxUsers.Font = new Font("Zilla Slab SemiBold", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 32;
            listBoxUsers.Location = new Point(529, 15);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(254, 260);
            listBoxUsers.TabIndex = 9;
            listBoxUsers.SelectedIndexChanged += listBoxUsers_SelectedIndexChanged;
            // 
            // btnSaveAndUpdate
            // 
            btnSaveAndUpdate.BackColor = Color.Lime;
            btnSaveAndUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveAndUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnSaveAndUpdate.Location = new Point(255, 297);
            btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            btnSaveAndUpdate.Size = new Size(146, 56);
            btnSaveAndUpdate.TabIndex = 10;
            btnSaveAndUpdate.Text = "Append";
            btnSaveAndUpdate.UseVisualStyleBackColor = false;
            btnSaveAndUpdate.Click += btnAppendandChange_Click;
            // 
            // txtBoxFileName
            // 
            txtBoxFileName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxFileName.Location = new Point(529, 285);
            txtBoxFileName.Name = "txtBoxFileName";
            txtBoxFileName.PlaceholderText = "File Name";
            txtBoxFileName.Size = new Size(254, 30);
            txtBoxFileName.TabIndex = 11;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.DarkKhaki;
            btnLoad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoad.ForeColor = SystemColors.ActiveCaptionText;
            btnLoad.Location = new Point(614, 321);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(84, 41);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(699, 321);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 41);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClearListBox
            // 
            btnClearListBox.BackColor = Color.Red;
            btnClearListBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearListBox.ForeColor = SystemColors.ActiveCaptionText;
            btnClearListBox.Location = new Point(529, 321);
            btnClearListBox.Name = "btnClearListBox";
            btnClearListBox.Size = new Size(84, 41);
            btnClearListBox.TabIndex = 14;
            btnClearListBox.Text = "Clear";
            btnClearListBox.UseVisualStyleBackColor = false;
            btnClearListBox.Click += btnClearListBox_Click;
            // 
            // btnCleartxtBoxes
            // 
            btnCleartxtBoxes.BackColor = Color.Crimson;
            btnCleartxtBoxes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCleartxtBoxes.ForeColor = SystemColors.ActiveCaptionText;
            btnCleartxtBoxes.Location = new Point(103, 297);
            btnCleartxtBoxes.Name = "btnCleartxtBoxes";
            btnCleartxtBoxes.Size = new Size(146, 56);
            btnCleartxtBoxes.TabIndex = 15;
            btnCleartxtBoxes.Text = "Clear";
            btnCleartxtBoxes.UseVisualStyleBackColor = false;
            btnCleartxtBoxes.Click += btnCleartxtBoxes_Click;
            // 
            // Questionnaire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 374);
            Controls.Add(btnCleartxtBoxes);
            Controls.Add(btnClearListBox);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(txtBoxFileName);
            Controls.Add(btnSaveAndUpdate);
            Controls.Add(listBoxUsers);
            Controls.Add(dateTimeBrithday);
            Controls.Add(label5);
            Controls.Add(txtBoxPhone);
            Controls.Add(label4);
            Controls.Add(txtBoxEmail);
            Controls.Add(label3);
            Controls.Add(txtBoxSurname);
            Controls.Add(txtBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Questionnaire";
            Text = "Questionnaire";
            Load += listBoxUsers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBoxName;
        private TextBox txtBoxSurname;
        private Label label3;
        private TextBox txtBoxEmail;
        private Label label4;
        private TextBox txtBoxPhone;
        private Label label5;
        private DateTimePicker dateTimeBrithday;
        private ListBox listBoxUsers;
        private Button btnSaveAndUpdate;
        private TextBox txtBoxFileName;
        private Button btnLoad;
        private Button btnSave;
        private Button btnClearListBox;
        private Button btnCleartxtBoxes;
    }
}
