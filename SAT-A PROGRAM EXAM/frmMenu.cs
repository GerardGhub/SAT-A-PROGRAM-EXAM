using MaterialSkin.Controls;
using SAT_A_PROGRAM_EXAM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAT_A_PROGRAM_EXAM
{
    public partial class frmMenu : MaterialForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Exam1Modify()
        {
            this.matbtnexam2.Enabled = false;
            this.matbtnexam3.Enabled = false;
        }


        private void Exam1Modify2()
        {
            this.matbtnExam1.Enabled = false;
            this.matbtnexam3.Enabled = false;
        }

        private void Exam1Modify3()
        {
            this.matbtnExam1.Enabled = false;
            this.matbtnexam2.Enabled = false;
        }


        private void matbtnExam1_Click(object sender, EventArgs e)
        {

            this.Exam1Modify();
           frmExamNumberOne mywipwh = new frmExamNumberOne(this      
                );
            mywipwh.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(this.textBox1.Text == "FormClosing")
            {
                this.ButtonEnabled();
            }

            this.textBox1.Text = String.Empty;
        }

        private void ButtonEnabled()
        {
            this.matbtnExam1.Enabled = true;
            this.matbtnexam2.Enabled = true;
            this.matbtnexam3.Enabled = true;
        }

        private void matbtnexam2_Click(object sender, EventArgs e)
        {

            this.Exam1Modify2();
            frmExamNumberTwo mywipwh = new frmExamNumberTwo(this
                 );
            mywipwh.ShowDialog();
        }

        private void matbtnexam3_Click(object sender, EventArgs e)
        {
            this.Exam1Modify3();
            frmExamNumberTres mywipwh = new frmExamNumberTres(this
                 );
            mywipwh.ShowDialog();
        }
    }
}
