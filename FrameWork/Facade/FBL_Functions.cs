using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using FrameWork.Negocios;
using FrameWork.Entidades;


namespace FrameWork.Facade
{
    public class FBL_Functions
    {
        #region Variaveis
        BLL_Functions vol_NegociosFunctions = null;
        #endregion

        #region Métodos Públicos
        //Método para preencher treeview
        public void TreeMain(TreeView pTreeView, ImageList pImgList)
        {
            vol_NegociosFunctions = new BLL_Functions();
            vol_NegociosFunctions.TreeMain(pTreeView, pImgList);
        }

        //Carrega a lista dos locais do planejamento
        public void ColorListView(ListView pLista, bool pTipoChecked)
        {
            vol_NegociosFunctions = new BLL_Functions();
            vol_NegociosFunctions.ColorListView(pLista, pTipoChecked);
        }

        //Método para aplicar efeito zebrado
        public void AplicarCorLista(ListViewItem pListaItem, int pCount)
        {
            if (pCount % Convert.ToInt16(2) == 0)
            {
                pListaItem.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                pListaItem.BackColor = Color.FromArgb(255, 255, 217);
            }
        }
        #endregion
    }
}
