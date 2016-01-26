using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace KursachBD_Elya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String ErrMsg = "Error";
            String Command = String.Empty;
            int paramets = 0;
            switch (comboBoxMain.SelectedItem.ToString())
            {
                case "Клиенты":
                    Command = "Select * from Customers";
                    break;
                case "Товары":
                    Command = "Select * from Goods";
                    break;
                case "Заказы":
                    Command = "Select * from Orders";
                    break;
                case "Доставка товаров":
                    Command = "Select * from DeliveryGoods";
                    break;
                case "Типы доставки":
                    Command = "Select * from TypeOfDelivery";
                    break;
            }
            SQL.SqlState state = SQL.SqlFunc.SqlViewTable(Command, ref ds, ref ErrMsg);
            if (state == SQL.SqlState.Success)
            {
                dataGridViewMain.Visible = true;
                dataGridViewMain.DataSource = ds.Tables[0].DefaultView;
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                switch (comboBoxMain.SelectedItem.ToString())
                {
                    case "Клиенты":
                        label1.Text = "Name";
                        label2.Text = "Address";
                        label3.Text = "Phone";
                        label4.Text = "ContactName";
                        break;
                    case "Товары":
                        label1.Text = "Price";
                        label2.Text = "Description";
                        break;
                    case "Заказы":
                        label1.Text = "CustomerID";
                        label2.Text = "DeliveryGoodsID";
                        label3.Text = "Amount";
                        label4.Text = "Date";
                        break;
                    case "Доставка товаров":
                        label1.Text = "TypeOfDeliveryID";
                        label2.Text = "GoodsID";
                        break;
                    case "Типы доставки":
                        label1.Text = "Price";
                        label2.Text = "Speed";
                        break;
                }
            }
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox AB = new AboutBox();
            AB.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String ErrMsg = "Error";
            String Table = String.Empty;
            SqlCommand Command = new SqlCommand();
            switch (comboBoxMain.SelectedItem.ToString())
            {
                case "Клиенты":
                    Command.Parameters.Add("@Name", SqlDbType.VarChar, 50);
                    Command.Parameters.Add("@Address", SqlDbType.VarChar, 100);
                    Command.Parameters.Add("@Phone", SqlDbType.VarChar, 30);
                    Command.Parameters.Add("@ContactName", SqlDbType.VarChar, 50);

                    Command.Parameters["@Name"].Value = textBox1.Text;
                    Command.Parameters["@Address"].Value = textBox2.Text;
                    Command.Parameters["@Phone"].Value = textBox3.Text;
                    Command.Parameters["@ContactName"].Value = textBox4.Text;
                    Table = "Customers";
                    Command.CommandText = "INSERT INTO " + Table + " ([Name],[Address],[Phone],[ContactName]) VALUES (@Name, @Address, @Phone, @ContactName)";
                    break;
                case "Товары":
                    Command.Parameters.Add("@Price", SqlDbType.Money);
                    Command.Parameters.Add("@Description", SqlDbType.VarChar, 100);

                    SqlMoney money = Convert.ToDecimal(textBox1.Text.Replace('.', ','));
                    Command.Parameters["@Price"].Value = money;
                    Command.Parameters["@Description"].Value = textBox2.Text;
                    Table = "Goods";
                    Command.CommandText = "INSERT INTO " + Table + " ([Price],[Description]) VALUES (@Price, @Description)";
                    break;
                case "Заказы":
                    Command.Parameters.Add("@CustomerID", SqlDbType.Int);
                    Command.Parameters.Add("@DeliveryGoodsID", SqlDbType.Int);
                    Command.Parameters.Add("@Number", SqlDbType.Int);
                    Command.Parameters.Add("@Date", SqlDbType.DateTime);

                    Command.Parameters["@CustomerID"].Value = Convert.ToInt32(textBox1.Text);
                    Command.Parameters["@DeliveryGoodsID"].Value = Convert.ToInt32(textBox2.Text);
                    Command.Parameters["@Number"].Value = Convert.ToInt32(textBox3.Text);
                    Command.Parameters["@Date"].Value = textBox4.Text;
                    Table = "Orders";
                    Command.CommandText = "INSERT INTO " + Table + " ([CustomerID],[DeliveryGoodsID],[Number],[Date]) VALUES (@CustomerID, @DeliveryGoodsID, @Number, @Date)";
                    break;
                case "Доставка товаров":
                    Command.Parameters.Add("@TypeOfDeliveryID", SqlDbType.Int);
                    Command.Parameters.Add("@GoodsID", SqlDbType.Int);

                    Command.Parameters["@TypeOfDeliveryID"].Value = Convert.ToInt32(textBox1.Text);
                    Command.Parameters["@GoodsID"].Value = Convert.ToInt32(textBox2.Text);
                    Table = "DeliveryGoods";
                    Command.CommandText = "INSERT INTO " + Table + " ([TypeOfDeliveryID],[GoodsID]) VALUES (@TypeOfDeliveryID, @GoodsID)";
                    break;
                case "Типы доставки":
                    Command.Parameters.Add("@Price", SqlDbType.Money);
                    Command.Parameters.Add("@Speed", SqlDbType.Int);

                    SqlMoney money1 = Convert.ToDecimal(textBox1.Text.Replace('.', ','));
                    Command.Parameters["@Price"].Value = money1;
                    Command.Parameters["@Speed"].Value = Convert.ToInt32(textBox2.Text);
                    Table = "TypeOfDelivery";
                    Command.CommandText = "INSERT INTO " + Table + " ([Price],[Speed]) VALUES (@Price, @Speed)";
                    break;
            }
            SQL.SqlState state = SQL.SqlFunc.SqlChange(Command, ref ErrMsg);
            if (state == SQL.SqlState.Success)
            {
                SQL.SqlFunc.SqlViewTable("SELECT * FROM " + Table, ref ds, ref ErrMsg);
                dataGridViewMain.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indexDel = dataGridViewMain.CurrentRow.Index;
            DataSet ds = new DataSet();
            String ErrMsg = "Error";
            String Table = String.Empty;
            SqlCommand Command = new SqlCommand();
            switch (comboBoxMain.SelectedItem.ToString())
            {
                case "Клиенты":
                    Command.Parameters.Add("@CustomerID", SqlDbType.Int);

                    Command.Parameters["@CustomerID"].Value = Convert.ToInt32(dataGridViewMain[0, indexDel].Value.ToString());
                    Table = "Customers";
                    Command.CommandText = "DELETE FROM " + Table + " WHERE CustomerID=@CustomerID";
                    break;
                case "Товары":
                    Command.Parameters.Add("@GoodsID", SqlDbType.Int);

                    Command.Parameters["@GoodsID"].Value = Convert.ToInt32(dataGridViewMain[0, indexDel].Value.ToString());
                    Table = "Goods";
                    Command.CommandText = "DELETE FROM " + Table + " WHERE GoodsID=@GoodsID";
                    break;
                case "Заказы":
                    Command.Parameters.Add("@OrderID", SqlDbType.Int);

                    Command.Parameters["@OrderID"].Value = Convert.ToInt32(dataGridViewMain[0, indexDel].Value.ToString());
                    Table = "Orders";
                    Command.CommandText = "DELETE FROM " + Table + " WHERE OrderID=@OrderID";
                    break;
                case "Доставка товаров":
                    Command.Parameters.Add("@DeliveryGoodsID", SqlDbType.Int);

                    Command.Parameters["@DeliveryGoodsID"].Value = Convert.ToInt32(dataGridViewMain[0, indexDel].Value.ToString());
                    Table = "DeliveryGoods";
                    Command.CommandText = "DELETE FROM " + Table + " WHERE DeliveryGoodsID=@DeliveryGoodsID";
                    break;
                case "Типы доставки":
                    Command.Parameters.Add("@TypeOfDeliveryID", SqlDbType.Int);

                    Command.Parameters["@TypeOfDeliveryID"].Value = Convert.ToInt32(dataGridViewMain[0, indexDel].Value.ToString());
                    Table = "TypeOfDelivery";
                    Command.CommandText = "DELETE FROM " + Table + " WHERE TypeOfDeliveryID=@TypeOfDeliveryID";
                    break;
            }
            SQL.SqlState state = SQL.SqlFunc.SqlChange(Command, ref ErrMsg);
            if (state == SQL.SqlState.Success)
            {
                SQL.SqlFunc.SqlViewTable("SELECT * FROM " + Table, ref ds, ref ErrMsg);
                dataGridViewMain.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int indexDel = dataGridViewMain.CurrentRow.Index;
            DataSet ds = new DataSet();
            String ErrMsg = "Error";
            String Table = String.Empty;
            SqlCommand Command = new SqlCommand();
            switch (comboBoxMain.SelectedItem.ToString())
            {
                case "Клиенты":
                    Command.Parameters.Add("@CustomerID", SqlDbType.Int);
                    Command.Parameters.Add("@newName", SqlDbType.VarChar, 50);
                    Command.Parameters.Add("@newAddress", SqlDbType.VarChar, 100);
                    Command.Parameters.Add("@newPhone", SqlDbType.VarChar, 30);
                    Command.Parameters.Add("@newContactName", SqlDbType.VarChar, 50);

                    Command.Parameters["@CustomerID"].Value = Convert.ToInt32(dataGridViewMain[0, indexDel].Value.ToString());
                    Command.Parameters["@newName"].Value = textBox1.Text;
                    Command.Parameters["@newAddress"].Value = textBox2.Text;
                    Command.Parameters["@newPhone"].Value = textBox3.Text;
                    Command.Parameters["@newContactName"].Value = textBox4.Text;
                    Table = "Customers";
                    Command.CommandText = "UPDATE " + Table + " SET Name=@newName, newAddress=@newAddress, newPhone=@newPhone, newContactName=@newContactName " +
                                            "WHERE CustomerID=@CustomerID";
                    break;
                case "Товары":
                    Command.Parameters.Add("@GoodsID", SqlDbType.Int);
                    Command.Parameters.Add("@newPrice", SqlDbType.Money);
                    Command.Parameters.Add("@newDescription", SqlDbType.VarChar, 100);

                    Command.Parameters["@GoodsID"].Value = Convert.ToInt32(dataGridViewMain[0, indexDel].Value.ToString());
                    SqlMoney money = Convert.ToDecimal(textBox1.Text.Replace('.', ','));
                    Command.Parameters["@newPrice"].Value = money;
                    Command.Parameters["@newDescription"].Value = textBox2.Text;
                    Table = "Goods";
                    Command.CommandText = "UPDATE " + Table + " SET Price=@newPrice, Description=@newDescription " +
                                            "WHERE GoodsID=@GoodsID";
                    break;
                case "Заказы":
                    Command.Parameters.Add("@OrderID", SqlDbType.Int);
                    Command.Parameters.Add("@newCustomerID", SqlDbType.Int);
                    Command.Parameters.Add("@newDeliveryGoodsID", SqlDbType.Int);
                    Command.Parameters.Add("@newNumber", SqlDbType.Int);
                    Command.Parameters.Add("@newDate", SqlDbType.DateTime);

                    Command.Parameters["@newOrderID"].Value = Convert.ToInt32(dataGridViewMain[0, indexDel].Value.ToString());
                    Command.Parameters["@newCustomerID"].Value = Convert.ToInt32(textBox1.Text);
                    Command.Parameters["@newDeliveryGoodsID"].Value = Convert.ToInt32(textBox2.Text);
                    Command.Parameters["@newNumber"].Value = Convert.ToInt32(textBox3.Text);
                    Command.Parameters["@newDate"].Value = textBox4.Text;
                    Table = "Orders";
                    Command.CommandText = "UPDATE " + Table + " SET CustomerID=@newCustomerID, DeliveryGoodsID=@newDeliveryGoodsID, Number=@newNumber, Date=@newDate " +
                                            "WHERE OrderID=@OrderID";
                    break;
                case "Доставка товаров":
                    Command.Parameters.Add("@DeliveryGoodsID", SqlDbType.Int);
                    Command.Parameters.Add("@newTypeOfDeliveryID", SqlDbType.Int);
                    Command.Parameters.Add("@newGoodsID", SqlDbType.Int);

                    Command.Parameters["@DeliveryGoodsID"].Value = Convert.ToInt32(dataGridViewMain[0, indexDel].Value.ToString());
                    Command.Parameters["@newTypeOfDeliveryID"].Value = Convert.ToInt32(textBox1.Text);
                    Command.Parameters["@newGoodsID"].Value = Convert.ToInt32(textBox2.Text);
                    Table = "DeliveryGoods";
                    Command.CommandText = "UPDATE " + Table + " SET TypeOfDeliveryID=@newTypeOfDeliveryID, GoodsID=@newGoodsID " +
                                            "WHERE DeliveryGoodsID=@DeliveryGoodsID";
                    break;
                case "Типы доставки":
                    Command.Parameters.Add("@TypeOfDeliveryID", SqlDbType.Int);
                    Command.Parameters.Add("@newPrice", SqlDbType.Money);
                    Command.Parameters.Add("@newSpeed", SqlDbType.Int);

                    Command.Parameters["@TypeOfDeliveryID"].Value = Convert.ToInt32(dataGridViewMain[0, indexDel].Value.ToString());
                    SqlMoney money1 = Convert.ToDecimal(textBox1.Text.Replace('.', ','));
                    Command.Parameters["@newPrice"].Value = money1;
                    Command.Parameters["@newSpeed"].Value = Convert.ToInt32(textBox2.Text);
                    Table = "TypeOfDelivery";
                    Command.CommandText = "UPDATE " + Table + " SET Price=@newPrice, Speed=@newSpeed " +
                                            "WHERE TypeOfDeliveryID=@TypeOfDeliveryID";
                    break;
            }
            SQL.SqlState state = SQL.SqlFunc.SqlChange(Command, ref ErrMsg);
            if (state == SQL.SqlState.Success)
            {
                SQL.SqlFunc.SqlViewTable("SELECT * FROM " + Table, ref ds, ref ErrMsg);
                dataGridViewMain.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void comboBoxDemands_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String ErrMsg = "Error";
            String Command = String.Empty;
            switch (comboBoxDemands.SelectedItem.ToString())
            {
                case "Запрос 1":
                    Command = "SELECT OrderID, [Name], Speed, Description " +
                                "FROM Orders O INNER JOIN Customers C ON O.CustomerID = C.CustomerID " +
				                "INNER JOIN DeliveryGoods DG ON O.DeliveryGoodsID = DG.DeliveryGoodsID " +
				                "INNER JOIN TypeOfDelivery TOD ON DG.TypeOfDeliveryID = TOD.TypeOfDeliveryID " +
				                "INNER JOIN Goods G ON DG.GoodsID = G.GoodsID";
                    labelDemands.Text = "Информация о заказе: имя заказчика, скорость доставки, товар";
                    break;
                case "Запрос 2":
                    Command = "SELECT TOP(1) WITH TIES Description " +
                                "FROM DeliveryGoods DG INNER JOIN Goods G ON DG.GoodsID = G.GoodsID " +
				                "INNER JOIN TypeOfDelivery TOD ON DG.TypeOfDeliveryID = TOD.TypeOfDeliveryID " +
                                "ORDER BY Speed ASC";
                    labelDemands.Text = "Для каких товаров доступна самая быстрая доставка";
                    break;
                case "Запрос 3":
                    Command = "SELECT Description, (Number * Price) AS 'Price' " +
                                "FROM Orders O INNER JOIN Customers C ON O.CustomerID = C.CustomerID AND Name = 'Балиев Рафис' " +
				                "INNER JOIN DeliveryGoods DG ON O.DeliveryGoodsID = DG.DeliveryGoodsID " +
				                "INNER JOIN Goods G ON DG.GoodsID = G.GoodsID";
                    labelDemands.Text = "На сколько Балиев Рафис заказал каждый товар";
                    break;
            }
            SQL.SqlState state = SQL.SqlFunc.SqlViewTable(Command, ref ds, ref ErrMsg);
            if (state == SQL.SqlState.Success)
            {
                dataGridViewMain.Visible = true;
                dataGridViewMain.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String ErrMsg = "Error";
            String Command = "SELECT * FROM AddressesAndInfOfDelivery";
            SQL.SqlState state = SQL.SqlFunc.SqlViewTable(Command, ref ds, ref ErrMsg);
            if (state == SQL.SqlState.Success)
            {
                dataGridViewMain.Visible = true;
                dataGridViewMain.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void btnTableFunc_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String ErrMsg = "Неправильный ввод параметра табличной функции";
            if (textBoxTableFuncParam.Text.Length == 1)
            {
                String Command = "SELECT * FROM FirstLetterInName('" + textBoxTableFuncParam.Text + "')";
                SQL.SqlState state = SQL.SqlFunc.SqlViewTable(Command, ref ds, ref ErrMsg);
                if (state == SQL.SqlState.Success)
                {
                    dataGridViewMain.Visible = true;
                    dataGridViewMain.DataSource = ds.Tables[0].DefaultView;
                }
            }
            else
            {
                MessageBox.Show(ErrMsg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxScalarFuncs_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String ErrMsg = "Error";
            String Command = String.Empty;
            switch (comboBoxScalarFuncs.SelectedItem.ToString())
            {
                case "Функция 1":
                    Command = "SELECT dbo.getFullPrice() AS FullPrice";
                    labelScalarFunc.Text = "Подсчет общей стоимости всех заказов";
                    break;
            }
            SQL.SqlState state = SQL.SqlFunc.SqlViewTable(Command, ref ds, ref ErrMsg);
            if (state == SQL.SqlState.Success)
            {
                dataGridViewMain.Visible = true;
                dataGridViewMain.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void btnStoredProc_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String ErrMsg = "Неправильный ввод ID";
            Int32 ID;
            if (Int32.TryParse(textBoxStoredProcParam.Text, out ID))
            {
                String Command = "EXEC deleteClientByID " + ID.ToString();
                SQL.SqlState state = SQL.SqlFunc.SqlViewTable(Command, ref ds, ref ErrMsg);
                if (state == SQL.SqlState.Success)
                {
                    dataGridViewMain.Visible = true;
                    dataGridViewMain.DataSource = ds.Tables[0].DefaultView;
                }
            }
            else
            {
                MessageBox.Show(ErrMsg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadFromXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMain.DataSource = null;
                DataSet ds = new DataSet();
                OpenFileDialog oFD = new OpenFileDialog();
                SqlConnection connect = new SqlConnection(SQL.SqlFunc.ConnectString);
                if (oFD.ShowDialog() == DialogResult.OK)
                {
                    String commandText = "exec clearDB";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, connect);

                    dataAdapter.Fill(ds);


                    ds.ReadXml(oFD.FileName);
                    for (int j = 0; j < ds.Tables.Count; j++)
                    {
                        insertIntoTable(ds, j);
                        //MessageBox.Show(ds.Tables[j].TableName);
                    }
                    dataGridViewMain.DataSource = null;
                    MessageBox.Show("База данных успешно загружена!");
                }
            }
            catch (Exception exp)
            {
                string ErrMsg = "Method: " + exp.TargetSite.Name.ToString() + "\r\nMessage " + exp.Message + "\r\nSource " + exp.Source;
                MessageBox.Show(ErrMsg, " Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMain.DataSource = null;
                SqlConnection connect = new SqlConnection(SQL.SqlFunc.ConnectString);

                String commandText = "SELECT *  FROM [Customers]";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, connect);
                DataSet ds = new DataSet();
                ds.DataSetName = "Maintenance orders";
                ds.Tables.Add("Customers");
                dataAdapter.Fill(ds.Tables[0]);

                dataAdapter.SelectCommand.CommandText = "SELECT *  FROM [Goods]";
                ds.Tables.Add("Goods");
                dataAdapter.Fill(ds.Tables[1]);

                dataAdapter.SelectCommand.CommandText = "SELECT *  FROM [TypeOfDelivery]";
                ds.Tables.Add("TypeOfDelivery");
                dataAdapter.Fill(ds.Tables[2]);

                dataAdapter.SelectCommand.CommandText = "SELECT *  FROM [DeliveryGoods]";
                ds.Tables.Add("DeliveryGoods");
                dataAdapter.Fill(ds.Tables[3]);

                dataAdapter.SelectCommand.CommandText = "SELECT *  FROM [Orders]";
                ds.Tables.Add("Orders");
                dataAdapter.Fill(ds.Tables[4]);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML Files | *.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ds.WriteXml(saveFileDialog.FileName);
                }
                connect.Close();
                dataGridViewMain.DataSource = null;
                MessageBox.Show("База данных успешно сохранена!");
            }
            catch (Exception exp)
            {
                string ErrMsg = "Method: " + exp.TargetSite.Name.ToString() + "\r\nMessage " + exp.Message + "\r\nSource " + exp.Source;
                MessageBox.Show(ErrMsg, " Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void insertIntoTable(DataSet ds, int i)
        {

            SqlConnection conect = new SqlConnection(SQL.SqlFunc.ConnectString);


            SqlCommand com = new SqlCommand("", conect);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            string table = string.Empty;
            switch (ds.Tables[i].TableName)
            {
                case "Customers":
                    {
                        dataGridViewMain.DataSource = ds.Tables[i].DefaultView;
                        for (int j = 0; j < ds.Tables[i].DefaultView.Count; j++)
                        {

                            table = ds.Tables[i].TableName;
                            com.Parameters.Add("@Name", SqlDbType.VarChar, 50);
                            com.Parameters.Add("@Address", SqlDbType.VarChar, 100);
                            com.Parameters.Add("@Phone", SqlDbType.VarChar, 30);
                            com.Parameters.Add("@ContactName", SqlDbType.VarChar, 50);

                            com.Parameters["@Name"].Value = dataGridViewMain[1, j].Value.ToString();
                            com.Parameters["@Address"].Value = dataGridViewMain[2, j].Value.ToString();
                            com.Parameters["@Phone"].Value = dataGridViewMain[3, j].Value.ToString();
                            com.Parameters["@ContactName"].Value = dataGridViewMain[4, j].Value.ToString();
                            com.CommandText = "INSERT INTO [" + table + "] ([Name],[Address],[Phone],[ContactName]) VALUES (@Name, @Address, @Phone, @ContactName)";
                            dataAdapter.Fill(ds);
                            com.Parameters.Clear();
                        }

                        break;
                    }
                case "Goods":
                    {
                        dataGridViewMain.DataSource = ds.Tables[i].DefaultView;
                        for (int j = 0; j < ds.Tables[i].DefaultView.Count; j++)
                        {

                            table = ds.Tables[i].TableName;
                            com.Parameters.Add("@Price", SqlDbType.Money);
                            com.Parameters.Add("@Description", SqlDbType.VarChar, 100);

                            com.Parameters["@Price"].Value = Convert.ToDecimal(dataGridViewMain[1, j].Value.ToString().Replace('.', ',')); //"'" + data[0] + "'";
                            com.Parameters["@Description"].Value = dataGridViewMain[2, j].Value.ToString();
                            com.CommandText = "INSERT INTO [" + table + "] ([Price],[Description]) VALUES (@Price, @Description)";
                            dataAdapter.Fill(ds);
                            com.Parameters.Clear();
                        }
                        break;
                    }
                case "Orders":
                    {
                        dataGridViewMain.DataSource = ds.Tables[i].DefaultView;
                        for (int j = 0; j < ds.Tables[i].DefaultView.Count; j++)
                        {
                            table = ds.Tables[i].TableName;
                            com.Parameters.Add("@CustomerID", SqlDbType.Int);
                            com.Parameters.Add("@DeliveryGoodsID", SqlDbType.Int);
                            com.Parameters.Add("@Number", SqlDbType.Int);
                            com.Parameters.Add("@Date", SqlDbType.DateTime);

                            com.Parameters["@CustomerID"].Value = Convert.ToInt32(dataGridViewMain[1, j].Value.ToString());
                            com.Parameters["@DeliveryGoodsID"].Value = Convert.ToInt32(dataGridViewMain[2, j].Value.ToString());
                            com.Parameters["@Number"].Value = Convert.ToInt32(dataGridViewMain[3, j].Value.ToString());
                            com.Parameters["@Date"].Value = dataGridViewMain[4, j].Value.ToString();
                            com.CommandText = "INSERT INTO [" + table + "] ([CustomerID], [DeliveryGoodsID], [Number], [Date]) " + " VALUES (@CustomerID, @DeliveryGoodsID, @Number, @Date)";
                            dataAdapter.Fill(ds);
                            com.Parameters.Clear();
                        }
                        break;
                    }
                case "DeliveryGoods":
                    {
                        dataGridViewMain.DataSource = ds.Tables[i].DefaultView;
                        for (int j = 0; j < ds.Tables[i].DefaultView.Count; j++)
                        {

                            table = ds.Tables[i].TableName;
                            com.Parameters.Add("@TypeOfDeliveryID", SqlDbType.Int);
                            com.Parameters.Add("@GoodsID", SqlDbType.Int);

                            com.Parameters["@TypeOfDeliveryID"].Value = Convert.ToInt32(dataGridViewMain[1, j].Value.ToString());
                            com.Parameters["@GoodsID"].Value = Convert.ToInt32(dataGridViewMain[2, j].Value.ToString());

                            com.CommandText = "INSERT INTO [" + table + "] ([TypeOfDeliveryID],[GoodsID]) VALUES (@TypeOfDeliveryID, @GoodsID)";
                            dataAdapter.Fill(ds);
                            com.Parameters.Clear();
                        }


                        break;
                    }
                case "TypeOfDelivery":
                    {
                        dataGridViewMain.DataSource = ds.Tables[i].DefaultView;
                        for (int j = 0; j < ds.Tables[i].DefaultView.Count; j++)
                        {

                            table = ds.Tables[i].TableName;
                            com.Parameters.Add("@Price", SqlDbType.Money);
                            com.Parameters.Add("@Speed", SqlDbType.Int);


                            com.Parameters["@Price"].Value = Convert.ToDecimal(dataGridViewMain[1, j].Value.ToString().Replace('.',','));
                            com.Parameters["@Speed"].Value = Convert.ToInt32(dataGridViewMain[2, j].Value.ToString());

                            com.CommandText = "INSERT INTO [" + table + "] ([Price],[Speed]) VALUES (@Price, @Speed)";
                            dataAdapter.Fill(ds);
                            com.Parameters.Clear();
                        }
                        break;
                    }
            }
        }

    }
}
