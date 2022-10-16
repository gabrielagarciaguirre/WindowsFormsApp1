
using System;

namespace WindowsFormsApp1
{
    partial class fusuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fusuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bbuscar = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.ComboBox();
            this.txtclave = new System.Windows.Forms.ComboBox();
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.txtbuscar = new System.Windows.Forms.ComboBox();
            this.txtcodigo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstcorreo = new System.Windows.Forms.ComboBox();
            this.bactualizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(483, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "INGRESO DE USUARIOS\r\n";
            // 
            // bbuscar
            // 
            this.bbuscar.Location = new System.Drawing.Point(676, 218);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Size = new System.Drawing.Size(75, 26);
            this.bbuscar.TabIndex = 8;
            this.bbuscar.Text = "Buscar";
            this.bbuscar.UseVisualStyleBackColor = true;
            this.bbuscar.Click += new System.EventHandler(this.bbuscar_Click);
            // 
            // bnuevo
            // 
            this.bnuevo.Location = new System.Drawing.Point(38, 314);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(84, 50);
            this.bnuevo.TabIndex = 9;
            this.bnuevo.Text = "nuevo";
            this.bnuevo.UseVisualStyleBackColor = true;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // bguardar
            // 
            this.bguardar.Location = new System.Drawing.Point(38, 314);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(84, 50);
            this.bguardar.TabIndex = 10;
            this.bguardar.Text = "guardar ";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // beliminar
            // 
            this.beliminar.Location = new System.Drawing.Point(139, 314);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(84, 50);
            this.beliminar.TabIndex = 11;
            this.beliminar.Text = "eliminar ";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bsalir
            // 
            this.bsalir.Location = new System.Drawing.Point(244, 314);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(84, 50);
            this.bsalir.TabIndex = 13;
            this.bsalir.Text = "salir";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.Location = new System.Drawing.Point(345, 314);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(84, 50);
            this.bmodificar.TabIndex = 14;
            this.bmodificar.Text = "modificar";
            this.bmodificar.UseVisualStyleBackColor = true;
            this.bmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.FormattingEnabled = true;
            this.txtusuario.Location = new System.Drawing.Point(139, 64);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(121, 21);
            this.txtusuario.TabIndex = 15;
            // 
            // txtclave
            // 
            this.txtclave.Enabled = false;
            this.txtclave.FormattingEnabled = true;
            this.txtclave.Location = new System.Drawing.Point(139, 108);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(121, 21);
            this.txtclave.TabIndex = 16;
            // 
            // lstnivel
            // 
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lstnivel.Location = new System.Drawing.Point(139, 152);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(71, 21);
            this.lstnivel.TabIndex = 17;
            // 
            // txtbuscar
            // 
            this.txtbuscar.FormattingEnabled = true;
            this.txtbuscar.Location = new System.Drawing.Point(525, 222);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(121, 21);
            this.txtbuscar.TabIndex = 18;
            // 
            // txtcodigo
            // 
            this.txtcodigo.FormattingEnabled = true;
            this.txtcodigo.Location = new System.Drawing.Point(139, 190);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(121, 21);
            this.txtcodigo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "correo";
            // 
            // lstcorreo
            // 
            this.lstcorreo.FormattingEnabled = true;
            this.lstcorreo.Location = new System.Drawing.Point(139, 230);
            this.lstcorreo.Name = "lstcorreo";
            this.lstcorreo.Size = new System.Drawing.Size(121, 21);
            this.lstcorreo.TabIndex = 22;
            // 
            // bactualizar
            // 
            this.bactualizar.Location = new System.Drawing.Point(345, 314);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(84, 50);
            this.bactualizar.TabIndex = 23;
            this.bactualizar.Text = "actualizar";
            this.bactualizar.UseVisualStyleBackColor = true;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(284, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // fusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstcorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.bmodificar);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.bbuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.bactualizar);
            this.Name = "fusuarios";
            this.Text = "usuarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;

            txtusuario.Focus();

            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtusuario.Text.ToString(); 
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bbuscar;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.ComboBox txtusuario;
        private System.Windows.Forms.ComboBox txtclave;
        private System.Windows.Forms.ComboBox lstnivel;
        private System.Windows.Forms.ComboBox txtbuscar;
        private System.Windows.Forms.ComboBox txtcodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox lstcorreo;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

