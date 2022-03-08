using MaterialSkin.Controls;
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

namespace SAT_A_PROGRAM_EXAM.Forms
{
    public partial class frmExamNumberTres : MaterialForm
    {
        frmMenu ths;
        DataSet dSet = new DataSet();
        public frmExamNumberTres(frmMenu frm)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
        }

        private void frmExamNumberTres_Load(object sender, EventArgs e)
        {
            this.BindSubject();
        }

        public void BindSubject()
        {
            String cone = @"Data Source=MIS-GSINGIAN-L;Initial Catalog=sata;Integrated Security=SSPI";

            //String con = @"Server=localhost\SQLEXPRESS;Initial Catalog=sata;Integrated Security=SSPI";

            SqlConnection con = new SqlConnection(cone);

            con.Open();
            string strCmd = "select * FROM [dbo].[subject] where is_active='1'";

            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbSubject.DataSource = ds.Tables[0];
            cmbSubject.DisplayMember = "subject_description";
            cmbSubject.ValueMember = "subject_description";

         
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text; ths.textBox1.Text = textBox1.Text;
        }

        private void frmExamNumberTres_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "FormClosing";
        }

        private void matbtnyes_Click(object sender, EventArgs e)
        {

            //dSet.Clear();
            //dSet = objStorProc.sp_Raw_Materials_Dry(0,
            //    this.txtMatItemCode.Text,
            //    this.txtMatItemDesc.Text, "", "", "", "", "", "", "", "", "", "", 0, "getbyname");

            //if (dSet.Tables[0].Rows.Count > 0)
            //{
            //    this.GlobalStatePopup.DataAlreadyExist();



            //    this.txtMatItemCode.Focus();
            //    return;
            //}
            //else
            //{
            //    this.MetroSave();
            //}

            //End

        }
    }
}
