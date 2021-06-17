
namespace ProyectoSimulacionOriginal
{
    partial class PruebaPromedios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVtablas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNivelSignificancia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPruebaPromedio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbldisnor = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblpromedio2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.txtVtablas);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtNivelSignificancia);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btnPruebaPromedio);
            this.panel1.Location = new System.Drawing.Point(35, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 334);
            this.panel1.TabIndex = 41;
            // 
            // txtVtablas
            // 
            this.txtVtablas.Enabled = false;
            this.txtVtablas.Location = new System.Drawing.Point(141, 96);
            this.txtVtablas.Name = "txtVtablas";
            this.txtVtablas.Size = new System.Drawing.Size(100, 20);
            this.txtVtablas.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(208, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(237, 23);
            this.label13.TabIndex = 22;
            this.label13.Text = "TABLA DE DISTRIBUCIÓN NORMAL";
            // 
            // txtNivelSignificancia
            // 
            this.txtNivelSignificancia.Location = new System.Drawing.Point(176, 71);
            this.txtNivelSignificancia.Name = "txtNivelSignificancia";
            this.txtNivelSignificancia.Size = new System.Drawing.Size(108, 20);
            this.txtNivelSignificancia.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Valor de tablas:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "Nivel de significancia:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Z,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView2.Location = new System.Drawing.Point(8, 122);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(593, 190);
            this.dataGridView2.TabIndex = 18;
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.Name = "Z";
            this.Z.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = ".00";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = ".01";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = ".02";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = ".03";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = ".04";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = ".05";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = ".06";
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = ".07";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = ".08";
            this.Column9.Name = "Column9";
            this.Column9.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = ".09";
            this.Column10.Name = "Column10";
            this.Column10.Width = 50;
            // 
            // btnPruebaPromedio
            // 
            this.btnPruebaPromedio.Location = new System.Drawing.Point(458, 90);
            this.btnPruebaPromedio.Name = "btnPruebaPromedio";
            this.btnPruebaPromedio.Size = new System.Drawing.Size(126, 23);
            this.btnPruebaPromedio.TabIndex = 19;
            this.btnPruebaPromedio.Text = "Calcular valor de tablas";
            this.btnPruebaPromedio.UseVisualStyleBackColor = true;
            this.btnPruebaPromedio.Click += new System.EventHandler(this.btnPruebaPromedio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.lblRespuesta);
            this.panel2.Controls.Add(this.btnPromedio);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lbldisnor);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lblpromedio2);
            this.panel2.Location = new System.Drawing.Point(652, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 264);
            this.panel2.TabIndex = 40;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.ForeColor = System.Drawing.Color.Red;
            this.lblRespuesta.Location = new System.Drawing.Point(35, 125);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(245, 116);
            this.lblRespuesta.TabIndex = 19;
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(316, 218);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(104, 23);
            this.btnPromedio.TabIndex = 18;
            this.btnPromedio.Text = "Realizar prueba";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(137, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "PRUEBA DE PROMEDIOS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Valor calculado Zo:";
            // 
            // lbldisnor
            // 
            this.lbldisnor.AutoSize = true;
            this.lbldisnor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisnor.Location = new System.Drawing.Point(161, 79);
            this.lbldisnor.Name = "lbldisnor";
            this.lbldisnor.Size = new System.Drawing.Size(0, 16);
            this.lbldisnor.TabIndex = 15;
            this.lbldisnor.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(278, 23);
            this.label14.TabIndex = 12;
            this.label14.Text = "Promedio de los numeros pseodoaleatorios:";
            // 
            // lblpromedio2
            // 
            this.lblpromedio2.AutoSize = true;
            this.lblpromedio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio2.Location = new System.Drawing.Point(313, 52);
            this.lblpromedio2.Name = "lblpromedio2";
            this.lblpromedio2.Size = new System.Drawing.Size(0, 16);
            this.lblpromedio2.TabIndex = 14;
            this.lblpromedio2.Visible = false;
            // 
            // PruebaPromedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "PruebaPromedios";
            this.Text = "PruebaPromedios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtVtablas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNivelSignificancia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnPruebaPromedio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lbldisnor;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblpromedio2;
    }
}