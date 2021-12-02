
namespace ProyectCarServices
{
    partial class FormInfoCarrosUPD
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
            this.SuspendLayout();
            // 
            // cbCarro
            // 
            this.cbCarro.Items.AddRange(new object[] {
            "Sedan",
            "Camioneta",
            "Pickup"});
            // 
            // FormInfoCarrosUPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(252, 406);
            this.Name = "FormInfoCarrosUPD";
            this.Load += new System.EventHandler(this.FormInfoCarrosUPD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
