Imports System.Web.Mvc
'Importamos la biblioteca de clases restaurante
Imports ClasesDelivery
Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        'En la accion Index vamos a definir la cadena de conexion de la BD
        Function Index() As ActionResult
            'Vamos a llamar al metodo inicializaSesion de la clase Util

            'i.Establecer la conexión a la base de datos. 1 puntos
            Util.inicializaSesion("KALO", "Delivery", "kalo", "kalo")
            'Definimos el nombre del Servidor, el nombre de la BD, el Usuario de la BD y la Contraseña

            Return View()
        End Function
    End Class
End Namespace