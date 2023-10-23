namespace Interface.Controls.Borda
{
    partial class Borda
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borda));
            this.picBarra = new System.Windows.Forms.PictureBox();
            this.lblBorda = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // picBarra
            // 
            this.picBarra.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picBarra.Image = ((System.Drawing.Image)(resources.GetObject("picBarra.Image")));
            this.picBarra.Location = new System.Drawing.Point(1, 1);
            this.picBarra.Name = "picBarra";
            this.picBarra.Size = new System.Drawing.Size(199, 23);
            this.picBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarra.TabIndex = 4;
            this.picBarra.TabStop = false;
            // 
            // lblBorda
            // 
            this.lblBorda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBorda.ForeColor = System.Drawing.Color.White;
            this.lblBorda.Location = new System.Drawing.Point(1, 1);
            this.lblBorda.Name = "lblBorda";
            this.lblBorda.Size = new System.Drawing.Size(199, 155);
            this.lblBorda.TabIndex = 5;
            this.lblBorda.Text = "Label1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(5, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(12, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = " ";
            // 
            // Borda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picBarra);
            this.Controls.Add(this.lblBorda);
            this.Name = "Borda";
            this.Size = new System.Drawing.Size(201, 157);
            this.Load += new System.EventHandler(this.Borda_Load);
            this.Resize += new System.EventHandler(this.Borda_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picBarra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picBarra;
        internal System.Windows.Forms.Label lblBorda;
        internal System.Windows.Forms.Label lblTitulo;
    }
}
