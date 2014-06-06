<%@ Page Title="" Language="C#" MasterPageFile="~/Deportic.Master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="Deportic_Site.Views.Login" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center" class="accountInfo">
        <div id="dvLogin" 
            style="width: 363px; margin-left: 2px; visibility: visible; position:relative; top: 147px; left: 0px;" align="left"
            runat="server" >
            <fieldset class="login" 
                style="position: relative; visibility: visible; top: 0px; left: 0px;" 
                id="fieldset" runat="server">
                <legend class="Legend">&nbsp;Información de Inicio</legend>
                <asp:Login ID="UserLogin" runat="server" TitleText="" UserNameLabelText="Usuario:"
                    LoginButtonType="Button" TextLayout="TextOnTop" CssClass="accountInfo" DisplayRememberMe="False"
                    FailureText="Usuario y/o contraseña inválidos. Por favor intenta nuevamente"
                    Font-Names="Century Gothic" LoginButtonText="Iniciar Sesión" PasswordLabelText="Contraseña:"
                    RememberMeText="" Width="280px" Height="163px" OnAuthenticate="AutenticarUsuario">
                    <FailureTextStyle Font-Names="Century Gothic" />
                    <LoginButtonStyle CssClass="Button" />
                    <TextBoxStyle Width="200px" />
                </asp:Login>
            </fieldset>
        </div>
        <div id="dvDefault" runat="server" style="visibility:hidden; position: inherit">
            <h2 runat="server" id="Titulo">
                BIENVENIDO
            </h2>
            <p style="position:relative; top: -42px; left: 388px; width: 109px;">[<%--<asp:HyperLink 
                    runat="server" id="cerrar" NavigateUrl="~/Views/Login.aspx">Cerrar Sesión</asp:HyperLink>--%>
                    <a href="Login.aspx" style="cursor:pointer; text-decoration:underline" id="close" runat="server">Cerrar Sesión</a>]</p>
           
            <p>
                Este sitio esta diseñado para que usted como usuario pueda conocer todos los beneficios
                que como Gimnasio le ofrecemos. También puede tener acceso a todo su registro de
                desempeño si desea realizarle seguimiento.</p>
            <p>
                Si tiene dudas e inquietudes, le recomendamos visitar la sección
                <asp:HyperLink ID="HyperLink1" runat="server" Style="text-decoration: underline;
                    color: #006600" NavigateUrl="~/About.aspx">Contacto</asp:HyperLink>
            </p>
            <div style="height: 235px">
                <div style="position: relative;  left: -287px; width: 290px; height: 220px; top: 20px;">
                    <img alt="photo3" src="../Images/3.jpg" style="height: 191px; width: 278px" />
                    <a>Consultar Rutinas</a>
                </div>
                <div style="position: relative;  left: 4px; width: 290px; height: 220px; top: -201px;">
                    <img alt="photo2" src="../Images/2.jpg" style="height: 191px; width: 278px" />
                    <a>Consultar Objetivos</a>
                </div>
                 <div style="position: relative; left: 300px; width: 290px; top: -420px;">
                    <img alt="photo1" src="../Images/1.jpg" />
                    <a>Consultar Resumen Histórico</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
