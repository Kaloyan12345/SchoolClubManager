using System.Drawing;
using System.Windows.Forms;

namespace SchoolClubManager.App;

partial class MainForm
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
        projectsListBox = new ListBox();
        label1 = new Label();
        titleTextBox = new TextBox();
        label2 = new Label();
        themeTextBox = new TextBox();
        label3 = new Label();
        dayComboBox = new ComboBox();
        label4 = new Label();
        mentorTextBox = new TextBox();
        addButton = new Button();
        updateButton = new Button();
        deleteButton = new Button();
        detailsLabel = new Label();
        summaryLabel = new Label();
        label5 = new Label();
        mentorEmailTextBox = new TextBox();
        label6 = new Label();
        mentorRoleTextBox = new TextBox();
        label7 = new Label();
        teamNameTextBox = new TextBox();
        label8 = new Label();
        teamMottoTextBox = new TextBox();
        label9 = new Label();
        teamMembersTextBox = new TextBox();
        label10 = new Label();
        studentLeadTextBox = new TextBox();
        label11 = new Label();
        studentGradeNumeric = new NumericUpDown();
        label12 = new Label();
        studentSubjectTextBox = new TextBox();
        label13 = new Label();
        statusComboBox = new ComboBox();
        label14 = new Label();
        notesTextBox = new TextBox();
        label15 = new Label();
        tasksTextBox = new TextBox();
        ((System.ComponentModel.ISupportInitialize)studentGradeNumeric).BeginInit();
        SuspendLayout();
        // 
        // projectsListBox
        // 
        projectsListBox.FormattingEnabled = true;
        projectsListBox.ItemHeight = 15;
        projectsListBox.Location = new Point(12, 46);
        projectsListBox.Name = "projectsListBox";
        projectsListBox.Size = new Size(220, 484);
        projectsListBox.TabIndex = 0;
        projectsListBox.SelectedIndexChanged += projectsListBox_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(255, 46);
        label1.Name = "label1";
        label1.Size = new Size(89, 15);
        label1.TabIndex = 1;
        label1.Text = "Име на проект";
        // 
        // titleTextBox
        // 
        titleTextBox.Location = new Point(255, 64);
        titleTextBox.Name = "titleTextBox";
        titleTextBox.PlaceholderText = "Пример: Слънчев спасител";
        titleTextBox.Size = new Size(250, 23);
        titleTextBox.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(255, 100);
        label2.Name = "label2";
        label2.Size = new Size(93, 15);
        label2.TabIndex = 3;
        label2.Text = "Тема/Категория";
        // 
        // themeTextBox
        // 
        themeTextBox.Location = new Point(255, 118);
        themeTextBox.Name = "themeTextBox";
        themeTextBox.PlaceholderText = "Роботика, екология...";
        themeTextBox.Size = new Size(250, 23);
        themeTextBox.TabIndex = 4;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(255, 154);
        label3.Name = "label3";
        label3.Size = new Size(91, 15);
        label3.TabIndex = 5;
        label3.Text = "Ден на срещите";
        // 
        // dayComboBox
        // 
        dayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        dayComboBox.FormattingEnabled = true;
        dayComboBox.Location = new Point(255, 172);
        dayComboBox.Name = "dayComboBox";
        dayComboBox.Size = new Size(250, 23);
        dayComboBox.TabIndex = 6;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(255, 208);
        label4.Name = "label4";
        label4.Size = new Size(91, 15);
        label4.TabIndex = 7;
        label4.Text = "Ментор / учител";
        // 
        // mentorTextBox
        // 
        mentorTextBox.Location = new Point(255, 226);
        mentorTextBox.Name = "mentorTextBox";
        mentorTextBox.PlaceholderText = "г-жа Георгиева";
        mentorTextBox.Size = new Size(250, 23);
        mentorTextBox.TabIndex = 8;
        // 
        // addButton
        // 
        addButton.Location = new Point(255, 520);
        addButton.Name = "addButton";
        addButton.Size = new Size(75, 35);
        addButton.TabIndex = 9;
        addButton.Text = "Добави";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += addButton_Click;
        // 
        // updateButton
        // 
        updateButton.Location = new Point(345, 520);
        updateButton.Name = "updateButton";
        updateButton.Size = new Size(75, 35);
        updateButton.TabIndex = 10;
        updateButton.Text = "Запази";
        updateButton.UseVisualStyleBackColor = true;
        updateButton.Click += updateButton_Click;
        // 
        // deleteButton
        // 
        deleteButton.Location = new Point(430, 520);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new Size(75, 35);
        deleteButton.TabIndex = 11;
        deleteButton.Text = "Изтрий";
        deleteButton.UseVisualStyleBackColor = true;
        deleteButton.Click += deleteButton_Click;
        // 
        // detailsLabel
        // 
        detailsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        detailsLabel.BackColor = Color.FromArgb(245, 245, 245);
        detailsLabel.BorderStyle = BorderStyle.FixedSingle;
        detailsLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
        detailsLabel.Location = new Point(810, 46);
        detailsLabel.Name = "detailsLabel";
        detailsLabel.Padding = new Padding(8);
        detailsLabel.Size = new Size(290, 520);
        detailsLabel.TabIndex = 12;
        detailsLabel.Text = "Избери проект, за да видиш детайли.";
        // 
        // summaryLabel
        // 
        summaryLabel.AutoSize = true;
        summaryLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        summaryLabel.Location = new Point(12, 18);
        summaryLabel.Name = "summaryLabel";
        summaryLabel.Size = new Size(144, 19);
        summaryLabel.TabIndex = 13;
        summaryLabel.Text = "Общо идеи: 0 (начало)";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(255, 260);
        label5.Name = "label5";
        label5.Size = new Size(89, 15);
        label5.TabIndex = 14;
        label5.Text = "Имейл на ментор";
        // 
        // mentorEmailTextBox
        // 
        mentorEmailTextBox.Location = new Point(255, 278);
        mentorEmailTextBox.Name = "mentorEmailTextBox";
        mentorEmailTextBox.PlaceholderText = "mentor@school.bg";
        mentorEmailTextBox.Size = new Size(250, 23);
        mentorEmailTextBox.TabIndex = 15;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(255, 312);
        label6.Name = "label6";
        label6.Size = new Size(97, 15);
        label6.TabIndex = 16;
        label6.Text = "Роля/предмет";
        // 
        // mentorRoleTextBox
        // 
        mentorRoleTextBox.Location = new Point(255, 330);
        mentorRoleTextBox.Name = "mentorRoleTextBox";
        mentorRoleTextBox.PlaceholderText = "Физика, информатика...";
        mentorRoleTextBox.Size = new Size(250, 23);
        mentorRoleTextBox.TabIndex = 17;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(531, 46);
        label7.Name = "label7";
        label7.Size = new Size(72, 15);
        label7.TabIndex = 18;
        label7.Text = "Име на екип";
        // 
        // teamNameTextBox
        // 
        teamNameTextBox.Location = new Point(531, 64);
        teamNameTextBox.Name = "teamNameTextBox";
        teamNameTextBox.PlaceholderText = "Екип Фотон";
        teamNameTextBox.Size = new Size(250, 23);
        teamNameTextBox.TabIndex = 19;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(531, 100);
        label8.Name = "label8";
        label8.Size = new Size(109, 15);
        label8.TabIndex = 20;
        label8.Text = "Мото/хаштаг на екипа";
        // 
        // teamMottoTextBox
        // 
        teamMottoTextBox.Location = new Point(531, 118);
        teamMottoTextBox.Name = "teamMottoTextBox";
        teamMottoTextBox.PlaceholderText = "Светлина за идеите";
        teamMottoTextBox.Size = new Size(250, 23);
        teamMottoTextBox.TabIndex = 21;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(531, 154);
        label9.Name = "label9";
        label9.Size = new Size(155, 15);
        label9.TabIndex = 22;
        label9.Text = "Членове на екипа (по ред)";
        // 
        // teamMembersTextBox
        // 
        teamMembersTextBox.AcceptsReturn = true;
        teamMembersTextBox.Location = new Point(531, 172);
        teamMembersTextBox.Multiline = true;
        teamMembersTextBox.Name = "teamMembersTextBox";
        teamMembersTextBox.PlaceholderText = "Ани Иванова\r\nБоби Димитров";
        teamMembersTextBox.ScrollBars = ScrollBars.Vertical;
        teamMembersTextBox.Size = new Size(250, 95);
        teamMembersTextBox.TabIndex = 23;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(531, 276);
        label10.Name = "label10";
        label10.Size = new Size(84, 15);
        label10.TabIndex = 24;
        label10.Text = "Водещ ученик";
        // 
        // studentLeadTextBox
        // 
        studentLeadTextBox.Location = new Point(531, 294);
        studentLeadTextBox.Name = "studentLeadTextBox";
        studentLeadTextBox.PlaceholderText = "Теди Лазаров";
        studentLeadTextBox.Size = new Size(250, 23);
        studentLeadTextBox.TabIndex = 25;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(531, 328);
        label11.Name = "label11";
        label11.Size = new Size(108, 15);
        label11.TabIndex = 26;
        label11.Text = "Клас на лидера";
        // 
        // studentGradeNumeric
        // 
        studentGradeNumeric.Location = new Point(531, 346);
        studentGradeNumeric.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        studentGradeNumeric.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
        studentGradeNumeric.Name = "studentGradeNumeric";
        studentGradeNumeric.Size = new Size(80, 23);
        studentGradeNumeric.TabIndex = 27;
        studentGradeNumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(622, 328);
        label12.Name = "label12";
        label12.Size = new Size(104, 15);
        label12.TabIndex = 28;
        label12.Text = "Любим предмет";
        // 
        // studentSubjectTextBox
        // 
        studentSubjectTextBox.Location = new Point(622, 346);
        studentSubjectTextBox.Name = "studentSubjectTextBox";
        studentSubjectTextBox.PlaceholderText = "Математика";
        studentSubjectTextBox.Size = new Size(159, 23);
        studentSubjectTextBox.TabIndex = 29;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(255, 364);
        label13.Name = "label13";
        label13.Size = new Size(104, 15);
        label13.TabIndex = 30;
        label13.Text = "Статус на проекта";
        // 
        // statusComboBox
        // 
        statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        statusComboBox.FormattingEnabled = true;
        statusComboBox.Location = new Point(255, 382);
        statusComboBox.Name = "statusComboBox";
        statusComboBox.Size = new Size(250, 23);
        statusComboBox.TabIndex = 31;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(255, 418);
        label14.Name = "label14";
        label14.Size = new Size(114, 15);
        label14.TabIndex = 32;
        label14.Text = "Бележки за срещите";
        // 
        // notesTextBox
        // 
        notesTextBox.AcceptsReturn = true;
        notesTextBox.Location = new Point(255, 436);
        notesTextBox.Multiline = true;
        notesTextBox.Name = "notesTextBox";
        notesTextBox.ScrollBars = ScrollBars.Vertical;
        notesTextBox.Size = new Size(250, 70);
        notesTextBox.TabIndex = 33;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(531, 382);
        label15.Name = "label15";
        label15.Size = new Size(187, 15);
        label15.TabIndex = 34;
        label15.Text = "Задачи ([x] означава изпълнена)";
        // 
        // tasksTextBox
        // 
        tasksTextBox.AcceptsReturn = true;
        tasksTextBox.Location = new Point(531, 400);
        tasksTextBox.Multiline = true;
        tasksTextBox.Name = "tasksTextBox";
        tasksTextBox.ScrollBars = ScrollBars.Vertical;
        tasksTextBox.Size = new Size(250, 106);
        tasksTextBox.TabIndex = 35;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1120, 600);
        Controls.Add(tasksTextBox);
        Controls.Add(label15);
        Controls.Add(notesTextBox);
        Controls.Add(label14);
        Controls.Add(statusComboBox);
        Controls.Add(label13);
        Controls.Add(studentSubjectTextBox);
        Controls.Add(label12);
        Controls.Add(studentGradeNumeric);
        Controls.Add(label11);
        Controls.Add(studentLeadTextBox);
        Controls.Add(label10);
        Controls.Add(teamMembersTextBox);
        Controls.Add(label9);
        Controls.Add(teamMottoTextBox);
        Controls.Add(label8);
        Controls.Add(teamNameTextBox);
        Controls.Add(label7);
        Controls.Add(mentorRoleTextBox);
        Controls.Add(label6);
        Controls.Add(mentorEmailTextBox);
        Controls.Add(label5);
        Controls.Add(summaryLabel);
        Controls.Add(detailsLabel);
        Controls.Add(deleteButton);
        Controls.Add(updateButton);
        Controls.Add(addButton);
        Controls.Add(mentorTextBox);
        Controls.Add(label4);
        Controls.Add(dayComboBox);
        Controls.Add(label3);
        Controls.Add(themeTextBox);
        Controls.Add(label2);
        Controls.Add(titleTextBox);
        Controls.Add(label1);
        Controls.Add(projectsListBox);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Клуб по идеи";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)studentGradeNumeric).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox projectsListBox;
    private Label label1;
    private TextBox titleTextBox;
    private Label label2;
    private TextBox themeTextBox;
    private Label label3;
    private ComboBox dayComboBox;
    private Label label4;
    private TextBox mentorTextBox;
    private Button addButton;
    private Button updateButton;
    private Button deleteButton;
    private Label detailsLabel;
    private Label summaryLabel;
    private Label label5;
    private TextBox mentorEmailTextBox;
    private Label label6;
    private TextBox mentorRoleTextBox;
    private Label label7;
    private TextBox teamNameTextBox;
    private Label label8;
    private TextBox teamMottoTextBox;
    private Label label9;
    private TextBox teamMembersTextBox;
    private Label label10;
    private TextBox studentLeadTextBox;
    private Label label11;
    private NumericUpDown studentGradeNumeric;
    private Label label12;
    private TextBox studentSubjectTextBox;
    private Label label13;
    private ComboBox statusComboBox;
    private Label label14;
    private TextBox notesTextBox;
    private Label label15;
    private TextBox tasksTextBox;
}
