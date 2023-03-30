
namespace Examinador_de_objetos
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
            this.btn_Play = new System.Windows.Forms.Button();
            this.bnt_Stop = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.filepathTextbox = new System.Windows.Forms.TextBox();
            this.btn_SeleccionarArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(250, 409);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(41, 34);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // bnt_Stop
            // 
            this.bnt_Stop.Location = new System.Drawing.Point(288, 409);
            this.bnt_Stop.Name = "bnt_Stop";
            this.bnt_Stop.Size = new System.Drawing.Size(41, 34);
            this.bnt_Stop.TabIndex = 1;
            this.bnt_Stop.Text = "Stop";
            this.bnt_Stop.UseVisualStyleBackColor = true;
            this.bnt_Stop.Click += new System.EventHandler(this.bnt_Stop_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(683, 232);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(41, 34);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Siguiente";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // filepathTextbox
            // 
            this.filepathTextbox.Location = new System.Drawing.Point(111, 289);
            this.filepathTextbox.Name = "filepathTextbox";
            this.filepathTextbox.Size = new System.Drawing.Size(369, 20);
            this.filepathTextbox.TabIndex = 3;
            this.filepathTextbox.TextChanged += new System.EventHandler(this.filepathTextbox_TextChanged);
            // 
            // btn_SeleccionarArchivo
            // 
            this.btn_SeleccionarArchivo.Location = new System.Drawing.Point(437, 401);
            this.btn_SeleccionarArchivo.Name = "btn_SeleccionarArchivo";
            this.btn_SeleccionarArchivo.Size = new System.Drawing.Size(73, 51);
            this.btn_SeleccionarArchivo.TabIndex = 4;
            this.btn_SeleccionarArchivo.Text = "Seleccionar Archivo";
            this.btn_SeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btn_SeleccionarArchivo.Click += new System.EventHandler(this.btn_SeleccionarArchivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Examinador_de_objetos.Properties.Resources._6d215981459db909e1762b89aa5a86f6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 591);
            this.Controls.Add(this.btn_SeleccionarArchivo);
            this.Controls.Add(this.filepathTextbox);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.bnt_Stop);
            this.Controls.Add(this.btn_Play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button bnt_Stop;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.TextBox filepathTextbox;
        private System.Windows.Forms.Button btn_SeleccionarArchivo;
    }
}

