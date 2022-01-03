Imports ClasesDelivery.Util
Public Class Ciudad
    'a. Crear la clase con los atributos y propiedades. (1 puntos)

#Region "Atributos"
    Private CiudadID As Integer
    Private Nombre As String
#End Region

#Region "Propiedades"
    Public Property pCiudadID As Integer
        Get
            Return CiudadID
        End Get
        Set(value As Integer)
            CiudadID = value
        End Set
    End Property

    Public Property pNombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
#End Region

#Region "Metodos"
    'b. Codificar un método que retorne todas las ciudades, usando el procedimiento
    'almacenado del tema 2. (2 puntos)

    Public Shared Function RecuperarRegistrosCiudad() As DataTable
        Try
            Dim dtCiudad As New Data.DataTable("Ciudad")
            dtCiudad = gDatos.TraerDataTable("spListarCiudades")
            Return dtCiudad
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
End Class
