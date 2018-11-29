namespace BackToDoTheFuture
{
    partial class ToDoSetPanel
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
            this.checkedListBoxToDoList = new System.Windows.Forms.CheckedListBox();
            this.dateTimePickerToDoDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxToDoDetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePickerToDoTime = new System.Windows.Forms.DateTimePicker();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxToDoList
            // 
            this.checkedListBoxToDoList.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkedListBoxToDoList.FormattingEnabled = true;
            this.checkedListBoxToDoList.HorizontalScrollbar = true;
            this.checkedListBoxToDoList.Location = new System.Drawing.Point(2, 203);
            this.checkedListBoxToDoList.Name = "checkedListBoxToDoList";
            this.checkedListBoxToDoList.Size = new System.Drawing.Size(707, 364);
            this.checkedListBoxToDoList.TabIndex = 0;
            this.checkedListBoxToDoList.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxToDoList_SelectedIndexChanged);
            // 
            // dateTimePickerToDoDate
            // 
            this.dateTimePickerToDoDate.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePickerToDoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToDoDate.Location = new System.Drawing.Point(2, 31);
            this.dateTimePickerToDoDate.Name = "dateTimePickerToDoDate";
            this.dateTimePickerToDoDate.Size = new System.Drawing.Size(185, 26);
            this.dateTimePickerToDoDate.TabIndex = 1;
            // 
            // textBoxToDoDetail
            // 
            this.textBoxToDoDetail.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxToDoDetail.Location = new System.Drawing.Point(2, 63);
            this.textBoxToDoDetail.Name = "textBoxToDoDetail";
            this.textBoxToDoDetail.Size = new System.Drawing.Size(705, 26);
            this.textBoxToDoDetail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ToDo の登録・修正";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(0, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ToDo の一覧";
            // 
            // buttonSet
            // 
            this.buttonSet.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSet.Location = new System.Drawing.Point(411, 95);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(145, 39);
            this.buttonSet.TabIndex = 5;
            this.buttonSet.Text = "登録";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCancel.Location = new System.Drawing.Point(562, 95);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(145, 39);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dateTimePickerToDoTime
            // 
            this.dateTimePickerToDoTime.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePickerToDoTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerToDoTime.Location = new System.Drawing.Point(193, 31);
            this.dateTimePickerToDoTime.Name = "dateTimePickerToDoTime";
            this.dateTimePickerToDoTime.ShowUpDown = true;
            this.dateTimePickerToDoTime.Size = new System.Drawing.Size(185, 26);
            this.dateTimePickerToDoTime.TabIndex = 7;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonDelete.Location = new System.Drawing.Point(479, 158);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(228, 39);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "チェックしたToDoを削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ToDoSetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 570);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dateTimePickerToDoTime);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxToDoDetail);
            this.Controls.Add(this.dateTimePickerToDoDate);
            this.Controls.Add(this.checkedListBoxToDoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ToDoSetPanel";
            this.Text = "ToDoを設定してください";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToDoSetPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxToDoList;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDoDate;
        private System.Windows.Forms.TextBox textBoxToDoDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDoTime;
        private System.Windows.Forms.Button buttonDelete;
    }
}