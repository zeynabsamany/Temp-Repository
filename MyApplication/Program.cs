namespace MyApplication
{
	internal static class Program
	{
		//******************************************
		#region Static Constructure
		//******************************************
		/// <summary>
		/// Static Constructure
		/// </summary>
		static Program()
		{
		}
		//******************************************
		#endregion /Static Constructure
		//******************************************

		//******************************************
		#region Main [ Method ]
		//******************************************
		[System.STAThread]
		internal static void Main()
		{
			//***************************************
			System.Windows.Forms.Application.EnableVisualStyles();

			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			//***************************************

			//***************************************
			Infrastructure.BaseForm startupForm = new StartupForm();

			System.Windows.Forms.Application.Run(mainForm: startupForm);
			//***************************************

			//***************************************
			if ((startupForm is null) == false)
			{
				if (startupForm.IsDisposed is false)
				{
					startupForm = null;
					startupForm.Dispose();
				}
			}
			//***************************************
		}
		//******************************************
		#endregion Main [ Method ]
		//******************************************
	}
}
