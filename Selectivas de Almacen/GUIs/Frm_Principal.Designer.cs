namespace Selectivas_de_Almacen.GUIs
{
    partial class Frm_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRutaArchivoEscaneo = new System.Windows.Forms.TextBox();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gridEscaneo = new DevExpress.XtraGrid.GridControl();
            this.etiquetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEscaneo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClaveNombreArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_etiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_caducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpiezas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.ofdEscaneo = new System.Windows.Forms.OpenFileDialog();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEscaneo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEscaneo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(165, 9);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(454, 33);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Abastecedora de Carnes Los Corrales";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selectivas de Almacen";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblEmpresa);
            this.pnlTitulo.Controls.Add(this.label2);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(784, 80);
            this.pnlTitulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Archivo de Escaneo:";
            // 
            // txbRutaArchivoEscaneo
            // 
            this.txbRutaArchivoEscaneo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRutaArchivoEscaneo.BackColor = System.Drawing.Color.White;
            this.txbRutaArchivoEscaneo.Enabled = false;
            this.txbRutaArchivoEscaneo.Location = new System.Drawing.Point(171, 86);
            this.txbRutaArchivoEscaneo.Name = "txbRutaArchivoEscaneo";
            this.txbRutaArchivoEscaneo.Size = new System.Drawing.Size(563, 27);
            this.txbRutaArchivoEscaneo.TabIndex = 4;
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarArchivo.Location = new System.Drawing.Point(740, 86);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(32, 27);
            this.btnBuscarArchivo.TabIndex = 5;
            this.btnBuscarArchivo.Text = "...";
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultar.Location = new System.Drawing.Point(342, 119);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 30);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gridEscaneo
            // 
            this.gridEscaneo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEscaneo.DataSource = this.etiquetasBindingSource;
            this.gridEscaneo.Location = new System.Drawing.Point(16, 155);
            this.gridEscaneo.MainView = this.gvEscaneo;
            this.gridEscaneo.Name = "gridEscaneo";
            this.gridEscaneo.Size = new System.Drawing.Size(756, 359);
            this.gridEscaneo.TabIndex = 7;
            this.gridEscaneo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEscaneo});
            // 
            // etiquetasBindingSource
            // 
            this.etiquetasBindingSource.DataSource = typeof(Selectivas_de_Almacen.Entity.etiquetas);
            // 
            // gvEscaneo
            // 
            this.gvEscaneo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEscaneo.Appearance.FooterPanel.Options.UseFont = true;
            this.gvEscaneo.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEscaneo.Appearance.GroupFooter.Options.UseFont = true;
            this.gvEscaneo.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEscaneo.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.gvEscaneo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClaveNombreArticulo,
            this.colnumero_etiqueta,
            this.colfecha_caducidad,
            this.colcantidad,
            this.colunidad,
            this.colpiezas,
            this.colestatus});
            this.gvEscaneo.GridControl = this.gridEscaneo;
            this.gvEscaneo.GroupCount = 1;
            this.gvEscaneo.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "numero_etiqueta", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", this.colcantidad, "")});
            this.gvEscaneo.Name = "gvEscaneo";
            this.gvEscaneo.OptionsBehavior.Editable = false;
            this.gvEscaneo.OptionsPrint.UsePrintStyles = true;
            this.gvEscaneo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colClaveNombreArticulo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvEscaneo.EndGrouping += new System.EventHandler(this.gvEscaneo_EndGrouping);
            this.gvEscaneo.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvEscaneo_CustomColumnDisplayText);
            // 
            // colClaveNombreArticulo
            // 
            this.colClaveNombreArticulo.Caption = "Artículo";
            this.colClaveNombreArticulo.FieldName = "articulos.ClaveNombreArticulo";
            this.colClaveNombreArticulo.Name = "colClaveNombreArticulo";
            this.colClaveNombreArticulo.Visible = true;
            this.colClaveNombreArticulo.VisibleIndex = 0;
            // 
            // colnumero_etiqueta
            // 
            this.colnumero_etiqueta.AppearanceCell.Options.UseTextOptions = true;
            this.colnumero_etiqueta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnumero_etiqueta.AppearanceHeader.Options.UseTextOptions = true;
            this.colnumero_etiqueta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnumero_etiqueta.Caption = "Número Etiqueta";
            this.colnumero_etiqueta.FieldName = "numero_etiqueta";
            this.colnumero_etiqueta.Name = "colnumero_etiqueta";
            this.colnumero_etiqueta.Visible = true;
            this.colnumero_etiqueta.VisibleIndex = 0;
            // 
            // colfecha_caducidad
            // 
            this.colfecha_caducidad.AppearanceCell.Options.UseTextOptions = true;
            this.colfecha_caducidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfecha_caducidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colfecha_caducidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfecha_caducidad.Caption = "Caducidad";
            this.colfecha_caducidad.FieldName = "fecha_caducidad";
            this.colfecha_caducidad.Name = "colfecha_caducidad";
            this.colfecha_caducidad.Visible = true;
            this.colfecha_caducidad.VisibleIndex = 1;
            // 
            // colcantidad
            // 
            this.colcantidad.AppearanceCell.Options.UseTextOptions = true;
            this.colcantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colcantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colcantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            // 
            // colunidad
            // 
            this.colunidad.AppearanceCell.Options.UseTextOptions = true;
            this.colunidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colunidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colunidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colunidad.Caption = "Unidad";
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 3;
            // 
            // colpiezas
            // 
            this.colpiezas.AppearanceCell.Options.UseTextOptions = true;
            this.colpiezas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpiezas.AppearanceHeader.Options.UseTextOptions = true;
            this.colpiezas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpiezas.Caption = "Piezas";
            this.colpiezas.FieldName = "piezas";
            this.colpiezas.Name = "colpiezas";
            this.colpiezas.Visible = true;
            this.colpiezas.VisibleIndex = 4;
            // 
            // colestatus
            // 
            this.colestatus.AppearanceCell.Options.UseTextOptions = true;
            this.colestatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colestatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colestatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colestatus.Caption = "Estatus";
            this.colestatus.FieldName = "estatus";
            this.colestatus.Name = "colestatus";
            this.colestatus.Visible = true;
            this.colestatus.VisibleIndex = 5;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Location = new System.Drawing.Point(342, 520);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // ofdEscaneo
            // 
            this.ofdEscaneo.FileName = "*.txt";
            this.ofdEscaneo.Filter = "Archivos de texto | *.txt";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gridEscaneo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnBuscarArchivo);
            this.Controls.Add(this.txbRutaArchivoEscaneo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Principal";
            this.Text = "Selectivas de almacen";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEscaneo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEscaneo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRutaArchivoEscaneo;
        private System.Windows.Forms.Button btnBuscarArchivo;
        private System.Windows.Forms.Button btnConsultar;
        private DevExpress.XtraGrid.GridControl gridEscaneo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEscaneo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.OpenFileDialog ofdEscaneo;
        private System.Windows.Forms.BindingSource etiquetasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveNombreArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_etiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_caducidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpiezas;
        private DevExpress.XtraGrid.Columns.GridColumn colestatus;
    }
}