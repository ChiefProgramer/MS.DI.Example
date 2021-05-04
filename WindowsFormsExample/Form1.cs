using Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample {
	public partial class Form1 : Form {
		IHelloWorldService _HelloWorldService;

		public Form1(IHelloWorldService aHelloWorldService) {
			_HelloWorldService = aHelloWorldService;
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			_HelloWorldService.HelloWord();

			
		}


		public void DrawString(string aString) {
			System.Drawing.Graphics formGraphics = this.CreateGraphics();
			string drawString = aString;
			System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 36);
			System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
			float x = 50.0F;
			float y = 50.0F;
			System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
			formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
			drawFont.Dispose();
			drawBrush.Dispose();
			formGraphics.Dispose();
		}

		private void Form1_Paint(object sender, PaintEventArgs e) {
			DrawString(_HelloWorldService.HelloWordText());
		}
	}
}
