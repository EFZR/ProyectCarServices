
namespace ProyectCarServices
{
    partial class FormInfoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoCliente));
            this.btn_accion = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker_FN = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_EstadoC = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_F = new System.Windows.Forms.RadioButton();
            this.radioButton_M = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Dpto = new System.Windows.Forms.ComboBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.textBox_Correo = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_accion
            // 
            this.btn_accion.Location = new System.Drawing.Point(337, 326);
            this.btn_accion.Name = "btn_accion";
            this.btn_accion.Size = new System.Drawing.Size(90, 23);
            this.btn_accion.TabIndex = 10;
            this.btn_accion.Text = "Accion";
            this.btn_accion.UseVisualStyleBackColor = true;
            this.btn_accion.Click += new System.EventHandler(this.btn_accion_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(338, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha de Nacimiento";
            // 
            // dateTimePicker_FN
            // 
            this.dateTimePicker_FN.Location = new System.Drawing.Point(337, 279);
            this.dateTimePicker_FN.Name = "dateTimePicker_FN";
            this.dateTimePicker_FN.Size = new System.Drawing.Size(288, 20);
            this.dateTimePicker_FN.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(334, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Estado Civil";
            // 
            // comboBox_EstadoC
            // 
            this.comboBox_EstadoC.FormattingEnabled = true;
            this.comboBox_EstadoC.Location = new System.Drawing.Point(337, 229);
            this.comboBox_EstadoC.Name = "comboBox_EstadoC";
            this.comboBox_EstadoC.Size = new System.Drawing.Size(288, 21);
            this.comboBox_EstadoC.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Direccion";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(11, 326);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(313, 21);
            this.txt_Direccion.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_F);
            this.groupBox1.Controls.Add(this.radioButton_M);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(337, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // radioButton_F
            // 
            this.radioButton_F.AutoSize = true;
            this.radioButton_F.Location = new System.Drawing.Point(6, 50);
            this.radioButton_F.Name = "radioButton_F";
            this.radioButton_F.Size = new System.Drawing.Size(99, 22);
            this.radioButton_F.TabIndex = 1;
            this.radioButton_F.TabStop = true;
            this.radioButton_F.Text = "Femenino";
            this.radioButton_F.UseVisualStyleBackColor = true;
            // 
            // radioButton_M
            // 
            this.radioButton_M.AutoSize = true;
            this.radioButton_M.Location = new System.Drawing.Point(6, 17);
            this.radioButton_M.Name = "radioButton_M";
            this.radioButton_M.Size = new System.Drawing.Size(98, 22);
            this.radioButton_M.TabIndex = 0;
            this.radioButton_M.TabStop = true;
            this.radioButton_M.Text = "Masculino";
            this.radioButton_M.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Identidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // comboBox_Dpto
            // 
            this.comboBox_Dpto.FormattingEnabled = true;
            this.comboBox_Dpto.Location = new System.Drawing.Point(337, 181);
            this.comboBox_Dpto.Name = "comboBox_Dpto";
            this.comboBox_Dpto.Size = new System.Drawing.Size(288, 21);
            this.comboBox_Dpto.TabIndex = 7;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Id.Location = new System.Drawing.Point(11, 181);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(313, 21);
            this.textBox_Id.TabIndex = 2;
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tel.Location = new System.Drawing.Point(11, 229);
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(313, 21);
            this.textBox_Tel.TabIndex = 3;
            // 
            // textBox_Correo
            // 
            this.textBox_Correo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Correo.Location = new System.Drawing.Point(11, 278);
            this.textBox_Correo.Name = "textBox_Correo";
            this.textBox_Correo.Size = new System.Drawing.Size(313, 21);
            this.textBox_Correo.TabIndex = 4;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Apellido.Location = new System.Drawing.Point(11, 129);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(313, 21);
            this.textBox_Apellido.TabIndex = 1;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(11, 85);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(313, 21);
            this.textBox_Name.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 54);
            this.panel1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 42);
            this.label8.TabIndex = 0;
            this.label8.Text = "Clientes";
            // 
            // FormInfoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 384);
            this.Controls.Add(this.btn_accion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker_FN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_EstadoC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Dpto);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.textBox_Tel);
            this.Controls.Add(this.textBox_Correo);
            this.Controls.Add(this.textBox_Apellido);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInfoCliente";
            this.Text = "Modificacion Cliente";
            this.Load += new System.EventHandler(this.FormInfoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comboBox_EstadoC;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_Direccion;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton radioButton_F;
        public System.Windows.Forms.RadioButton radioButton_M;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox_Dpto;
        public System.Windows.Forms.TextBox textBox_Id;
        public System.Windows.Forms.TextBox textBox_Tel;
        public System.Windows.Forms.TextBox textBox_Correo;
        public System.Windows.Forms.TextBox textBox_Apellido;
        public System.Windows.Forms.TextBox textBox_Name;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_accion;
        public System.Windows.Forms.DateTimePicker dateTimePicker_FN;
        public System.Windows.Forms.Label label8;
    }
}