namespace FFmpeg_Downloader
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btn_c = new Button();
            btn_variable = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btn_command_generiren = new Button();
            lbl_speicherpath = new Label();
            btn_speicherort = new Button();
            tb_link = new TextBox();
            lbl_path = new Label();
            btn_file = new Button();
            label7 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label9 = new Label();
            tabPage4 = new TabPage();
            textBox3 = new TextBox();
            label12 = new Label();
            button3 = new Button();
            label8 = new Label();
            button4 = new Button();
            label10 = new Label();
            button5 = new Button();
            label11 = new Label();
            tabPage5 = new TabPage();
            textBox4 = new TextBox();
            label13 = new Label();
            button6 = new Button();
            label14 = new Label();
            button7 = new Button();
            label15 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_c);
            groupBox1.Controls.Add(btn_variable);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(7, 8);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(631, 239);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "FFMPEG Installieren";
            // 
            // btn_c
            // 
            btn_c.BackColor = Color.Red;
            btn_c.Location = new Point(351, 157);
            btn_c.Margin = new Padding(3, 4, 3, 4);
            btn_c.Name = "btn_c";
            btn_c.Size = new Size(136, 39);
            btn_c.TabIndex = 10;
            btn_c.Text = "Hinzufügen";
            btn_c.UseVisualStyleBackColor = false;
            btn_c.Click += btn_c_Click;
            // 
            // btn_variable
            // 
            btn_variable.BackColor = Color.Red;
            btn_variable.Location = new Point(351, 95);
            btn_variable.Margin = new Padding(3, 4, 3, 4);
            btn_variable.Name = "btn_variable";
            btn_variable.Size = new Size(136, 39);
            btn_variable.TabIndex = 9;
            btn_variable.Text = "Hinzufügen";
            btn_variable.UseVisualStyleBackColor = false;
            btn_variable.Click += btn_variable_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 167);
            label6.Name = "label6";
            label6.Size = new Size(278, 20);
            label6.TabIndex = 8;
            label6.Text = "Hinzufügen von FFMPEG in den C Ordner";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 104);
            label5.Name = "label5";
            label5.Size = new Size(335, 20);
            label5.TabIndex = 7;
            label5.Text = "Hinzufügen von FFMPEG zu dem Systemvariablen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 48);
            label4.Name = "label4";
            label4.Size = new Size(637, 20);
            label4.TabIndex = 6;
            label4.Text = "Für dieses Programm wird FFMPEG benötigt dafür würde das Programm dies gerne installieren ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_command_generiren);
            groupBox2.Controls.Add(lbl_speicherpath);
            groupBox2.Controls.Add(btn_speicherort);
            groupBox2.Controls.Add(tb_link);
            groupBox2.Controls.Add(lbl_path);
            groupBox2.Controls.Add(btn_file);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(3, 8);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(961, 413);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Download Link Erstellen";
            // 
            // btn_command_generiren
            // 
            btn_command_generiren.Location = new Point(19, 283);
            btn_command_generiren.Margin = new Padding(3, 4, 3, 4);
            btn_command_generiren.Name = "btn_command_generiren";
            btn_command_generiren.Size = new Size(925, 112);
            btn_command_generiren.TabIndex = 16;
            btn_command_generiren.Text = "Downloaden";
            btn_command_generiren.UseVisualStyleBackColor = true;
            btn_command_generiren.Click += btn_command_generiren_Click;
            // 
            // lbl_speicherpath
            // 
            lbl_speicherpath.BackColor = SystemColors.ButtonHighlight;
            lbl_speicherpath.Location = new Point(243, 96);
            lbl_speicherpath.Name = "lbl_speicherpath";
            lbl_speicherpath.Size = new Size(701, 28);
            lbl_speicherpath.TabIndex = 15;
            lbl_speicherpath.Text = "Path";
            lbl_speicherpath.Click += lbl_speicherpath_Click;
            // 
            // btn_speicherort
            // 
            btn_speicherort.Location = new Point(19, 85);
            btn_speicherort.Margin = new Padding(3, 4, 3, 4);
            btn_speicherort.Name = "btn_speicherort";
            btn_speicherort.Size = new Size(217, 41);
            btn_speicherort.TabIndex = 14;
            btn_speicherort.Text = "Speicherort aussuchen";
            btn_speicherort.UseVisualStyleBackColor = true;
            btn_speicherort.Click += btn_speicherort_Click;
            // 
            // tb_link
            // 
            tb_link.Location = new Point(183, 47);
            tb_link.Margin = new Padding(3, 4, 3, 4);
            tb_link.Name = "tb_link";
            tb_link.Size = new Size(765, 27);
            tb_link.TabIndex = 13;
            tb_link.TextChanged += tb_link_TextChanged;
            // 
            // lbl_path
            // 
            lbl_path.BackColor = SystemColors.ButtonHighlight;
            lbl_path.Location = new Point(429, 231);
            lbl_path.Name = "lbl_path";
            lbl_path.Size = new Size(511, 28);
            lbl_path.TabIndex = 12;
            lbl_path.Text = "Path";
            // 
            // btn_file
            // 
            btn_file.Location = new Point(286, 221);
            btn_file.Margin = new Padding(3, 4, 3, 4);
            btn_file.Name = "btn_file";
            btn_file.Size = new Size(136, 37);
            btn_file.TabIndex = 11;
            btn_file.Text = "Datei aussuchen";
            btn_file.UseVisualStyleBackColor = true;
            btn_file.Click += btn_file_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 231);
            label7.Name = "label7";
            label7.Size = new Size(289, 20);
            label7.TabIndex = 10;
            label7.Text = "Oder txt Datei mit mehrern Links angeben:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 51);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 9;
            label2.Text = "Bitte VOE Link angeben:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(14, 16);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(994, 473);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(986, 440);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(986, 440);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(986, 440);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(13, 11);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(961, 413);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Download Link Erstellen";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(7, 135);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(765, 27);
            textBox2.TabIndex = 20;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 111);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 19;
            label3.Text = "Namen";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(231, 213);
            label1.Name = "label1";
            label1.Size = new Size(701, 28);
            label1.TabIndex = 18;
            label1.Text = "Path";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(7, 203);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(217, 41);
            button2.TabIndex = 17;
            button2.Text = "Speicherort aussuchen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(7, 268);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(925, 112);
            button1.TabIndex = 16;
            button1.Text = "Downloaden";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 64);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(765, 27);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 25);
            label9.Name = "label9";
            label9.Size = new Size(208, 20);
            label9.TabIndex = 9;
            label9.Text = "Bitte Download Link angeben:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(textBox3);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(label11);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(986, 440);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(33, 132);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(765, 27);
            textBox3.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 108);
            label12.Name = "label12";
            label12.Size = new Size(57, 20);
            label12.TabIndex = 23;
            label12.Text = "Namen";
            // 
            // button3
            // 
            button3.Location = new Point(33, 260);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(925, 112);
            button3.TabIndex = 22;
            button3.Text = "Downloaden";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(257, 73);
            label8.Name = "label8";
            label8.Size = new Size(701, 28);
            label8.TabIndex = 21;
            label8.Text = "Path";
            // 
            // button4
            // 
            button4.Location = new Point(33, 63);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(217, 41);
            button4.TabIndex = 20;
            button4.Text = "Speicherort aussuchen";
            button4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(442, 208);
            label10.Name = "label10";
            label10.Size = new Size(511, 28);
            label10.TabIndex = 19;
            label10.Text = "Path";
            // 
            // button5
            // 
            button5.Location = new Point(299, 199);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(136, 37);
            button5.TabIndex = 18;
            button5.Text = "Datei aussuchen";
            button5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 208);
            label11.Name = "label11";
            label11.Size = new Size(289, 20);
            label11.TabIndex = 17;
            label11.Text = "Oder txt Datei mit mehrern Links angeben:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(textBox4);
            tabPage5.Controls.Add(label13);
            tabPage5.Controls.Add(button6);
            tabPage5.Controls.Add(label14);
            tabPage5.Controls.Add(button7);
            tabPage5.Controls.Add(label15);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(986, 440);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            tabPage5.Click += tabPage5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(33, 83);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(765, 27);
            textBox4.TabIndex = 30;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 59);
            label13.Name = "label13";
            label13.Size = new Size(99, 20);
            label13.TabIndex = 29;
            label13.Text = "Aniworld Link";
            // 
            // button6
            // 
            button6.Location = new Point(33, 262);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(925, 112);
            button6.TabIndex = 28;
            button6.Text = "Get Links";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label14
            // 
            label14.BackColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(175, 208);
            label14.Name = "label14";
            label14.Size = new Size(511, 28);
            label14.TabIndex = 27;
            label14.Text = "Path";
            label14.Click += label14_Click;
            // 
            // button7
            // 
            button7.Location = new Point(33, 199);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(136, 37);
            button7.TabIndex = 26;
            button7.Text = "Datei aussuchen";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(29, 159);
            label15.Name = "label15";
            label15.Size = new Size(88, 20);
            label15.TabIndex = 25;
            label15.Text = "Speicherort:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 513);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_c;
        private Button btn_variable;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox tb_link;
        private Label lbl_path;
        private Button btn_file;
        private Label label7;
        private Label label2;
        private Label lbl_speicherpath;
        private Button btn_speicherort;
        private Button btn_command_generiren;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox3;
        private Button button1;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox2;
        private Label label3;
        private Label label1;
        private Button button2;
        private TabPage tabPage4;
        private TextBox textBox3;
        private Label label12;
        private Button button3;
        private Label label8;
        private Button button4;
        private Label label10;
        private Button button5;
        private Label label11;
        private TabPage tabPage5;
        private TextBox textBox4;
        private Label label13;
        private Button button6;
        private Label label14;
        private Button button7;
        private Label label15;
    }
}