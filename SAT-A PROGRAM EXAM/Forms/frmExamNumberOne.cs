using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAT_A_PROGRAM_EXAM.Forms
{
    public partial class frmExamNumberOne : MaterialForm
    {
        frmMenu ths;

        public frmExamNumberOne(frmMenu frm)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
        }

        private void frmExamNumberOne_Load(object sender, EventArgs e)
        {
    
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmExamNumberOne_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "FormClosing";
        }
    }
}
