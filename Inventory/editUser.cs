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
    public partial class editUser : Form
    {
        public editUser()
        {
            InitializeComponent();
        }

        private void editUser_Load(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";

            string fName = "SELECT userFName FROM user WHERE userID = '"+ID.Text+"'";
            string lName = "SELECT userLName FROM user WHERE userID = '" + ID.Text + "'";
            string ext = "SELECT userExt FROM user WHERE userID = '" + ID.Text + "'";
            string host = "SELECT hostName FROM userPC INNER JOIN user ON user.userID = userPC.userID WHERE user.userID = '" + ID.Text + "'";
            string tag = "SELECT servicetag FROM userPC INNER JOIN user ON user.userID = userPC.userID WHERE user.userID = '" + ID.Text + "'";
            string memory = "SELECT ram FROM userPC INNER JOIN user ON user.userID = userPC.userID WHERE user.userID = '" + ID.Text + "'";
            string hardDisk = "SELECT hdd FROM userPC INNER JOIN user ON user.userID = userPC.userID WHERE user.userID = '" + ID.Text + "'";
            string system = "SELECT os FROM userPC INNER JOIN user ON user.userID = userPC.userID WHERE user.userID = '" + ID.Text + "'";
            string systemType = "SELECT type FROM userPC INNER JOIN user ON user.userID = userPC.userID WHERE user.userID = '" + ID.Text + "'";
            string inventoryIDTag = "SELECT inventoryID FROM userPC INNER JOIN user ON user.userID = userPC.userID WHERE user.userID = '" + ID.Text + "'";
            string yearInstalled = "SELECT year FROM userPC INNER JOIN user ON user.userID = userPC.userID WHERE user.userID = '" + ID.Text + "'";
            string arch = "SELECT arch FROM userPC INNER JOIN user ON user.userID = userPC.userID WHERE user.userID = '" + ID.Text + "'";
            string dual = "SELECT dualGraphics FROM userPC INNER JOIN user ON user.userID = userPC.userID WHERE user.userID = '" + ID.Text + "'";
            string print = "SELECT printer FROM userPC INNER JOIN user ON user.userID = userPC.userID WHERE user.userID = '" + ID.Text + "'";



            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteCommand cmd = new SQLiteCommand(fName, conn);
            SQLiteCommand cmd2 = new SQLiteCommand(lName, conn);
            SQLiteCommand cmd3 = new SQLiteCommand(ext, conn);
            SQLiteCommand cmd4 = new SQLiteCommand(host, conn);
            SQLiteCommand cmd5 = new SQLiteCommand(tag, conn);
            SQLiteCommand cmd6 = new SQLiteCommand(memory, conn);
            SQLiteCommand cmd7 = new SQLiteCommand(hardDisk, conn);
            SQLiteCommand cmd8 = new SQLiteCommand(system, conn);
            SQLiteCommand cmd9= new SQLiteCommand(systemType, conn);
            SQLiteCommand cmd10 = new SQLiteCommand(inventoryIDTag, conn);
            SQLiteCommand cmd11 = new SQLiteCommand(yearInstalled, conn);
            SQLiteCommand cmd12 = new SQLiteCommand(arch, conn);
            SQLiteCommand dualgraph = new SQLiteCommand(dual, conn);
            SQLiteCommand dualPrint = new SQLiteCommand(print, conn);

            SQLiteCommand cmd13 = new SQLiteCommand("SELECT man FROM PCMan INNER JOIN userPC ON userPC.PCManID= PCMan.ManID INNER JOIN user ON userPC.userID = user.userID INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE user.userID = '"+ID.Text+"'", conn);
            SQLiteCommand cmd14 = new SQLiteCommand("SELECT manMake FROM PCMan INNER JOIN userPC ON userPC.PCManID= PCMan.ManID INNER JOIN user ON userPC.userID = user.userID INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE user.userID = '" + ID.Text + "'", conn);
            SQLiteCommand cmd15 = new SQLiteCommand("SELECT manModel FROM PCMan INNER JOIN userPC ON userPC.PCManID= PCMan.ManID INNER JOIN user ON userPC.userID = user.userID INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE user.userID = '" + ID.Text + "'", conn);



            conn.Open();
            fname.Text = cmd.ExecuteScalar().ToString();
            lname.Text = cmd2.ExecuteScalar().ToString();
            userExt.Text = cmd3.ExecuteScalar().ToString();
            hostName.Text = cmd4.ExecuteScalar().ToString();
            pcTag.Text = cmd5.ExecuteScalar().ToString();
            ram.Text = cmd6.ExecuteScalar().ToString();
            hdd.Text = cmd7.ExecuteScalar().ToString();
            os.Text = cmd8.ExecuteScalar().ToString();
            type.Text = cmd9.ExecuteScalar().ToString();
            inventoryID.Text = cmd10.ExecuteScalar().ToString();
            year.Text = cmd11.ExecuteScalar().ToString();
            comboBox7.Text = cmd12.ExecuteScalar().ToString();
            comboBox1.Text = cmd13.ExecuteScalar().ToString();
            comboBox2.Text = cmd14.ExecuteScalar().ToString();
            comboBox3.Text = cmd15.ExecuteScalar().ToString();
            string dualResult = dualgraph.ExecuteScalar().ToString();
            string printResult = dualPrint.ExecuteScalar().ToString();

            

            conn.Close();

            if (dualResult == "1")
            {
                checkBox1.Checked = true;
            }
            if (printResult == "1")
            {
                checkBox2.Checked = true;
            }




            string getMake = "SELECT DISTINCT man FROM PCMan";
            
            SQLiteCommand cmd200 = new SQLiteCommand(getMake, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd200);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            string getMake2 = "SELECT make FROM PCMan INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE manMake= '" + comboBox2.Text + "' AND manModel = '" + comboBox3.Text + "'";
            string getModel = "SELECT model FROM PCMan INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE manMake= '" + comboBox2.Text + "' AND manModel = '" + comboBox3.Text + "'";
            string getprocessor = "SELECT processorMan FROM PCMan INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE manMake= '" + comboBox2.Text + "' AND manModel = '" + comboBox3.Text + "'";

         
            SQLiteCommand cmd300 = new SQLiteCommand(getprocessor, conn);
            SQLiteCommand cmd400 = new SQLiteCommand(getMake2, conn);
            SQLiteCommand cmd500 = new SQLiteCommand(getModel, conn);
           
            conn.Open();
            comboBox4.Text = cmd300.ExecuteScalar().ToString();
            comboBox5.Text = cmd400.ExecuteScalar().ToString();
            comboBox6.Text = cmd500.ExecuteScalar().ToString();

            conn.Close();


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string dualMonitors = "";
            string printer = "0";
            if(checkBox1.Checked == true)
            {

                dualMonitors = "1";
            }
            else
            {
                dualMonitors = "0";
            }
            if (checkBox2.Checked)
            {
                printer = "1";
            }

            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";
            string updateUserCommand = "UPDATE user SET userFName = '"+fname.Text+"', userLName = '"+lname.Text+"', userExt = '"+userExt.Text+"' WHERE userID = '"+ID.Text+"'";
            string updateUserPCCommand = "UPDATE userPC SET hostName = '"+hostName.Text+"', serviceTag = UPPER('"+pcTag.Text+"'), ram = '"+ram.Text+"' , dualGraphics = '"+dualMonitors+"', hdd = '"+hdd.Text+"', os = '"+os.Text+"', type = '"+type.Text+"', inventoryID = '"+inventoryID.Text+"', year = '"+year.Text+"' , arch = '"+comboBox7.Text+"', PCManID = (SELECT manID FROM PCMan WHERE manMake = '"+comboBox2.Text+"' AND manModel = '"+comboBox3.Text+"'AND man = '"+comboBox1.Text+"'), printer = '"+printer+"' WHERE userID = '"+ID.Text+"'";
            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteCommand cmd = new SQLiteCommand(updateUserCommand, conn);
            SQLiteCommand cmd2 = new SQLiteCommand(updateUserPCCommand, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();
        }
    }
}
