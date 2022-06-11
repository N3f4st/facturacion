Public Class Producto
    Public Shared Function obtenerTipoProducto() As List(Of Datos.tipoProducto)
        Using db As New Datos.BillingEntities()
            Return db.tipoProducto.ToList()
        End Using
    End Function
End Class
