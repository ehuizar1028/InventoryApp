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
    public partial class addPC : Form
    {
        public addPC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertPC = "INSERT INTO PCMan (man, manMake, manModel, processorID) VALUES ('"+manBrand.Text+"', '"+manMake.Text+"', '"+manModel.Text+"', (SELECT processorID FROM processor WHERE processorMan = '"+processorBrand.Text+"' AND make = '"+processorMake.Text+"' AND model = '"+processorModel.Text+"'))";
            string insertProcessor = "INSERT INTO processor (processorMan, make, model, speed) VALUES ('"+processorBrand.Text+"', '"+processorMake.Text+"', '"+processorModel.Text+"', '"+processorSpeed.Text+"')";
            string appPath = Application.StartupPath;
            string startupPath = "Data Source=" + appPath + "\\..\\..\\_Inventory.sqlite";
            SQLiteConnection conn = new SQLiteConnection(startupPath);
            SQLiteCommand cmd2 = new SQLiteCommand(insertProcessor, conn);
            SQLiteCommand cmd = new SQLiteCommand(insertPC, conn);
            conn.Open();
            cmd2.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
