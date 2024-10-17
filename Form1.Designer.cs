namespace TaskManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonRemoveTask;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.DateTimePicker dateTimePickerReminder;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime; // Новый элемент для времени
        private System.Windows.Forms.Button buttonSetReminder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonRemoveTask = new System.Windows.Forms.Button();
            this.labelTask = new System.Windows.Forms.Label();
            this.dateTimePickerReminder = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.buttonSetReminder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.monthCalendar1.Location = new System.Drawing.Point(330, 282);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 16;
            this.listBoxTasks.Location = new System.Drawing.Point(20, 122);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(530, 148);
            this.listBoxTasks.TabIndex = 1;
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(20, 94);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(530, 22);
            this.textBoxTask.TabIndex = 2;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTask.Location = new System.Drawing.Point(20, 276);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(112, 33);
            this.buttonAddTask.TabIndex = 3;
            this.buttonAddTask.Text = "Добавить";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonRemoveTask
            // 
            this.buttonRemoveTask.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonRemoveTask.Location = new System.Drawing.Point(138, 276);
            this.buttonRemoveTask.Name = "buttonRemoveTask";
            this.buttonRemoveTask.Size = new System.Drawing.Size(112, 33);
            this.buttonRemoveTask.TabIndex = 4;
            this.buttonRemoveTask.Text = "Удалить";
            this.buttonRemoveTask.UseVisualStyleBackColor = true;
            this.buttonRemoveTask.Click += new System.EventHandler(this.buttonRemoveTask_Click);
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask.Location = new System.Drawing.Point(20, 69);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(126, 22);
            this.labelTask.TabIndex = 5;
            this.labelTask.Text = "Новая задача:";
            // 
            // dateTimePickerReminder
            // 
            this.dateTimePickerReminder.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerReminder.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dateTimePickerReminder.Location = new System.Drawing.Point(334, 18);
            this.dateTimePickerReminder.Name = "dateTimePickerReminder";
            this.dateTimePickerReminder.Size = new System.Drawing.Size(216, 30);
            this.dateTimePickerReminder.TabIndex = 6;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(216, 18);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(112, 30);
            this.dateTimePickerTime.TabIndex = 8;
            // 
            // buttonSetReminder
            // 
            this.buttonSetReminder.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonSetReminder.Location = new System.Drawing.Point(216, 55);
            this.buttonSetReminder.Name = "buttonSetReminder";
            this.buttonSetReminder.Size = new System.Drawing.Size(334, 33);
            this.buttonSetReminder.TabIndex = 7;
            this.buttonSetReminder.Text = "Установить напоминание";
            this.buttonSetReminder.UseVisualStyleBackColor = true;
            this.buttonSetReminder.Click += new System.EventHandler(this.buttonSetReminder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 508);
            this.Controls.Add(this.buttonSetReminder);
            this.Controls.Add(this.dateTimePickerReminder);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.buttonRemoveTask);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}