using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			main1.Show();
			label2.SendToBack();
			label3.SendToBack();
			label4.SendToBack();
			label5.SendToBack();
			label6.SendToBack();
			label7.SendToBack();
			label8.SendToBack();
			label9.SendToBack();
			label10.SendToBack();
			label11.SendToBack();
			label12.SendToBack();
			label13.SendToBack();
			label14.SendToBack();
			label15.SendToBack();
			label16.SendToBack();
			label17.SendToBack();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void guna2Button1_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private Point mousePoint;
		private void panel3_MouseDown(object sender, MouseEventArgs e)
		{
			mousePoint = new Point(e.X, e.Y);
		}

		private void panel3_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) //마우스 왼쪽 클릭 시에만 실행
			{
				//폼의 위치를 드래그중인 마우스의 좌표로 이동 
				Location = new Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
			}
		}

		private void exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			main1.Show();
			manual1.SendToBack();
			notice1.SendToBack();
			white1.SendToBack();
			label2.SendToBack();
			label3.SendToBack();
			label4.SendToBack();
			label5.SendToBack();
			label6.SendToBack();
			label7.SendToBack();
			label8.SendToBack();
			label9.SendToBack();
			label10.SendToBack();
			label11.SendToBack();
			label12.SendToBack();
			label13.SendToBack();
			label14.SendToBack();
			label15.SendToBack();
			label16.SendToBack();
			label17.SendToBack();
		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			manual1.Show();
			main1.SendToBack();
			notice1.SendToBack();
			white1.SendToBack();
			label2.SendToBack();
			label3.SendToBack();
			label4.SendToBack();
			label5.SendToBack();
			label6.SendToBack();
			label7.SendToBack();
			label8.SendToBack();
			label9.SendToBack();
			label10.SendToBack();
			label11.SendToBack();
			label12.SendToBack();
			label13.SendToBack();
			label14.SendToBack();
			label15.SendToBack();
			label16.SendToBack();
			label17.SendToBack();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			notice1.Show();
			manual1.SendToBack();
			main1.SendToBack();
			white1.SendToBack();
			label2.SendToBack();
			label3.SendToBack();
			label4.SendToBack();
			label5.SendToBack();
			label6.SendToBack();
			label7.SendToBack();
			label8.SendToBack();
			label9.SendToBack();
			label10.SendToBack();
			label11.SendToBack();
			label12.SendToBack();
			label13.SendToBack();
			label14.SendToBack();
			label15.SendToBack();
			label16.SendToBack();
			label17.SendToBack();
		}

		private void guna2TextBox1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				white1.Show();
				main1.SendToBack();
				manual1.SendToBack();
				notice1.SendToBack();
				label2.BringToFront();
				label3.BringToFront();
				label4.BringToFront();
				label5.BringToFront();
				label6.BringToFront();
				label7.BringToFront();
				label8.BringToFront();
				label9.BringToFront();
				label10.BringToFront();
				label11.BringToFront();
				label12.BringToFront();
				label13.BringToFront();
				label14.BringToFront();
				label15.BringToFront();
				label16.BringToFront();
				label17.BringToFront();
				var name=guna2TextBox1.Text;
				guna2TextBox1.Text = name+"11";
			}
		}
		/*
label2.SendToBack();
label3.SendToBack();
label4.SendToBack();
label5.SendToBack();
label6.SendToBack();
label7.SendToBack();
label8.SendToBack();
label9.SendToBack();
label10.SendToBack();
label11.SendToBack();
label12.SendToBack();
label13.SendToBack();
label14.SendToBack();
label15.SendToBack();
label16.SendToBack();
label17.SendToBack();
*/
	}
}
