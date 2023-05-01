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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_variable = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_command_generiren = new System.Windows.Forms.Button();
            this.lbl_speicherpath = new System.Windows.Forms.Label();
            this.btn_speicherort = new System.Windows.Forms.Button();
            this.tb_link = new System.Windows.Forms.TextBox();
            this.lbl_path = new System.Windows.Forms.Label();
            this.btn_file = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_c);
            this.groupBox1.Controls.Add(this.btn_variable);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 179);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FFMPEG Installieren";
            // 
            // btn_c
            // 
            this.btn_c.BackColor = System.Drawing.Color.Red;
            this.btn_c.Location = new System.Drawing.Point(307, 118);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(119, 29);
            this.btn_c.TabIndex = 10;
            this.btn_c.Text = "Hinzufügen";
            this.btn_c.UseVisualStyleBackColor = false;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_variable
            // 
            this.btn_variable.BackColor = System.Drawing.Color.Red;
            this.btn_variable.Location = new System.Drawing.Point(307, 71);
            this.btn_variable.Name = "btn_variable";
            this.btn_variable.Size = new System.Drawing.Size(119, 29);
            this.btn_variable.TabIndex = 9;
            this.btn_variable.Text = "Hinzufügen";
            this.btn_variable.UseVisualStyleBackColor = false;
            this.btn_variable.Click += new System.EventHandler(this.btn_variable_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hinzufügen von FFMPEG in den C Ordner";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hinzufügen von FFMPEG zu dem Systemvariablen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(508, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Für dieses Programm wird FFMPEG benötigt dafür würde das Programm dies gerne inst" +
    "allieren ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_command_generiren);
            this.groupBox2.Controls.Add(this.lbl_speicherpath);
            this.groupBox2.Controls.Add(this.btn_speicherort);
            this.groupBox2.Controls.Add(this.tb_link);
            this.groupBox2.Controls.Add(this.lbl_path);
            this.groupBox2.Controls.Add(this.btn_file);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 310);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download Link Erstellen";
            // 
            // btn_command_generiren
            // 
            this.btn_command_generiren.Location = new System.Drawing.Point(17, 212);
            this.btn_command_generiren.Name = "btn_command_generiren";
            this.btn_command_generiren.Size = new System.Drawing.Size(809, 84);
            this.btn_command_generiren.TabIndex = 16;
            this.btn_command_generiren.Text = "Downloaden";
            this.btn_command_generiren.UseVisualStyleBackColor = true;
            this.btn_command_generiren.Click += new System.EventHandler(this.btn_command_generiren_Click);
            // 
            // lbl_speicherpath
            // 
            this.lbl_speicherpath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_speicherpath.Location = new System.Drawing.Point(213, 72);
            this.lbl_speicherpath.Name = "lbl_speicherpath";
            this.lbl_speicherpath.Size = new System.Drawing.Size(613, 21);
            this.lbl_speicherpath.TabIndex = 15;
            this.lbl_speicherpath.Text = "Path";
            // 
            // btn_speicherort
            // 
            this.btn_speicherort.Location = new System.Drawing.Point(17, 64);
            this.btn_speicherort.Name = "btn_speicherort";
            this.btn_speicherort.Size = new System.Drawing.Size(190, 31);
            this.btn_speicherort.TabIndex = 14;
            this.btn_speicherort.Text = "Speicherort aussuchen";
            this.btn_speicherort.UseVisualStyleBackColor = true;
            this.btn_speicherort.Click += new System.EventHandler(this.btn_speicherort_Click);
            // 
            // tb_link
            // 
            this.tb_link.Location = new System.Drawing.Point(160, 35);
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(670, 23);
            this.tb_link.TabIndex = 13;
            this.tb_link.TextChanged += new System.EventHandler(this.tb_link_TextChanged);
            // 
            // lbl_path
            // 
            this.lbl_path.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_path.Location = new System.Drawing.Point(375, 173);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(447, 21);
            this.lbl_path.TabIndex = 12;
            this.lbl_path.Text = "Path";
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(250, 166);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(119, 28);
            this.btn_file.TabIndex = 11;
            this.btn_file.Text = "Datei aussuchen";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Oder txt Datei mit mehrern Links angeben:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bitte VOE Link angeben:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 355);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 684);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 385);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}