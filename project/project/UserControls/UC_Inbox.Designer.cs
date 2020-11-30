namespace project.UserControls
{
	partial class UC_Inbox
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

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inbox));
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.guna2Button1);
			this.panel1.Controls.Add(this.guna2TextBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(892, 100);
			this.panel1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(312, 508);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(17, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "activate";
			// 
			// guna2TextBox1
			// 
			this.guna2TextBox1.BorderRadius = 15;
			this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox1.DefaultText = "";
			this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
			this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
			this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
			this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(5, 0);
			this.guna2TextBox1.Location = new System.Drawing.Point(21, 13);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '\0';
			this.guna2TextBox1.PlaceholderText = "Search Username";
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
			this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
			this.guna2TextBox1.TabIndex = 3;
			// 
			// guna2ContextMenuStrip1
			// 
			this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
			this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
			this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
			this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
			this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// guna2Button1
			// 
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new System.Drawing.Point(243, 31);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new System.Drawing.Size(35, 35);
			this.guna2Button1.TabIndex = 0;
			// 
			// UC_Inbox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "UC_Inbox";
			this.Size = new System.Drawing.Size(892, 608);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
	}
}
