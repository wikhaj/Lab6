using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.DataFormats;

namespace Lab6
{
    public partial class Form2 : Form
    {

        public Form1 for1;



        public string tmp_author { get; set; }
        public string tmp_title { get; set; }
        public string tmp_id { get; set; }

        public Form2(Form1 f)
        {
            InitializeComponent();
            for1 = f;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            tmp_author = textBox1.Text;
            textBox1.Clear();
            tmp_title = textBox2.Text;
            textBox2.Clear();
            tmp_id = for1.dataGridView1.Rows.Count.ToString();


            for1.bindingSource1.Add(new Book(tmp_title, tmp_author, tmp_id));
            for1.dataGridView1.DataSource = for1.bindingSource1;

            for1.dataGridView1.Update();
            for1.dataGridView1.Refresh();

            this.Close();

        }
    }
}
