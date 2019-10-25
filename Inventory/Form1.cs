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
using iTextSharp.text.pdf;
using iTextSharp.text;
using itextsharp.pdfa;
using System.IO;
using System.Reflection;

namespace _Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";

            string selectAllData = "SELECT user.userID, userFName, userLName, userExt, hostName, servicetag, RAM, HDD, OS, arch, type, inventoryID, year, man, manMake, manModel,  processorMan, make, model, speed FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID";
            string count = "SELECT count(*) FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID";

            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectAllData, conn);
            //SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
           // dataGridView1.ColumnHeadersVisible = false;

             SQLiteCommand getCountCommand = new SQLiteCommand(count, conn);
            conn.Open();
            label3.Text = getCountCommand.ExecuteScalar().ToString();
            conn.Close();

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int upgradeYear = year - 3;
            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";

            string selectAllData = "SELECT user.userID, userFName, userLName, userExt, hostName, servicetag, RAM, HDD, OS, arch, type, inventoryID, year, man, manMake, manModel,  processorMan, make, model, speed FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE year <= '" + upgradeYear + "' AND userFname != 'Loaner'";
            string count = "SELECT count(*) FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE year <= '" + upgradeYear + "' AND userFname != 'Loaner'";

            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectAllData, conn);
            //SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            SQLiteCommand getCountCommand = new SQLiteCommand(count, conn);
            conn.Open();
            label3.Text = getCountCommand.ExecuteScalar().ToString();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string fName = dataGridView1.CurrentCell.Value.ToString();
            //string lName = dataGridView1.CurrentCell.ColumnIndex[1];
            if (dataGridView1.CurrentCell.ColumnIndex == 0 && fName.Any(char.IsDigit))
            {
               // MessageBox.Show("Index is 0");
                editUser editUser = new editUser();
                editUser.ID.Text = fName;
                editUser.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 hideForm1 = new Form1();
            hideForm1.Hide();
            addUser add = new addUser();
            add.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";

            string selectAllData = "SELECT user.userID, userFName, userLName, userExt, hostName, servicetag, RAM, HDD, OS, arch, type, inventoryID, year, man, manMake, manModel,  processorMan, make, model, speed FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE dualGraphics = 0 AND userFName != 'Loaner'";
            string count = "SELECT count(*) FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE dualGraphics = 0 AND userFName != 'Loaner'";

            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectAllData, conn);
            //SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            SQLiteCommand getCountCommand = new SQLiteCommand(count, conn);
            conn.Open();
            label3.Text = getCountCommand.ExecuteScalar().ToString();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 hideForm1 = new Form1();
            hideForm1.Hide();
            addPC add = new addPC();
            add.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";

            string selectAllData = "SELECT user.userID, userFName, userLName, userExt, hostName, servicetag, RAM, HDD, OS, arch, type, inventoryID, year, man, manMake, manModel,  processorMan, make, model, speed FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID";
            string count = "SELECT count(*) FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID";

            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectAllData, conn);
            //SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            SQLiteCommand getCountCommand = new SQLiteCommand(count, conn);
            conn.Open();
            label3.Text = getCountCommand.ExecuteScalar().ToString();
            conn.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";

            string selectAllData = "SELECT user.userID, userFName, userLName, userExt, hostName, servicetag, RAM, HDD, OS, arch, type, inventoryID, year, man, manMake, manModel,  processorMan, make, model, speed FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE user.userFName LIKE '%" + searchBox.Text + "%' OR user.userLName LIKE '%" + searchBox.Text + "%' OR year = '" + searchBox.Text + "' OR man LIKE '%" + searchBox.Text + "%' OR manMake LIKE '%" + searchBox.Text + "%' OR manModel LIKE '%" + searchBox.Text + "%'";
            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectAllData, conn);
            //SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data

            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }


            Stream myStream;
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.Filter = "PDF file (*.pdf*)|*.pdf";
            saveFile1.FilterIndex = 2;
            saveFile1.RestoreDirectory = true;

            if (saveFile1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFile1.OpenFile()) != null)
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, myStream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    myStream.Close();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";

            string selectAllData = "SELECT user.userID, userFName, userLName, userExt, hostName, servicetag, RAM, HDD, OS, arch, type, inventoryID, year, man, manMake, manModel,  processorMan, make, model, speed FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE printer = 1 AND userFName != 'Loaner'";
            string count = "SELECT count(*) FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE printer = 1 AND userFName != 'Loaner'";

            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectAllData, conn);
            //SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            SQLiteCommand getCountCommand = new SQLiteCommand(count, conn);
            conn.Open();
            label3.Text = getCountCommand.ExecuteScalar().ToString();
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";

            string selectAllData = "SELECT user.userID, userFName, userLName, userExt, hostName, servicetag, RAM, HDD, OS, arch, type, inventoryID, year, man, manMake, manModel,  processorMan, make, model, speed FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE printer != 1 AND userFName != 'Loaner'";
            string count = "SELECT count(*) FROM user INNER JOIN userPC ON user.userID= userPC.userID INNER JOIN PCMan ON PCMan.ManID = userPC.PCManID INNER JOIN processor ON processor.processorID = PCMan.processorID WHERE printer != 1 AND userFName != 'Loaner'";

            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectAllData, conn);
            //SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            SQLiteCommand getCountCommand = new SQLiteCommand(count, conn);
            conn.Open();
            label3.Text = getCountCommand.ExecuteScalar().ToString();
            conn.Close();
        }
    }
}
