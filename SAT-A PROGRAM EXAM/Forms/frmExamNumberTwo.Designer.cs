
namespace SAT_A_PROGRAM_EXAM.Forms
{
    partial class frmExamNumberTwo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.matbtnyes = new MaterialSkin.Controls.MaterialFlatButton();
            this.matbtnno = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guesing Game think of a number 1 - 1000";
            // 
            // matbtnyes
            // 
            this.matbtnyes.AutoSize = true;
            this.matbtnyes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnyes.Depth = 0;
            this.matbtnyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matbtnyes.Location = new System.Drawing.Point(206, 204);
            this.matbtnyes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnyes.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnyes.Name = "matbtnyes";
            this.matbtnyes.Primary = false;
            this.matbtnyes.Size = new System.Drawing.Size(36, 36);
            this.matbtnyes.TabIndex = 2;
            this.matbtnyes.Text = "YES ";
            this.matbtnyes.UseVisualStyleBackColor = true;
            this.matbtnyes.Click += new System.EventHandler(this.matbtnyes_Click);
            // 
            // matbtnno
            // 
            this.matbtnno.AutoSize = true;
            this.matbtnno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnno.Depth = 0;
            this.matbtnno.Location = new System.Drawing.Point(487, 204);
            this.matbtnno.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnno.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnno.Name = "matbtnno";
            this.matbtnno.Primary = false;
            this.matbtnno.Size = new System.Drawing.Size(31, 36);
            this.matbtnno.TabIndex = 3;
            this.matbtnno.Text = "NO";
            this.matbtnno.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(652, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // frmExamNumberTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.matbtnno);
            this.Controls.Add(this.matbtnyes);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExamNumberTwo";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExamNumberTwo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExamNumberTwo_FormClosing);
            this.Load += new System.EventHandler(this.frmExamNumberTwo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton matbtnyes;
        private MaterialSkin.Controls.MaterialFlatButton matbtnno;
        public System.Windows.Forms.TextBox textBox1;
    }
}