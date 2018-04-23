Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private dataSet11 As DataSet1
	Private productReportsTableAdapter1 As DataSet1TableAdapters.ProductReportsTableAdapter
	Private GroupHeader1 As GroupHeaderBand
	Private xrLabel1 As XRLabel
	Private xrLabel3 As XRLabel
	Private xrLabel2 As XRLabel
	Private GroupHeader2 As GroupHeaderBand
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resourceFileName As String = "XtraReport1.resx"
		Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.dataSet11 = New DataSet1()
		Me.productReportsTableAdapter1 = New DataSet1TableAdapters.ProductReportsTableAdapter()
		Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
		Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
		CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Height = 0
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' dataSet11
		' 
		Me.dataSet11.DataSetName = "DataSet1"
		Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		' 
		' productReportsTableAdapter1
		' 
		Me.productReportsTableAdapter1.ClearBeforeFill = True
		' 
		' GroupHeader1
		' 
		Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
		Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
		Me.GroupHeader1.Height = 25
		Me.GroupHeader1.Level = 1
		Me.GroupHeader1.Name = "GroupHeader1"
		' 
		' xrLabel1
		' 
		Me.xrLabel1.BackColor = System.Drawing.Color.Turquoise
		Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ProductReports.CategoryName", "")})
		Me.xrLabel1.Location = New System.Drawing.Point(0,0)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2,2,0,0,96F)
		Me.xrLabel1.Size = New System.Drawing.Size(100,25)
		Me.xrLabel1.StylePriority.UseBackColor = False
		Me.xrLabel1.Text = "xrLabel1"
		' 
		' xrLabel2
		' 
		Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ProductReports.ProductName", "")})
		Me.xrLabel2.Location = New System.Drawing.Point(50,0)
		Me.xrLabel2.Name = "xrLabel2"
		Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2,2,0,0,100F)
		Me.xrLabel2.Size = New System.Drawing.Size(333,25)
		Me.xrLabel2.Text = "xrLabel2"
		' 
		' xrLabel3
		' 
		Me.xrLabel3.BackColor = System.Drawing.Color.Turquoise
		Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ProductReports.ProductSales", "")})
		Me.xrLabel3.Location = New System.Drawing.Point(400,0)
		Me.xrLabel3.Name = "xrLabel3"
		Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2,2,0,0,100F)
		Me.xrLabel3.Size = New System.Drawing.Size(142,25)
		Me.xrLabel3.StylePriority.UseBackColor = False
		xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
		Me.xrLabel3.Summary = xrSummary1
		Me.xrLabel3.Text = "xrLabel3"
		' 
		' GroupHeader2
		' 
		Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel2})
		Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
		Me.GroupHeader2.Height = 25
		Me.GroupHeader2.Name = "GroupHeader2"
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.GroupHeader1, Me.GroupHeader2})
		Me.DataAdapter = Me.productReportsTableAdapter1
		Me.DataMember = "ProductReports"
		Me.DataSource = Me.dataSet11
		Me.Version = "8.3"
		CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region
End Class
