using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void addVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;     
            Form2 f = new Form2();  
            f.Visible = true;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            
            textBox_price_adult_holiday.Clear();
            textBox_price_adult_weekend.Clear();
            textBox_price_aged_holiday.Clear();
            textBox_price_aged_weekend.Clear();
            textBox_price_child_weekend.Clear();
            textBox_price_child_holiday.Clear();

            comboBox_group.Text = string.Empty;
            comboBox_hours.Text = string.Empty;
        }
    }
}
