using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary_10._05._2023_class_work.MyStudent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dz_10._05
{
    public partial class Form1 : Form
    {
        List<Student> students;

        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
            students.Add(new Student("Ivan", 20, "ItStep"));
            students.Add(new Student("Oleg", 18, "Politeh"));
            students.Add(new Student("Kirill", 19, "ItStep"));
            students.Add(new Student("Sonya", 18, "Mechnikova"));

            listView1.Columns.Add("Имя");
            listView1.Columns.Add("Возраст");
            listView1.Columns.Add("Университет");
            listView1.View = View.Details;

            foreach (var s in students)
            {
                ListViewItem item = listView1.Items.Add(s.name);
                item.SubItems.Add(s.age.ToString());
                item.SubItems.Add(s.academy);
            }

            listView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.Items.Add(textBox1.Text);
            item.SubItems.Add(textBox2.Text);
            item.SubItems.Add(textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
    }
}
