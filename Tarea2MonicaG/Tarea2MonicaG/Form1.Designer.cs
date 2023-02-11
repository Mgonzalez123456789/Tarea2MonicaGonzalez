namespace Tarea2MonicaG
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Numero1textBox1 = new System.Windows.Forms.TextBox();
            this.Numero2textBox2 = new System.Windows.Forms.TextBox();
            this.Numero3textBox3 = new System.Windows.Forms.TextBox();
            this.Numero4textBox4 = new System.Windows.Forms.TextBox();
            this.Promerdiobutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su nota por parcial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Parcial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Parcial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tercer Parcial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cuarto Parcial:";
            // 
            // Numero1textBox1
            // 
            this.Numero1textBox1.Location = new System.Drawing.Point(397, 104);
            this.Numero1textBox1.Name = "Numero1textBox1";
            this.Numero1textBox1.Size = new System.Drawing.Size(100, 20);
            this.Numero1textBox1.TabIndex = 5;
            this.Numero1textBox1.TextChanged += new System.EventHandler(this.Numero1textBox1_TextChanged);
            // 
            // Numero2textBox2
            // 
            this.Numero2textBox2.Location = new System.Drawing.Point(397, 152);
            this.Numero2textBox2.Name = "Numero2textBox2";
            this.Numero2textBox2.Size = new System.Drawing.Size(100, 20);
            this.Numero2textBox2.TabIndex = 6;
            // 
            // Numero3textBox3
            // 
            this.Numero3textBox3.Location = new System.Drawing.Point(397, 199);
            this.Numero3textBox3.Name = "Numero3textBox3";
            this.Numero3textBox3.Size = new System.Drawing.Size(100, 20);
            this.Numero3textBox3.TabIndex = 7;
            // 
            // Numero4textBox4
            // 
            this.Numero4textBox4.Location = new System.Drawing.Point(397, 248);
            this.Numero4textBox4.Name = "Numero4textBox4";
            this.Numero4textBox4.Size = new System.Drawing.Size(100, 20);
            this.Numero4textBox4.TabIndex = 8;
            // 
            // Promerdiobutton1
            // 
            this.Promerdiobutton1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Promerdiobutton1.Location = new System.Drawing.Point(334, 298);
            this.Promerdiobutton1.Name = "Promerdiobutton1";
            this.Promerdiobutton1.Size = new System.Drawing.Size(101, 32);
            this.Promerdiobutton1.TabIndex = 9;
            this.Promerdiobutton1.Text = "Promedio";
            this.Promerdiobutton1.UseVisualStyleBackColor = true;
            this.Promerdiobutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Promerdiobutton1);
            this.Controls.Add(this.Numero4textBox4);
            this.Controls.Add(this.Numero3textBox3);
            this.Controls.Add(this.Numero2textBox2);
            this.Controls.Add(this.Numero1textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Numero1textBox1;
        private System.Windows.Forms.TextBox Numero2textBox2;
        private System.Windows.Forms.TextBox Numero3textBox3;
        private System.Windows.Forms.TextBox Numero4textBox4;
        private System.Windows.Forms.Button Promerdiobutton1;
    }
}

