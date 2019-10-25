using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _Inventory
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void addUser_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'iREM_InventoryDataSet2.PCMan' table. You can move, or remove it, as needed.
            //this.pCManTableAdapter1.Fill(this.iREM_InventoryDataSet2.PCMan);
            //// TODO: This line of code loads data into the 'iREM_InventoryDataSet1.PCMan' table. You can move, or remove it, as needed.
            //this.pCManTableAdapter.Fill(this.iREM_InventoryDataSet1.PCMan);

            string getMake = "SELECT DISTINCT man FROM PCMan";
            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";
            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteCommand cmd = new SQLiteCommand(getMake, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox3.Text = "";

            if (comboBox1.Text == "Unknown")
            {
               
                    comboBox2.Text = "Unknown";
                    comboBox3.Text = "Unknown";
                
            }
            else
            {
                comboBox2.Items.Clear();
                string getMake = "SELECT DISTINCT manMake FROM PCMan WHERE man = '" + comboBox1.Text + "'";
                string appPath = Application.StartupPath;
                string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";
                SQLiteConnection conn = new SQLiteConnection(startupPath);
                SQLiteCommand cmd = new SQLiteCommand(getMake, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    comboBox2.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            string getMake = "SELECT DISTINCT manModel FROM PCMan WHERE manMake= '" + comboBox2.Text + "'";
            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";
            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteCommand cmd = new SQLiteCommand(getMake, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox3.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getMake = "SELECT make FROM PCMan INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE manMake= '" + comboBox2.Text + "' AND manModel = '" + comboBox3.Text + "'";
            string getModel = "SELECT model FROM PCMan INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE manMake= '" + comboBox2.Text + "' AND manModel = '" + comboBox3.Text + "'";
            string getprocessor = "SELECT processorMan FROM PCMan INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE manMake= '" + comboBox2.Text + "' AND manModel = '" + comboBox3.Text + "'";

            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";
            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteCommand cmd = new SQLiteCommand(getprocessor, conn);
            SQLiteCommand cmd2 = new SQLiteCommand(getMake, conn);
            SQLiteCommand cmd3 = new SQLiteCommand(getModel, conn);
            //SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    comboBox4.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            //}
            conn.Open();
            comboBox4.Text = cmd.ExecuteScalar().ToString();
            comboBox5.Text = cmd2.ExecuteScalar().ToString();
            comboBox6.Text = cmd3.ExecuteScalar().ToString();

            conn.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dualMonitor = "0";
            string printer = "0";

            if (checkBox2.Checked)
            {
                printer = "1";
            }

            if (checkBox1.Checked)
            {
                dualMonitor = "1";
            }
            string insertUser = "INSERT INTO user (userFName, userLName, userExt) VALUES ('"+fname.Text+"', '"+lname.Text+"', '"+ext.Text+"')";
            string subQueryInsertUserID = "SELECT  userID FROM user WHERE userFName = '"+fname.Text+"' AND userLName = '"+lname.Text+"' AND userExt = '"+ext.Text+"'";
            string subQueryInsertPCManID = "SELECT  manID FROM PCMan WHERE man = '" + comboBox1.Text + "' AND manMake = '" + comboBox2.Text + "' AND manModel = '" + comboBox3.Text + "'";
            string insertUserInfo = "INSERT INTO userPC (hostName, userID, servicetag, RAM, HDD, OS, PCManID, type, inventoryID, year, printer) VALUES ('"+hostName+"', ("+subQueryInsertUserID+"), '"+pcTag.Text+"', '"+ram.Text+"', '"+hdd.Text+"', '"+os.Text+"', ('"+subQueryInsertPCManID+"'), '"+type.Text+"', '"+inventoryID.Text+"', '"+year.Text+"', '"+printer+"')";
            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";
            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteCommand cmd = new SQLiteCommand(insertUser, conn);
            SQLiteCommand cmd2 = new SQLiteCommand("INSERT INTO userPC (hostName, userID, servicetag, RAM, HDD, OS, PCManID, type, inventoryID, year, arch, dualGraphics, printer) VALUES ('" + hostName.Text + "', (" + subQueryInsertUserID + "), '" + pcTag.Text + "', '" + ram.Text + "', '" + hdd.Text + "', '" + os.Text + "', (SELECT manID FROM PCMan WHERE man = '" + comboBox1.Text + "' AND manMake = '" + comboBox2.Text + "' AND manModel = '" + comboBox3.Text + "'), '" + type.Text + "', '" + inventoryID.Text + "', '" + year.Text + "', '"+comboBox7.Text+"', '"+dualMonitor+"', '"+printer+"')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();
        }
    }
}
