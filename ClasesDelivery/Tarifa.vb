Imports ClasesDelivery
Imports ClasesDelivery.Util
Public Class Tarifa
    'a. Crear la clase con los atributos y propiedades. (2 puntos)
#Region "Atributos"
    Private TarifaID As Integer
    Private CiudadID As Integer
    Private TipoVehiculoID As Integer
    Private CostoServicio As Double
#End Region


#Region "Propiedades"
    Public Property pTarifaID As Integer
        Get
            Return TarifaID
        End Get
        Set(value As Integer)
            TarifaID = value
        End Set
    End Property

    Public Property pCiudadID As Integer
        Get
            Return CiudadID
        End Get
        Set(value As Integer)
            CiudadID = value
        End Set
    End Property

    Public Property pTipoVehiculoID As Integer
        Get
            Return TipoVehiculoID
        End Get
        Set(value As Integer)
            TipoVehiculoID = value
        End Set
    End Property

    Public Property pCostoServicio As Double
        Get
            Return CostoServicio
        End Get
        Set(value As Double)
            CostoServicio = value
        End Set
    End Property
#End Region


#Region "Metodos"
    Public Function RecuperarCostoServicio(ByVal vCodigoCiudad As Integer, vTipoVehiculo As Integer) As Tarifa
        Try
            Dim dtTarifa As New Data.DataTable("Tarifa")
            dtTarifa = gDatos.TraerDataTable("spDevolverCostoServicio", vCodigoCiudad, vTipoVehiculo)
            If dtTarifa.Rows.Count > 0 Then

                Dim vTarifa As New Tarifa
                vTarifa.pCostoServicio = dtTarifa.Rows(0).Item("CostoServicio")

                Return vTarifa.MemberwiseClone

            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
End Class
