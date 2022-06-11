Imports DevExpress.XtraBars

Partial Public Class Form1

    Dim Productos As New XFrmListaProductos
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub RbListaProductos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles RbListaProductos.ItemClick
        If Productos Is Nothing OrElse Not XFrmListaProductos.Visible Then
            Productos = New XFrmListaProductos
            Productos.MdiParent = Me
        End If
        Productos.Show()
        Productos.Focus()
        RibbonPage2.Visible = True
        RibbonPage4.Visible = True
        RibbonPageCategory1.Visible = True
        ribbonControl1.SelectedPage = RibbonPage2
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RibbonPageCategory1.Visible = False
    End Sub

    Private Sub ribbonControl1_Click(sender As Object, e As EventArgs) Handles ribbonControl1.Click

    End Sub

    Private Sub RbNuevoProducto_ItemClick(sender As Object, e As ItemClickEventArgs) Handles RbNuevoProducto.ItemClick
        XFrmProducto.Show()
    End Sub
End Class
