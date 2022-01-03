
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Nueva Entrega</title>
    <link href="~/css/bootstrap.min.css" rel="stylesheet" media="screen" />
</head>
<body>
    <div class="container">
        <h2>Nueva Entrega</h2>

        <form action="create" method="post" class="form-horizontal">

            <div class="form-group">
                <label class="control-label col-xs-3">Fecha Entrega</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="date" class="form-control" placeholder="FechaEntrega" name="fechaEntrega" />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Cliente</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Cliente" name="cliente" />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Ciudad</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <select name="ciudadid" class="form-control" id="idCiudad">
                        @for Each row In ViewData("ciudades")
                            @<option value="@row("CiudadID")">@row("Nombre")</option>
                        Next
                    </select>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Tipo Vehiculo</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <select name="tiposVehiculos" class="form-control" id="idTipoVehiculo">
                        @for Each row In ViewData("tiposVehiculos")
                            @<option value="@row("TipoVehiculoID")">@row("Descripcion")</option>
                        Next
                    </select>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Direccion</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Direccion" name="direccion" />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Personal</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <select name="personales" class="form-control">
                        @for Each row In ViewData("personales")
                            @<option value="@row("PersonalID")">@row("NombreApellido")</option>
                        Next
                    </select>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3"></label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="button" class="btn btn-default" onclick="javascript:calcularMontoCuota()" value="Calcular" />
                </div>


            </div>

            <div>
            <label class="control-label col-xs-3">Monto:</label>
            <input type="number" id="montoCuota" value="" name="costo_servicio">
            </div>

            <div class="form-group">
                <div class="col-xs-offset-3 col-sm-4 col-md-4 col-lg-4">
                    <button type="submit" class="btn btn-primary">Guardar</button>
                    <input type="reset" class="btn btn-default" value="Limpiar" />
                </div>
            </div>

        </form>
    </div>

    <script src="~/script/jquery-3.5.1.min.js"></script>
    <script src="~/js/bootstrap.min.js"></script>

    <script type="text/javascript">
        function calcularMontoCuota() {
            var listaCiudad = document.getElementById("idCiudad");
            var listaTipoVehiculo = document.getElementById("idTipoVehiculo");
            var parametro = {
                idCiudad: listaCiudad.options[listaCiudad.selectedIndex].value,
                idTipoVehiculo: listaTipoVehiculo.options[listaTipoVehiculo.selectedIndex].value
            };

            $.ajax({
                url: '../Entrega/calcularMontoCuota',
                data: parametro,
                type: 'get',
                cache: false,
                success: function (retorno) {
                    
                    var element = document.getElementById("montoCuota");
                    element.value = retorno;
                    

                },

            });
        }
    </script>

</body>
</html>
