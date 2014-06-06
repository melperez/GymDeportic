<%@ Page Title="" Language="C#" MasterPageFile="~/Deportic.Master" AutoEventWireup="true"
    CodeBehind="RegistroMaquina.aspx.cs" Inherits="Deportic_Site.Views.RegistroMaquina" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="Form" runat="server" style="background-color: #F3F781; height: 444px; width: 887px;
        visibility: hidden">
        <div style="height: 200px; width: 145px; position: relative; top: 55px; left: 678px"
            id="div2">
            <img id="ImgInsert" runat="server" alt="" src="../Images/Maquina2.jpg" style="height: 221px; width: 212px; position: relative;
                top: 47px; left: -97px; visibility: hidden" /></div>
        <div id="divFieldset" style="position: relative; left: 61px; width: 502px; height: 286px;
            top: -160px; visibility: visible" runat="server" >
            <div style="height: 30px; margin-top: 8px; background-color: green; color: white;
                font-size: 16px;" runat="server" align="center">
                Registro Máquina:
            </div>
           
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 30px; margin-top: 8px;">
                        Referencia:
                        <input runat="server" id="Ref" type="text" style="width: 250px; margin-left: 18px" /></p>
                </div>
                <div style="position: relative; top: 0px; left: 13px; height: 36px; width: 392px;">
                    <p style="height: 30px; margin-top: 5px">
                        Nombre:
                        <input runat="server" id="Nombre" type="text" style="width: 253px; margin-left: 32px" /></p>
                </div>
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 30px; margin-top: 5px">
                        Descripcion:
                        <input runat="server" id="Desc" type="text" style="width: 250px; margin-left: 11px" /></p>
                </div>
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Estado:
                        <select runat="server" id="estado" name="D1" style="height: 24px; margin-left: 38px; margin-right: 20px;
                            width: 259px;">
                            <option>Nueva</option>
                            <option>Buena</option>
                            <option>Vieja</option>
                            <option>Dañada</option>
                        </select></p>
                </div>
                <div style="position: relative; top: 0px; left: 14px; height: 36px; width: 392px;">
                    <p style="height: 24px; margin-top: 5px">
                        Fecha Compra:
                        <input runat="server" id="FechaAnio" type="text" style="width: 60px; margin-left: 8px; margin-right: 8px"
                            value="YYYY" />
                        /
                        <input runat="server" id="fechaMes" type="text" style="width: 40px; margin-left: 8px; margin-right: 8px"
                            value="MM" />
                        /
                        <input runat="server" id="fechaDia" type="text" style="width: 40px; margin-left: 8px; margin-right: 8px"
                            value="DD" /></p>
                </div>
                <div style="position: relative; top: 70px; left: -43px; height: 74px; width: 620px;"
                    align="right">
                    <input id="BtnRegistroMaquina" runat="server" type="button" value="Enviar"
                        style="position: relative; height: 30px; width: 152px; left: -221px;
                        top: 21px; text-align: center; background: #122A0A; color: white;" 
                        align="bottom"/>
                    <input id="BtnBack" runat="server" type="button" value="Atrás" 
                        
                        style="position: relative; width: 148px; height: 30px; top: 21px; left: -211px; text-align: center; background-color: #122A0A; color: #FFFFFF;" 
                        align="top"  /></div>
        </div>
    </div>
    <div id="Consultar" runat="server" 
        style="background-color: #F3F781; height: 708px;
        width: 887px; visibility: visible; position: relative; top: -440px; left: 3px;">
        <div style="height: 30px; margin-top: 8px; background-color: green; color: white;
            font-size: 16px" runat="server" align="center">
            Listado Máquinas Adquiridas
        </div>
        <asp:GridView runat="server" ID="GvMaquinas" AlternatingRowStyle-BackColor="ActiveBorder"
            HeaderStyle-BackColor="White" Height="194px" Width="886px" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="ActiveBorder"></AlternatingRowStyle>
            <Columns>               
                <asp:TemplateField>
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:ImageButton runat="server" ID="ImageButton3" ImageUrl="~/Images/Edit2.jpg" OnClick="EditMaquina" OnClientClick="EditMaquina" PostBackUrl="~/Views/RegistroMaquina.aspx" />
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Select2.jpg" OnClick="EditMaquina" />
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/Delete.jpg" OnClick="BorrarMaquina" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        ID</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblId" runat="server" Text='<%#Bind("id")%>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Referencia</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblRef" runat="server" Text='<%#Bind("Referencia")%>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Nombre</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblNombre" runat="server" Text='<%#Bind("Nombre")%>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Descripcion</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblDescripcion" runat="server" Text='<%#Bind("Descripcion")%>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Estado</HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblEstado" runat="server" Text='<%#Bind("Estado")%>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:TemplateField>
            </Columns>
            <HeaderStyle BackColor="White"></HeaderStyle>
        </asp:GridView>
    </div>
</asp:Content>
