using System;
using System.Windows.Forms;

namespace TaskManagerApp.Forms
{
    partial class MainForm
    {
        private TextBox textBoxTitle;
        private TextBox textBoxDescription;
        private TextBox textBoxCategory;
        private ListBox listBoxTasks;
        private DateTimePicker dateTimePickerDueDate;
        private Button buttonAddTask;
        private Button buttonMarkCompleted;
        private Button buttonDeleteTask;

        /// <summary>
        /// Initialisiert die Steuerelemente der Form
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTitle = new TextBox();
            textBoxDescription = new TextBox();
            textBoxCategory = new TextBox();
            listBoxTasks = new ListBox();
            dateTimePickerDueDate = new DateTimePicker();
            buttonAddTask = new Button();
            buttonMarkCompleted = new Button();
            buttonDeleteTask = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(12, 37);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(370, 26);
            textBoxTitle.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 88);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(370, 26);
            textBoxDescription.TabIndex = 1;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(12, 139);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(370, 26);
            textBoxCategory.TabIndex = 2;
            // 
            // listBoxTasks
            // 
            listBoxTasks.Location = new Point(418, 20);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(1349, 232);
            listBoxTasks.TabIndex = 3;
            // 
            // dateTimePickerDueDate
            // 
            dateTimePickerDueDate.Location = new Point(418, 264);
            dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            dateTimePickerDueDate.Size = new Size(200, 26);
            dateTimePickerDueDate.TabIndex = 4;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(9, 184);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(373, 30);
            buttonAddTask.TabIndex = 5;
            buttonAddTask.Text = "Aufgabe Hinzufügen";
            buttonAddTask.Click += ButtonAddTask_Click;
            // 
            // buttonMarkCompleted
            // 
            buttonMarkCompleted.Location = new Point(9, 234);
            buttonMarkCompleted.Name = "buttonMarkCompleted";
            buttonMarkCompleted.Size = new Size(373, 30);
            buttonMarkCompleted.TabIndex = 6;
            buttonMarkCompleted.Text = "Aufgabe Abschließen";
            buttonMarkCompleted.Click += ButtonMarkCompleted_Click;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.Location = new Point(9, 286);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new Size(373, 30);
            buttonDeleteTask.TabIndex = 7;
            buttonDeleteTask.Text = "Aufgabe Löschen";
            buttonDeleteTask.Click += ButtonDeleteTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 8;
            label1.Text = "Titel der Aufgabe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(170, 19);
            label2.TabIndex = 9;
            label2.Text = "Beschreibung der Aufgabe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(146, 19);
            label3.TabIndex = 10;
            label3.Text = "Kategorie der Aufgabe";
            // 
            // MainForm
            // 
            ClientSize = new Size(1816, 346);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxCategory);
            Controls.Add(listBoxTasks);
            Controls.Add(dateTimePickerDueDate);
            Controls.Add(buttonAddTask);
            Controls.Add(buttonMarkCompleted);
            Controls.Add(buttonDeleteTask);
            Name = "MainForm";
            Text = "Task Manager";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
    }
}
