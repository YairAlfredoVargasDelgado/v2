namespace ControlV2
{
    partial class FrmRegistrarVehículo
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
            this.pctBxImagenVehículo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxImagenVehículo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBxImagenVehículo
            // 
            this.pctBxImagenVehículo.Image = global::ControlV2.Properties.Resources.flag;
            this.pctBxImagenVehículo.Location = new System.Drawing.Point(13, 13);
            this.pctBxImagenVehículo.Name = "pctBxImagenVehículo";
            this.pctBxImagenVehículo.Size = new System.Drawing.Size(342, 206);
            this.pctBxImagenVehículo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBxImagenVehículo.TabIndex = 0;
            this.pctBxImagenVehículo.TabStop = false;
            // 
            // FrmRegistrarVehículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 368);
            this.Controls.Add(this.pctBxImagenVehículo);
            this.Name = "FrmRegistrarVehículo";
            this.Text = "FrmRegistrarVehículo";
            ((System.ComponentModel.ISupportInitialize)(this.pctBxImagenVehículo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBxImagenVehículo;
    }
}