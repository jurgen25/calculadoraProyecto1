<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="calculadoraProyecto1.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Proyecto de Calculadora Web - Grupo 3 - Programación 3</title><!-- Título de la página -->
    <link rel="stylesheet" type="text/css" href="styles.css"><!-- Enlace a CSS -->
</head>
<body>
    <form id="form1" runat="server">
        <div class="calculator-container"> <!-- Contenedor principal de la calculadora -->
            <img src="Imagines/calculadora.png" alt="Calculadora" style="height: 67px; width: 87px" /> <h1>Proyecto de Calculadora Web</h1><!-- Título principal -->
            <h2>Grupo 3 - Programación 3</h2><!-- Subtítulo -->
            <asp:TextBox ID="Display" CssClass="display" runat="server" ReadOnly="true"></asp:TextBox><!-- Campo de visualización de resultados -->
            <table class="calculator-grid"><!-- Tabla que contiene los botones -->
                <tr>
                    <td><asp:Button Text="7" OnClick="Numero_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="8" OnClick="Numero_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="9" OnClick="Numero_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="/" OnClick="Operador_Click" runat="server" CssClass="calc-button" /></td>
                </tr>
                <tr>
                    <td><asp:Button Text="4" OnClick="Numero_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="5" OnClick="Numero_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="6" OnClick="Numero_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="*" OnClick="Operador_Click" runat="server" CssClass="calc-button" /></td>
                </tr>
                <tr>
                    <td><asp:Button Text="1" OnClick="Numero_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="2" OnClick="Numero_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="3" OnClick="Numero_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="-" OnClick="Operador_Click" runat="server" CssClass="calc-button" /></td>
                </tr>
                <tr>
                    <td><asp:Button Text="C" OnClick="Borrar_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="0" OnClick="Numero_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="=" OnClick="Igual_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="+" OnClick="Operador_Click" runat="server" CssClass="calc-button" /></td>
                </tr>
                <tr>
                    <td><asp:Button Text="√" OnClick="RaizCuadrada_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="x^y" OnClick="Potencia_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="10^x" OnClick="DiezALaX_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="log" OnClick="Logaritmo_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="x^2" OnClick="Cuadrado_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="n!" OnClick="Factorial_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="," OnClick="Coma_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="+/-" OnClick="CambioSigno_Click" runat="server" CssClass="calc-button" /></td>
                    <td><asp:Button Text="√^2" OnClick="RaizCuadradaConExponente_Click" runat="server" CssClass="calc-button" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
