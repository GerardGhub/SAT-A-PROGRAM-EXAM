using MaterialSkin.Controls;
using SAT_A_PROGRAM_EXAM.Class;
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
    public partial class frmExamNumberTwo : MaterialForm
    {
        Notifications GlobalStatePopup = new Notifications();
        frmMenu ths;
        int num = 0;
        public frmExamNumberTwo(frmMenu frm)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
        }

        private void frmExamNumberTwo_Load(object sender, EventArgs e)
        {

        }



        private void ConfirmationTwice()
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Is Your number "+this.GlobalStatePopup.RandomNumberExectuOne+" You want guess a number again?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Random rand = new Random();
                int number = rand.Next(0, 1000);
                this.num = 2;
                this.GlobalStatePopup.RandomNumberExectuOne = number;
                this.GlobalStatePopup.RandomNumber();
                this.ConfirmationTres();
            }
            else
            {
                return;
            }

        }


        private void ConfirmationTres()
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Is Your number " + this.GlobalStatePopup.RandomNumberExectuOne + " I have guessed your number in 2 tries?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
             
                if(this.num == 2)
                {
                    this.GlobalStatePopup.GuessedNumCOmpleted();
                    this.frmExamNumberTwo_Load(new object(), new System.EventArgs());
                }
          
            }
            else
            {
                if (this.num == 2)
                {
                    this.GlobalStatePopup.GuessedNumCOmpleted();
                    this.frmExamNumberTwo_Load(new object(), new System.EventArgs());
                }
            }

        }

        private void RandomNumber()
        {
            Random rand = new Random();
            int number = rand.Next(0, 1000);
          
        }

        private void matbtnyes_Click(object sender, EventArgs e)
        {

            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want execute your number?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Random rand = new Random();
                int number = rand.Next(0, 1000);
                this.num = 1;
                this.GlobalStatePopup.RandomNumberExectuOne = number;
                this.GlobalStatePopup.RandomNumber();
                this.ConfirmationTwice();

            }
            else
            {
                return;
            }


            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmExamNumberTwo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "FormClosing";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }
    }
}
