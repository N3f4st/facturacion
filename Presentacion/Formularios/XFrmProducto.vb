Public Class XFrmProducto
    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles XtraTabControl1.Click

    End Sub

    Private Sub BtnUbicacionBodega_Click(sender As Object, e As EventArgs) Handles BtnUbicacionBodega.Click
        XFrmUbicacionBodega.ShowDialog()
    End Sub

    Private Sub BtnUnidadMedida_Click(sender As Object, e As EventArgs) Handles BtnUnidadMedida.Click
        XFrmUnidadMedida.ShowDialog()
    End Sub

    Private Sub BtnProductoCategoria_Click(sender As Object, e As EventArgs) Handles BtnProductoCategoria.Click
        XFrmProductoCategoria.ShowDialog()
    End Sub

    Private Sub BtnProductoMarca_Click(sender As Object, e As EventArgs) Handles BtnProductoMarca.Click
        XFrmProductoMarca.ShowDialog()
    End Sub

    Private Sub XFrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lueTipoProducto.Properties.DataSource = Negocio.Producto.obtenerTipoProducto()
    End Sub
End Class