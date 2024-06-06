namespace SQLBkpandRestore
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chklistboxDb = new System.Windows.Forms.CheckedListBox();
            this.chklistboxlogin = new System.Windows.Forms.CheckedListBox();
            this.chklistboxRestore = new System.Windows.Forms.CheckedListBox();
            this.btnrestoreclr = new System.Windows.Forms.Button();
            this.btnConn = new System.Windows.Forms.Button();
            this.btnhostall = new System.Windows.Forms.Button();
            this.btnhostclr = new System.Windows.Forms.Button();
            this.btnrestoreall = new System.Windows.Forms.Button();
            this.btnloginclr = new System.Windows.Forms.Button();
            this.btnloginall = new System.Windows.Forms.Button();
            this.txtremotesa = new System.Windows.Forms.TextBox();
            this.txtremotename = new System.Windows.Forms.TextBox();
            this.txthostsa = new System.Windows.Forms.TextBox();
            this.txthostpwd = new System.Windows.Forms.TextBox();
            this.txthostname = new System.Windows.Forms.TextBox();
            this.txtremotepwd = new System.Windows.Forms.TextBox();
            this.btnStartRestore = new System.Windows.Forms.Button();
            this.btnSelectRes = new System.Windows.Forms.Button();
            this.btnTransferLogin = new System.Windows.Forms.Button();
            this.chkhostpwd = new System.Windows.Forms.CheckBox();
            this.chkremotepwd = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnWindows = new System.Windows.Forms.Button();
            this.btnLinux = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chklistboxDb
            // 
            this.chklistboxDb.FormattingEnabled = true;
            this.chklistboxDb.Location = new System.Drawing.Point(432, 305);
            this.chklistboxDb.Name = "chklistboxDb";
            this.chklistboxDb.Size = new System.Drawing.Size(289, 559);
            this.chklistboxDb.TabIndex = 0;
            // 
            // chklistboxlogin
            // 
            this.chklistboxlogin.FormattingEnabled = true;
            this.chklistboxlogin.Location = new System.Drawing.Point(1191, 305);
            this.chklistboxlogin.Name = "chklistboxlogin";
            this.chklistboxlogin.Size = new System.Drawing.Size(289, 559);
            this.chklistboxlogin.TabIndex = 1;
            // 
            // chklistboxRestore
            // 
            this.chklistboxRestore.FormattingEnabled = true;
            this.chklistboxRestore.Location = new System.Drawing.Point(1514, 305);
            this.chklistboxRestore.Name = "chklistboxRestore";
            this.chklistboxRestore.Size = new System.Drawing.Size(289, 559);
            this.chklistboxRestore.TabIndex = 2;
            // 
            // btnrestoreclr
            // 
            this.btnrestoreclr.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnrestoreclr.Location = new System.Drawing.Point(1728, 879);
            this.btnrestoreclr.Name = "btnrestoreclr";
            this.btnrestoreclr.Size = new System.Drawing.Size(75, 32);
            this.btnrestoreclr.TabIndex = 3;
            this.btnrestoreclr.Text = "Clear";
            this.btnrestoreclr.UseVisualStyleBackColor = true;
            this.btnrestoreclr.Click += new System.EventHandler(this.btnrestoreclr_Click);
            // 
            // btnConn
            // 
            this.btnConn.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConn.Location = new System.Drawing.Point(17, 274);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(240, 30);
            this.btnConn.TabIndex = 4;
            this.btnConn.Text = "Connect SQL Server";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnhostall
            // 
            this.btnhostall.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhostall.Location = new System.Drawing.Point(432, 879);
            this.btnhostall.Name = "btnhostall";
            this.btnhostall.Size = new System.Drawing.Size(139, 32);
            this.btnhostall.TabIndex = 5;
            this.btnhostall.Text = "Select All Database";
            this.btnhostall.UseVisualStyleBackColor = true;
            this.btnhostall.Click += new System.EventHandler(this.btnhostall_Click);
            // 
            // btnhostclr
            // 
            this.btnhostclr.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnhostclr.Location = new System.Drawing.Point(646, 881);
            this.btnhostclr.Name = "btnhostclr";
            this.btnhostclr.Size = new System.Drawing.Size(75, 32);
            this.btnhostclr.TabIndex = 6;
            this.btnhostclr.Text = "Clear";
            this.btnhostclr.UseVisualStyleBackColor = true;
            this.btnhostclr.Click += new System.EventHandler(this.btnhostclr_Click);
            // 
            // btnrestoreall
            // 
            this.btnrestoreall.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnrestoreall.Location = new System.Drawing.Point(1514, 879);
            this.btnrestoreall.Name = "btnrestoreall";
            this.btnrestoreall.Size = new System.Drawing.Size(140, 32);
            this.btnrestoreall.TabIndex = 7;
            this.btnrestoreall.Text = "Select All Database";
            this.btnrestoreall.UseVisualStyleBackColor = true;
            this.btnrestoreall.Click += new System.EventHandler(this.btnrestoreall_Click);
            // 
            // btnloginclr
            // 
            this.btnloginclr.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnloginclr.Location = new System.Drawing.Point(1405, 879);
            this.btnloginclr.Name = "btnloginclr";
            this.btnloginclr.Size = new System.Drawing.Size(75, 32);
            this.btnloginclr.TabIndex = 8;
            this.btnloginclr.Text = "Clear";
            this.btnloginclr.UseVisualStyleBackColor = true;
            this.btnloginclr.Click += new System.EventHandler(this.btnloginclr_Click);
            // 
            // btnloginall
            // 
            this.btnloginall.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnloginall.Location = new System.Drawing.Point(1191, 880);
            this.btnloginall.Name = "btnloginall";
            this.btnloginall.Size = new System.Drawing.Size(140, 32);
            this.btnloginall.TabIndex = 9;
            this.btnloginall.Text = "Select All Logins";
            this.btnloginall.UseVisualStyleBackColor = true;
            this.btnloginall.Click += new System.EventHandler(this.btnloginall_Click);
            // 
            // txtremotesa
            // 
            this.txtremotesa.Location = new System.Drawing.Point(20, 206);
            this.txtremotesa.Name = "txtremotesa";
            this.txtremotesa.Size = new System.Drawing.Size(55, 20);
            this.txtremotesa.TabIndex = 11;
            // 
            // txtremotename
            // 
            this.txtremotename.Location = new System.Drawing.Point(20, 175);
            this.txtremotename.Name = "txtremotename";
            this.txtremotename.Size = new System.Drawing.Size(240, 20);
            this.txtremotename.TabIndex = 12;
            this.txtremotename.Enter += new System.EventHandler(this.txtremotename_Enter);
            this.txtremotename.Leave += new System.EventHandler(this.txtremotename_Leave);
            // 
            // txthostsa
            // 
            this.txthostsa.Location = new System.Drawing.Point(17, 206);
            this.txthostsa.Name = "txthostsa";
            this.txthostsa.Size = new System.Drawing.Size(55, 20);
            this.txthostsa.TabIndex = 13;
            // 
            // txthostpwd
            // 
            this.txthostpwd.Location = new System.Drawing.Point(78, 206);
            this.txthostpwd.Name = "txthostpwd";
            this.txthostpwd.Size = new System.Drawing.Size(179, 20);
            this.txthostpwd.TabIndex = 14;
            this.txthostpwd.Enter += new System.EventHandler(this.txthostpwd_Enter);
            this.txthostpwd.Leave += new System.EventHandler(this.txthostpwd_Leave);
            // 
            // txthostname
            // 
            this.txthostname.Location = new System.Drawing.Point(17, 175);
            this.txthostname.Name = "txthostname";
            this.txthostname.Size = new System.Drawing.Size(240, 20);
            this.txthostname.TabIndex = 15;
            this.txthostname.Enter += new System.EventHandler(this.txthostname_Enter);
            this.txthostname.Leave += new System.EventHandler(this.txthostname_Leave);
            // 
            // txtremotepwd
            // 
            this.txtremotepwd.Location = new System.Drawing.Point(81, 206);
            this.txtremotepwd.Name = "txtremotepwd";
            this.txtremotepwd.Size = new System.Drawing.Size(179, 20);
            this.txtremotepwd.TabIndex = 16;
            this.txtremotepwd.Enter += new System.EventHandler(this.txtremotepwd_Enter);
            this.txtremotepwd.Leave += new System.EventHandler(this.txtremotepwd_Leave);
            // 
            // btnStartRestore
            // 
            this.btnStartRestore.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRestore.Location = new System.Drawing.Point(20, 315);
            this.btnStartRestore.Name = "btnStartRestore";
            this.btnStartRestore.Size = new System.Drawing.Size(240, 30);
            this.btnStartRestore.TabIndex = 18;
            this.btnStartRestore.Text = "Start Database Restore";
            this.btnStartRestore.UseVisualStyleBackColor = true;
            this.btnStartRestore.Click += new System.EventHandler(this.btnStartRestore_Click);
            // 
            // btnSelectRes
            // 
            this.btnSelectRes.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRes.Location = new System.Drawing.Point(20, 274);
            this.btnSelectRes.Name = "btnSelectRes";
            this.btnSelectRes.Size = new System.Drawing.Size(117, 30);
            this.btnSelectRes.TabIndex = 19;
            this.btnSelectRes.Text = "Choose Database";
            this.btnSelectRes.UseVisualStyleBackColor = true;
            this.btnSelectRes.Click += new System.EventHandler(this.btnSelectRes_Click);
            // 
            // btnTransferLogin
            // 
            this.btnTransferLogin.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferLogin.Location = new System.Drawing.Point(141, 274);
            this.btnTransferLogin.Name = "btnTransferLogin";
            this.btnTransferLogin.Size = new System.Drawing.Size(117, 30);
            this.btnTransferLogin.TabIndex = 20;
            this.btnTransferLogin.Text = "Start Login Transfer";
            this.btnTransferLogin.UseVisualStyleBackColor = true;
            this.btnTransferLogin.Click += new System.EventHandler(this.btnTransferLogin_Click);
            // 
            // chkhostpwd
            // 
            this.chkhostpwd.AutoSize = true;
            this.chkhostpwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkhostpwd.BackgroundImage")));
            this.chkhostpwd.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.chkhostpwd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkhostpwd.Location = new System.Drawing.Point(150, 241);
            this.chkhostpwd.Name = "chkhostpwd";
            this.chkhostpwd.Size = new System.Drawing.Size(107, 18);
            this.chkhostpwd.TabIndex = 21;
            this.chkhostpwd.Text = "Show Password";
            this.chkhostpwd.UseVisualStyleBackColor = true;
            this.chkhostpwd.CheckedChanged += new System.EventHandler(this.chkhostpwd_CheckedChanged);
            // 
            // chkremotepwd
            // 
            this.chkremotepwd.AutoSize = true;
            this.chkremotepwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkremotepwd.BackgroundImage")));
            this.chkremotepwd.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.chkremotepwd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkremotepwd.Location = new System.Drawing.Point(153, 241);
            this.chkremotepwd.Name = "chkremotepwd";
            this.chkremotepwd.Size = new System.Drawing.Size(107, 18);
            this.chkremotepwd.TabIndex = 22;
            this.chkremotepwd.Text = "Show Password";
            this.chkremotepwd.UseVisualStyleBackColor = true;
            this.chkremotepwd.CheckedChanged += new System.EventHandler(this.chkremotepwd_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chkremotepwd);
            this.panel1.Controls.Add(this.btnSelectRes);
            this.panel1.Controls.Add(this.btnTransferLogin);
            this.panel1.Controls.Add(this.btnStartRestore);
            this.panel1.Controls.Add(this.txtremotesa);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtremotepwd);
            this.panel1.Controls.Add(this.txtremotename);
            this.panel1.Location = new System.Drawing.Point(881, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 384);
            this.panel1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(47, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Remote Host";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnWindows);
            this.panel2.Controls.Add(this.btnLinux);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txthostname);
            this.panel2.Controls.Add(this.btnConn);
            this.panel2.Controls.Add(this.chkhostpwd);
            this.panel2.Controls.Add(this.txthostpwd);
            this.panel2.Controls.Add(this.txthostsa);
            this.panel2.Location = new System.Drawing.Point(119, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 384);
            this.panel2.TabIndex = 23;
            // 
            // btnWindows
            // 
            this.btnWindows.Font = new System.Drawing.Font("Gadugi", 7F, System.Drawing.FontStyle.Bold);
            this.btnWindows.Location = new System.Drawing.Point(140, 315);
            this.btnWindows.Name = "btnWindows";
            this.btnWindows.Size = new System.Drawing.Size(117, 30);
            this.btnWindows.TabIndex = 27;
            this.btnWindows.Text = "Backup for Windows";
            this.btnWindows.UseVisualStyleBackColor = true;
            this.btnWindows.Click += new System.EventHandler(this.btnWindows_Click);
            // 
            // btnLinux
            // 
            this.btnLinux.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLinux.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLinux.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLinux.Font = new System.Drawing.Font("Gadugi", 7F, System.Drawing.FontStyle.Bold);
            this.btnLinux.Location = new System.Drawing.Point(17, 315);
            this.btnLinux.Name = "btnLinux";
            this.btnLinux.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLinux.Size = new System.Drawing.Size(117, 30);
            this.btnLinux.TabIndex = 26;
            this.btnLinux.Text = "Backup for Linux";
            this.btnLinux.UseVisualStyleBackColor = true;
            this.btnLinux.Click += new System.EventHandler(this.btnLinux_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(66, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Local Host";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(200, 551);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(481, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Local Databases";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Coral;
            this.label4.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(67, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Local Logins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Coral;
            this.label5.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(1545, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Selected Databases";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(432, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 39);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Coral;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(1191, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 39);
            this.panel4.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Coral;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(1514, 260);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(289, 39);
            this.panel5.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1842, 934);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnloginall);
            this.Controls.Add(this.btnloginclr);
            this.Controls.Add(this.btnrestoreall);
            this.Controls.Add(this.btnhostclr);
            this.Controls.Add(this.btnhostall);
            this.Controls.Add(this.btnrestoreclr);
            this.Controls.Add(this.chklistboxRestore);
            this.Controls.Add(this.chklistboxlogin);
            this.Controls.Add(this.chklistboxDb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SQL Server Backup & Restore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklistboxDb;
        private System.Windows.Forms.CheckedListBox chklistboxlogin;
        private System.Windows.Forms.CheckedListBox chklistboxRestore;
        private System.Windows.Forms.Button btnrestoreclr;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnhostall;
        private System.Windows.Forms.Button btnhostclr;
        private System.Windows.Forms.Button btnrestoreall;
        private System.Windows.Forms.Button btnloginclr;
        private System.Windows.Forms.Button btnloginall;
        private System.Windows.Forms.TextBox txtremotesa;
        private System.Windows.Forms.TextBox txtremotename;
        private System.Windows.Forms.TextBox txthostsa;
        private System.Windows.Forms.TextBox txthostpwd;
        private System.Windows.Forms.TextBox txthostname;
        private System.Windows.Forms.TextBox txtremotepwd;
        private System.Windows.Forms.Button btnStartRestore;
        private System.Windows.Forms.Button btnSelectRes;
        private System.Windows.Forms.Button btnTransferLogin;
        private System.Windows.Forms.CheckBox chkhostpwd;
        private System.Windows.Forms.CheckBox chkremotepwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnWindows;
        private System.Windows.Forms.Button btnLinux;
    }
}

