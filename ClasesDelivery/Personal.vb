Imports ClasesDelivery.Util
Public Class Personal
    'a. Crear la clase con los atributos y propiedades. (1 puntos)
#Region "Atributos"
    Private PersonalID As Integer
    Private NroDocumento As String
    Private NombreApellido As String
    Private Telefono As String
#End Region

#Region "Propiedades"
    Public Property pPersonalID As Integer
        Get
            Return PersonalID
        End Get
        Set(value As Integer)
            PersonalID = value
        End Set
    End Property

    Public Property pNroDocumento As String
        Get
            Return NroDocumento
        End Get
        Set(value As String)
            NroDocumento = value
        End Set
    End Property

    Public Property pNombreApellido As String
        Get
            Return NombreApellido
        End Get
        Set(value As String)
            NombreApellido = value
        End Set
    End Property

    Public Property pTelefono As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property
#End Region

#Region "Metodos"
    'b. Codificar un método que retorne todos los personales, usando el procedimiento
    'almacenado del tema 3. (2 puntos)

    Public Shared Function RecuperarRegistrosPersonal() As DataTable
        Try
            Dim dtPersonal As New Data.DataTable("Personal")
            dtPersonal = gDatos.TraerDataTable("spListarPersonal")
            Return dtPersonal
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

End Class
