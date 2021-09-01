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
		private string _dataReceipt;

		private void customTextBox1_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(customTextBox1.Text))
			{
				_dataReceipt = null;
				return;
			}
			else if (customTextBox1.Text.Length < 10)
			{
				customTextBox1.Clear();
				_dataReceipt = null;
				return;
			}
			else
			{
				_dataReceipt = customTextBox1.Text.Insert(3, "-").Insert(10, "-");
				MessageBox.Show(_dataReceipt);
			}
		}

		public TestControlForm()
		{
			InitializeComponent();
		}

		private void customTextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (customTextBox1.Text.Length > 10)
			{
				MessageBox.Show($"{customTextBox1.Text.Length}");
			}
		}

		private void customTextBox1_TextChanged(object sender, EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}

		private void bunifuTextBox1_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(bunifuTextBox1.Text) || string.Compare(bunifuTextBox1.Text, "0 تومان") == 0 || bunifuTextBox1.Text.Length <= 6)
			{
				bunifuTextBox1.Clear();
				return;
			}
			else
			{
				_dataReceipt = bunifuTextBox1.Text;
				MessageBox.Show($"{_dataReceipt}");
			}
		}

		private void bunifuTextBox1_Enter(object sender, EventArgs e)
		{

			bunifuTextBox1.Text = "0 تومان";

			bunifuTextBox1.Select(0, bunifuTextBox1.Text.Length - 6);

			if (string.IsNullOrWhiteSpace(bunifuTextBox1.Text))
			{
				
			}
			else if (bunifuTextBox1.Text.Contains("تومان"))
			{
				return;
			}
		}

		private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{

		}
	}
}
