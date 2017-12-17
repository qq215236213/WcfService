namespace WindowsFormClient
{
	partial class Form3
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
			this.begin = new System.Windows.Forms.Button();
			this.stop = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.result = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// begin
			// 
			this.begin.Location = new System.Drawing.Point(40, 30);
			this.begin.Name = "begin";
			this.begin.Size = new System.Drawing.Size(75, 23);
			this.begin.TabIndex = 0;
			this.begin.Text = "开始";
			this.begin.UseVisualStyleBackColor = true;
			this.begin.Click += new System.EventHandler(this.begin_Click);
			// 
			// stop
			// 
			this.stop.Location = new System.Drawing.Point(40, 77);
			this.stop.Name = "stop";
			this.stop.Size = new System.Drawing.Size(75, 23);
			this.stop.TabIndex = 1;
			this.stop.Text = "停止";
			this.stop.UseVisualStyleBackColor = true;
			this.stop.Click += new System.EventHandler(this.stop_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(40, 146);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "挑选靓号：";
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(130, 146);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(0, 12);
			this.result.TabIndex = 3;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 206);
			this.Controls.Add(this.result);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.stop);
			this.Controls.Add(this.begin);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button begin;
		private System.Windows.Forms.Button stop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label result;
	}
}