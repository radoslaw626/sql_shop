using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SQL_Sklep
{
    public partial class Sklep : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8SVGI16;Initial Catalog=TestingDatabase;Integrated Security=True");
        public bool mouseDown;
        public int mouseX = 0, mouseY = 0, mouseinX = 0, mouseinY = 0;
        public bool sortId = false;
        public string sortString = "id asc";
        bool selectedButton;
        public Sklep()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.loginLabel.Visible = true;
            this.passwordLabel.Visible = true;
            this.loginTextBox.Visible = true;
            this.passwordTextBox.Visible = true;
            this.loginButton2.Visible = true;
            this.loginButton.Visible = false;
            this.registerButton2.Visible = false;
            this.registerButton.Visible = true;
            this.repeatpasswordLabel.Visible = false;
            this.repeatpasswordTextBox.Visible = false;
            this.nameLabel.Visible = false;
            this.nameTextBox.Visible = false;
            this.surnameLabel.Visible = false;
            this.surnameTextBox.Visible = false;
            this.cityLabel.Visible = false;
            this.cityTextBox.Visible = false;
            this.streetLabel.Visible = false;
            this.streetTextBox.Visible = false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.loginLabel.Visible = true;
            this.passwordLabel.Visible = true;
            this.loginTextBox.Visible = true;
            this.passwordTextBox.Visible = true;
            this.registerButton2.Visible = true;
            this.loginButton.Visible = true;
            this.loginButton2.Visible = false;
            this.registerButton.Visible = false;
            this.repeatpasswordLabel.Visible = true;
            this.repeatpasswordTextBox.Visible = true;
            this.nameLabel.Visible = true;
            this.nameTextBox.Visible = true;
            this.surnameLabel.Visible = true;
            this.surnameTextBox.Visible = true;
            this.cityLabel.Visible = true;
            this.cityTextBox.Visible = true;
            this.streetLabel.Visible = true;
            this.streetTextBox.Visible = true;
        }

        private void registerButton2_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == repeatpasswordTextBox.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand
                    ("insert into Clients ( balance, name, surname, city, street,login,password)" +
                    "values (0," +
                    "'" + nameTextBox.Text + "'," +
                    "'" + surnameTextBox.Text + "'," +
                    "'" + cityTextBox.Text + "'," +
                    "'" + streetTextBox.Text + "'," +
                    "'" + loginTextBox.Text + "'," +
                    "'" + repeatpasswordTextBox.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Registered");
                }
                else
                {
                    MessageBox.Show("error");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }
        public string login;
        public string password;
        public void loginButton2_Click(object sender, EventArgs e)
        {
            login = loginTextBox.Text.Trim();
            password = passwordTextBox.Text.Trim();
            string query = "select * from Clients where login = '" + loginTextBox.Text.Trim() + "' and password = '" + passwordTextBox.Text.Trim() + "'";
            string queryAdmin = "select * from Admins where login = '" + loginTextBox.Text.Trim() + "' and password = '" + passwordTextBox.Text.Trim() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlDataAdapter daAdmin = new SqlDataAdapter(queryAdmin, con);
            DataTable dt = new DataTable();
            DataTable dtAdmin = new DataTable();
            da.Fill(dt);
            daAdmin.Fill(dtAdmin);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Logged in");
                tabControl1.SelectedIndex = 1;
            }
            else if (dtAdmin.Rows.Count == 1)
            {
                MessageBox.Show("Logged in as admin");
                tabControl1.SelectedIndex = 2;
            }
            else
            {
                MessageBox.Show("Incorrect login or password");
            }
        }
        public void grid()
        {
            con.Open();

            if (tabControl1.SelectedIndex == 2)
            {
                string databaseQuery = "select *, case" +
             " when count<= maxcount / 2 then 'low'" +
             " when count = maxcount then 'full'" +
             " when count> maxcount / 2 and count<maxcount then 'ok'" +
             " when count = 0 then 'empty'" +
             " end as 'stock condition'" +
             " from Products" +
             " order by " + sortString;

                SqlDataAdapter databaseAdapter = new SqlDataAdapter(databaseQuery, con);
                DataTable dt = new DataTable();
                databaseAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            con.Close();
        }
        public void gridClient()
        {
            con.Open();

            if (tabControl1.SelectedIndex == 1)
            {
                string databaseQuery = "select id, name, category, price from Products" +
             " order by " + sortString;
                SqlDataAdapter databaseAdapter = new SqlDataAdapter(databaseQuery, con);
                DataTable dt = new DataTable();
                databaseAdapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            con.Close();
        }
        public int clientBalance = 0;
        public int clientId = 0;
        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
                grid();
            if (tabControl1.SelectedIndex == 1)
            {
                gridClient();
                con.Open();
                string clientName = "";
                string query1 = "select name, balance, clientid from Clients where login = '" + login + "' and password = '" + password + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                while (rd1.Read())
                {
                    clientName = rd1.GetString(0);
                    clientBalance = rd1.GetInt32(1);
                    clientId = rd1.GetInt32(2);
                }

                rd1.Close();
                clientNameLabel.Text = "Hello, " + clientName;
                string clientBalanceStr = clientBalance.ToString();
                clientBalanceLabel.Text = "Your balance: " + clientBalance + " PLN";
                con.Close();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            grid();
        }

        private void idSortButton_Click(object sender, EventArgs e)
        {
            if (sortId == true)
            {
                sortId = false;
                sortString = "id desc";
                grid();
                gridClient();
            }
            else
            {
                sortString = "id asc";
                sortId = true;
                grid();
                gridClient();
            }
        }

        private void nameSortButton_Click(object sender, EventArgs e)
        {
            if (sortId == true)
            {
                sortId = false;
                sortString = "name desc";
                grid();
                gridClient();
            }
            else
            {
                sortString = "name asc";
                sortId = true;
                grid();
                gridClient();
            }
        }

        private void categorySortButton_Click(object sender, EventArgs e)
        {
            if (sortId == true)
            {
                sortId = false;
                sortString = "category desc";
                grid();
                gridClient();
            }
            else
            {
                sortString = "category asc";
                sortId = true;
                grid();
                gridClient();
            }
        }

        private void priceSortButton_Click(object sender, EventArgs e)
        {
            if (sortId == true)
            {
                sortId = false;
                sortString = "price desc";
                grid();
                gridClient();
            }
            else
            {
                sortString = "price asc";
                sortId = true;
                grid();
                gridClient();
            }
        }

        private void newProductButton_Click(object sender, EventArgs e)
        {
            newNameLabel.Visible = true;
            newCategoryLabel.Visible = true;
            newPriceLabel.Visible = true;
            newCountLabel.Visible = true;
            newMaxCountLabel.Visible = true;
            newNameTB.Visible = true;
            newCategoryTB.Visible = true;
            newPriceTB.Visible = true;
            newCountTB.Visible = true;
            newMaxCountTB.Visible = true;
            AddButton.Visible = true;
            newProductButton.Visible = true;
            finalButton.Visible = false;
            replenishButton.Visible = true;
            idLabel.Visible = false;
            idTB.Visible = false;
            howManyLabel.Visible = false;
            howManyTB.Visible = false;
            replenishButton.Visible = true;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand
                    ("insert into Products (name, category, price, count, maxcount)" +
                    "values" +
                    " ('" + newNameTB.Text.Trim() + "'," +
                    "'" + newCategoryTB.Text.Trim() + "'," +
                    "'" + newPriceTB.Text.Trim() + "'," +
                    "'" + newCountTB.Text.Trim() + "'," +
                    "'" + newMaxCountTB.Text.Trim() + "')", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Added");
                newNameTB.Clear();
                newCategoryTB.Clear();
                newPriceTB.Clear();
                newCountTB.Clear();
                newMaxCountTB.Clear();
            }
            con.Close();
        }

        private void replenishButton_Click(object sender, EventArgs e)
        {
            finalButton.Visible = true;
            replenishButton.Visible = true;
            idTB.Visible = true;
            idLabel.Visible = true;
            howManyLabel.Visible = true;
            howManyTB.Visible = true;
            newProductButton.Visible = true;
            newNameLabel.Visible = false;
            newCategoryLabel.Visible = false;
            newPriceLabel.Visible = false;
            newCountLabel.Visible = false;
            newMaxCountLabel.Visible = false;
            newNameTB.Visible = false;
            newCategoryTB.Visible = false;
            newPriceTB.Visible = false;
            newCountTB.Visible = false;
            newMaxCountTB.Visible = false;
            AddButton.Visible = false;
            selectedButton = true;
            finalButton.Text = "Replenish";
            howManyLabel.Text = "how many:";
            howManyTB.Clear();
            idTB.Clear();
        }
        public int maxcount, count, id, howMany;

        private void addMoreBalance_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = clientId.ToString();
            int added;
            Int32.TryParse(addBalanceTB.Text.Trim(), out added);
            int newBalance = clientBalance + added;
            clientBalance = newBalance;
            string add = newBalance.ToString();
            string query2 = "update Clients set balance = " + add + " where clientid = " + id;
            SqlCommand cmd2 = new SqlCommand(query2, con);
            int i = cmd2.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Success");
            }
            clientBalanceLabel.Text = "Your balance: " + clientBalance + " PLN";
            con.Close();
        }
        public bool a = true;

        private void buyButton_Click(object sender, EventArgs e)
        {

            int price = 1;
            int count = 1;
            string query = "select price,count from Products where id = " + productIdTB.Text.Trim();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                price = rd.GetInt32(0);
                count = rd.GetInt32(1);
            }
            rd.Close();
            int quantity;
            string id = clientId.ToString();
            Int32.TryParse(quantityTB.Text.Trim(), out quantity);
            int sum = quantity * price;
            int finalFunds = clientBalance - sum;
            int newCount = count - quantity;
            if (clientBalance < sum)
            {
                MessageBox.Show("Not enough funds");
                con.Close();
                return;
            }
            string newCountStr = newCount.ToString();
            string finalFundsStr = finalFunds.ToString();
            string query1 = "update Clients set balance = " + finalFundsStr + " where clientid = " + id;
            SqlCommand cmd2 = new SqlCommand(query1, con);
            int i = cmd2.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Success");
            }
            clientBalanceLabel.Text = "Your balance: " + finalFunds + " PLN";
            string query3 = "update Products set count = " + newCountStr + " where id = " + productIdTB.Text.Trim();
            SqlCommand cmd3 = new SqlCommand(query3, con);
            cmd3.ExecuteNonQuery();
            clientBalance = finalFunds;
            con.Close();
        }

        private void addBalanceButton_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                a = false;
                addMoreBalance.Visible = true;
                addBalanceTB.Visible = true;
            }
            else
            {
                addMoreBalance.Visible = false;
                addBalanceTB.Visible = false;
                a = true;
            }
        }

        private void changePriceButton_Click(object sender, EventArgs e)
        {
            finalButton.Visible = true;
            replenishButton.Visible = true;
            idTB.Visible = true;
            idLabel.Visible = true;
            howManyLabel.Visible = true;
            howManyTB.Visible = true;
            newProductButton.Visible = true;
            newNameLabel.Visible = false;
            newCategoryLabel.Visible = false;
            newPriceLabel.Visible = false;
            newCountLabel.Visible = false;
            newMaxCountLabel.Visible = false;
            newNameTB.Visible = false;
            newCategoryTB.Visible = false;
            newPriceTB.Visible = false;
            newCountTB.Visible = false;
            newMaxCountTB.Visible = false;
            AddButton.Visible = false;
            selectedButton = false;
            finalButton.Text = "Change price";
            howManyLabel.Text = "new price:";
            howManyTB.Clear();
            idTB.Clear();
        }

        private void finalButton_Click(object sender, EventArgs e)
        {
            if (selectedButton == true)
            {
                if (idTB.TextLength != 0 && howManyTB.TextLength != 0)
                {
                    string idTBString = idTB.Text.Trim();
                    string howManyStr = howManyTB.Text.Trim();
                    Int32.TryParse(idTBString, out id);
                    Int32.TryParse(howManyStr, out howMany);
                    string query = "select maxcount from Products where id = " + idTBString;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        maxcount = rd.GetInt32(0);
                        string strMaxCount = maxcount.ToString();
                    }
                    rd.Close();
                    string query1 = "select count from Products where id = " + idTBString;
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    if (rd1.HasRows)
                    {
                        rd1.Read();
                        count = rd1.GetInt32(0);
                        string strCount = count.ToString();
                    }
                    rd1.Close();
                    if (count + howMany >= 0)
                    {
                        if (count + howMany <= maxcount)
                        {
                            int sum = howMany + count;
                            string add = sum.ToString();
                            string query2 = "update Products " +
                                "set count = " + add + " where id = " + idTBString;
                            SqlCommand cmd2 = new SqlCommand(query2, con);
                            int i = cmd2.ExecuteNonQuery();
                            if (i != 0)
                            {
                                MessageBox.Show("Success");
                            }
                        }

                        else if (count + howMany > maxcount)
                        {
                            MessageBox.Show("Not enough space");
                        }
                    }
                    else
                        MessageBox.Show("Count can not be negative number");
                }
                else
                {
                    MessageBox.Show("Add values");
                }
                con.Close();
            }
            else if (selectedButton == false)
            {
                con.Open();
                string idTBString = idTB.Text.Trim();
                string howMuch = howManyTB.Text.Trim();
                string query3 = "update Products set price = " + howMuch + " where id = " + idTBString;
                SqlCommand cmd3 = new SqlCommand(query3, con);
                int i = cmd3.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Success");
                }
                con.Close();
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void minimazeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
