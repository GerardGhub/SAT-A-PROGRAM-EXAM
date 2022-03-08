
namespace SAT_A_PROGRAM_EXAM
{
    partial class frmMenu
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
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.materialContextMenuStrip2 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.matbtnExam1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.matbtnexam2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.matbtnexam3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // materialContextMenuStrip2
            // 
            this.materialContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip2.Depth = 0;
            this.materialContextMenuStrip2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip2.Name = "materialContextMenuStrip2";
            this.materialContextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // matbtnExam1
            // 
            this.matbtnExam1.AutoSize = true;
            this.matbtnExam1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnExam1.Depth = 0;
            this.matbtnExam1.Location = new System.Drawing.Point(41, 151);
            this.matbtnExam1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnExam1.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnExam1.Name = "matbtnExam1";
            this.matbtnExam1.Primary = false;
            this.matbtnExam1.Size = new System.Drawing.Size(61, 36);
            this.matbtnExam1.TabIndex = 2;
            this.matbtnExam1.Text = "EXAM 1";
            this.matbtnExam1.UseVisualStyleBackColor = true;
            this.matbtnExam1.Click += new System.EventHandler(this.matbtnExam1_Click);
            // 
            // matbtnexam2
            // 
            this.matbtnexam2.AutoSize = true;
            this.matbtnexam2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnexam2.Depth = 0;
            this.matbtnexam2.Location = new System.Drawing.Point(41, 219);
            this.matbtnexam2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnexam2.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnexam2.Name = "matbtnexam2";
            this.matbtnexam2.Primary = false;
            this.matbtnexam2.Size = new System.Drawing.Size(61, 36);
            this.matbtnexam2.TabIndex = 3;
            this.matbtnexam2.Text = "EXAM 2";
            this.matbtnexam2.UseVisualStyleBackColor = true;
            this.matbtnexam2.Click += new System.EventHandler(this.matbtnexam2_Click);
            // 
            // matbtnexam3
            // 
            this.matbtnexam3.AutoSize = true;
            this.matbtnexam3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnexam3.Depth = 0;
            this.matbtnexam3.Location = new System.Drawing.Point(41, 282);
            this.matbtnexam3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnexam3.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnexam3.Name = "matbtnexam3";
            this.matbtnexam3.Primary = false;
            this.matbtnexam3.Size = new System.Drawing.Size(61, 36);
            this.matbtnexam3.TabIndex = 4;
            this.matbtnexam3.Text = "EXAM 3";
            this.matbtnexam3.UseVisualStyleBackColor = true;
            this.matbtnexam3.Click += new System.EventHandler(this.matbtnexam3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(503, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.matbtnexam3);
            this.Controls.Add(this.matbtnexam2);
            this.Controls.Add(this.matbtnExam1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip2;
        private MaterialSkin.Controls.MaterialFlatButton matbtnExam1;
        private MaterialSkin.Controls.MaterialFlatButton matbtnexam2;
        private MaterialSkin.Controls.MaterialFlatButton matbtnexam3;
        public System.Windows.Forms.TextBox textBox1;
    }
}

