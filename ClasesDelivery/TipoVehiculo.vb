Imports ClasesDelivery.Util
Public Class TipoVehiculo
    'a. Crear la clase con los atributos y propiedades. (1 puntos)

#Region "Atributos"
    Private TipoVehiculoID As Integer
    Private Descripcion As String
#End Region

#Region "Propiedades"
    Public Property pTipoVehiculoID As Integer
        Get
            Return TipoVehiculoID
        End Get
        Set(value As Integer)
            TipoVehiculoID = value
        End Set
    End Property

    Public Property pDescripcion As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property
#End Region

#Region "Metodos"
    'b. Codificar un método que retorne todos los tipos de vehículos, usando el procedimiento
    'almacenado del tema 3. (2 puntos)

    Public Shared Function RecuperarRegistrosTipoVehiculo() As DataTable
        Try
            Dim dtTipoVehiculo As New Data.DataTable("TipoVehiculo")
            dtTipoVehiculo = gDatos.TraerDataTable("spListarTiposVehiculos")
            Return dtTipoVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
End Class
