
namespace ProyectCarServices
{
    partial class FrmCategoriaCarrosInfo
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtTipoCarro = new System.Windows.Forms.TextBox();
            this.txtProcentajeCosto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_accion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 54);
            this.panel1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 42);
            this.label8.TabIndex = 0;
            this.label8.Text = "Categoria de Carros";
            // 
            // txtTipoCarro
            // 
            this.txtTipoCarro.Location = new System.Drawing.Point(34, 107);
            this.txtTipoCarro.Name = "txtTipoCarro";
            this.txtTipoCarro.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCarro.TabIndex = 13;
            // 
            // txtProcentajeCosto
            // 
            this.txtProcentajeCosto.Location = new System.Drawing.Point(167, 107);
            this.txtProcentajeCosto.Name = "txtProcentajeCosto";
            this.txtProcentajeCosto.Size = new System.Drawing.Size(100, 20);
            this.txtProcentajeCosto.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipo de Carro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Porcentaje de Costo";
            // 
            // btn_accion
            // 
            this.btn_accion.Location = new System.Drawing.Point(242, 150);
            this.btn_accion.Name = "btn_accion";
            this.btn_accion.Size = new System.Drawing.Size(75, 23);
            this.btn_accion.TabIndex = 17;
            this.btn_accion.Text = "Accion";
            this.btn_accion.UseVisualStyleBackColor = true;
            this.btn_accion.Click += new System.EventHandler(this.btn_accion_Click);
            // 
            // FrmCategoriaCarrosInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 201);
            this.Controls.Add(this.btn_accion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProcentajeCosto);
            this.Controls.Add(this.txtTipoCarro);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCategoriaCarrosInfo";
            this.Text = "FrmCategoriaCarrosInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtTipoCarro;
        public System.Windows.Forms.TextBox txtProcentajeCosto;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_accion;
    }
}