using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using FrameWork.Facade;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface.Forms
{
    public partial class FrmPesquisar : Form
    {
        #region Variáveis
        //Variáveis públicas
        public string vcg_Pesquisa = String.Empty;              
        public Int32 vig_Codigo = 0;                            
        public string vcg_Descricao = String.Empty;             
        public Int32 vig_IdTipoConselho = 0;
        public int vig_sortColumn = -1;
        //Objetos de classe
        FBL_Pesquisar vol_FacadePesquisar = null;               
        #endregion

        #region Form
        public FrmPesquisar()
        {
            InitializeComponent();
        }

        private void FrmPesquisar_Load(object sender, EventArgs e)
        {
            //Altera a cor de fundo do form
            this.BackColor = Color.FromArgb(231, 234, 244);
            //Adiciona o controle label do título a da imagem da barra
            pctBarra.Controls.Add(lblTitulo);
            //Adiciona o controle imagem do icone a da imagem da barra
            pctBarra.Controls.Add(pctIcone);
            //Seleciona o radCodigo
            radCodigo.Checked = true;
            //Realiza pesquisa conforme parâmetro
            this.FP_Editar(vcg_Pesquisa);
        }

        private void FrmPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.BtnFechar_Click(sender, e);
            }
        }

        private void FrmPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Digita somente letras ou números
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                return;
            }
        }
        #endregion

        #region Controles
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            if (lvwPesquisa.Items.Count > 0 && lvwPesquisa.SelectedItems.Count > 0)
            {
                vig_Codigo = Convert.ToInt32(lvwPesquisa.SelectedItems[0].SubItems[0].Text);
                vcg_Descricao = Convert.ToString(lvwPesquisa.SelectedItems[0].SubItems[1].Text);
                this.BtnFechar_Click(sender, e);
            }
        }

        private void LvwPesquisa_DoubleClick(object sender, EventArgs e)
        {
            BtnSelecionar_Click(sender, e);
        }

        private void LvwPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.BtnFechar_Click(sender, e);
            }
        }

        private void TxtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSelecionar_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.BtnFechar_Click(sender, e);
            }
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Digita apenas numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && radCodigo.Checked)
            {
                e.Handled = true;
            }
            //Digita apenas letras
            else if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)32 && e.KeyChar != (char)8 && radDescricao.Checked)
            {
                e.Handled = true;
            }
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {           
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                return;
            }

            if (radDescricao.Checked && Char.IsLetter(txtNome.Text, txtNome.Text.Length - 1))
            {
                //Variáveis private
                String vcl_Descricao;

                for (int vil_Count = 0; vil_Count < lvwPesquisa.Items.Count; vil_Count++)
                {
                    Int32 vil_ItemLength = (txtNome.Text.Length > lvwPesquisa.Items[vil_Count].SubItems[1].Text.Length ? lvwPesquisa.Items[vil_Count].SubItems[1].Text.Length : txtNome.Text.Length);
                    vcl_Descricao = lvwPesquisa.Items[vil_Count].SubItems[1].Text.Substring(0, vil_ItemLength);
                    if (txtNome.Text.ToUpper() == vcl_Descricao.ToUpper())
                    {
                        //Focaliza a lista e o item encontrado
                        lvwPesquisa.Items[vil_Count].Selected = true;                        
                        //Define o foco no controle Listview
                        lvwPesquisa.Focus();
                        //Assegura que se o item estiver em uma parte não visível ele será exibido
                        lvwPesquisa.EnsureVisible(vil_Count);
                        return;
                    }
                }
            }
            else if (radCodigo.Checked && Char.IsDigit(txtNome.Text, txtNome.Text.Length - 1))
            {
                //Variaveis private
                String vcl_Codigo;                           
                for (int vil_Count = 0; vil_Count < lvwPesquisa.Items.Count; vil_Count++)
                {
                    vcl_Codigo = Convert.ToString(lvwPesquisa.Items[vil_Count].SubItems[0].Text);
                    if (Convert.ToString(txtNome.Text) == vcl_Codigo)
                    {
                        //Focaliza a lista e o item encontrado
                        lvwPesquisa.Items[vil_Count].Selected = true;
                        //Define o foco no controle Listview
                        lvwPesquisa.Focus();
                        //Assegura que se o item estiver em uma parte não visível ele será exibido
                        lvwPesquisa.EnsureVisible(vil_Count);
                        return;
                    }
                }
            }
        }

        private void RadCodigo_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Text = "Digite o código a ser localizado";
            txtNome.Focus();
            //
            vig_sortColumn = 0;            
            lvwPesquisa.Sorting = SortOrder.Ascending;
            lvwPesquisa.Sort();
            lvwPesquisa.ListViewItemSorter = new ListViewItemComparer(vig_sortColumn, lvwPesquisa.Sorting);


        }

        private void RadDescricao_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Text = "Digite parte da descrição a ser localizado";
            txtNome.Focus();
            //
            vig_sortColumn = 1;
            lvwPesquisa.Sorting = SortOrder.Ascending;
            lvwPesquisa.Sort();
            lvwPesquisa.ListViewItemSorter = new ListViewItemComparer(vig_sortColumn, lvwPesquisa.Sorting);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion

        #region Métodos Privados
        private void FP_Editar(string pPesquisa)
        {
            try
            {
                //Inicializa objeto
                vol_FacadePesquisar = new FBL_Pesquisar();
                //Seleciona tipo de pesquisa
                switch (pPesquisa)
                {
                    case "Produtos":
                        lblTitulo.Text = pPesquisa;
                        lvwPesquisa.Columns[1].Text = pPesquisa;
                        this.Text = "Pesquisa de Produtos";
                        vol_FacadePesquisar.ListarProdutos(lvwPesquisa);
                        break;
                    case "Clientes":
                        lblTitulo.Text = pPesquisa;
                        lvwPesquisa.Columns[1].Text = pPesquisa;
                        this.Text = "Pesquisa de Clientes";
                        vol_FacadePesquisar.ListarClientes(lvwPesquisa);
                        break;
                }
            }
            catch
            {
                return;
            }
        }
        #endregion

    }
}
