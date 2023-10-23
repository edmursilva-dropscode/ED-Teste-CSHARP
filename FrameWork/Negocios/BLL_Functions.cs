using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Diagnostics;
using FrameWork.Dados;
using FrameWork.Entidades;

namespace FrameWork.Negocios
{
    //Gravar que contém funções diversas de uso comum    
    public class BLL_Functions
    {
        #region Variaveis
        //Objeto de classe                           
        DAL_Usuario vol_DadosUsuario = null;
        //Variaveis privadas
        XmlNode vol_xNode = null;
        TreeNode vol_tNode = null;
        XmlNodeList vol_nodeListMod = null;
        XmlNodeList vol_nodeListSubMod = null;
        string vcl_Key = String.Empty;
        string vcl_Text = String.Empty;
        int vil_ImgIndex = 0;
        int vil_SelImgIndex = 0;
        #endregion

        #region Metodos Publicos
        //Método gera os nós do treview
        public void TreeMain(TreeView pTreeView, ImageList pImgList)
        {
            //Apaga os nós 
            pTreeView.Nodes.Clear();
            //Associa o Treeview com o ImageList
            pTreeView.ImageList = pImgList;
            //Cria os nós 
            pTreeView.BeginUpdate();
            // Load the XML Document
            XmlDocument doc = new XmlDocument();
            try
            {
                string vcl_PathFilename = System.Windows.Forms.Application.StartupPath + @"\Parametros\TreeView.xml";
                doc.Load(vcl_PathFilename);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            pTreeView.Nodes.Clear();
            pTreeView.Nodes.Add(new TreeNode(doc.DocumentElement.Name));
            _ = new TreeNode();
            TreeNode tNode = pTreeView.Nodes[0];
            //Percorre os nós XML para o usuario/perfil até que a folha seja atingido.
            for (int vil_CountTreeView = 0; vil_CountTreeView < doc.ChildNodes[0].ChildNodes.Count; vil_CountTreeView++)
            {
                if (doc.ChildNodes[0].ChildNodes[vil_CountTreeView].Name == "Supervisor") 
                {
                    FP_ConvertXmlNodeToTreeNodeMod(doc.ChildNodes[0].ChildNodes[vil_CountTreeView], tNode);
                    break;
                }
            }

            pTreeView.Nodes[0].Expand();
            pTreeView.Nodes[0].ForeColor = Color.DimGray;
            pTreeView.Nodes[0].NodeFont = new System.Drawing.Font("Verdana", 8.50F, System.Drawing.FontStyle.Bold);
            pTreeView.EndUpdate();
            //pTreeView.ExpandAll();
        }

        //Percorre os nós XML para o modulo até que a folha seja atingido.
        private void FP_ConvertXmlNodeToTreeNodeMod(XmlNode pXmlNode, TreeNode pTreeNodes)
        {
            // Adicionar os nós para o TreeView durante o processo de looping.
            if (pXmlNode.HasChildNodes)
            {
                vol_nodeListMod = pXmlNode.ChildNodes;

                for (int vil_CountMod = 0; vil_CountMod < vol_nodeListMod.Count; vil_CountMod++)
                {
                    if (pXmlNode.ChildNodes[vil_CountMod] != null)
                    {
                        vol_xNode = pXmlNode.ChildNodes[vil_CountMod];

                        if (vol_xNode.Name == "Property")
                        {
                            //Recupera valores do XML
                            vcl_Key = vol_xNode.Attributes["key"].Value;
                            vcl_Text = vol_xNode.Attributes["text"].Value;
                            vil_ImgIndex = Convert.ToInt32(vol_xNode.Attributes["imgIndex"].Value);
                            vil_SelImgIndex = Convert.ToInt32(vol_xNode.Attributes["selImgIndex"].Value);
                            //Adiciona os dados ao treeview
                            pTreeNodes.Nodes.Add(vcl_Key, vcl_Text, vil_ImgIndex, vil_SelImgIndex);
                            //Salva o nó principal para preencher os nós filhos
                            vol_tNode = pTreeNodes.Nodes[vcl_Key];
                            //Preenche os nós filhos caso existam
                            FP_ConvertXmlNodeToTreeNodeSub(vol_xNode, vol_tNode);
                            //Verifica se o nó principal é o de contas de acessos para preencher os usuários
                            if (vcl_Key == "Usuarios")
                            {
                                FP_TreeNodeUsuarios(vol_xNode, pTreeNodes);
                            }
                        }
                        else
                        {
                            FP_ConvertXmlNodeToTreeNodeSub(vol_xNode, pTreeNodes);
                        }
                    }
                }
            }
        }

        //Percorre os nós XML para o submodulo até que a folha seja atingido.
        private void FP_ConvertXmlNodeToTreeNodeSub(XmlNode pXmlNode, TreeNode pTreeNodes)
        {
            // Adicionar os nós para o TreeView durante o processo de looping.
            if (pXmlNode.HasChildNodes)
            {
                vol_nodeListSubMod = pXmlNode.ChildNodes;

                for (int vil_CountSubMod = 0; vil_CountSubMod < vol_nodeListSubMod.Count; vil_CountSubMod++)
                {
                    if (pXmlNode.ChildNodes[vil_CountSubMod] != null)
                    {
                        vol_xNode = pXmlNode.ChildNodes[vil_CountSubMod];

                        if (vol_xNode.Name == "Property")
                        {
                            //Recupera valores do XML
                            vcl_Key = vol_xNode.Attributes["key"].Value;
                            vcl_Text = vol_xNode.Attributes["text"].Value;
                            vil_ImgIndex = Convert.ToInt32(vol_xNode.Attributes["imgIndex"].Value);
                            vil_SelImgIndex = Convert.ToInt32(vol_xNode.Attributes["selImgIndex"].Value);
                            //Adiciona os dados ao treeview
                            pTreeNodes.Nodes.Add(vcl_Key, vcl_Text, vil_ImgIndex, vil_SelImgIndex);
                            //Salva o nó principal para preencher os nós filhos
                            vol_tNode = pTreeNodes.Nodes[vcl_Key];
                            //Preenche os nós filhos caso existam
                            FP_ConvertXmlNodeToTreeNodeSub(vol_xNode, vol_tNode);
                            //Verifica se o nó principal é o de contas de acessos para preencher os usuários
                            if (vcl_Key == "Usuarios")
                            {
                                FP_TreeNodeUsuarios(vol_xNode, pTreeNodes);
                            }
                        }
                        else
                        {
                            FP_ConvertXmlNodeToTreeNodeSub(vol_xNode, pTreeNodes);
                        }
                    }
                }
            }
        }

        private void FP_TreeNodeUsuarios(XmlNode pXmlNode, TreeNode pTreeNodes)
        {
            if (pXmlNode is null)
            {
                throw new ArgumentNullException(nameof(pXmlNode));
            }
            //Inicializa o objeto
            vol_DadosUsuario = new DAL_Usuario();
            //Recupera os usuário do sistema
            List<Usuario> vol_ListUsuario = vol_DadosUsuario.SelecionarUsuarioSistemas(0);
            //Percorre lista para incluir usuários
            foreach (Usuario vol_Item in vol_ListUsuario)
            {
                //Verifica se é usuário é supervisor e seleciona a imagem
                vil_ImgIndex = (vol_Item.TipoPerfil == 1 ? 2 : 1);
                //Verifica se é usuário está ativo e seleciona a imagem
                vil_ImgIndex = (vol_Item.Ativo == 0 ? vil_ImgIndex : 3);
                //Imagem para quando selecionado o item
                vil_SelImgIndex = vil_ImgIndex;
                //Adiciona o usuário ao nó
                pTreeNodes.Nodes.Add(Convert.ToString(vol_Item.IdUsuario), vol_Item.Nome, vil_ImgIndex, vil_SelImgIndex);
            }
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

        public void ColorListView(ListView pLista, bool pTipoChecked)
        {
            int vil_Count = 0;

            pLista.Items.Clear();
            if (pTipoChecked==false)
            {
                pLista.CheckBoxes = false;
            }
            else
            {
                pLista.CheckBoxes = true;
            }
            ListViewItem vol_ListViewItem = new ListViewItem("");
            pLista.Items.Add(vol_ListViewItem);
            vil_Count++;
            AplicarCorLista(vol_ListViewItem, vil_Count);
            pLista.FullRowSelect = true;
            pLista.GridLines = true;
            pLista.Refresh();
            //
        }

        public void RedefineColorListView(ListView pLista)
        {
            int vil_Count = 0;
            foreach (ListViewItem vol_ListViewItem in pLista.Items)
            {
                vil_Count++;
                AplicarCorLista(vol_ListViewItem, vil_Count);
            }
        }
        #endregion
    }
}
