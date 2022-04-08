<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Prueba_Desarrollo_CNT._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="gvdAlumnos" runat="server" AutoGenerateColumns="true">

    </asp:GridView>

    <div class="jumbotron">
        <h1>URGENCIAS CNT</h1>
        <p class="lead">Urgencias CNT, es un sistemas de automatización de Urgencias de la empresa CNT Sistemas .</p>
    </div>
    <div class="col-md-12">
		<div class="card">
			<div class="card-header">
				<div class="card-title">Datos Básicos</div>
			</div>
            <div class="card-body">
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="squareSelect">Tipo de Identificación</label>
                            <asp:DropDownList runat="server" ID="typeIdentity" DataSourceID="" AppendDataBoundItems="true" class="form-control input-square" >
                                <asp:ListItem Text="seleccione una opción" Value="" />
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label for="squareInput">Numero de Documento</label>
                            <asp:TextBox ID="txtNumberId" 
                                runat="server" 
                                required="true" type="text" class="form-control input-square" placeholder="número de documento" >
                            </asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="squareInput2">Nombres</label>
                            <asp:TextBox ID="txtNames" 
                                runat="server" 
                                required="true" type="text" class="form-control input-square" placeholder="nombres" >
                            </asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="squareInput">Apellidos</label>
                            <asp:TextBox ID="txtSurnames" 
                                runat="server" 
                                required="true" type="text" class="form-control input-square" placeholder="apellidos" >
                            </asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="squareInput">Edad</label>
                            <asp:TextBox ID="txtAge" 
                                runat="server" 
                                required="true" type="number" class="form-control input-square" placeholder="edad" >
                            </asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="squareInput">Dirección</label>
                            <asp:TextBox ID="txtAddress" 
                                runat="server" 
                                required="true" type="text" class="form-control input-square" placeholder="direccion" >
                            </asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Sexo</label>
                            <asp:DropDownList runat="server" ID="Gender" DataSourceID="" AppendDataBoundItems="true" class="form-control input-square" >
                                <asp:ListItem Text="seleccione una opción" Value="" />
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="squareSelect">Peso</label>
                            <asp:TextBox ID="txtWeight" 
                                runat="server" 
                                required="true" type="text" class="form-control input-square" placeholder="peso" >
                            </asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="squareInput2">Estatura</label>
                            <asp:TextBox ID="txtHeight" 
                                runat="server" 
                                required="true" type="text" class="form-control input-square" placeholder="estatura" >
                            </asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Es Fumador?</label>
                            <asp:DropDownList runat="server" ID="IsSmoker" DataSourceID="" AppendDataBoundItems="true" class="form-control input-square" >
                                <asp:ListItem Text="seleccione una opción" Value="" />
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Años Fumando?</label>
                            <asp:TextBox ID="txtYearsSmoking" 
                                runat="server" 
                                required="true" type="number" class="form-control input-square" placeholder="años fumando" >
                            </asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Maneja Dieta Alimenticia?</label>
                            <asp:DropDownList runat="server" ID="Diet" DataSourceID="" AppendDataBoundItems="true" class="form-control input-square" >
                                <asp:ListItem Text="seleccione una opción" Value="" />
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Relación Peso-Estatura</label>
                            <asp:DropDownList runat="server" ID="HWRelation" AppendDataBoundItems="true" class="form-control input-square" >
                                <asp:ListItem Text="seleccione una opción" Value="" />
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
            <div class="card-footer">
                <div class="float-right">
                    <asp:Button ID="Button1" runat="server" class="btn btn-success" Text="Click" OnClick="BtnSubmit_Click" />
                    <asp:Button ID="Button2" runat="server" type="submit" class="btn btn-danger" Text="Cancelar" />
                </div>
            </div>
            
		</div>
	</div>
</asp:Content>
