
namespace ProyectCarServices
{
    partial class FrmServiciosDetalleInfo
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
            this.cb_categoriaS = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_accion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_categoriaS
            // 
            this.cb_categoriaS.FormattingEnabled = true;
            this.cb_categoriaS.Location = new System.Drawing.Point(178, 98);
            this.cb_categoriaS.Name = "cb_categoriaS";
            this.cb_categoriaS.Size = new System.Drawing.Size(121, 21);
            this.cb_categoriaS.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 98);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(12, 139);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 54);
            this.panel1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 42);
            this.label8.TabIndex = 0;
            this.label8.Text = "Servicio Detalle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Categoria de Servicio";
            // 
            // btn_accion
            // 
            this.btn_accion.Location = new System.Drawing.Point(225, 183);
            this.btn_accion.Name = "btn_accion";
            this.btn_accion.Size = new System.Drawing.Size(75, 23);
            this.btn_accion.TabIndex = 16;
            this.btn_accion.Text = "Accion";
            this.btn_accion.UseVisualStyleBackColor = true;
            this.btn_accion.Click += new System.EventHandler(this.btn_accion_Click);
            // 
            // FrmServiciosDetalleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 218);
            this.Controls.Add(this.btn_accion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.cb_categoriaS);
            this.Name = "FrmServiciosDetalleInfo";
            this.Text = "FrmServiciosDetalleInfo";
            this.Load += new System.EventHandler(this.FrmServiciosDetalleInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btn_accion;
        public System.Windows.Forms.ComboBox cb_categoriaS;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.TextBox txt_precio;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
    }
}