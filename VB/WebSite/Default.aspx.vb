Imports System

Imports DevExpress.XtraReports.Web
Imports DevExpress.XtraReports.UI

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Session("Report") Is Nothing Then
                Dim r As New XtraReport1()
                Session("Report") = r
            End If
            ASPxDocumentViewer1.Report = TryCast(Session("Report"), XtraReport)
    End Sub
    Protected Sub ReportViewer1_Unload(ByVal sender As Object, ByVal e As EventArgs)
        DirectCast(sender, ASPxDocumentViewer).Report = Nothing
    End Sub
End Class
