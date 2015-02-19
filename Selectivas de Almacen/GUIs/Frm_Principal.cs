using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Selectivas_de_Almacen.Entity;

namespace Selectivas_de_Almacen.GUIs
{
    public partial class Frm_Principal : Form
    {
        private string sArchivoDeEscaneo;

        public Frm_Principal()
        {
            InitializeComponent();
        }
        
        private void ShowException(Exception ex)
        {
            string TipoException = ex.GetType().ToString();
            StringBuilder SB = new StringBuilder();
            if (ex.InnerException != null)
                SB.AppendLine(ex.InnerException.Message);
            else
                SB.AppendLine(ex.Message);

            MessageBox.Show(SB.ToString(), TipoException, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarEtiquetas();
        }
        private List<string> obtenerListaDeEtiquetetasDeEscaneo()
        {
            //Leer el archivo de escaneo
            List<string> listEtiquetas = new List<string>();

            try
            {
                if (sArchivoDeEscaneo != null)
                {
                    StreamReader sr = new StreamReader(sArchivoDeEscaneo);

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Trim() != string.Empty)
                        {
                            listEtiquetas.Add(line);
                        }
                    }

                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }

            listEtiquetas = listEtiquetas.Distinct().ToList();

            return listEtiquetas;

        }
        private void ConsultarEtiquetas()
        {
            //Obtener lista de etiquetas.
            List<string> listNumerosDeEtiquetas = obtenerListaDeEtiquetetasDeEscaneo();
            EtiquetasEntities Contexto = new EtiquetasEntities();

            List<etiquetas> listEtiquetas = new List<etiquetas>();

            var EtiquetasBuscadas = from buscaEtiqueta in Contexto.etiquetas
                                    where (listNumerosDeEtiquetas.Contains(buscaEtiqueta.numero_etiqueta))
                                    select buscaEtiqueta;

            listEtiquetas = EtiquetasBuscadas.OrderBy(o=>o.id_etiqueta).ToList();

            gridEscaneo.DataSource = listEtiquetas;
            gvEscaneo.BestFitColumns();
        }

        

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            obtenerArchivoDeEscaneo();
        }
        private void obtenerArchivoDeEscaneo()
        {
            DialogResult DR = ofdEscaneo.ShowDialog();

            if (DR == DialogResult.OK)
            {
                sArchivoDeEscaneo = ofdEscaneo.FileName;
                txbRutaArchivoEscaneo.Text = ofdEscaneo.FileName;
            }
        }

        private void gvEscaneo_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gridEscaneo.ShowPrintPreview();
        }
        private void ImprimirGrid()
        {
        }

        private void gvEscaneo_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "estatus")
            {
                char estado = Convert.ToChar(e.Value);
                switch (estado)
                {
                    case 'A': e.DisplayText = "Almacen";
                        break;
                    case 'E': e.DisplayText = "Entregada";
                        break;
                    case 'B': e.DisplayText = "Borrada";
                        break;
                }
            }
        }

    }
}
