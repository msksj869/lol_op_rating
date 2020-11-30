namespace project
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.guna2Button3);
			this.panel1.Controls.Add(this.guna2Button2);
			this.panel1.Controls.Add(this.guna2Button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(180, 608);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(68, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "TROLL.GG";
			// 
			// guna2Button1
			// 
			this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 22;
			this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.guna2Button1.Checked = true;
			this.guna2Button1.CheckedState.BorderColor = System.Drawing.Color.White;
			this.guna2Button1.CheckedState.CustomBorderColor = System.Drawing.Color.White;
			this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
			this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
			this.guna2Button1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.CheckedState.Image")));
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
			this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button1.ImageOffset = new System.Drawing.Point(10, 0);
			this.guna2Button1.Location = new System.Drawing.Point(12, 105);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new System.Drawing.Size(163, 43);
			this.guna2Button1.TabIndex = 2;
			this.guna2Button1.Text = "MAIN";
			this.guna2Button1.UseTransparentBackground = true;
			this.guna2Button1.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
			// 
			// guna2Button2
			// 
			this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button2.BorderRadius = 22;
			this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.guna2Button2.CheckedState.BorderColor = System.Drawing.Color.White;
			this.guna2Button2.CheckedState.CustomBorderColor = System.Drawing.Color.White;
			this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.White;
			this.guna2Button2.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
			this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button2.ImageOffset = new System.Drawing.Point(10, 0);
			this.guna2Button2.Location = new System.Drawing.Point(12, 392);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new System.Drawing.Size(163, 43);
			this.guna2Button2.TabIndex = 3;
			this.guna2Button2.Text = "NOTICE";
			this.guna2Button2.UseTransparentBackground = true;
			this.guna2Button2.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
			// 
			// guna2Button3
			// 
			this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button3.BorderRadius = 22;
			this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.guna2Button3.CheckedState.BorderColor = System.Drawing.Color.White;
			this.guna2Button3.CheckedState.CustomBorderColor = System.Drawing.Color.White;
			this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.White;
			this.guna2Button3.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
			this.guna2Button3.CheckedState.Parent = this.guna2Button3;
			this.guna2Button3.CustomImages.Parent = this.guna2Button3;
			this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
			this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2Button3.ForeColor = System.Drawing.Color.White;
			this.guna2Button3.HoverState.Parent = this.guna2Button3;
			this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button3.ImageOffset = new System.Drawing.Point(10, 0);
			this.guna2Button3.Location = new System.Drawing.Point(12, 175);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
			this.guna2Button3.Size = new System.Drawing.Size(163, 43);
			this.guna2Button3.TabIndex = 4;
			this.guna2Button3.Text = "MANUAL";
			this.guna2Button3.UseTransparentBackground = true;
			this.guna2Button3.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(180, 0);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(0, 6, 6, 6);
			this.panel2.Size = new System.Drawing.Size(892, 608);
			this.panel2.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
			this.ClientSize = new System.Drawing.Size(1072, 608);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2Button guna2Button3;
		private System.Windows.Forms.Panel panel2;
	}
}

