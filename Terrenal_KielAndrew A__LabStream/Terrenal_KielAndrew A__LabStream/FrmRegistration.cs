using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terrenal_KielAndrew_A__LabStream
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            ArrayList course = new ArrayList();
            course.Add("BS information Technlogy");
            course.Add("BS Computer Science");
            course.Add("BS computer Engineeering");
            foreach (string i in course)
            {
                cbProgram.Items.Add(i);
            }
            ArrayList gender = new ArrayList();
            gender.Add("Male");
            gender.Add("Female");
            foreach (string i in gender)
            {
                cbGender.Items.Add(i);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFileName frmFileName = new FrmFileName();

        }
    }
}
