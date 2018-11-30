using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
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
				throw new ProtectedFromASyncUnfoldException(new Exception("B", a));
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

	public class ProtectedFromASyncUnfoldException : Exception
	{
		public Exception InternalException { get;  }
		public ProtectedFromASyncUnfoldException() {	}

		public ProtectedFromASyncUnfoldException(string message) 
			: base(message) {	}

		/// <summary>
		/// Hack of exception.
		/// Setting InternalException instead of innerException 
		/// to avoid strange behaviour of async exception handling in windows forms
		/// that otherwise throws away all but the base exception
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException">transformed to InternalException</param>
		public ProtectedFromASyncUnfoldException(string message, Exception innerException) 
			: base(message)
		{
			InternalException = innerException;
		}

		public ProtectedFromASyncUnfoldException(Exception innerException) 
			: this(innerException.Message, innerException) { }

		protected ProtectedFromASyncUnfoldException(SerializationInfo info, StreamingContext context) 
			: base(info, context) { }

		public override string ToString()
		{
			return base.ToString() 
				+ Environment.NewLine 
				+ Environment.NewLine 
				+ "---------------------" 
				+ InternalException?.ToString();
		}
	}
}
