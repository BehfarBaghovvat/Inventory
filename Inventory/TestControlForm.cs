using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
	public partial class TestControlForm : Form
	{
		public TestControlForm()
		{
			InitializeComponent();
		}

		private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			MessageBox.Show($"Month name:{guna2ComboBox1.SelectedItem}and month number:{guna2ComboBox1.SelectedIndex}");
			
		}
	}
}
