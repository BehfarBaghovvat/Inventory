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
		decimal sumNumber, firstNumber, secondNumber = 0;



		public TestControlForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			firstNumber = decimal.Parse(textBox1.Texts);

			sumNumber = firstNumber + secondNumber;

			secondNumber = sumNumber;

			
			MessageBox.Show($"Sum Number is : {sumNumber}");

		}
	}
}
