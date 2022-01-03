Imports ClasesDelivery.Util
Public Class Entrega
    'a. Crear la clase con los atributos y propiedades. (1 puntos)

#Region "Atributos"
    Private EntregaID As Integer
    Private FechaRegistro As Integer
    Private FechaEntrega As Date
    Private Cliente As String
    Private CiudadID As Integer
    Private TipoVehiculoID As Integer
    Private CostoServicio As Double
    Private Direccion As String
    Private PersonalID As Integer
    Private EstadoID As Integer
#End Region

#Region "Propiedades"
    Public Property pEntregaID As Integer
        Get
            Return EntregaID
        End Get
        Set(value As Integer)
            EntregaID = value
        End Set
    End Property

    Public Property pFechaRegistro As Integer
        Get
            Return FechaRegistro
        End Get
        Set(value As Integer)
            FechaRegistro = value
        End Set
    End Property

    Public Property pFechaEntrega As Date
        Get
            Return FechaEntrega
        End Get
        Set(value As Date)
            FechaEntrega = value
        End Set
    End Property

    Public Property pCliente As String
        Get
            Return Cliente
        End Get
        Set(value As String)
            Cliente = value
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

    Public Property pDireccion As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property

    Public Property pPersonalID As Integer
        Get
            Return PersonalID
        End Get
        Set(value As Integer)
            PersonalID = value
        End Set
    End Property

    Public Property pEstadoID As Integer
        Get
            Return EstadoID
        End Get
        Set(value As Integer)
            EstadoID = value
        End Set
    End Property
#End Region

#Region "Metodos"
    'b. Codificar un método que retorne todas las entregas, usando el procedimiento
    'almacenado del tema 1. Debe retornar una tabla. (2 puntos)
    Public Shared Function RecuperarRegistrosEntrega() As DataTable
        Try
            Dim dtEntrega As New Data.DataTable("Entrega")
            dtEntrega = gDatos.TraerDataTable("spListarEntregas")
            Return dtEntrega
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'c. Codificar un método para registrar una entrega, usando el procedimiento almacenado del
    'tema 6. (2 puntos)
    Public Sub Insertar()
        Try
            gDatos.Ejecutar("spRegistrarEntrega", Me.FechaEntrega, Me.Cliente, Me.CiudadID, Me.TipoVehiculoID,
                            Me.CostoServicio, Me.Direccion, Me.PersonalID)
        Catch ex As Exception

            Throw ex
        End Try
    End Sub
#End Region

End Class
