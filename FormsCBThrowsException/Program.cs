using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCBThrowsException
{
	static class Program
	{
		private static Form1 _form1;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			// Setup error handling
			Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			_form1 = new Form1();
			Application.Run(_form1);
		}

		private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			_form1.SetMessageInTextBox(nameof(Application_ThreadException) + Environment.NewLine + e.Exception.ToString());
		}
	}
}
