
namespace SimplePhotoDiary.Presentation_Layer
{
    partial class EventActions
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
            this.EventNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AEventB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImportanceBox = new System.Windows.Forms.ComboBox();
            this.CreationDateBox = new System.Windows.Forms.DateTimePicker();
            this.Upd_Importance = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Upd_EventName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Upd_EventID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Del_EventID = new System.Windows.Forms.TextBox();
            this.eventListView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.GoEventID = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventListView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventNameBox
            // 
            this.EventNameBox.Location = new System.Drawing.Point(146, 62);
            this.EventNameBox.Name = "EventNameBox";
            this.EventNameBox.Size = new System.Drawing.Size(179, 27);
            this.EventNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Name";
            // 
            // AEventB
            // 
            this.AEventB.Location = new System.Drawing.Point(114, 238);
            this.AEventB.Name = "AEventB";
            this.AEventB.Size = new System.Drawing.Size(106, 37);
            this.AEventB.TabIndex = 2;
            this.AEventB.Text = "Add";
            this.AEventB.UseVisualStyleBackColor = true;
            this.AEventB.Click += new System.EventHandler(this.AEventB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Creation Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Importance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 5;
            // 
            // ImportanceBox
            // 
            this.ImportanceBox.FormattingEnabled = true;
            this.ImportanceBox.Items.AddRange(new object[] {
            "Highly Important",
            "Moderately Important",
            "Less Important"});
            this.ImportanceBox.Location = new System.Drawing.Point(146, 123);
            this.ImportanceBox.Name = "ImportanceBox";
            this.ImportanceBox.Size = new System.Drawing.Size(179, 26);
            this.ImportanceBox.TabIndex = 6;
            // 
            // CreationDateBox
            // 
            this.CreationDateBox.Location = new System.Drawing.Point(146, 182);
            this.CreationDateBox.Name = "CreationDateBox";
            this.CreationDateBox.Size = new System.Drawing.Size(179, 27);
            this.CreationDateBox.TabIndex = 7;
            // 
            // Upd_Importance
            // 
            this.Upd_Importance.FormattingEnabled = true;
            this.Upd_Importance.Items.AddRange(new object[] {
            "Highly Important",
            "Moderately Important",
            "Less Important"});
            this.Upd_Importance.Location = new System.Drawing.Point(582, 186);
            this.Upd_Importance.Name = "Upd_Importance";
            this.Upd_Importance.Size = new System.Drawing.Size(179, 26);
            this.Upd_Importance.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(720, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Importance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Event Name";
            // 
            // Upd_EventName
            // 
            this.Upd_EventName.Location = new System.Drawing.Point(582, 135);
            this.Upd_EventName.Name = "Upd_EventName";
            this.Upd_EventName.Size = new System.Drawing.Size(179, 27);
            this.Upd_EventName.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Event Id";
            // 
            // Upd_EventID
            // 
            this.Upd_EventID.Location = new System.Drawing.Point(584, 74);
            this.Upd_EventID.Name = "Upd_EventID";
            this.Upd_EventID.Size = new System.Drawing.Size(179, 27);
            this.Upd_EventID.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 25);
            this.button2.TabIndex = 18;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Enter Event Id To Delete";
            // 
            // Del_EventID
            // 
            this.Del_EventID.Location = new System.Drawing.Point(80, 122);
            this.Del_EventID.Name = "Del_EventID";
            this.Del_EventID.Size = new System.Drawing.Size(209, 27);
            this.Del_EventID.TabIndex = 19;
            // 
            // eventListView
            // 
            this.eventListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventListView.Location = new System.Drawing.Point(29, 340);
            this.eventListView.Name = "eventListView";
            this.eventListView.RowHeadersWidth = 51;
            this.eventListView.RowTemplate.Height = 24;
            this.eventListView.Size = new System.Drawing.Size(546, 271);
            this.eventListView.TabIndex = 22;
            this.eventListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventListView_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 25);
            this.button3.TabIndex = 25;
            this.button3.Text = "Go";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(305, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Enter Event Id To Go To That Event";
            // 
            // GoEventID
            // 
            this.GoEventID.Location = new System.Drawing.Point(80, 87);
            this.GoEventID.Name = "GoEventID";
            this.GoEventID.Size = new System.Drawing.Size(179, 27);
            this.GoEventID.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 37);
            this.button4.TabIndex = 26;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(139, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 37);
            this.button5.TabIndex = 27;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(104, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Add Event";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(138, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Update Event";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(107, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "Delete Event";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.EventNameBox);
            this.groupBox1.Controls.Add(this.ImportanceBox);
            this.groupBox1.Controls.Add(this.CreationDateBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AEventB);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 295);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(437, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 295);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.Del_EventID);
            this.groupBox3.Location = new System.Drawing.Point(943, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 295);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.GoEventID);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(943, 383);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(361, 228);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(638, 558);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(263, 53);
            this.Logout.TabIndex = 35;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // EventActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 668);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.eventListView);
            this.Controls.Add(this.Upd_EventID);
            this.Controls.Add(this.Upd_Importance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Upd_EventName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EventActions";
            this.Text = "EventActions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventActions1_FormClosing);
            this.Load += new System.EventHandler(this.EventActions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventListView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EventNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AEventB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ImportanceBox;
        private System.Windows.Forms.DateTimePicker CreationDateBox;
        private System.Windows.Forms.ComboBox Upd_Importance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Upd_EventName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Upd_EventID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Del_EventID;
        private System.Windows.Forms.DataGridView eventListView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox GoEventID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Logout;
    }
}