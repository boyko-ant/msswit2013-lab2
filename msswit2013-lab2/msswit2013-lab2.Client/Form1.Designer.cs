namespace msswit2013_lab2.Client
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
			this.lbQueue = new System.Windows.Forms.ListBox();
			this.btnQueue = new System.Windows.Forms.Button();
			this.lbStatus = new System.Windows.Forms.ListBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.tbPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbQueue
			// 
			this.lbQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbQueue.FormattingEnabled = true;
			this.lbQueue.Location = new System.Drawing.Point(303, 65);
			this.lbQueue.Name = "lbQueue";
			this.lbQueue.Size = new System.Drawing.Size(186, 342);
			this.lbQueue.TabIndex = 15;
			// 
			// btnQueue
			// 
			this.btnQueue.Location = new System.Drawing.Point(94, 35);
			this.btnQueue.Name = "btnQueue";
			this.btnQueue.Size = new System.Drawing.Size(75, 23);
			this.btnQueue.TabIndex = 14;
			this.btnQueue.Text = "Queue";
			this.btnQueue.UseVisualStyleBackColor = true;
			this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
			// 
			// lbStatus
			// 
			this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lbStatus.FormattingEnabled = true;
			this.lbStatus.Location = new System.Drawing.Point(12, 65);
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(284, 342);
			this.lbStatus.TabIndex = 13;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(12, 35);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 12;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// tbPass
			// 
			this.tbPass.Location = new System.Drawing.Point(196, 9);
			this.tbPass.Name = "tbPass";
			this.tbPass.Size = new System.Drawing.Size(100, 20);
			this.tbPass.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(160, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Pass";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Login";
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(52, 9);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(100, 20);
			this.tbLogin.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 415);
			this.Controls.Add(this.lbQueue);
			this.Controls.Add(this.btnQueue);
			this.Controls.Add(this.lbStatus);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.tbPass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbLogin);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbQueue;
		private System.Windows.Forms.Button btnQueue;
		private System.Windows.Forms.ListBox lbStatus;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox tbPass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbLogin;

	}
}

