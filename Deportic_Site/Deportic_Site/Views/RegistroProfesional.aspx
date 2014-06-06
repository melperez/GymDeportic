<%@ Page Title="" Language="C#" MasterPageFile="~/Deportic.Master" AutoEventWireup="true" CodeBehind="RegistroProfesional.aspx.cs" Inherits="Deportic_Site.Views.Profesional" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="Form" runat="server" 
        style="background-color: #D0F5A9; height: 633px; width: 906px;">
        <div style="height: 220px; width: 200px; position: relative; top: 50px; left: 5px;">
            <img alt="" src="../Images/icon-user-Admin.png" style="height: 181px; width: 168px;
                position: relative; top: 18px; left: 15px;" /></div>
        <div id="divFieldset" style="position: relative; left: 204px; width: 645px; height: 596px;
            top: -223px;">
            <fieldset  class="login" id="fieldset" runat="server" style="top:-10px">
                <legend class="Legend" style="position: relative; top: 13px; left: 22px;">&nbsp;Formulario
                    Registro Instructor</legend>
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 30px; margin-top: 8px;">
                        Nombres:
                        <input id="Text1" type="text" style="width: 250px; margin-left: 20px" /></p>
                </div>
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 30px; margin-top: 5px">
                        Apellidos:
                        <input id="Text2" type="text" style="width: 250px; margin-left: 20px" /></p>
                </div>
                <div style="position: relative; top:0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 30px; margin-top: 5px">
                        Usuario:
                        <input id="Text3" type="text" style="width: 250px; margin-left: 32px" /></p>
                </div>
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 10px">
                        Contraseña:
                        <input id="Password1" type="password" style="width: 250px; margin-left: 2px" /></p>
                </div>
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Email:
                        <input id="Text4" type="text" style="width: 250px; margin-left: 42px" value="@gmail.com" /></p>
                </div>
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 592px;">
                    <p style="height: 24px; margin-top: 5px">
                        Direccion:
                        <input id="Text5" type="text" style="width: 474px; margin-left: 16px" /></p>
                </div>
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Barrio:
                        <input id="Text7" type="text" style="width: 250px; margin-left: 40px; margin-right: 25px" />
                        Género:
                        <select id="Select2" name="D1" style="height: 24px; margin-left: 10px; margin-right: 20px">
                            <option>M</option>
                            <option>F</option>
                        </select>
                    </p>
                </div>
                <div style="position: relative; top:0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Tipo Identificacion:
                        <select id="Select1" name="D1" style="height: 24px; margin-left: 10px; margin-right: 20px">
                            <option>CC</option>
                            <option>TI</option>
                            <option>CE</option>
                            <option>NN</option>
                        </select>
                        Número Identificacion:
                        <input id="Text6" type="text" style="width: 190px; margin-left: 10px" /></p>
                </div>
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Fecha Nacimiento:
                        <input id="Text8" type="text" style="width: 60px; margin-left: 8px; margin-right: 8px"
                            value="YYYY" />
                        /
                        <input id="Text9" type="text" style="width: 40px; margin-left: 8px; margin-right: 8px"
                            value="MM" />
                        /
                        <input id="Text10" type="text" style="width: 40px; margin-left: 8px; margin-right: 8px"
                            value="DD" /></p>
                </div>
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Ocupación:
                        <input id="Text11" type="text" style="width: 250px; margin-left: 10px" /></p>
                </div>
                 <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Especialidad:
                        <input id="Text12" type="text" style="width: 250px; margin-left: 2px" /></p>
                </div>
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Perfil:
                        <select id="Select3" name="D1" style="height: 24px; margin-left: 45px;" disabled="disabled">
                            <option>Instructor</option>
                            <option>Deportista</option>
                        </select></p>
                </div>
                <div style="position: relative; top: 0px; left: 14px; height: 46px; width: 620px;"
                    align="right">
                    <input id="BtnRegistroInstructor" runat="server" type="button" value="Enviar" class="Button" style="position: relative; height:30px;
                        width: 120px;" align="middle" /></div>
            </fieldset>
        </div>
    </div>
</asp:Content>
