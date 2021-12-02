
namespace ProyectCarServices
{
    partial class FrmVehiculosClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehiculosClientes));
            this.Muestra_Grid = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_filtrocarro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_next_carro = new System.Windows.Forms.PictureBox();
            this.pb_prev_carro = new System.Windows.Forms.PictureBox();
            this.cbCant_Carros = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_insertar_Carros = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Muestra_Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_next_carro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_prev_carro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Muestra_Grid
            // 
            this.Muestra_Grid.AllowUserToAddRows = false;
            this.Muestra_Grid.AllowUserToDeleteRows = false;
            this.Muestra_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Muestra_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.add});
            this.Muestra_Grid.Location = new System.Drawing.Point(18, 97);
            this.Muestra_Grid.Name = "Muestra_Grid";
            this.Muestra_Grid.ReadOnly = true;
            this.Muestra_Grid.Size = new System.Drawing.Size(750, 305);
            this.Muestra_Grid.TabIndex = 46;
            this.Muestra_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Muestra_Grid_CellClick);
            // 
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.add.HeaderText = "Agregar";
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Text = "Agregar";
            this.add.Width = 50;
            // 
            // txt_filtrocarro
            // 
            this.txt_filtrocarro.Location = new System.Drawing.Point(649, 61);
            this.txt_filtrocarro.Name = "txt_filtrocarro";
            this.txt_filtrocarro.Size = new System.Drawing.Size(119, 20);
            this.txt_filtrocarro.TabIndex = 45;
            this.txt_filtrocarro.TextChanged += new System.EventHandler(this.txt_filtrocarro_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pb_next_carro);
            this.groupBox1.Controls.Add(this.pb_prev_carro);
            this.groupBox1.Location = new System.Drawing.Point(650, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 72);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "next";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "prev";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pb_next_carro
            // 
            this.pb_next_carro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_next_carro.Location = new System.Drawing.Point(71, 19);
            this.pb_next_carro.Name = "pb_next_carro";
            this.pb_next_carro.Size = new System.Drawing.Size(41, 29);
            this.pb_next_carro.TabIndex = 30;
            this.pb_next_carro.TabStop = false;
            this.pb_next_carro.Click += new System.EventHandler(this.pb_next_carro_Click);
            // 
            // pb_prev_carro
            // 
            this.pb_prev_carro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_prev_carro.Location = new System.Drawing.Point(6, 19);
            this.pb_prev_carro.Name = "pb_prev_carro";
            this.pb_prev_carro.Size = new System.Drawing.Size(39, 29);
            this.pb_prev_carro.TabIndex = 29;
            this.pb_prev_carro.TabStop = false;
            this.pb_prev_carro.Click += new System.EventHandler(this.pb_prev_carro_Click);
            // 
            // cbCant_Carros
            // 
            this.cbCant_Carros.FormattingEnabled = true;
            this.cbCant_Carros.Location = new System.Drawing.Point(71, 60);
            this.cbCant_Carros.Name = "cbCant_Carros";
            this.cbCant_Carros.Size = new System.Drawing.Size(60, 21);
            this.cbCant_Carros.TabIndex = 43;
            this.cbCant_Carros.SelectedIndexChanged += new System.EventHandler(this.cbCant_Carros_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(137, 60);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 42;
            this.Label3.Text = "Registros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mostrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 36);
            this.label1.TabIndex = 39;
            this.label1.Text = "Carros";
            // 
            // button_insertar_Carros
            // 
            this.button_insertar_Carros.BackColor = System.Drawing.Color.LimeGreen;
            this.button_insertar_Carros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_insertar_Carros.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insertar_Carros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_insertar_Carros.Location = new System.Drawing.Point(608, 12);
            this.button_insertar_Carros.Name = "button_insertar_Carros";
            this.button_insertar_Carros.Size = new System.Drawing.Size(160, 31);
            this.button_insertar_Carros.TabIndex = 47;
            this.button_insertar_Carros.Text = "+ Insertar";
            this.button_insertar_Carros.UseVisualStyleBackColor = false;
            this.button_insertar_Carros.Click += new System.EventHandler(this.button_insertar_Carros_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectCarServices.Properties.Resources.lupa;
            this.pictureBox2.Location = new System.Drawing.Point(608, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectCarServices.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(18, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVehiculosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_insertar_Carros);
            this.Controls.Add(this.Muestra_Grid);
            this.Controls.Add(this.txt_filtrocarro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCant_Carros);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVehiculosClientes";
            this.Text = "FrmVehiculosClientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVehiculosClientes_FormClosed);
            this.Load += new System.EventHandler(this.FrmVehiculosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Muestra_Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_next_carro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_prev_carro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView Muestra_Grid;
        private System.Windows.Forms.TextBox txt_filtrocarro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_next_carro;
        private System.Windows.Forms.PictureBox pb_prev_carro;
        private System.Windows.Forms.ComboBox cbCant_Carros;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn add;
        private System.Windows.Forms.Button button_insertar_Carros;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}