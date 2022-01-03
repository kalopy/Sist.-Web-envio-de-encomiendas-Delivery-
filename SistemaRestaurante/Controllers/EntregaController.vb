Imports System.Web.Mvc
Imports ClasesDelivery
Namespace Controllers
    Public Class EntregaController
        Inherits Controller

        ' GET: Entrega
        Function Index() As ActionResult

            Dim dtEntregas As New DataTable
            dtEntregas = Entrega.RecuperarRegistrosEntrega
            ViewData("entregas") = dtEntregas.AsEnumerable
            Return View()
        End Function

        Function Create() As ActionResult

            Dim dtCiudades As New DataTable
            dtCiudades = Ciudad.RecuperarRegistrosCiudad
            ViewData("ciudades") = dtCiudades.AsEnumerable

            Dim dtTiposVehiculos As New DataTable
            dtTiposVehiculos = TipoVehiculo.RecuperarRegistrosTipoVehiculo
            ViewData("tiposVehiculos") = dtTiposVehiculos.AsEnumerable

            Dim dtPersonales As New DataTable
            dtPersonales = Personal.RecuperarRegistrosPersonal
            ViewData("personales") = dtPersonales.AsEnumerable
            Return View()
        End Function

        <HttpPost()>
        Function Create(form As FormCollection) As ActionResult

            Dim vEntrega As New Entrega

            With vEntrega
                .pFechaRegistro = form("fechaRegistro")
                .pFechaEntrega = form("fechaEntrega")
                .pCliente = form("cliente")
                .pCiudadID = form("ciudadid")
                .pTipoVehiculoID = form("tiposVehiculos")
                .pCostoServicio = form("costo_servicio")
                .pDireccion = form("direccion")
                .pPersonalID = form("personales")
                .pEstadoID = form("estadoid")
                .Insertar()
            End With

            Return RedirectToAction("Index")
        End Function

        Function calcularMontoCuota(idCiudad As Integer, idTipoVehiculo As Integer) As Integer
            Dim vTarifa = New Tarifa
            vTarifa = vTarifa.RecuperarCostoServicio(idCiudad, idTipoVehiculo)
            Return vTarifa.pCostoServicio
        End Function

    End Class
End Namespace