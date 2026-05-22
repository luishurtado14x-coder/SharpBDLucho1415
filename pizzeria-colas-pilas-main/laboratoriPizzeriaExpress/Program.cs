
using System;
using System.Windows.Forms;

namespace laboratoriPizzeriaExpress
{
	/// <summary>

	/// </summary>
	internal sealed class Program
	{
		/// <summary>

		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
