
namespace WinLoadHtml
{
    partial class FrmPrincipal
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
            this.RefreshBut = new System.Windows.Forms.Button();
            this.dgrData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshBut
            // 
            this.RefreshBut.Location = new System.Drawing.Point(461, 42);
            this.RefreshBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshBut.Name = "RefreshBut";
            this.RefreshBut.Size = new System.Drawing.Size(244, 104);
            this.RefreshBut.TabIndex = 0;
            this.RefreshBut.Text = "Refrescar";
            this.RefreshBut.UseVisualStyleBackColor = true;
            this.RefreshBut.Click += new System.EventHandler(this.RefreshBut_Click);
            // 
            // dgrData
            // 
            this.dgrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrData.Location = new System.Drawing.Point(97, 203);
            this.dgrData.Name = "dgrData";
            this.dgrData.Size = new System.Drawing.Size(967, 341);
            this.dgrData.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dgrData);
            this.Controls.Add(this.RefreshBut);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RefreshBut;
        private System.Windows.Forms.DataGridView dgrData;
    }
}

