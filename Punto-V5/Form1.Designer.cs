
namespace Punto_V5
{
    partial class ForMaster
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCxP = new System.Windows.Forms.Button();
            this.btnCxC = new System.Windows.Forms.Button();
            this.btnForContenedor = new System.Windows.Forms.Button();
            this.panelNombreModulo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.btnCxP);
            this.panelMenu.Controls.Add(this.btnCxC);
            this.panelMenu.Controls.Add(this.btnForContenedor);
            this.panelMenu.Location = new System.Drawing.Point(12, 25);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(872, 55);
            this.panelMenu.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.AutoSize = true;
            this.btnInicio.BackgroundImage = global::Punto_V5.Properties.Resources.home;
            this.btnInicio.Location = new System.Drawing.Point(3, 5);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(56, 46);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "FContene";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCxP
            // 
            this.btnCxP.Location = new System.Drawing.Point(62, 5);
            this.btnCxP.Name = "btnCxP";
            this.btnCxP.Size = new System.Drawing.Size(56, 46);
            this.btnCxP.TabIndex = 2;
            this.btnCxP.Text = "CxP";
            this.btnCxP.UseVisualStyleBackColor = true;
            // 
            // btnCxC
            // 
            this.btnCxC.Location = new System.Drawing.Point(121, 5);
            this.btnCxC.Name = "btnCxC";
            this.btnCxC.Size = new System.Drawing.Size(56, 46);
            this.btnCxC.TabIndex = 1;
            this.btnCxC.Text = "CxC";
            this.btnCxC.UseVisualStyleBackColor = true;
            // 
            // btnForContenedor
            // 
            this.btnForContenedor.Location = new System.Drawing.Point(180, 5);
            this.btnForContenedor.Name = "btnForContenedor";
            this.btnForContenedor.Size = new System.Drawing.Size(56, 46);
            this.btnForContenedor.TabIndex = 0;
            this.btnForContenedor.Text = "InvFact";
            this.btnForContenedor.UseVisualStyleBackColor = true;
            // 
            // panelNombreModulo
            // 
            this.panelNombreModulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNombreModulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNombreModulo.Location = new System.Drawing.Point(12, 86);
            this.panelNombreModulo.Name = "panelNombreModulo";
            this.panelNombreModulo.Size = new System.Drawing.Size(872, 51);
            this.panelNombreModulo.TabIndex = 1;
            // 
            // ForMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 472);
            this.Controls.Add(this.panelNombreModulo);
            this.Controls.Add(this.panelMenu);
            this.IsMdiContainer = true;
            this.Name = "ForMaster";
            this.Text = "Formulario Master";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForMaster_FormClosed);
            this.Load += new System.EventHandler(this.ForMaster_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnCxP;
        public System.Windows.Forms.Button btnCxC;
        public System.Windows.Forms.Button btnForContenedor;
        public System.Windows.Forms.Panel panelNombreModulo;
        public System.Windows.Forms.Button btnInicio;
    }
}

