namespace projectMessenger
{
    partial class home
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.msglisttextbox = new System.Windows.Forms.TextBox();
            this.startbtn = new System.Windows.Forms.Button();
            this.sendbtn = new System.Windows.Forms.Button();
            this.msgtextbox = new System.Windows.Forms.TextBox();
            this.connectbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.port2textbox = new System.Windows.Forms.TextBox();
            this.ip2textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.port1textbox = new System.Windows.Forms.TextBox();
            this.ip1textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(563, 341);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.msglisttextbox);
            this.tabPage3.Controls.Add(this.startbtn);
            this.tabPage3.Controls.Add(this.sendbtn);
            this.tabPage3.Controls.Add(this.msgtextbox);
            this.tabPage3.Controls.Add(this.connectbtn);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(555, 315);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Message";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // msglisttextbox
            // 
            this.msglisttextbox.Location = new System.Drawing.Point(20, 160);
            this.msglisttextbox.Multiline = true;
            this.msglisttextbox.Name = "msglisttextbox";
            this.msglisttextbox.Size = new System.Drawing.Size(520, 102);
            this.msglisttextbox.TabIndex = 7;
            this.msglisttextbox.TextChanged += new System.EventHandler(this.msglisttextbox_TextChanged);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(107, 131);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 6;
            this.startbtn.Text = "start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(392, 268);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 23);
            this.sendbtn.TabIndex = 5;
            this.sendbtn.Text = "send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // msgtextbox
            // 
            this.msgtextbox.Location = new System.Drawing.Point(39, 268);
            this.msgtextbox.Name = "msgtextbox";
            this.msgtextbox.Size = new System.Drawing.Size(332, 23);
            this.msgtextbox.TabIndex = 4;
            this.msgtextbox.TextChanged += new System.EventHandler(this.msgtextbox_TextChanged);
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(367, 131);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(75, 23);
            this.connectbtn.TabIndex = 2;
            this.connectbtn.Text = "connect";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.port2textbox);
            this.groupBox2.Controls.Add(this.ip2textbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(326, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "client";
            // 
            // port2textbox
            // 
            this.port2textbox.Location = new System.Drawing.Point(41, 57);
            this.port2textbox.Name = "port2textbox";
            this.port2textbox.Size = new System.Drawing.Size(100, 23);
            this.port2textbox.TabIndex = 5;
            this.port2textbox.TextChanged += new System.EventHandler(this.port2textbox_TextChanged);
            // 
            // ip2textbox
            // 
            this.ip2textbox.Location = new System.Drawing.Point(41, 23);
            this.ip2textbox.Name = "ip2textbox";
            this.ip2textbox.Size = new System.Drawing.Size(100, 23);
            this.ip2textbox.TabIndex = 4;
            this.ip2textbox.TextChanged += new System.EventHandler(this.ip2textbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.port1textbox);
            this.groupBox1.Controls.Add(this.ip1textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(39, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "server";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // port1textbox
            // 
            this.port1textbox.Location = new System.Drawing.Point(43, 54);
            this.port1textbox.Name = "port1textbox";
            this.port1textbox.Size = new System.Drawing.Size(100, 23);
            this.port1textbox.TabIndex = 3;
            this.port1textbox.TextChanged += new System.EventHandler(this.port1textbox_TextChanged);
            // 
            // ip1textbox
            // 
            this.ip1textbox.Location = new System.Drawing.Point(43, 23);
            this.ip1textbox.Name = "ip1textbox";
            this.ip1textbox.Size = new System.Drawing.Size(100, 23);
            this.ip1textbox.TabIndex = 2;
            this.ip1textbox.TextChanged += new System.EventHandler(this.ip1textbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GrayText;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.Location = new System.Drawing.Point(581, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 55);
            this.button6.TabIndex = 8;
            this.button6.Text = "Send / Receive files";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Boopee", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desktop Messenger and sharefile";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(836, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tabControl2);
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load_1);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox port2textbox;
        private System.Windows.Forms.TextBox ip2textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox port1textbox;
        private System.Windows.Forms.TextBox ip1textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.TextBox msgtextbox;
        private System.Windows.Forms.Button startbtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox msglisttextbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;

    }
}