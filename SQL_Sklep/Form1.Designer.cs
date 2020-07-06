using System.Windows.Forms;

namespace SQL_Sklep
{
    partial class Sklep
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sklep));
            this.mainPanel = new System.Windows.Forms.PictureBox();
            this.minimazeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xLabel = new System.Windows.Forms.Label();
            this._label = new System.Windows.Forms.Label();
            this.iconPicturebox = new System.Windows.Forms.PictureBox();
            this.panelText = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.registerButton2 = new System.Windows.Forms.Button();
            this.loginButton2 = new System.Windows.Forms.Button();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.repeatpasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.repeatpasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addMoreBalance = new System.Windows.Forms.Button();
            this.addBalanceTB = new System.Windows.Forms.TextBox();
            this.addBalanceButton = new System.Windows.Forms.Button();
            this.clientBalanceLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.changePriceButton = new System.Windows.Forms.Button();
            this.howManyLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.howManyTB = new System.Windows.Forms.TextBox();
            this.finalButton = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.replenishButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.newMaxCountLabel = new System.Windows.Forms.Label();
            this.newCountLabel = new System.Windows.Forms.Label();
            this.newPriceLabel = new System.Windows.Forms.Label();
            this.newCategoryLabel = new System.Windows.Forms.Label();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.newMaxCountTB = new System.Windows.Forms.TextBox();
            this.newCountTB = new System.Windows.Forms.TextBox();
            this.newPriceTB = new System.Windows.Forms.TextBox();
            this.newCategoryTB = new System.Windows.Forms.TextBox();
            this.newNameTB = new System.Windows.Forms.TextBox();
            this.newProductButton = new System.Windows.Forms.Button();
            this.sortingLabel = new System.Windows.Forms.Label();
            this.categorySortButton = new System.Windows.Forms.Button();
            this.priceSortButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.nameSortButton = new System.Windows.Forms.Button();
            this.idSortButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sortbyLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.productIdTB = new System.Windows.Forms.TextBox();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicturebox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Location = new System.Drawing.Point(-4, -5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(842, 47);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.TabStop = false;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // minimazeButton
            // 
            this.minimazeButton.BackColor = System.Drawing.Color.Black;
            this.minimazeButton.Location = new System.Drawing.Point(759, 7);
            this.minimazeButton.Name = "minimazeButton";
            this.minimazeButton.Size = new System.Drawing.Size(29, 25);
            this.minimazeButton.TabIndex = 2;
            this.minimazeButton.TabStop = false;
            this.minimazeButton.Click += new System.EventHandler(this.minimazeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(796, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(29, 25);
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.pictureBox1.Location = new System.Drawing.Point(5, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(827, 506);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // xLabel
            // 
            this.xLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.xLabel.AutoSize = true;
            this.xLabel.BackColor = System.Drawing.Color.Black;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xLabel.ForeColor = System.Drawing.Color.Transparent;
            this.xLabel.Location = new System.Drawing.Point(803, 12);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(16, 16);
            this.xLabel.TabIndex = 5;
            this.xLabel.Text = "X";
            this.xLabel.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // _label
            // 
            this._label.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this._label.AutoSize = true;
            this._label.BackColor = System.Drawing.Color.Black;
            this._label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._label.ForeColor = System.Drawing.Color.Transparent;
            this._label.Location = new System.Drawing.Point(767, 10);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(15, 16);
            this._label.TabIndex = 6;
            this._label.Text = "_";
            this._label.Click += new System.EventHandler(this.minimazeButton_Click);
            // 
            // iconPicturebox
            // 
            this.iconPicturebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.iconPicturebox.BackgroundImage = global::SQL_Sklep.Properties.Resources.Fasticon_Shop_Cart_Shop_cart;
            this.iconPicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPicturebox.Location = new System.Drawing.Point(12, 7);
            this.iconPicturebox.Name = "iconPicturebox";
            this.iconPicturebox.Size = new System.Drawing.Size(23, 25);
            this.iconPicturebox.TabIndex = 7;
            this.iconPicturebox.TabStop = false;
            // 
            // panelText
            // 
            this.panelText.AutoSize = true;
            this.panelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelText.ForeColor = System.Drawing.Color.White;
            this.panelText.Location = new System.Drawing.Point(41, 13);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(135, 13);
            this.panelText.TabIndex = 8;
            this.panelText.Text = "GROCERY SHOPPING";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(-14, 29);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 540);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.tabPage1.Controls.Add(this.registerButton2);
            this.tabPage1.Controls.Add(this.loginButton2);
            this.tabPage1.Controls.Add(this.streetLabel);
            this.tabPage1.Controls.Add(this.cityLabel);
            this.tabPage1.Controls.Add(this.surnameLabel);
            this.tabPage1.Controls.Add(this.nameLabel);
            this.tabPage1.Controls.Add(this.repeatpasswordLabel);
            this.tabPage1.Controls.Add(this.passwordLabel);
            this.tabPage1.Controls.Add(this.loginLabel);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.streetTextBox);
            this.tabPage1.Controls.Add(this.cityTextBox);
            this.tabPage1.Controls.Add(this.surnameTextBox);
            this.tabPage1.Controls.Add(this.repeatpasswordTextBox);
            this.tabPage1.Controls.Add(this.passwordTextBox);
            this.tabPage1.Controls.Add(this.loginTextBox);
            this.tabPage1.Controls.Add(this.registerButton);
            this.tabPage1.Controls.Add(this.loginButton);
            this.tabPage1.Controls.Add(this.welcomeLabel);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // registerButton2
            // 
            this.registerButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButton2.Location = new System.Drawing.Point(472, 443);
            this.registerButton2.Name = "registerButton2";
            this.registerButton2.Size = new System.Drawing.Size(338, 50);
            this.registerButton2.TabIndex = 0;
            this.registerButton2.Text = "REGISTER";
            this.registerButton2.UseVisualStyleBackColor = true;
            this.registerButton2.Visible = false;
            this.registerButton2.Click += new System.EventHandler(this.registerButton2_Click);
            // 
            // loginButton2
            // 
            this.loginButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton2.Location = new System.Drawing.Point(45, 443);
            this.loginButton2.Name = "loginButton2";
            this.loginButton2.Size = new System.Drawing.Size(338, 50);
            this.loginButton2.TabIndex = 1;
            this.loginButton2.Text = "LOG IN";
            this.loginButton2.UseVisualStyleBackColor = true;
            this.loginButton2.Visible = false;
            this.loginButton2.Click += new System.EventHandler(this.loginButton2_Click);
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.streetLabel.Location = new System.Drawing.Point(539, 388);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(45, 13);
            this.streetLabel.TabIndex = 16;
            this.streetLabel.Text = "Street:";
            this.streetLabel.Visible = false;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cityLabel.Location = new System.Drawing.Point(550, 318);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(32, 13);
            this.cityLabel.TabIndex = 15;
            this.cityLabel.Text = "City:";
            this.cityLabel.Visible = false;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnameLabel.Location = new System.Drawing.Point(525, 247);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(60, 13);
            this.surnameLabel.TabIndex = 14;
            this.surnameLabel.Text = "Surname:";
            this.surnameLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(539, 180);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 13);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Visible = false;
            // 
            // repeatpasswordLabel
            // 
            this.repeatpasswordLabel.AutoSize = true;
            this.repeatpasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.repeatpasswordLabel.Location = new System.Drawing.Point(59, 388);
            this.repeatpasswordLabel.Name = "repeatpasswordLabel";
            this.repeatpasswordLabel.Size = new System.Drawing.Size(104, 13);
            this.repeatpasswordLabel.TabIndex = 12;
            this.repeatpasswordLabel.Text = "repeat password:";
            this.repeatpasswordLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.Location = new System.Drawing.Point(92, 318);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(64, 13);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "password:";
            this.passwordLabel.Visible = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.Location = new System.Drawing.Point(115, 247);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "login:";
            this.loginLabel.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(601, 166);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(209, 39);
            this.nameTextBox.TabIndex = 15;
            this.nameTextBox.Visible = false;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.streetTextBox.Location = new System.Drawing.Point(601, 371);
            this.streetTextBox.Multiline = true;
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(209, 39);
            this.streetTextBox.TabIndex = 18;
            this.streetTextBox.Visible = false;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cityTextBox.Location = new System.Drawing.Point(601, 304);
            this.cityTextBox.Multiline = true;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(209, 39);
            this.cityTextBox.TabIndex = 17;
            this.cityTextBox.Visible = false;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnameTextBox.Location = new System.Drawing.Point(601, 232);
            this.surnameTextBox.Multiline = true;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(209, 39);
            this.surnameTextBox.TabIndex = 16;
            this.surnameTextBox.Visible = false;
            // 
            // repeatpasswordTextBox
            // 
            this.repeatpasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.repeatpasswordTextBox.Location = new System.Drawing.Point(174, 371);
            this.repeatpasswordTextBox.Multiline = true;
            this.repeatpasswordTextBox.Name = "repeatpasswordTextBox";
            this.repeatpasswordTextBox.PasswordChar = '*';
            this.repeatpasswordTextBox.Size = new System.Drawing.Size(209, 39);
            this.repeatpasswordTextBox.TabIndex = 14;
            this.repeatpasswordTextBox.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextBox.Location = new System.Drawing.Point(174, 304);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(209, 39);
            this.passwordTextBox.TabIndex = 13;
            this.passwordTextBox.Visible = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginTextBox.Location = new System.Drawing.Point(174, 232);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(209, 39);
            this.loginTextBox.TabIndex = 12;
            this.loginTextBox.Visible = false;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButton.Location = new System.Drawing.Point(472, 136);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(338, 50);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "REGISTER";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.Location = new System.Drawing.Point(45, 136);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(338, 50);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.welcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomeLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(45, 37);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(765, 62);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "GROCERY SHOPPING ONLINE";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.quantityLabel);
            this.tabPage2.Controls.Add(this.productIdLabel);
            this.tabPage2.Controls.Add(this.quantityTB);
            this.tabPage2.Controls.Add(this.productIdTB);
            this.tabPage2.Controls.Add(this.buyButton);
            this.tabPage2.Controls.Add(this.sortbyLabel);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.addMoreBalance);
            this.tabPage2.Controls.Add(this.addBalanceTB);
            this.tabPage2.Controls.Add(this.addBalanceButton);
            this.tabPage2.Controls.Add(this.clientBalanceLabel);
            this.tabPage2.Controls.Add(this.clientNameLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(854, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addMoreBalance
            // 
            this.addMoreBalance.Location = new System.Drawing.Point(710, 145);
            this.addMoreBalance.Name = "addMoreBalance";
            this.addMoreBalance.Size = new System.Drawing.Size(119, 28);
            this.addMoreBalance.TabIndex = 5;
            this.addMoreBalance.Text = "Add";
            this.addMoreBalance.UseVisualStyleBackColor = true;
            this.addMoreBalance.Visible = false;
            this.addMoreBalance.Click += new System.EventHandler(this.addMoreBalance_Click);
            // 
            // addBalanceTB
            // 
            this.addBalanceTB.Location = new System.Drawing.Point(710, 119);
            this.addBalanceTB.Name = "addBalanceTB";
            this.addBalanceTB.Size = new System.Drawing.Size(119, 20);
            this.addBalanceTB.TabIndex = 4;
            this.addBalanceTB.Visible = false;
            // 
            // addBalanceButton
            // 
            this.addBalanceButton.Location = new System.Drawing.Point(710, 85);
            this.addBalanceButton.Name = "addBalanceButton";
            this.addBalanceButton.Size = new System.Drawing.Size(119, 28);
            this.addBalanceButton.TabIndex = 3;
            this.addBalanceButton.Text = "Add balance";
            this.addBalanceButton.UseVisualStyleBackColor = true;
            this.addBalanceButton.Click += new System.EventHandler(this.addBalanceButton_Click);
            // 
            // clientBalanceLabel
            // 
            this.clientBalanceLabel.AutoSize = true;
            this.clientBalanceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.clientBalanceLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientBalanceLabel.Location = new System.Drawing.Point(707, 57);
            this.clientBalanceLabel.Name = "clientBalanceLabel";
            this.clientBalanceLabel.Size = new System.Drawing.Size(0, 15);
            this.clientBalanceLabel.TabIndex = 2;
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.clientNameLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientNameLabel.Location = new System.Drawing.Point(707, 27);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(0, 15);
            this.clientNameLabel.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.changePriceButton);
            this.tabPage3.Controls.Add(this.howManyLabel);
            this.tabPage3.Controls.Add(this.idLabel);
            this.tabPage3.Controls.Add(this.howManyTB);
            this.tabPage3.Controls.Add(this.finalButton);
            this.tabPage3.Controls.Add(this.idTB);
            this.tabPage3.Controls.Add(this.replenishButton);
            this.tabPage3.Controls.Add(this.AddButton);
            this.tabPage3.Controls.Add(this.newMaxCountLabel);
            this.tabPage3.Controls.Add(this.newCountLabel);
            this.tabPage3.Controls.Add(this.newPriceLabel);
            this.tabPage3.Controls.Add(this.newCategoryLabel);
            this.tabPage3.Controls.Add(this.newNameLabel);
            this.tabPage3.Controls.Add(this.newMaxCountTB);
            this.tabPage3.Controls.Add(this.newCountTB);
            this.tabPage3.Controls.Add(this.newPriceTB);
            this.tabPage3.Controls.Add(this.newCategoryTB);
            this.tabPage3.Controls.Add(this.newNameTB);
            this.tabPage3.Controls.Add(this.newProductButton);
            this.tabPage3.Controls.Add(this.sortingLabel);
            this.tabPage3.Controls.Add(this.categorySortButton);
            this.tabPage3.Controls.Add(this.priceSortButton);
            this.tabPage3.Controls.Add(this.refreshButton);
            this.tabPage3.Controls.Add(this.nameSortButton);
            this.tabPage3.Controls.Add(this.idSortButton);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(854, 531);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // changePriceButton
            // 
            this.changePriceButton.Location = new System.Drawing.Point(22, 461);
            this.changePriceButton.Name = "changePriceButton";
            this.changePriceButton.Size = new System.Drawing.Size(126, 51);
            this.changePriceButton.TabIndex = 25;
            this.changePriceButton.Text = "Change price";
            this.changePriceButton.UseVisualStyleBackColor = true;
            this.changePriceButton.Click += new System.EventHandler(this.changePriceButton_Click);
            // 
            // howManyLabel
            // 
            this.howManyLabel.AutoSize = true;
            this.howManyLabel.Location = new System.Drawing.Point(297, 426);
            this.howManyLabel.Name = "howManyLabel";
            this.howManyLabel.Size = new System.Drawing.Size(58, 13);
            this.howManyLabel.TabIndex = 24;
            this.howManyLabel.Text = "how many:";
            this.howManyLabel.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(173, 426);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(57, 13);
            this.idLabel.TabIndex = 23;
            this.idLabel.Text = "product id:";
            this.idLabel.Visible = false;
            // 
            // howManyTB
            // 
            this.howManyTB.Location = new System.Drawing.Point(300, 442);
            this.howManyTB.Multiline = true;
            this.howManyTB.Name = "howManyTB";
            this.howManyTB.Size = new System.Drawing.Size(118, 22);
            this.howManyTB.TabIndex = 22;
            this.howManyTB.Visible = false;
            // 
            // finalButton
            // 
            this.finalButton.Location = new System.Drawing.Point(456, 426);
            this.finalButton.Name = "finalButton";
            this.finalButton.Size = new System.Drawing.Size(126, 51);
            this.finalButton.TabIndex = 21;
            this.finalButton.Text = "Replenish";
            this.finalButton.UseVisualStyleBackColor = true;
            this.finalButton.Visible = false;
            this.finalButton.Click += new System.EventHandler(this.finalButton_Click);
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(176, 442);
            this.idTB.Multiline = true;
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(118, 22);
            this.idTB.TabIndex = 20;
            this.idTB.Visible = false;
            // 
            // replenishButton
            // 
            this.replenishButton.Location = new System.Drawing.Point(22, 404);
            this.replenishButton.Name = "replenishButton";
            this.replenishButton.Size = new System.Drawing.Size(126, 51);
            this.replenishButton.TabIndex = 19;
            this.replenishButton.Text = "Replenish product";
            this.replenishButton.UseVisualStyleBackColor = true;
            this.replenishButton.Click += new System.EventHandler(this.replenishButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(666, 426);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(126, 51);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // newMaxCountLabel
            // 
            this.newMaxCountLabel.AutoSize = true;
            this.newMaxCountLabel.Location = new System.Drawing.Point(669, 360);
            this.newMaxCountLabel.Name = "newMaxCountLabel";
            this.newMaxCountLabel.Size = new System.Drawing.Size(59, 13);
            this.newMaxCountLabel.TabIndex = 17;
            this.newMaxCountLabel.Text = "max count:";
            this.newMaxCountLabel.Visible = false;
            // 
            // newCountLabel
            // 
            this.newCountLabel.AutoSize = true;
            this.newCountLabel.Location = new System.Drawing.Point(545, 360);
            this.newCountLabel.Name = "newCountLabel";
            this.newCountLabel.Size = new System.Drawing.Size(37, 13);
            this.newCountLabel.TabIndex = 16;
            this.newCountLabel.Text = "count:";
            this.newCountLabel.Visible = false;
            // 
            // newPriceLabel
            // 
            this.newPriceLabel.AutoSize = true;
            this.newPriceLabel.Location = new System.Drawing.Point(421, 360);
            this.newPriceLabel.Name = "newPriceLabel";
            this.newPriceLabel.Size = new System.Drawing.Size(33, 13);
            this.newPriceLabel.TabIndex = 15;
            this.newPriceLabel.Text = "price:";
            this.newPriceLabel.Visible = false;
            // 
            // newCategoryLabel
            // 
            this.newCategoryLabel.AutoSize = true;
            this.newCategoryLabel.Location = new System.Drawing.Point(297, 360);
            this.newCategoryLabel.Name = "newCategoryLabel";
            this.newCategoryLabel.Size = new System.Drawing.Size(51, 13);
            this.newCategoryLabel.TabIndex = 14;
            this.newCategoryLabel.Text = "category:";
            this.newCategoryLabel.Visible = false;
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Location = new System.Drawing.Point(173, 360);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(36, 13);
            this.newNameLabel.TabIndex = 13;
            this.newNameLabel.Text = "name:";
            this.newNameLabel.Visible = false;
            // 
            // newMaxCountTB
            // 
            this.newMaxCountTB.Location = new System.Drawing.Point(672, 376);
            this.newMaxCountTB.Multiline = true;
            this.newMaxCountTB.Name = "newMaxCountTB";
            this.newMaxCountTB.Size = new System.Drawing.Size(118, 22);
            this.newMaxCountTB.TabIndex = 12;
            this.newMaxCountTB.Visible = false;
            // 
            // newCountTB
            // 
            this.newCountTB.Location = new System.Drawing.Point(548, 376);
            this.newCountTB.Multiline = true;
            this.newCountTB.Name = "newCountTB";
            this.newCountTB.Size = new System.Drawing.Size(118, 22);
            this.newCountTB.TabIndex = 11;
            this.newCountTB.Visible = false;
            // 
            // newPriceTB
            // 
            this.newPriceTB.Location = new System.Drawing.Point(424, 376);
            this.newPriceTB.Multiline = true;
            this.newPriceTB.Name = "newPriceTB";
            this.newPriceTB.Size = new System.Drawing.Size(118, 22);
            this.newPriceTB.TabIndex = 10;
            this.newPriceTB.Visible = false;
            // 
            // newCategoryTB
            // 
            this.newCategoryTB.Location = new System.Drawing.Point(300, 376);
            this.newCategoryTB.Multiline = true;
            this.newCategoryTB.Name = "newCategoryTB";
            this.newCategoryTB.Size = new System.Drawing.Size(118, 22);
            this.newCategoryTB.TabIndex = 9;
            this.newCategoryTB.Visible = false;
            // 
            // newNameTB
            // 
            this.newNameTB.Location = new System.Drawing.Point(176, 376);
            this.newNameTB.Multiline = true;
            this.newNameTB.Name = "newNameTB";
            this.newNameTB.Size = new System.Drawing.Size(118, 22);
            this.newNameTB.TabIndex = 8;
            this.newNameTB.Visible = false;
            // 
            // newProductButton
            // 
            this.newProductButton.Location = new System.Drawing.Point(22, 347);
            this.newProductButton.Name = "newProductButton";
            this.newProductButton.Size = new System.Drawing.Size(126, 51);
            this.newProductButton.TabIndex = 7;
            this.newProductButton.Text = "Add new product";
            this.newProductButton.UseVisualStyleBackColor = true;
            this.newProductButton.Click += new System.EventHandler(this.newProductButton_Click);
            // 
            // sortingLabel
            // 
            this.sortingLabel.AutoSize = true;
            this.sortingLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sortingLabel.Location = new System.Drawing.Point(772, 15);
            this.sortingLabel.Name = "sortingLabel";
            this.sortingLabel.Size = new System.Drawing.Size(48, 15);
            this.sortingLabel.TabIndex = 6;
            this.sortingLabel.Text = "sort by:";
            // 
            // categorySortButton
            // 
            this.categorySortButton.Location = new System.Drawing.Point(771, 154);
            this.categorySortButton.Name = "categorySortButton";
            this.categorySortButton.Size = new System.Drawing.Size(71, 54);
            this.categorySortButton.TabIndex = 5;
            this.categorySortButton.Text = "category";
            this.categorySortButton.UseVisualStyleBackColor = true;
            this.categorySortButton.Click += new System.EventHandler(this.categorySortButton_Click);
            // 
            // priceSortButton
            // 
            this.priceSortButton.Location = new System.Drawing.Point(771, 214);
            this.priceSortButton.Name = "priceSortButton";
            this.priceSortButton.Size = new System.Drawing.Size(71, 54);
            this.priceSortButton.TabIndex = 4;
            this.priceSortButton.Text = "price";
            this.priceSortButton.UseVisualStyleBackColor = true;
            this.priceSortButton.Click += new System.EventHandler(this.priceSortButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshButton.Location = new System.Drawing.Point(771, 274);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(71, 54);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "REFRESH";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // nameSortButton
            // 
            this.nameSortButton.Location = new System.Drawing.Point(771, 94);
            this.nameSortButton.Name = "nameSortButton";
            this.nameSortButton.Size = new System.Drawing.Size(71, 54);
            this.nameSortButton.TabIndex = 2;
            this.nameSortButton.Text = "name";
            this.nameSortButton.UseVisualStyleBackColor = true;
            this.nameSortButton.Click += new System.EventHandler(this.nameSortButton_Click);
            // 
            // idSortButton
            // 
            this.idSortButton.Location = new System.Drawing.Point(771, 34);
            this.idSortButton.Name = "idSortButton";
            this.idSortButton.Size = new System.Drawing.Size(71, 54);
            this.idSortButton.TabIndex = 1;
            this.idSortButton.Text = "id";
            this.idSortButton.UseVisualStyleBackColor = true;
            this.idSortButton.Click += new System.EventHandler(this.idSortButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(54, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(462, 305);
            this.dataGridView2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "id";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.idSortButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 54);
            this.button2.TabIndex = 8;
            this.button2.Text = "name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.nameSortButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 54);
            this.button3.TabIndex = 9;
            this.button3.Text = "category";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.categorySortButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(545, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 54);
            this.button4.TabIndex = 10;
            this.button4.Text = "price";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.priceSortButton_Click);
            // 
            // sortbyLabel
            // 
            this.sortbyLabel.AutoSize = true;
            this.sortbyLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sortbyLabel.Location = new System.Drawing.Point(542, 27);
            this.sortbyLabel.Name = "sortbyLabel";
            this.sortbyLabel.Size = new System.Drawing.Size(48, 15);
            this.sortbyLabel.TabIndex = 11;
            this.sortbyLabel.Text = "sort by:";
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(54, 372);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(113, 57);
            this.buyButton.TabIndex = 12;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // productIdTB
            // 
            this.productIdTB.Location = new System.Drawing.Point(215, 409);
            this.productIdTB.Multiline = true;
            this.productIdTB.Name = "productIdTB";
            this.productIdTB.Size = new System.Drawing.Size(100, 20);
            this.productIdTB.TabIndex = 13;
            // 
            // quantityTB
            // 
            this.quantityTB.Location = new System.Drawing.Point(369, 409);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(100, 20);
            this.quantityTB.TabIndex = 14;
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Location = new System.Drawing.Point(212, 393);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(57, 13);
            this.productIdLabel.TabIndex = 15;
            this.productIdLabel.Text = "product id:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(366, 393);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(47, 13);
            this.quantityLabel.TabIndex = 16;
            this.quantityLabel.Text = "quantity:";
            // 
            // Sklep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(837, 560);
            this.ControlBox = false;
            this.Controls.Add(this._label);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.minimazeButton);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.iconPicturebox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sklep";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Sklep";
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicturebox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPanel;
        private System.Windows.Forms.PictureBox minimazeButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.PictureBox iconPicturebox;
        private System.Windows.Forms.Label panelText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Button registerButton;
        private Button loginButton;
        private Label welcomeLabel;
        private Button registerButton2;
        private Button loginButton2;
        private Label streetLabel;
        private Label cityLabel;
        private Label surnameLabel;
        private Label nameLabel;
        private Label repeatpasswordLabel;
        private Label passwordLabel;
        private Label loginLabel;
        private TextBox nameTextBox;
        private TextBox streetTextBox;
        private TextBox cityTextBox;
        private TextBox surnameTextBox;
        private TextBox repeatpasswordTextBox;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private Button categorySortButton;
        private Button priceSortButton;
        private Button refreshButton;
        private Button nameSortButton;
        private Button idSortButton;
        private Label sortingLabel;
        private TextBox newCountTB;
        private TextBox newPriceTB;
        private TextBox newCategoryTB;
        private TextBox newNameTB;
        private Button newProductButton;
        private Button AddButton;
        private Label newMaxCountLabel;
        private Label newCountLabel;
        private Label newPriceLabel;
        private Label newCategoryLabel;
        private Label newNameLabel;
        private TextBox newMaxCountTB;
        private Button replenishButton;
        private TextBox idTB;
        private Button finalButton;
        private Label howManyLabel;
        private Label idLabel;
        private TextBox howManyTB;
        private Button changePriceButton;
        private Label clientNameLabel;
        private Label clientBalanceLabel;
        private Button addBalanceButton;
        private TextBox addBalanceTB;
        private Button addMoreBalance;
        private DataGridView dataGridView2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label sortbyLabel;
        private Label quantityLabel;
        private Label productIdLabel;
        private TextBox quantityTB;
        private TextBox productIdTB;
        private Button buyButton;
    }
}

