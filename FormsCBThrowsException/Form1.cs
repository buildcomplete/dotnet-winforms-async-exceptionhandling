using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCBThrowsException
{
	public partial class Form1 : Form
	{
		private TextBox _textBoxToSetTextOnGivenLastCall;
		public Form1()
		{
			InitializeComponent();
		}

		private async void buttonThrowAndWrapExceptionAsync_Click(object sender, EventArgs e)
		{
			_textBoxToSetTextOnGivenLastCall = textBox1;
			try
			{
				await Task.Run(() =>
					ThrowExceptionA());
			}
			catch (Exception a)
			{
				throw new Exception("B", a);
			}
		}

		private async void buttonThrowAndRethrowNewExceptionAsync_Click(object sender, EventArgs e)
		{
			_textBoxToSetTextOnGivenLastCall = textBox2;
			try
			{
				await Task.Run(() =>
					ThrowExceptionA());
			}
			catch (Exception)
			{
				throw new Exception("B");
			}
		}

		private void ThrowExceptionA() => throw new Exception("A");

		public void SetMessageInTextBox(string x) =>
			BeginInvoke((MethodInvoker)(() => _textBoxToSetTextOnGivenLastCall.Text = x) );
		
	}
}
