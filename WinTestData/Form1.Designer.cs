
namespace WinTestData
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
            this.butLoad = new System.Windows.Forms.Button();
            this.dgrData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).BeginInit();
            this.SuspendLayout();
            // 
            // butLoad
            // 
            this.butLoad.Location = new System.Drawing.Point(3, 2);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(187, 42);
            this.butLoad.TabIndex = 0;
            this.butLoad.Text = "LoadData";
            this.butLoad.UseVisualStyleBackColor = true;
            this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // dgrData
            // 
            this.dgrData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrData.Location = new System.Drawing.Point(3, 71);
            this.dgrData.Name = "dgrData";
            this.dgrData.Size = new System.Drawing.Size(1069, 496);
            this.dgrData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 567);
            this.Controls.Add(this.dgrData);
            this.Controls.Add(this.butLoad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butLoad;
        private System.Windows.Forms.DataGridView dgrData;
    }
}

