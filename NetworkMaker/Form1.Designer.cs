namespace NetworkMaker
{
    partial class Form1
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
            this.lsbTeendok = new System.Windows.Forms.ListBox();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnEltavolitas = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnKalibralas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbTeendok
            // 
            this.lsbTeendok.FormattingEnabled = true;
            this.lsbTeendok.Location = new System.Drawing.Point(12, 12);
            this.lsbTeendok.Name = "lsbTeendok";
            this.lsbTeendok.Size = new System.Drawing.Size(306, 381);
            this.lsbTeendok.TabIndex = 0;
            // 
            // btnUj
            // 
            this.btnUj.Enabled = false;
            this.btnUj.Location = new System.Drawing.Point(335, 51);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(75, 23);
            this.btnUj.TabIndex = 1;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // btnEltavolitas
            // 
            this.btnEltavolitas.Location = new System.Drawing.Point(335, 95);
            this.btnEltavolitas.Name = "btnEltavolitas";
            this.btnEltavolitas.Size = new System.Drawing.Size(75, 23);
            this.btnEltavolitas.TabIndex = 2;
            this.btnEltavolitas.Text = "Eltávolítás";
            this.btnEltavolitas.UseVisualStyleBackColor = true;
            this.btnEltavolitas.Click += new System.EventHandler(this.btnEltavolitas_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(335, 350);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnKalibralas
            // 
            this.btnKalibralas.Enabled = false;
            this.btnKalibralas.Location = new System.Drawing.Point(335, 299);
            this.btnKalibralas.Name = "btnKalibralas";
            this.btnKalibralas.Size = new System.Drawing.Size(75, 23);
            this.btnKalibralas.TabIndex = 5;
            this.btnKalibralas.Text = "Kalibrálás";
            this.btnKalibralas.UseVisualStyleBackColor = true;
            this.btnKalibralas.Visible = false;
            this.btnKalibralas.Click += new System.EventHandler(this.btnKalibralas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 410);
            this.Controls.Add(this.btnKalibralas);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnEltavolitas);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.lsbTeendok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbTeendok;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnEltavolitas;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnKalibralas;
    }
}

