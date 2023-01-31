using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWD604_ClassActivity_Singleton_31_01_2023.Modules;

namespace SWD604_ClassActivity_Singleton_31_01_2023
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CreateDatabaseConnection DataBaseConnect = CreateDatabaseConnection.GetDB_Instance();
			MessageBox.Show(DataBaseConnect.connectionString());
			
		}
	}
}
