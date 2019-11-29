namespace Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListBoxClient = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txbMesseger = new System.Windows.Forms.TextBox();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_Host = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lollipopBtnSend = new LollipopButton();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxClient
            // 
            this.ListBoxClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ListBoxClient.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxClient.FormattingEnabled = true;
            this.ListBoxClient.ItemHeight = 17;
            this.ListBoxClient.Location = new System.Drawing.Point(20, 47);
            this.ListBoxClient.Name = "ListBoxClient";
            this.ListBoxClient.ScrollAlwaysVisible = true;
            this.ListBoxClient.Size = new System.Drawing.Size(191, 225);
            this.ListBoxClient.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(261, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(457, 327);
            this.listBox1.TabIndex = 12;
            // 
            // txbMesseger
            // 
            this.txbMesseger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMesseger.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMesseger.Location = new System.Drawing.Point(261, 407);
            this.txbMesseger.Multiline = true;
            this.txbMesseger.Name = "txbMesseger";
            this.txbMesseger.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMesseger.Size = new System.Drawing.Size(372, 51);
            this.txbMesseger.TabIndex = 11;
            // 
            // textBox_IP
            // 
            this.textBox_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IP.Location = new System.Drawing.Point(17, 310);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.ReadOnly = true;
            this.textBox_IP.Size = new System.Drawing.Size(220, 26);
            this.textBox_IP.TabIndex = 16;
            // 
            // textBox_Host
            // 
            this.textBox_Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Host.Location = new System.Drawing.Point(17, 368);
            this.textBox_Host.Name = "textBox_Host";
            this.textBox_Host.ReadOnly = true;
            this.textBox_Host.Size = new System.Drawing.Size(220, 26);
            this.textBox_Host.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lollipopLabel3);
            this.groupBox1.Controls.Add(this.ListBoxClient);
            this.groupBox1.Controls.Add(this.lollipopLabel2);
            this.groupBox1.Controls.Add(this.textBox_Host);
            this.groupBox1.Controls.Add(this.lollipopLabel1);
            this.groupBox1.Controls.Add(this.textBox_IP);
            this.groupBox1.Location = new System.Drawing.Point(2, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 405);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // lollipopBtnSend
            // 
            this.lollipopBtnSend.BackColor = System.Drawing.Color.Transparent;
            this.lollipopBtnSend.BGColor = "#508ef5";
            this.lollipopBtnSend.FontColor = "#ffffff";
            this.lollipopBtnSend.Location = new System.Drawing.Point(639, 407);
            this.lollipopBtnSend.Name = "lollipopBtnSend";
            this.lollipopBtnSend.Size = new System.Drawing.Size(79, 51);
            this.lollipopBtnSend.TabIndex = 23;
            this.lollipopBtnSend.Text = "Send";
            this.lollipopBtnSend.Click += new System.EventHandler(this.lollipopBtnSend_Click);
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(17, 16);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(117, 17);
            this.lollipopLabel3.TabIndex = 21;
            this.lollipopLabel3.Text = "Connected Users";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(13, 340);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(78, 17);
            this.lollipopLabel2.TabIndex = 20;
            this.lollipopLabel2.Text = "Host Name";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(17, 277);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(122, 17);
            this.lollipopLabel1.TabIndex = 19;
            this.lollipopLabel1.Text = "IP Address Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 482);
            this.Controls.Add(this.lollipopBtnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txbMesseger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.lollipopBtnSend_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBoxClient;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txbMesseger;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_Host;
        private LollipopLabel lollipopLabel1;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private LollipopButton lollipopBtnSend;
    }
}

