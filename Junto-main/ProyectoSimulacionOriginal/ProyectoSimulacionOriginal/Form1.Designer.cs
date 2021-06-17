
namespace ProyectoSimulacionOriginal
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
            this.label8 = new System.Windows.Forms.Label();
            this.tbn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNoPseudoalatorio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumaNumeroGenerado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbXo = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnV = new System.Windows.Forms.Button();
            this.btnTinas = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldisnor2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PDistancia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.label8.Location = new System.Drawing.Point(32, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Generador de Numeros Pseodoalarorios";
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(158, 175);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(108, 20);
            this.tbn.TabIndex = 28;
            this.tbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbn_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.label5.Location = new System.Drawing.Point(19, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Numeros a generar:";
            // 
            // btnNoPseudoalatorio
            // 
            this.btnNoPseudoalatorio.Location = new System.Drawing.Point(192, 133);
            this.btnNoPseudoalatorio.Name = "btnNoPseudoalatorio";
            this.btnNoPseudoalatorio.Size = new System.Drawing.Size(75, 23);
            this.btnNoPseudoalatorio.TabIndex = 26;
            this.btnNoPseudoalatorio.Text = "Generar";
            this.btnNoPseudoalatorio.UseVisualStyleBackColor = true;
            this.btnNoPseudoalatorio.Click += new System.EventHandler(this.btnNoPseudoalatorio_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNumero,
            this.ColumaNumeroGenerado});
            this.dataGridView1.Location = new System.Drawing.Point(337, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(253, 449);
            this.dataGridView1.TabIndex = 25;
            // 
            // ColumnaNumero
            // 
            this.ColumnaNumero.HeaderText = "No.";
            this.ColumnaNumero.Name = "ColumnaNumero";
            // 
            // ColumaNumeroGenerado
            // 
            this.ColumaNumeroGenerado.HeaderText = "Numero Pseudoalatorio";
            this.ColumaNumeroGenerado.Name = "ColumaNumeroGenerado";
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(63, 130);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(108, 20);
            this.tbM.TabIndex = 24;
            this.tbM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbM_KeyPress);
            // 
            // tbXo
            // 
            this.tbXo.Location = new System.Drawing.Point(63, 104);
            this.tbXo.Name = "tbXo";
            this.tbXo.Size = new System.Drawing.Size(108, 20);
            this.tbXo.TabIndex = 23;
            this.tbXo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbXo_KeyPress);
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(63, 78);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(108, 20);
            this.tbC.TabIndex = 22;
            this.tbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbC_KeyPress);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(63, 52);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(108, 20);
            this.tbA.TabIndex = 21;
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "M:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Xo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "c:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "a:";
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(36, 310);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(75, 30);
            this.btnV.TabIndex = 31;
            this.btnV.Text = "Volados";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnTinas
            // 
            this.btnTinas.Location = new System.Drawing.Point(117, 310);
            this.btnTinas.Name = "btnTinas";
            this.btnTinas.Size = new System.Drawing.Size(75, 30);
            this.btnTinas.TabIndex = 32;
            this.btnTinas.Text = "Tinas";
            this.btnTinas.UseVisualStyleBackColor = true;
            this.btnTinas.Click += new System.EventHandler(this.btnTinas_Click);
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(198, 310);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(75, 30);
            this.btnPi.TabIndex = 33;
            this.btnPi.Text = "Pi";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Distribución normal:";
            this.label7.Visible = false;
            // 
            // lbldisnor2
            // 
            this.lbldisnor2.AutoSize = true;
            this.lbldisnor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisnor2.Location = new System.Drawing.Point(139, 489);
            this.lbldisnor2.Name = "lbldisnor2";
            this.lbldisnor2.Size = new System.Drawing.Size(0, 16);
            this.lbldisnor2.TabIndex = 37;
            this.lbldisnor2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Promedio de los numeros pseodoaleatorios:";
            this.label6.Visible = false;
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio.Location = new System.Drawing.Point(155, 304);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(0, 16);
            this.lblpromedio.TabIndex = 36;
            this.lblpromedio.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 38;
            this.button1.Text = "Prueba Promedios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PDistancia
            // 
            this.PDistancia.Location = new System.Drawing.Point(158, 371);
            this.PDistancia.Name = "PDistancia";
            this.PDistancia.Size = new System.Drawing.Size(109, 40);
            this.PDistancia.TabIndex = 39;
            this.PDistancia.Text = "Prueba Distancia";
            this.PDistancia.UseVisualStyleBackColor = true;
            this.PDistancia.Click += new System.EventHandler(this.PDistancia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 494);
            this.Controls.Add(this.PDistancia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbldisnor2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblpromedio);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnTinas);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNoPseudoalatorio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.tbXo);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNoPseudoalatorio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumaNumeroGenerado;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbXo;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnTinas;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbldisnor2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblpromedio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PDistancia;
    }
}

