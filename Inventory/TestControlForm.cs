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

        private void mbbComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			Mbb.Windows.Forms.MessageBox.Show($"{mbbComboBox1.SelectedItem}","name item",icon: Mbb.Windows.Forms.MessageBoxIcon.Information,button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
        }
    }
}
