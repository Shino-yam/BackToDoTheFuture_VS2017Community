namespace BackToDoTheFuture
{
    partial class MainPanel
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBlinkStop = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxNotifiedToDo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxToDoDetail = new System.Windows.Forms.TextBox();
            this.buttonToDoSet = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPresentSecond = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPresentHour = new System.Windows.Forms.TextBox();
            this.textBoxPresentMinute = new System.Windows.Forms.TextBox();
            this.textBoxPresentDay = new System.Windows.Forms.TextBox();
            this.textBoxPresentYear = new System.Windows.Forms.TextBox();
            this.textBoxPresentMonth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxToDoHour = new System.Windows.Forms.TextBox();
            this.textBoxToDoMinute = new System.Windows.Forms.TextBox();
            this.textBoxToDoDay = new System.Windows.Forms.TextBox();
            this.textBoxToDoYear = new System.Windows.Forms.TextBox();
            this.textBoxToDoMonth = new System.Windows.Forms.TextBox();
            this.labelPresentHM = new System.Windows.Forms.Label();
            this.labelPresentMS = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timerGetPresent = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.buttonBlinkStop);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.textBoxNotifiedToDo);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.textBoxToDoDetail);
            this.panel1.Controls.Add(this.buttonToDoSet);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBoxPresentSecond);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBoxPresentHour);
            this.panel1.Controls.Add(this.textBoxPresentMinute);
            this.panel1.Controls.Add(this.textBoxPresentDay);
            this.panel1.Controls.Add(this.textBoxPresentYear);
            this.panel1.Controls.Add(this.textBoxPresentMonth);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxToDoHour);
            this.panel1.Controls.Add(this.textBoxToDoMinute);
            this.panel1.Controls.Add(this.textBoxToDoDay);
            this.panel1.Controls.Add(this.textBoxToDoYear);
            this.panel1.Controls.Add(this.textBoxToDoMonth);
            this.panel1.Controls.Add(this.labelPresentHM);
            this.panel1.Controls.Add(this.labelPresentMS);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 527);
            this.panel1.TabIndex = 0;
            // 
            // buttonBlinkStop
            // 
            this.buttonBlinkStop.BackColor = System.Drawing.Color.Black;
            this.buttonBlinkStop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlinkStop.ForeColor = System.Drawing.Color.Red;
            this.buttonBlinkStop.Location = new System.Drawing.Point(808, 477);
            this.buttonBlinkStop.Name = "buttonBlinkStop";
            this.buttonBlinkStop.Size = new System.Drawing.Size(127, 40);
            this.buttonBlinkStop.TabIndex = 32;
            this.buttonBlinkStop.Text = "Blink Stop";
            this.buttonBlinkStop.UseVisualStyleBackColor = false;
            this.buttonBlinkStop.Click += new System.EventHandler(this.buttonBlinkStop_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkGray;
            this.label16.Location = new System.Drawing.Point(297, 483);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label16.Size = new System.Drawing.Size(160, 22);
            this.label16.TabIndex = 31;
            this.label16.Text = "NOTIFIED TODO";
            // 
            // textBoxNotifiedToDo
            // 
            this.textBoxNotifiedToDo.BackColor = System.Drawing.Color.Black;
            this.textBoxNotifiedToDo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNotifiedToDo.ForeColor = System.Drawing.Color.Red;
            this.textBoxNotifiedToDo.Location = new System.Drawing.Point(15, 432);
            this.textBoxNotifiedToDo.Name = "textBoxNotifiedToDo";
            this.textBoxNotifiedToDo.ReadOnly = true;
            this.textBoxNotifiedToDo.Size = new System.Drawing.Size(920, 39);
            this.textBoxNotifiedToDo.TabIndex = 30;
            this.textBoxNotifiedToDo.TabStop = false;
            this.textBoxNotifiedToDo.Text = "通知されたToDoがありません";
            this.textBoxNotifiedToDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(317, 209);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label15.Size = new System.Drawing.Size(140, 22);
            this.label15.TabIndex = 29;
            this.label15.Text = "TODO DETAIL";
            // 
            // textBoxToDoDetail
            // 
            this.textBoxToDoDetail.BackColor = System.Drawing.Color.Black;
            this.textBoxToDoDetail.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxToDoDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.textBoxToDoDetail.Location = new System.Drawing.Point(12, 158);
            this.textBoxToDoDetail.Name = "textBoxToDoDetail";
            this.textBoxToDoDetail.ReadOnly = true;
            this.textBoxToDoDetail.Size = new System.Drawing.Size(920, 39);
            this.textBoxToDoDetail.TabIndex = 28;
            this.textBoxToDoDetail.TabStop = false;
            this.textBoxToDoDetail.Text = "登録されているToDoがありません。";
            this.textBoxToDoDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonToDoSet
            // 
            this.buttonToDoSet.BackColor = System.Drawing.Color.Black;
            this.buttonToDoSet.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToDoSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonToDoSet.Location = new System.Drawing.Point(804, 72);
            this.buttonToDoSet.Name = "buttonToDoSet";
            this.buttonToDoSet.Size = new System.Drawing.Size(127, 40);
            this.buttonToDoSet.TabIndex = 26;
            this.buttonToDoSet.Text = "ToDo Set";
            this.buttonToDoSet.UseVisualStyleBackColor = false;
            this.buttonToDoSet.Click += new System.EventHandler(this.buttonToDoSet_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Maroon;
            this.label13.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(821, 263);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label13.Size = new System.Drawing.Size(90, 22);
            this.label13.TabIndex = 23;
            this.label13.Text = "SECOND";
            // 
            // textBoxPresentSecond
            // 
            this.textBoxPresentSecond.BackColor = System.Drawing.Color.Black;
            this.textBoxPresentSecond.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPresentSecond.ForeColor = System.Drawing.Color.Lime;
            this.textBoxPresentSecond.Location = new System.Drawing.Point(804, 288);
            this.textBoxPresentSecond.Name = "textBoxPresentSecond";
            this.textBoxPresentSecond.ReadOnly = true;
            this.textBoxPresentSecond.Size = new System.Drawing.Size(128, 71);
            this.textBoxPresentSecond.TabIndex = 22;
            this.textBoxPresentSecond.TabStop = false;
            this.textBoxPresentSecond.Text = "--";
            this.textBoxPresentSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(307, 372);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label12.Size = new System.Drawing.Size(150, 22);
            this.label12.TabIndex = 21;
            this.label12.Text = "PRESENT TIME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Maroon;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(235, 263);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "YEAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Maroon;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(405, 263);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label8.Size = new System.Drawing.Size(60, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "DAY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(543, 263);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "HOUR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Maroon;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(682, 263);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "MINUTE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Maroon;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(48, 263);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label11.Size = new System.Drawing.Size(80, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "MONTH";
            // 
            // textBoxPresentHour
            // 
            this.textBoxPresentHour.BackColor = System.Drawing.Color.Black;
            this.textBoxPresentHour.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPresentHour.ForeColor = System.Drawing.Color.Lime;
            this.textBoxPresentHour.Location = new System.Drawing.Point(515, 288);
            this.textBoxPresentHour.Name = "textBoxPresentHour";
            this.textBoxPresentHour.ReadOnly = true;
            this.textBoxPresentHour.Size = new System.Drawing.Size(128, 71);
            this.textBoxPresentHour.TabIndex = 15;
            this.textBoxPresentHour.TabStop = false;
            this.textBoxPresentHour.Text = "--";
            this.textBoxPresentHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPresentMinute
            // 
            this.textBoxPresentMinute.BackColor = System.Drawing.Color.Black;
            this.textBoxPresentMinute.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPresentMinute.ForeColor = System.Drawing.Color.Lime;
            this.textBoxPresentMinute.Location = new System.Drawing.Point(661, 288);
            this.textBoxPresentMinute.Name = "textBoxPresentMinute";
            this.textBoxPresentMinute.ReadOnly = true;
            this.textBoxPresentMinute.Size = new System.Drawing.Size(128, 71);
            this.textBoxPresentMinute.TabIndex = 14;
            this.textBoxPresentMinute.TabStop = false;
            this.textBoxPresentMinute.Text = "--";
            this.textBoxPresentMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPresentDay
            // 
            this.textBoxPresentDay.BackColor = System.Drawing.Color.Black;
            this.textBoxPresentDay.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPresentDay.ForeColor = System.Drawing.Color.Lime;
            this.textBoxPresentDay.Location = new System.Drawing.Point(377, 288);
            this.textBoxPresentDay.Name = "textBoxPresentDay";
            this.textBoxPresentDay.ReadOnly = true;
            this.textBoxPresentDay.Size = new System.Drawing.Size(116, 71);
            this.textBoxPresentDay.TabIndex = 13;
            this.textBoxPresentDay.TabStop = false;
            this.textBoxPresentDay.Text = "--";
            this.textBoxPresentDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPresentYear
            // 
            this.textBoxPresentYear.BackColor = System.Drawing.Color.Black;
            this.textBoxPresentYear.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPresentYear.ForeColor = System.Drawing.Color.Lime;
            this.textBoxPresentYear.Location = new System.Drawing.Point(176, 288);
            this.textBoxPresentYear.Name = "textBoxPresentYear";
            this.textBoxPresentYear.ReadOnly = true;
            this.textBoxPresentYear.Size = new System.Drawing.Size(195, 71);
            this.textBoxPresentYear.TabIndex = 12;
            this.textBoxPresentYear.TabStop = false;
            this.textBoxPresentYear.Text = "----";
            this.textBoxPresentYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPresentMonth
            // 
            this.textBoxPresentMonth.BackColor = System.Drawing.Color.Black;
            this.textBoxPresentMonth.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPresentMonth.ForeColor = System.Drawing.Color.Lime;
            this.textBoxPresentMonth.Location = new System.Drawing.Point(12, 288);
            this.textBoxPresentMonth.Name = "textBoxPresentMonth";
            this.textBoxPresentMonth.ReadOnly = true;
            this.textBoxPresentMonth.Size = new System.Drawing.Size(158, 71);
            this.textBoxPresentMonth.TabIndex = 11;
            this.textBoxPresentMonth.TabStop = false;
            this.textBoxPresentMonth.Text = "---";
            this.textBoxPresentMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(337, 125);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "TODO TIME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(235, 16);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "YEAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(405, 16);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "DAY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(543, 16);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "HOUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(682, 16);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "MINUTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "MONTH";
            // 
            // textBoxToDoHour
            // 
            this.textBoxToDoHour.BackColor = System.Drawing.Color.Black;
            this.textBoxToDoHour.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxToDoHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.textBoxToDoHour.Location = new System.Drawing.Point(515, 41);
            this.textBoxToDoHour.Name = "textBoxToDoHour";
            this.textBoxToDoHour.ReadOnly = true;
            this.textBoxToDoHour.Size = new System.Drawing.Size(128, 71);
            this.textBoxToDoHour.TabIndex = 4;
            this.textBoxToDoHour.TabStop = false;
            this.textBoxToDoHour.Text = "--";
            this.textBoxToDoHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxToDoMinute
            // 
            this.textBoxToDoMinute.BackColor = System.Drawing.Color.Black;
            this.textBoxToDoMinute.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxToDoMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.textBoxToDoMinute.Location = new System.Drawing.Point(661, 41);
            this.textBoxToDoMinute.Name = "textBoxToDoMinute";
            this.textBoxToDoMinute.ReadOnly = true;
            this.textBoxToDoMinute.Size = new System.Drawing.Size(128, 71);
            this.textBoxToDoMinute.TabIndex = 3;
            this.textBoxToDoMinute.TabStop = false;
            this.textBoxToDoMinute.Text = "--";
            this.textBoxToDoMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxToDoDay
            // 
            this.textBoxToDoDay.BackColor = System.Drawing.Color.Black;
            this.textBoxToDoDay.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxToDoDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.textBoxToDoDay.Location = new System.Drawing.Point(377, 41);
            this.textBoxToDoDay.Name = "textBoxToDoDay";
            this.textBoxToDoDay.ReadOnly = true;
            this.textBoxToDoDay.Size = new System.Drawing.Size(116, 71);
            this.textBoxToDoDay.TabIndex = 2;
            this.textBoxToDoDay.TabStop = false;
            this.textBoxToDoDay.Text = "--";
            this.textBoxToDoDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxToDoYear
            // 
            this.textBoxToDoYear.BackColor = System.Drawing.Color.Black;
            this.textBoxToDoYear.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxToDoYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.textBoxToDoYear.Location = new System.Drawing.Point(176, 41);
            this.textBoxToDoYear.Name = "textBoxToDoYear";
            this.textBoxToDoYear.ReadOnly = true;
            this.textBoxToDoYear.Size = new System.Drawing.Size(195, 71);
            this.textBoxToDoYear.TabIndex = 1;
            this.textBoxToDoYear.TabStop = false;
            this.textBoxToDoYear.Text = "----";
            this.textBoxToDoYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxToDoMonth
            // 
            this.textBoxToDoMonth.BackColor = System.Drawing.Color.Black;
            this.textBoxToDoMonth.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxToDoMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.textBoxToDoMonth.Location = new System.Drawing.Point(12, 41);
            this.textBoxToDoMonth.Name = "textBoxToDoMonth";
            this.textBoxToDoMonth.ReadOnly = true;
            this.textBoxToDoMonth.Size = new System.Drawing.Size(158, 71);
            this.textBoxToDoMonth.TabIndex = 0;
            this.textBoxToDoMonth.TabStop = false;
            this.textBoxToDoMonth.Text = "---";
            this.textBoxToDoMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPresentHM
            // 
            this.labelPresentHM.AutoSize = true;
            this.labelPresentHM.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPresentHM.ForeColor = System.Drawing.Color.Lime;
            this.labelPresentHM.Location = new System.Drawing.Point(636, 288);
            this.labelPresentHM.Margin = new System.Windows.Forms.Padding(0);
            this.labelPresentHM.Name = "labelPresentHM";
            this.labelPresentHM.Size = new System.Drawing.Size(41, 64);
            this.labelPresentHM.TabIndex = 24;
            this.labelPresentHM.Text = ":";
            this.labelPresentHM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPresentMS
            // 
            this.labelPresentMS.AutoSize = true;
            this.labelPresentMS.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPresentMS.ForeColor = System.Drawing.Color.Lime;
            this.labelPresentMS.Location = new System.Drawing.Point(780, 288);
            this.labelPresentMS.Margin = new System.Windows.Forms.Padding(0);
            this.labelPresentMS.Name = "labelPresentMS";
            this.labelPresentMS.Size = new System.Drawing.Size(41, 64);
            this.labelPresentMS.TabIndex = 25;
            this.labelPresentMS.Text = ":";
            this.labelPresentMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(636, 41);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 64);
            this.label14.TabIndex = 27;
            this.label14.Text = ":";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerGetPresent
            // 
            this.timerGetPresent.Enabled = true;
            this.timerGetPresent.Interval = 500;
            this.timerGetPresent.Tick += new System.EventHandler(this.timerGetPresent_Tick);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 525);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainPanel";
            this.Text = "BackToDoTheFuture - TODO App.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPanel_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxToDoHour;
        private System.Windows.Forms.TextBox textBoxToDoMinute;
        private System.Windows.Forms.TextBox textBoxToDoDay;
        private System.Windows.Forms.TextBox textBoxToDoYear;
        private System.Windows.Forms.TextBox textBoxToDoMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonToDoSet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxPresentSecond;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPresentHour;
        private System.Windows.Forms.TextBox textBoxPresentMinute;
        private System.Windows.Forms.TextBox textBoxPresentDay;
        private System.Windows.Forms.TextBox textBoxPresentYear;
        private System.Windows.Forms.TextBox textBoxPresentMonth;
        private System.Windows.Forms.Label labelPresentHM;
        private System.Windows.Forms.Label labelPresentMS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timerGetPresent;
        private System.Windows.Forms.TextBox textBoxToDoDetail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxNotifiedToDo;
        private System.Windows.Forms.Button buttonBlinkStop;
    }
}

