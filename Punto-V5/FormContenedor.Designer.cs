
namespace Punto_V5
{
    partial class FormContenedor
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioYFacturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instalacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utiliariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblUsuActivo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelNombreModulo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.lblUsuActivo);
            this.panelMenu.Controls.Add(this.lblUsuario);
            this.panelMenu.Location = new System.Drawing.Point(12, 32);
            this.panelMenu.Size = new System.Drawing.Size(776, 52);
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            this.panelMenu.Controls.SetChildIndex(this.btnInicio, 0);
            this.panelMenu.Controls.SetChildIndex(this.btnForContenedor, 0);
            this.panelMenu.Controls.SetChildIndex(this.btnCxC, 0);
            this.panelMenu.Controls.SetChildIndex(this.btnCxP, 0);
            this.panelMenu.Controls.SetChildIndex(this.button2, 0);
            this.panelMenu.Controls.SetChildIndex(this.lblUsuario, 0);
            this.panelMenu.Controls.SetChildIndex(this.lblUsuActivo, 0);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 3);
            // 
            // btnCxP
            // 
            this.btnCxP.Location = new System.Drawing.Point(235, 3);
            this.toolTip1.SetToolTip(this.btnCxP, "Modulo Cuentas Por Pagar");
            // 
            // btnCxC
            // 
            this.btnCxC.Location = new System.Drawing.Point(158, 3);
            this.toolTip1.SetToolTip(this.btnCxC, "Modulo Cuentas por Cobrar");
            // 
            // btnForContenedor
            // 
            this.btnForContenedor.Location = new System.Drawing.Point(81, 3);
            this.toolTip1.SetToolTip(this.btnForContenedor, "Modulo Inventario y Facturacion");
            // 
            // panelNombreModulo
            // 
            this.panelNombreModulo.Controls.Add(this.label1);
            this.panelNombreModulo.Location = new System.Drawing.Point(12, 93);
            this.panelNombreModulo.Size = new System.Drawing.Size(776, 44);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.instalacionToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.utiliariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioYFacturacionToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // inventarioYFacturacionToolStripMenuItem
            // 
            this.inventarioYFacturacionToolStripMenuItem.Name = "inventarioYFacturacionToolStripMenuItem";
            this.inventarioYFacturacionToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.inventarioYFacturacionToolStripMenuItem.Text = "Inventario y Facturacion";
            // 
            // instalacionToolStripMenuItem
            // 
            this.instalacionToolStripMenuItem.Name = "instalacionToolStripMenuItem";
            this.instalacionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.instalacionToolStripMenuItem.Text = "Instalacion";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // utiliariosToolStripMenuItem
            // 
            this.utiliariosToolStripMenuItem.Name = "utiliariosToolStripMenuItem";
            this.utiliariosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.utiliariosToolStripMenuItem.Text = "Utiliarios";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA PRINCIPAL";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(539, 17);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(81, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario :";
            // 
            // lblUsuActivo
            // 
            this.lblUsuActivo.AutoSize = true;
            this.lblUsuActivo.Location = new System.Drawing.Point(626, 22);
            this.lblUsuActivo.Name = "lblUsuActivo";
            this.lblUsuActivo.Size = new System.Drawing.Size(35, 13);
            this.lblUsuActivo.TabIndex = 5;
            this.lblUsuActivo.Text = "label2";
            // 
            // FormContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormContenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOLUCIONES BELLO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormContenedor_FormClosed);
            this.Load += new System.EventHandler(this.FormContenedor_Load);
            this.Controls.SetChildIndex(this.panelMenu, 0);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.panelNombreModulo, 0);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelNombreModulo.ResumeLayout(false);
            this.panelNombreModulo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instalacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utiliariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem inventarioYFacturacionToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuActivo;
    }
}