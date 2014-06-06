<%@ Page Title="" Language="C#" MasterPageFile="~/Deportic.Master" AutoEventWireup="true"
    CodeBehind="RegistroDeportista.aspx.cs" Inherits="Deportic_Site.Views.Deportista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        #Main
        {
            height: 574px;
            width: 880px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="Form" runat="server" 
        style="background-color: #D0F5A9; height: 614px; width: 906px;">
        <div style="height: 220px; width: 200px; position: relative; top: 50px; left: 5px;">
            <img alt="" src="../Images/icon-user-default.png" style="height: 181px; width: 168px;
                position: relative; top: 18px; left: 15px;" /></div>
        <div id="divFieldset" style="position: relative; left: 204px; width: 645px; height: 531px;
            top: -223px;">
            <fieldset  class="login" id="fieldset" runat="server" style="top:-10px">
                <legend class="Legend" style="position: relative; top: 13px; left: 22px;">&nbsp;Formulario
                    Registro Deportista</legend>
                <div style="position: relative; top: 20px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 30px; margin-top: 5px;">
                        Nombres:
                        <input id="Nombres" runat="server" type="text" style="width: 250px; margin-left: 20px" /></p>
                </div>
                <div style="position: relative; top: 20px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 30px; margin-top: 5px">
                        Apellidos:
                        <input id="Apellidos" runat="server" type="text" style="width: 250px; margin-left: 20px" /></p>
                </div>
                <div style="position: relative; top: 20px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 30px; margin-top: 5px">
                        Usuario:
                        <input id="UserName" runat="server" type="text" style="width: 250px; margin-left: 32px" /></p>
                </div>
                <div style="position: relative; top: 20px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 10px">
                        Contraseña:
                        <input id="Pass" runat="server" type="password" style="width: 250px; margin-left: 2px" /></p>
                </div>
                <div style="position: relative; top: 20px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Email:
                        <input id="email" runat="server" type="text" style="width: 250px; margin-left: 42px" value="@gmail.com" /></p>
                </div>
                <div style="position: relative; top: 20px; left: 14px; height: 36px; width: 592px;">
                    <p style="height: 24px; margin-top: 5px">
                        Direccion:
                        <input id="direccion" runat="server" type="text" style="width: 474px; margin-left: 16px" /></p>
                </div>
                <div style="position: relative; top: 20px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Barrio:
                        <input id="barrio" runat="server" type="text" style="width: 250px; margin-left: 40px; margin-right: 25px" />
                        Género:
                        <select id="Genero" runat="server" name="D1" style="height: 24px; margin-left: 10px; margin-right: 20px">
                            <option>M</option>
                            <option>F</option>
                        </select>
                    </p>
                </div>
                <div style="position: relative; top: 20px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Tipo Identificacion:
                        <select id="TipoID" runat="server" name="D1" style="height: 24px; margin-left: 10px; margin-right: 20px">
                            <option>CC</option>
                            <option>TI</option>
                            <option>CE</option>
                            <option>NN</option>
                        </select>
                        Número Identificacion:
                        <input id="NroIdentificacion" runat="server" type="text" style="width: 190px; margin-left: 10px" /></p>
                </div>
                <div style="position: relative; top: 20px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Fecha Nacimiento:
                        <input id="AnioNacimiento" runat="server" type="text" style="width: 60px; margin-left: 8px; margin-right: 8px"
                            value="YYYY" />
                        /
                        <input id="MesNacimiento" runat="server" type="text" style="width: 40px; margin-left: 8px; margin-right: 8px"
                            value="MM" />
                        /
                        <input id="DiaNacimiento" runat="server" type="text" style="width: 40px; margin-left: 8px; margin-right: 8px"
                            value="DD" /></p>
                </div>
                <div style="position: relative; top: 204px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Ocupación:
                        <input id="Ocupacion" runat="server" type="text" style="width: 250px; margin-left: 2px" /></p>
                </div>
                <div style="position: relative; top: -20px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Perfil:
                        <select id="Perfil" runat="server" name="D1" style="height: 24px; margin-left: 45px;" disabled="disabled">
                            <option>Deportista</option>
                            <option>Instructor</option>
                        </select></p>
                </div>
                <div style="position: relative; top: -20px; left: 14px; height: 36px; width: 620px;"
                    align="right">
                    <input id="BtnRegistroDep" runat="server" type="button" value="Enviar" class="Button" style="position: relative; height:30px;
                        width: 120px;" align="middle" onclick="BtnRegistroDep_Click" /></div>
            </fieldset>
        </div>
    </div>
</asp:Content>
