﻿namespace QLVT_DATHANG.Report
{
   partial class Xrpt_ReportHDNV
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

      #region Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_ReportHDNV));
         this.sqlDataSource = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.label1 = new DevExpress.XtraReports.UI.XRLabel();
         this.table1 = new DevExpress.XtraReports.UI.XRTable();
         this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
         this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
         this.table2 = new DevExpress.XtraReports.UI.XRTable();
         this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
         this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
         this.dataSetReport = new QLVT_DATHANG.DataSetReport();
         this.taReport_HDNV = new QLVT_DATHANG.DataSetReportTableAdapters.Report_HDNVTableAdapter();
         ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // sqlDataSource1
         // 
         this.sqlDataSource.Name = "sqlDataSource1";
         storedProcQuery1.Name = "Report_HDNV";
         queryParameter1.Name = "@MANV";
         queryParameter1.Type = typeof(int);
         queryParameter1.ValueInfo = "0";
         queryParameter2.Name = "@LOAI";
         queryParameter2.Type = typeof(char);
         queryParameter3.Name = "@BEGIN";
         queryParameter3.Type = typeof(string);
         queryParameter4.Name = "@END";
         queryParameter4.Type = typeof(string);
         storedProcQuery1.Parameters.Add(queryParameter1);
         storedProcQuery1.Parameters.Add(queryParameter2);
         storedProcQuery1.Parameters.Add(queryParameter3);
         storedProcQuery1.Parameters.Add(queryParameter4);
         storedProcQuery1.StoredProcName = "Report_HDNV";
         this.sqlDataSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
         this.sqlDataSource.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
         // 
         // Title
         // 
         this.Title.BackColor = System.Drawing.Color.Transparent;
         this.Title.BorderColor = System.Drawing.Color.Black;
         this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.Title.BorderWidth = 1F;
         this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
         this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.Title.Name = "Title";
         // 
         // DetailCaption1
         // 
         this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(228)))));
         this.DetailCaption1.BorderColor = System.Drawing.Color.White;
         this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
         this.DetailCaption1.BorderWidth = 2F;
         this.DetailCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
         this.DetailCaption1.ForeColor = System.Drawing.Color.White;
         this.DetailCaption1.Name = "DetailCaption1";
         this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
         this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // DetailData1
         // 
         this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
         this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
         this.DetailData1.BorderWidth = 2F;
         this.DetailData1.Font = new System.Drawing.Font("Arial", 8.25F);
         this.DetailData1.ForeColor = System.Drawing.Color.Black;
         this.DetailData1.Name = "DetailData1";
         this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
         this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // DetailData3_Odd
         // 
         this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
         this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
         this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.DetailData3_Odd.BorderWidth = 1F;
         this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
         this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
         this.DetailData3_Odd.Name = "DetailData3_Odd";
         this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
         this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // PageInfo
         // 
         this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
         this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.PageInfo.Name = "PageInfo";
         this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         // 
         // TopMargin
         // 
         this.TopMargin.Name = "TopMargin";
         // 
         // BottomMargin
         // 
         this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
         this.BottomMargin.Name = "BottomMargin";
         // 
         // ReportHeader
         // 
         this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
         this.ReportHeader.HeightF = 60F;
         this.ReportHeader.Name = "ReportHeader";
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
         this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
         this.GroupHeader1.HeightF = 28F;
         this.GroupHeader1.Name = "GroupHeader1";
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
         this.Detail.HeightF = 25F;
         this.Detail.Name = "Detail";
         // 
         // pageInfo1
         // 
         this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
         this.pageInfo1.Name = "pageInfo1";
         this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.pageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F);
         this.pageInfo1.StyleName = "PageInfo";
         // 
         // pageInfo2
         // 
         this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(331F, 6F);
         this.pageInfo2.Name = "pageInfo2";
         this.pageInfo2.SizeF = new System.Drawing.SizeF(313F, 23F);
         this.pageInfo2.StyleName = "PageInfo";
         this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.pageInfo2.TextFormatString = "Page {0} of {1}";
         // 
         // label1
         // 
         this.label1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
         this.label1.Name = "label1";
         this.label1.SizeF = new System.Drawing.SizeF(638F, 24.19433F);
         this.label1.StyleName = "Title";
         this.label1.Text = "HOẠT ĐỘNG NHÂN VIÊN";
         // 
         // table1
         // 
         this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.table1.Name = "table1";
         this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
         this.table1.SizeF = new System.Drawing.SizeF(650F, 28F);
         // 
         // tableRow1
         // 
         this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5,
            this.tableCell6,
            this.tableCell7,
            this.tableCell8});
         this.tableRow1.Name = "tableRow1";
         this.tableRow1.Weight = 1D;
         // 
         // tableCell1
         // 
         this.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.tableCell1.Name = "tableCell1";
         this.tableCell1.StyleName = "DetailCaption1";
         this.tableCell1.StylePriority.UseBorders = false;
         this.tableCell1.Text = "Ngày";
         this.tableCell1.Weight = 0.086263850285456731D;
         // 
         // tableCell2
         // 
         this.tableCell2.Name = "tableCell2";
         this.tableCell2.StyleName = "DetailCaption1";
         this.tableCell2.Text = "Mã Phiếu";
         this.tableCell2.Weight = 0.13191096379206732D;
         // 
         // tableCell3
         // 
         this.tableCell3.Name = "tableCell3";
         this.tableCell3.StyleName = "DetailCaption1";
         this.tableCell3.Text = "Họ và Tên";
         this.tableCell3.Weight = 0.14104726938100962D;
         // 
         // tableCell4
         // 
         this.tableCell4.Name = "tableCell4";
         this.tableCell4.StyleName = "DetailCaption1";
         this.tableCell4.Text = "Tên Vật Tư";
         this.tableCell4.Weight = 0.15151331974909857D;
         // 
         // tableCell5
         // 
         this.tableCell5.Name = "tableCell5";
         this.tableCell5.StyleName = "DetailCaption1";
         this.tableCell5.Text = "Tên Kho";
         this.tableCell5.Weight = 0.12275174654447116D;
         // 
         // tableCell6
         // 
         this.tableCell6.Name = "tableCell6";
         this.tableCell6.StyleName = "DetailCaption1";
         this.tableCell6.StylePriority.UseTextAlignment = false;
         this.tableCell6.Text = "Số Lượng";
         this.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell6.Weight = 0.1420904306265024D;
         // 
         // tableCell7
         // 
         this.tableCell7.Name = "tableCell7";
         this.tableCell7.StyleName = "DetailCaption1";
         this.tableCell7.StylePriority.UseTextAlignment = false;
         this.tableCell7.Text = "Đơn Giá";
         this.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell7.Weight = 0.12120418842022236D;
         // 
         // tableCell8
         // 
         this.tableCell8.Name = "tableCell8";
         this.tableCell8.StyleName = "DetailCaption1";
         this.tableCell8.StylePriority.UseTextAlignment = false;
         this.tableCell8.Text = "Trị Giá";
         this.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell8.Weight = 0.10321826641376201D;
         // 
         // table2
         // 
         this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.table2.Name = "table2";
         this.table2.OddStyleName = "DetailData3_Odd";
         this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
         this.table2.SizeF = new System.Drawing.SizeF(650F, 25F);
         // 
         // tableRow2
         // 
         this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell9,
            this.tableCell10,
            this.tableCell11,
            this.tableCell12,
            this.tableCell13,
            this.tableCell14,
            this.tableCell15,
            this.tableCell16});
         this.tableRow2.Name = "tableRow2";
         this.tableRow2.Weight = 11.5D;
         // 
         // tableCell9
         // 
         this.tableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.tableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Ngày]")});
         this.tableCell9.Name = "tableCell9";
         this.tableCell9.StyleName = "DetailData1";
         this.tableCell9.StylePriority.UseBorders = false;
         this.tableCell9.Weight = 0.0862638444166917D;
         // 
         // tableCell10
         // 
         this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Mã Phiếu]")});
         this.tableCell10.Name = "tableCell10";
         this.tableCell10.StyleName = "DetailData1";
         this.tableCell10.Weight = 0.13191096379206732D;
         // 
         // tableCell11
         // 
         this.tableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Họ và Tên]")});
         this.tableCell11.Name = "tableCell11";
         this.tableCell11.StyleName = "DetailData1";
         this.tableCell11.Weight = 0.14104726938100962D;
         // 
         // tableCell12
         // 
         this.tableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tên Vật Tư]")});
         this.tableCell12.Name = "tableCell12";
         this.tableCell12.StyleName = "DetailData1";
         this.tableCell12.Weight = 0.15151331974909857D;
         // 
         // tableCell13
         // 
         this.tableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tên Kho]")});
         this.tableCell13.Name = "tableCell13";
         this.tableCell13.StyleName = "DetailData1";
         this.tableCell13.Weight = 0.12275174654447116D;
         // 
         // tableCell14
         // 
         this.tableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Số Lượng]")});
         this.tableCell14.Name = "tableCell14";
         this.tableCell14.StyleName = "DetailData1";
         this.tableCell14.StylePriority.UseTextAlignment = false;
         this.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell14.Weight = 0.1420904306265024D;
         // 
         // tableCell15
         // 
         this.tableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Đơn Giá]")});
         this.tableCell15.Name = "tableCell15";
         this.tableCell15.StyleName = "DetailData1";
         this.tableCell15.StylePriority.UseTextAlignment = false;
         this.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell15.Weight = 0.12120418842022236D;
         // 
         // tableCell16
         // 
         this.tableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Trị Giá]")});
         this.tableCell16.Name = "tableCell16";
         this.tableCell16.StyleName = "DetailData1";
         this.tableCell16.StylePriority.UseTextAlignment = false;
         this.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell16.Weight = 0.10321824293870192D;
         // 
         // dataSetReport1
         // 
         this.dataSetReport.DataSetName = "DataSetReport";
         this.dataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // report_HDNVTableAdapter1
         // 
         this.taReport_HDNV.ClearBeforeFill = true;
         // 
         // Xrpt_ReportHDNV
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource,
            this.dataSetReport});
         this.DataAdapter = this.taReport_HDNV;
         this.DataMember = "Report_HDNV";
         this.DataSource = this.dataSetReport;
         this.Font = new System.Drawing.Font("Arial", 9.75F);
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
         this.Version = "19.1";
         ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

      #endregion

      private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource;
      private DevExpress.XtraReports.UI.XRControlStyle Title;
      private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
      private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
      private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
      private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
      private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
      private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
      private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
      private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
      private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
      private DevExpress.XtraReports.UI.XRLabel label1;
      private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
      private DevExpress.XtraReports.UI.XRTable table1;
      private DevExpress.XtraReports.UI.XRTableRow tableRow1;
      private DevExpress.XtraReports.UI.XRTableCell tableCell1;
      private DevExpress.XtraReports.UI.XRTableCell tableCell2;
      private DevExpress.XtraReports.UI.XRTableCell tableCell3;
      private DevExpress.XtraReports.UI.XRTableCell tableCell4;
      private DevExpress.XtraReports.UI.XRTableCell tableCell5;
      private DevExpress.XtraReports.UI.XRTableCell tableCell6;
      private DevExpress.XtraReports.UI.XRTableCell tableCell7;
      private DevExpress.XtraReports.UI.XRTableCell tableCell8;
      private DevExpress.XtraReports.UI.DetailBand Detail;
      private DevExpress.XtraReports.UI.XRTable table2;
      private DevExpress.XtraReports.UI.XRTableRow tableRow2;
      private DevExpress.XtraReports.UI.XRTableCell tableCell9;
      private DevExpress.XtraReports.UI.XRTableCell tableCell10;
      private DevExpress.XtraReports.UI.XRTableCell tableCell11;
      private DevExpress.XtraReports.UI.XRTableCell tableCell12;
      private DevExpress.XtraReports.UI.XRTableCell tableCell13;
      private DevExpress.XtraReports.UI.XRTableCell tableCell14;
      private DevExpress.XtraReports.UI.XRTableCell tableCell15;
      private DevExpress.XtraReports.UI.XRTableCell tableCell16;
      private DataSetReport dataSetReport;
      private DataSetReportTableAdapters.Report_HDNVTableAdapter taReport_HDNV;
   }
}
