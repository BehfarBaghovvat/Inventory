
namespace Inventory.Forms.Financial_Form
{
	partial class AncillaryCostsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AncillaryCostsForm));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.listExpensesComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.amountPaymentTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.paymentButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Indigo;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.dataGridView1);
            this.guna2Panel1.Controls.Add(this.paymentButton);
            this.guna2Panel1.Controls.Add(this.listExpensesComboBox);
            this.guna2Panel1.Controls.Add(this.amountPaymentTextBox);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1150, 650);
            this.guna2Panel1.TabIndex = 0;
            // 
            // listExpensesComboBox
            // 
            this.listExpensesComboBox.Animated = true;
            this.listExpensesComboBox.BackColor = System.Drawing.Color.Transparent;
            this.listExpensesComboBox.BorderColor = System.Drawing.Color.Indigo;
            this.listExpensesComboBox.BorderThickness = 3;
            this.listExpensesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listExpensesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listExpensesComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
            this.listExpensesComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.listExpensesComboBox.FocusedState.Parent = this.listExpensesComboBox;
            this.listExpensesComboBox.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listExpensesComboBox.ForeColor = System.Drawing.Color.Gray;
            this.listExpensesComboBox.FormattingEnabled = true;
            this.listExpensesComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listExpensesComboBox.HoverState.Parent = this.listExpensesComboBox;
            this.listExpensesComboBox.ItemHeight = 30;
            this.listExpensesComboBox.Items.AddRange(new object[] {
            "...انتخاب هزینه انجام شده",
            "آب",
            "برق",
            "گاز",
            "تلفن",
            "تعمیرات برقی",
            "تعمیرات تاسیساتی",
            "تعمیرات معماری",
            "طراحی و تکوراسیون",
            "تاکسی",
            "آژانس(اسنپ یا غیره...)"});
            this.listExpensesComboBox.ItemsAppearance.BackColor = System.Drawing.Color.Teal;
            this.listExpensesComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.listExpensesComboBox.ItemsAppearance.Parent = this.listExpensesComboBox;
            this.listExpensesComboBox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.listExpensesComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.listExpensesComboBox.Location = new System.Drawing.Point(492, 27);
            this.listExpensesComboBox.Name = "listExpensesComboBox";
            this.listExpensesComboBox.ShadowDecoration.Parent = this.listExpensesComboBox;
            this.listExpensesComboBox.Size = new System.Drawing.Size(306, 36);
            this.listExpensesComboBox.StartIndex = 0;
            this.listExpensesComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.listExpensesComboBox.TabIndex = 1;
            this.listExpensesComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.listExpensesComboBox.SelectedIndexChanged += new System.EventHandler(this.listExpensesComboBox_SelectedIndexChanged);
            // 
            // amountPaymentTextBox
            // 
            this.amountPaymentTextBox.AcceptsReturn = false;
            this.amountPaymentTextBox.AcceptsTab = false;
            this.amountPaymentTextBox.AnimationSpeed = 250;
            this.amountPaymentTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.amountPaymentTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.amountPaymentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
            this.amountPaymentTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("amountPaymentTextBox.BackgroundImage")));
            this.amountPaymentTextBox.BorderColorActive = System.Drawing.Color.CornflowerBlue;
            this.amountPaymentTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.amountPaymentTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.amountPaymentTextBox.BorderColorIdle = System.Drawing.Color.Indigo;
            this.amountPaymentTextBox.BorderRadius = 1;
            this.amountPaymentTextBox.BorderThickness = 3;
            this.amountPaymentTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.amountPaymentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountPaymentTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.amountPaymentTextBox.DefaultText = "";
            this.amountPaymentTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
            this.amountPaymentTextBox.HideSelection = true;
            this.amountPaymentTextBox.IconLeft = null;
            this.amountPaymentTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.amountPaymentTextBox.IconPadding = 10;
            this.amountPaymentTextBox.IconRight = null;
            this.amountPaymentTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.amountPaymentTextBox.Lines = new string[0];
            this.amountPaymentTextBox.Location = new System.Drawing.Point(824, 27);
            this.amountPaymentTextBox.MaximumSize = new System.Drawing.Size(300, 35);
            this.amountPaymentTextBox.MaxLength = 32767;
            this.amountPaymentTextBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.amountPaymentTextBox.Modified = false;
            this.amountPaymentTextBox.Multiline = false;
            this.amountPaymentTextBox.Name = "amountPaymentTextBox";
            stateProperties5.BorderColor = System.Drawing.Color.CornflowerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.amountPaymentTextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.amountPaymentTextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.amountPaymentTextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Indigo;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.amountPaymentTextBox.OnIdleState = stateProperties8;
            this.amountPaymentTextBox.PasswordChar = '\0';
            this.amountPaymentTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.amountPaymentTextBox.PlaceholderText = "مبلغ هزینه شده";
            this.amountPaymentTextBox.ReadOnly = false;
            this.amountPaymentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountPaymentTextBox.SelectedText = "";
            this.amountPaymentTextBox.SelectionLength = 0;
            this.amountPaymentTextBox.SelectionStart = 0;
            this.amountPaymentTextBox.ShortcutsEnabled = true;
            this.amountPaymentTextBox.Size = new System.Drawing.Size(300, 35);
            this.amountPaymentTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.amountPaymentTextBox.TabIndex = 0;
            this.amountPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amountPaymentTextBox.TextMarginBottom = 0;
            this.amountPaymentTextBox.TextMarginLeft = 5;
            this.amountPaymentTextBox.TextMarginTop = 0;
            this.amountPaymentTextBox.TextPlaceholder = "مبلغ هزینه شده";
            this.amountPaymentTextBox.UseSystemPasswordChar = false;
            this.amountPaymentTextBox.WordWrap = true;
            this.amountPaymentTextBox.TextChange += new System.EventHandler(this.amountPaymentTextBox_TextChange);
            this.amountPaymentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountPaymentTextBox_KeyPress);
            this.amountPaymentTextBox.Enter += new System.EventHandler(this.amountPaymentTextBox_Enter);
            this.amountPaymentTextBox.Leave += new System.EventHandler(this.amountPaymentTextBox_Leave);
            // 
            // paymentButton
            // 
            this.paymentButton.Animated = true;
            this.paymentButton.BorderRadius = 5;
            this.paymentButton.CheckedState.Parent = this.paymentButton;
            this.paymentButton.CustomImages.Parent = this.paymentButton;
            this.paymentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
            this.paymentButton.FillColor2 = System.Drawing.Color.Fuchsia;
            this.paymentButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.paymentButton.ForeColor = System.Drawing.Color.White;
            this.paymentButton.HoverState.FillColor = System.Drawing.Color.Fuchsia;
            this.paymentButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
            this.paymentButton.HoverState.Parent = this.paymentButton;
            this.paymentButton.Location = new System.Drawing.Point(286, 27);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.PressedColor = System.Drawing.Color.White;
            this.paymentButton.ShadowDecoration.Parent = this.paymentButton;
            this.paymentButton.Size = new System.Drawing.Size(180, 36);
            this.paymentButton.TabIndex = 2;
            this.paymentButton.Text = "پرداخت";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // AncillaryCostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("IRANSansX", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "AncillaryCostsForm";
            this.Text = "AncillaryCostsForm";
            this.Load += new System.EventHandler(this.AncillaryCostsForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox listExpensesComboBox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox amountPaymentTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton paymentButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}