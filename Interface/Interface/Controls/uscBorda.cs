using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface.Controls.Borda
{
    public partial class Borda : UserControl
    {
        public Borda()
        {
            InitializeComponent();
        }

        private void Borda_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(112, 144, 191);
            picBarra.Controls.Add(lblTitulo);
        }

        private void Borda_Resize(object sender, EventArgs e)
        {
            lblBorda.Width = this.Width - 2;
            lblBorda.Height = this.Height - 2;
            picBarra.Width = this.Width - 2;
            this.Refresh();
        }

        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

    }
}
