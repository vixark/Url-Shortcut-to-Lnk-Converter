namespace Url_Shortcut_to_Lnk_Converter {
    partial class FrmPrincipal {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.BtnConvertir = new System.Windows.Forms.Button();
            this.TxtDirectorioÍconos = new System.Windows.Forms.TextBox();
            this.TxtDirectorioAccesosDirectos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConvertir
            // 
            this.BtnConvertir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConvertir.Location = new System.Drawing.Point(674, 191);
            this.BtnConvertir.Margin = new System.Windows.Forms.Padding(20);
            this.BtnConvertir.Name = "BtnConvertir";
            this.BtnConvertir.Size = new System.Drawing.Size(131, 47);
            this.BtnConvertir.TabIndex = 0;
            this.BtnConvertir.Text = "Convert";
            this.BtnConvertir.UseVisualStyleBackColor = true;
            this.BtnConvertir.Click += new System.EventHandler(this.BtnConvertir_Click);
            // 
            // TxtDirectorioÍconos
            // 
            this.TxtDirectorioÍconos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDirectorioÍconos.Location = new System.Drawing.Point(297, 110);
            this.TxtDirectorioÍconos.Margin = new System.Windows.Forms.Padding(20);
            this.TxtDirectorioÍconos.Name = "TxtDirectorioÍconos";
            this.TxtDirectorioÍconos.Size = new System.Drawing.Size(508, 40);
            this.TxtDirectorioÍconos.TabIndex = 1;
            this.TxtDirectorioÍconos.Text = "D:\\Juegos\\Íconos";
            // 
            // TxtDirectorioAccesosDirectos
            // 
            this.TxtDirectorioAccesosDirectos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDirectorioAccesosDirectos.Location = new System.Drawing.Point(297, 30);
            this.TxtDirectorioAccesosDirectos.Margin = new System.Windows.Forms.Padding(20);
            this.TxtDirectorioAccesosDirectos.Name = "TxtDirectorioAccesosDirectos";
            this.TxtDirectorioAccesosDirectos.Size = new System.Drawing.Size(508, 40);
            this.TxtDirectorioAccesosDirectos.TabIndex = 2;
            this.TxtDirectorioAccesosDirectos.Text = "D:\\Juegos\\Accesos Directos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shorcuts Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Icons Directory";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDirectorioAccesosDirectos);
            this.Controls.Add(this.TxtDirectorioÍconos);
            this.Controls.Add(this.BtnConvertir);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Url Shortcut to Lnk Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConvertir;
        private System.Windows.Forms.TextBox TxtDirectorioÍconos;
        private System.Windows.Forms.TextBox TxtDirectorioAccesosDirectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

