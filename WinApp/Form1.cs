using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Form1 : Form
    {
        localhost.WebService wb = new localhost.WebService();
        public Form1()
        {
            InitializeComponent();
            
        }

        public void showData()
        {
            DataTable dt = new DataTable();
            dt = wb.getData();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        public void insertDane()
        {
           
            ServiceReference1.WebServiceSoapClient web= new ServiceReference1.WebServiceSoapClient();
            web.insertRecord(pomiar:textBox1.Text,data_pomiaru:textBox2.Text);
            
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           insertDane();
          // showData();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Wyniki_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            dataGridView1.ClearSelection();
        }
    }
}
