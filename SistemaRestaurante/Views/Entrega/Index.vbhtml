

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Lista de Entregas</title>
    <link href="~/css/bootstrap.min.css" rel="stylesheet" media="screen" />
</head>
<body>
    <div class="container">

        <h3>
            <a href="Entrega/Create">Nueva Entrega</a>
        </h3>

        <table class="table table-hover">
            <tr>
                <td>Fecha Registro</td>
                <td>Fecha Entrega</td>
                <td>Personal</td>
                <td>Estado</td>
                <td></td>
            </tr>
            @For Each item In ViewData("entregas")
@<tr>
    
    <td>@item("Fecha Registro")</td>
    <td>@item("Fecha Entrega")</td>
    <td>@item("Personal")</td>
    <td>@item("Estado")</td>

</tr>
            Next
        </table>
    </div>

    <script src="~/script/jquery-3.5.1.min.js"></script>
    <script src="~/js/bootstrap.min.js"></script>

</body>
</html>

