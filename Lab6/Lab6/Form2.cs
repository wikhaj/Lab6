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
        public string tmp_publisher { get; set; }
        public int tmp_year { get; set; }
        public string tmp_city { get; set; }
        public bool tmp_status { get; set; }

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

            if(!String.IsNullOrEmpty(textBox3.Text))
            {
                tmp_publisher = textBox3.Text;
                textBox3.Clear();
                tmp_city = textBox4.Text;
                textBox4.Clear();
                tmp_year = Int32.Parse(textBox6.Text);
                textBox6.Clear();

                if(comboBox1.SelectedIndex == 0)
                {
                    tmp_status = true;
                }else if(comboBox1.SelectedIndex == 1)
                {
                    tmp_status = false;
                }else 
                {
                    MessageBox.Show("Domyślny status to wypożyczony!");
                }
                Book book = new Book(tmp_title, tmp_author, tmp_id, tmp_publisher, tmp_year, tmp_city, tmp_status);
                for1.bindingSource1.Add(book);
                Program.book_list.Add(book);
                for1.dataGridView1.DataSource = for1.bindingSource1;

                for1.dataGridView1.Update();
                for1.dataGridView1.Refresh();
            }
            else
            {
                for1.bindingSource1.Add(new Book(tmp_title, tmp_author, tmp_id));
                for1.dataGridView1.DataSource = for1.bindingSource1;

                for1.dataGridView1.Update();
                for1.dataGridView1.Refresh();
            }


            this.Close();

        }
    }
}
