
namespace ProyectCarServices
{
    partial class FrmGridUsuarios
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
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_dirRight = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox_dirLeft = new System.Windows.Forms.PictureBox();
            this.Muestra_Grid = new System.Windows.Forms.DataGridView();
            this.UPDATE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtFiltroB = new System.Windows.Forms.TextBox();
            this.cmbCantS = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dirRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dirLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Muestra_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox_dirRight);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox_dirLeft);
            this.panel1.Location = new System.Drawing.Point(964, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 59);
            this.panel1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "prev";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox_dirRight
            // 
            this.pictureBox_dirRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_dirRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_dirRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_dirRight.Location = new System.Drawing.Point(61, 10);
            this.pictureBox_dirRight.Name = "pictureBox_dirRight";
            this.pictureBox_dirRight.Size = new System.Drawing.Size(33, 25);
            this.pictureBox_dirRight.TabIndex = 8;
            this.pictureBox_dirRight.TabStop = false;
            this.pictureBox_dirRight.Click += new System.EventHandler(this.pictureBox_dirRight_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "next";
            // 
            // pictureBox_dirLeft
            // 
            this.pictureBox_dirLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_dirLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_dirLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_dirLeft.Location = new System.Drawing.Point(12, 10);
            this.pictureBox_dirLeft.Name = "pictureBox_dirLeft";
            this.pictureBox_dirLeft.Size = new System.Drawing.Size(33, 25);
            this.pictureBox_dirLeft.TabIndex = 9;
            this.pictureBox_dirLeft.TabStop = false;
            this.pictureBox_dirLeft.Click += new System.EventHandler(this.pictureBox_dirLeft_Click);
            // 
            // Muestra_Grid
            // 
            this.Muestra_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Muestra_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UPDATE,
            this.DELETE});
            this.Muestra_Grid.Location = new System.Drawing.Point(18, 100);
            this.Muestra_Grid.Name = "Muestra_Grid";
            this.Muestra_Grid.Size = new System.Drawing.Size(1052, 305);
            this.Muestra_Grid.TabIndex = 34;
            this.Muestra_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Muestra_Grid_CellContentClick);
            // 
            // UPDATE
            // 
            this.UPDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UPDATE.HeaderText = "Actualizar";
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.ReadOnly = true;
            this.UPDATE.Width = 59;
            // 
            // DELETE
            // 
            this.DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DELETE.HeaderText = "Eliminar";
            this.DELETE.Name = "DELETE";
            this.DELETE.ReadOnly = true;
            this.DELETE.Width = 49;
            // 
            // txtFiltroB
            // 
            this.txtFiltroB.Location = new System.Drawing.Point(950, 64);
            this.txtFiltroB.Name = "txtFiltroB";
            this.txtFiltroB.Size = new System.Drawing.Size(120, 20);
            this.txtFiltroB.TabIndex = 33;
            this.txtFiltroB.TextChanged += new System.EventHandler(this.txtFiltroB_TextChanged);
            // 
            // cmbCantS
            // 
            this.cmbCantS.FormattingEnabled = true;
            this.cmbCantS.Location = new System.Drawing.Point(71, 61);
            this.cmbCantS.Name = "cmbCantS";
            this.cmbCantS.Size = new System.Drawing.Size(58, 21);
            this.cmbCantS.TabIndex = 32;
            this.cmbCantS.SelectedIndexChanged += new System.EventHandler(this.cmbCantS_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(135, 64);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "Registros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mostrar";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsertar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsertar.Location = new System.Drawing.Point(910, 16);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(160, 31);
            this.btnInsertar.TabIndex = 29;
            this.btnInsertar.Text = "+ Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectCarServices.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(18, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectCarServices.Properties.Resources.lupa;
            this.pictureBox2.Location = new System.Drawing.Point(910, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // FrmGridUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 530);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Muestra_Grid);
            this.Controls.Add(this.txtFiltroB);
            this.Controls.Add(this.cmbCantS);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label1);
            this.Name = "FrmGridUsuarios";
            this.Text = "FrmGridUsuarios";
            this.Load += new System.EventHandler(this.FrmGridUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dirRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dirLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Muestra_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_dirRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox_dirLeft;
        public System.Windows.Forms.DataGridView Muestra_Grid;
        private System.Windows.Forms.DataGridViewButtonColumn UPDATE;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
        private System.Windows.Forms.TextBox txtFiltroB;
        private System.Windows.Forms.ComboBox cmbCantS;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}