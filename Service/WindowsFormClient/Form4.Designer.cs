﻿namespace WindowsFormClient
{
    partial class Form4
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
			this.label1 = new System.Windows.Forms.Label();
			this.nickname = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.displaymsg = new System.Windows.Forms.RichTextBox();
			this.sendmsg = new System.Windows.Forms.RichTextBox();
			this.btnsend = new System.Windows.Forms.Button();
			this.resultmsg = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "我的昵称 :";
			// 
			// nickname
			// 
			this.nickname.Location = new System.Drawing.Point(110, 19);
			this.nickname.Name = "nickname";
			this.nickname.Size = new System.Drawing.Size(112, 21);
			this.nickname.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.displaymsg);
			this.groupBox1.Location = new System.Drawing.Point(12, 60);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(485, 374);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "消息列表";
			// 
			// displaymsg
			// 
			this.displaymsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.displaymsg.Location = new System.Drawing.Point(3, 17);
			this.displaymsg.Name = "displaymsg";
			this.displaymsg.ReadOnly = true;
			this.displaymsg.Size = new System.Drawing.Size(479, 354);
			this.displaymsg.TabIndex = 0;
			this.displaymsg.Text = "";
			// 
			// sendmsg
			// 
			this.sendmsg.Location = new System.Drawing.Point(12, 441);
			this.sendmsg.Name = "sendmsg";
			this.sendmsg.Size = new System.Drawing.Size(482, 63);
			this.sendmsg.TabIndex = 3;
			this.sendmsg.Text = "";
			// 
			// btnsend
			// 
			this.btnsend.Location = new System.Drawing.Point(15, 512);
			this.btnsend.Name = "btnsend";
			this.btnsend.Size = new System.Drawing.Size(75, 23);
			this.btnsend.TabIndex = 4;
			this.btnsend.Text = "发送";
			this.btnsend.UseVisualStyleBackColor = true;
			this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
			// 
			// resultmsg
			// 
			this.resultmsg.AutoSize = true;
			this.resultmsg.Location = new System.Drawing.Point(129, 517);
			this.resultmsg.Name = "resultmsg";
			this.resultmsg.Size = new System.Drawing.Size(0, 12);
			this.resultmsg.TabIndex = 5;
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 547);
			this.Controls.Add(this.resultmsg);
			this.Controls.Add(this.btnsend);
			this.Controls.Add(this.sendmsg);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.nickname);
			this.Controls.Add(this.label1);
			this.Name = "Form4";
			this.Text = "Form4";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox sendmsg;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label resultmsg;
		private System.Windows.Forms.RichTextBox displaymsg;
	}
}