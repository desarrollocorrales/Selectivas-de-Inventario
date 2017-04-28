using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraGrid.Views.Base;
using Selectivas_de_Almacen.Entity;
using System.Drawing;

namespace Selectivas_de_Almacen.GUIs
{
    public partial class Frm_Principal : Form
    {
        // Creando componentes de impresión.
        PrintingSystem SistemaImpresion = new PrintingSystem();
        PrintableComponentLink ComponenteImpresion = new PrintableComponentLink();
        //.......
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
            List<paquetes> listPaquetes = new List<paquetes>();

            var EtiquetasBuscadas = from buscaEtiqueta in Contexto.etiquetas
                                    where (listNumerosDeEtiquetas.Contains(buscaEtiqueta.numero_etiqueta))
                                    select buscaEtiqueta;

            var TarimasBuscadas = from buscaPaquete in Contexto.paquetes
                                  where (listNumerosDeEtiquetas.Contains(buscaPaquete.numero_etiqueta))
                                  select buscaPaquete;

            listEtiquetas = EtiquetasBuscadas.OrderBy(o=>o.id_etiqueta).ToList();
            listPaquetes = TarimasBuscadas.OrderBy(o => o.id_paquete).ToList();

            foreach (paquetes paq in listPaquetes)
            {
                var listaDetallesPaqueteEntity = paq.paquetes_det;
                List<paquetes_det> lstDetallesPaquete = listaDetallesPaqueteEntity.ToList();
                lstDetallesPaquete = lstDetallesPaquete.FindAll(o => o.etiquetas.estatus == "A");
                foreach (paquetes_det detalle in lstDetallesPaquete)
                {
                    listEtiquetas.Add(detalle.etiquetas); 
                }
            }

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
            ImprimirGrid();
        }
        private void ImprimirGrid()
        {
            /******************************/
            // Creamos el Header
            PageHeaderArea Header = new PageHeaderArea();
            ComponenteImpresion.Images.Add(Image.FromFile("logomini.png"));
            Header.Content.AddRange(new string[] { "[Image 0]", "", "[Time Printed]" });
            Header.LineAlignment = BrickAlignment.Far;
            /******************************/

            /******************************/
            //Creamos el Footer
            string izquierda = "Paginas: [Page # of Pages #]";
            string centro    = "Usuario: [User Name]";
            string derecha   =   "Fecha: [Date Printed]";
            PageFooterArea Footer = new PageFooterArea();
            Footer.Content.AddRange(new string[] { izquierda, centro, derecha });
            Footer.LineAlignment = BrickAlignment.Near;
            /*****************************/

            /******************************/
            //Agregar el Grid al documento
            ComponenteImpresion.Component = gridEscaneo;
            //Agregar el header y el footer al documento
            ComponenteImpresion.PageHeaderFooter = new PageHeaderFooter(Header, Footer);          
            //Crear el documento
            ComponenteImpresion.CreateDocument(SistemaImpresion);
            //Mostrar la vista previa para imprimir
            ComponenteImpresion.ShowPreviewDialog();
        }

        private void gvEscaneo_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
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

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
