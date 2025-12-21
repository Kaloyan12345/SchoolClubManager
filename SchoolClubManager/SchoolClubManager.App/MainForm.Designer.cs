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
        projectsListBox.Location = new Point(14, 61);
        projectsListBox.Margin = new Padding(3, 4, 3, 4);
        projectsListBox.Name = "projectsListBox";
        projectsListBox.Size = new Size(251, 644);
        projectsListBox.TabIndex = 0;
        projectsListBox.SelectedIndexChanged += projectsListBox_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(291, 61);
        label1.Name = "label1";
        label1.Size = new Size(112, 20);
        label1.TabIndex = 1;
        label1.Text = "Име на проект";
        // 
        // titleTextBox
        // 
        titleTextBox.Location = new Point(291, 85);
        titleTextBox.Margin = new Padding(3, 4, 3, 4);
        titleTextBox.Name = "titleTextBox";
        titleTextBox.PlaceholderText = "Пример: Слънчев спасител";
        titleTextBox.Size = new Size(285, 27);
        titleTextBox.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(291, 133);
        label2.Name = "label2";
        label2.Size = new Size(122, 20);
        label2.TabIndex = 3;
        label2.Text = "Тема/Категория";
        // 
        // themeTextBox
        // 
        themeTextBox.Location = new Point(291, 157);
        themeTextBox.Margin = new Padding(3, 4, 3, 4);
        themeTextBox.Name = "themeTextBox";
        themeTextBox.PlaceholderText = "Роботика, екология...";
        themeTextBox.Size = new Size(285, 27);
        themeTextBox.TabIndex = 4;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(291, 205);
        label3.Name = "label3";
        label3.Size = new Size(120, 20);
        label3.TabIndex = 5;
        label3.Text = "Ден на срещите";
        // 
        // dayComboBox
        // 
        dayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        dayComboBox.FormattingEnabled = true;
        dayComboBox.Location = new Point(291, 229);
        dayComboBox.Margin = new Padding(3, 4, 3, 4);
        dayComboBox.Name = "dayComboBox";
        dayComboBox.Size = new Size(285, 28);
        dayComboBox.TabIndex = 6;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(291, 277);
        label4.Name = "label4";
        label4.Size = new Size(123, 20);
        label4.TabIndex = 7;
        label4.Text = "Ментор / учител";
        // 
        // mentorTextBox
        // 
        mentorTextBox.Location = new Point(291, 301);
        mentorTextBox.Margin = new Padding(3, 4, 3, 4);
        mentorTextBox.Name = "mentorTextBox";
        mentorTextBox.PlaceholderText = "г-жа Георгиева";
        mentorTextBox.Size = new Size(285, 27);
        mentorTextBox.TabIndex = 8;
        // 
        // addButton
        // 
        addButton.Location = new Point(291, 693);
        addButton.Margin = new Padding(3, 4, 3, 4);
        addButton.Name = "addButton";
        addButton.Size = new Size(86, 47);
        addButton.TabIndex = 9;
        addButton.Text = "Добави";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += addButton_Click;
        // 
        // updateButton
        // 
        updateButton.Location = new Point(394, 693);
        updateButton.Margin = new Padding(3, 4, 3, 4);
        updateButton.Name = "updateButton";
        updateButton.Size = new Size(86, 47);
        updateButton.TabIndex = 10;
        updateButton.Text = "Запази";
        updateButton.UseVisualStyleBackColor = true;
        updateButton.Click += updateButton_Click;
        // 
        // deleteButton
        // 
        deleteButton.Location = new Point(491, 693);
        deleteButton.Margin = new Padding(3, 4, 3, 4);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new Size(86, 47);
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
        detailsLabel.Font = new Font("Consolas", 9F);
        detailsLabel.Location = new Point(926, 61);
        detailsLabel.Name = "detailsLabel";
        detailsLabel.Padding = new Padding(9, 11, 9, 11);
        detailsLabel.Size = new Size(331, 693);
        detailsLabel.TabIndex = 12;
        detailsLabel.Text = "Избери проект, за да видиш детайли.";
        // 
        // summaryLabel
        // 
        summaryLabel.AutoSize = true;
        summaryLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        summaryLabel.Location = new Point(14, 24);
        summaryLabel.Name = "summaryLabel";
        summaryLabel.Size = new Size(200, 23);
        summaryLabel.TabIndex = 13;
        summaryLabel.Text = "Общо идеи: 0 (начало)";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(291, 347);
        label5.Name = "label5";
        label5.Size = new Size(133, 20);
        label5.TabIndex = 14;
        label5.Text = "Имейл на ментор";
        // 
        // mentorEmailTextBox
        // 
        mentorEmailTextBox.Location = new Point(291, 371);
        mentorEmailTextBox.Margin = new Padding(3, 4, 3, 4);
        mentorEmailTextBox.Name = "mentorEmailTextBox";
        mentorEmailTextBox.PlaceholderText = "mentor@school.bg";
        mentorEmailTextBox.Size = new Size(285, 27);
        mentorEmailTextBox.TabIndex = 15;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(291, 416);
        label6.Name = "label6";
        label6.Size = new Size(107, 20);
        label6.TabIndex = 16;
        label6.Text = "Роля/предмет";
        // 
        // mentorRoleTextBox
        // 
        mentorRoleTextBox.Location = new Point(291, 440);
        mentorRoleTextBox.Margin = new Padding(3, 4, 3, 4);
        mentorRoleTextBox.Name = "mentorRoleTextBox";
        mentorRoleTextBox.PlaceholderText = "Физика, информатика...";
        mentorRoleTextBox.Size = new Size(285, 27);
        mentorRoleTextBox.TabIndex = 17;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(607, 61);
        label7.Name = "label7";
        label7.Size = new Size(97, 20);
        label7.TabIndex = 18;
        label7.Text = "Име на екип";
        // 
        // teamNameTextBox
        // 
        teamNameTextBox.Location = new Point(607, 85);
        teamNameTextBox.Margin = new Padding(3, 4, 3, 4);
        teamNameTextBox.Name = "teamNameTextBox";
        teamNameTextBox.PlaceholderText = "Екип Фотон";
        teamNameTextBox.Size = new Size(285, 27);
        teamNameTextBox.TabIndex = 19;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(607, 133);
        label8.Name = "label8";
        label8.Size = new Size(165, 20);
        label8.TabIndex = 20;
        label8.Text = "Мото/хаштаг на екипа";
        // 
        // teamMottoTextBox
        // 
        teamMottoTextBox.Location = new Point(607, 157);
        teamMottoTextBox.Margin = new Padding(3, 4, 3, 4);
        teamMottoTextBox.Name = "teamMottoTextBox";
        teamMottoTextBox.PlaceholderText = "Светлина за идеите";
        teamMottoTextBox.Size = new Size(285, 27);
        teamMottoTextBox.TabIndex = 21;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(607, 205);
        label9.Name = "label9";
        label9.Size = new Size(196, 20);
        label9.TabIndex = 22;
        label9.Text = "Членове на екипа (по ред)";
        // 
        // teamMembersTextBox
        // 
        teamMembersTextBox.AcceptsReturn = true;
        teamMembersTextBox.Location = new Point(607, 229);
        teamMembersTextBox.Margin = new Padding(3, 4, 3, 4);
        teamMembersTextBox.Multiline = true;
        teamMembersTextBox.Name = "teamMembersTextBox";
        teamMembersTextBox.PlaceholderText = "Ани Иванова\r\nБоби Димитров";
        teamMembersTextBox.ScrollBars = ScrollBars.Vertical;
        teamMembersTextBox.Size = new Size(285, 125);
        teamMembersTextBox.TabIndex = 23;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(607, 368);
        label10.Name = "label10";
        label10.Size = new Size(107, 20);
        label10.TabIndex = 24;
        label10.Text = "Водещ ученик";
        // 
        // studentLeadTextBox
        // 
        studentLeadTextBox.Location = new Point(607, 392);
        studentLeadTextBox.Margin = new Padding(3, 4, 3, 4);
        studentLeadTextBox.Name = "studentLeadTextBox";
        studentLeadTextBox.PlaceholderText = "Теди Лазаров";
        studentLeadTextBox.Size = new Size(285, 27);
        studentLeadTextBox.TabIndex = 25;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(607, 437);
        label11.Name = "label11";
        label11.Size = new Size(116, 20);
        label11.TabIndex = 26;
        label11.Text = "Клас на лидера";
        // 
        // studentGradeNumeric
        // 
        studentGradeNumeric.Location = new Point(607, 461);
        studentGradeNumeric.Margin = new Padding(3, 4, 3, 4);
        studentGradeNumeric.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        studentGradeNumeric.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
        studentGradeNumeric.Name = "studentGradeNumeric";
        studentGradeNumeric.Size = new Size(91, 27);
        studentGradeNumeric.TabIndex = 27;
        studentGradeNumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(711, 437);
        label12.Name = "label12";
        label12.Size = new Size(123, 20);
        label12.TabIndex = 28;
        label12.Text = "Любим предмет";
        // 
        // studentSubjectTextBox
        // 
        studentSubjectTextBox.Location = new Point(711, 461);
        studentSubjectTextBox.Margin = new Padding(3, 4, 3, 4);
        studentSubjectTextBox.Name = "studentSubjectTextBox";
        studentSubjectTextBox.PlaceholderText = "Математика";
        studentSubjectTextBox.Size = new Size(181, 27);
        studentSubjectTextBox.TabIndex = 29;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(291, 485);
        label13.Name = "label13";
        label13.Size = new Size(133, 20);
        label13.TabIndex = 30;
        label13.Text = "Статус на проекта";
        // 
        // statusComboBox
        // 
        statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        statusComboBox.FormattingEnabled = true;
        statusComboBox.Location = new Point(291, 509);
        statusComboBox.Margin = new Padding(3, 4, 3, 4);
        statusComboBox.Name = "statusComboBox";
        statusComboBox.Size = new Size(285, 28);
        statusComboBox.TabIndex = 31;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(291, 557);
        label14.Name = "label14";
        label14.Size = new Size(151, 20);
        label14.TabIndex = 32;
        label14.Text = "Бележки за срещите";
        // 
        // notesTextBox
        // 
        notesTextBox.AcceptsReturn = true;
        notesTextBox.Location = new Point(291, 581);
        notesTextBox.Margin = new Padding(3, 4, 3, 4);
        notesTextBox.Multiline = true;
        notesTextBox.Name = "notesTextBox";
        notesTextBox.ScrollBars = ScrollBars.Vertical;
        notesTextBox.Size = new Size(285, 92);
        notesTextBox.TabIndex = 33;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(607, 509);
        label15.Name = "label15";
        label15.Size = new Size(238, 20);
        label15.TabIndex = 34;
        label15.Text = "Задачи ([x] означава изпълнена)";
        // 
        // tasksTextBox
        // 
        tasksTextBox.AcceptsReturn = true;
        tasksTextBox.Location = new Point(607, 533);
        tasksTextBox.Margin = new Padding(3, 4, 3, 4);
        tasksTextBox.Multiline = true;
        tasksTextBox.Name = "tasksTextBox";
        tasksTextBox.ScrollBars = ScrollBars.Vertical;
        tasksTextBox.Size = new Size(285, 140);
        tasksTextBox.TabIndex = 35;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1280, 800);
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
        Margin = new Padding(3, 4, 3, 4);
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
