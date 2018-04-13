<%@ Page Title="" Language="C#" MasterPageFile="~/CarBook.master" AutoEventWireup="true" CodeFile="AnCar.aspx.cs" Inherits="AnCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <asp:Label ID="lblCarNo" runat="server" Text="Car No" Width="100px"></asp:Label>
            &nbsp;<asp:DropDownList ID="ddlCarNo" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblCarMake" runat="server" Text="Car Make" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtCarMake" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblCarModel" runat="server"  Text="CarModel" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtCarModel" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblColour" runat="server" Text="Colour" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtColour" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblAge" runat="server" Text="Age" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtAge" runat="server" style="z-index: 1; "></asp:TextBox>
            <br />
            <asp:Label ID="lblMileage" runat="server" Text="Mileage" Width="100px"></asp:Label>
            <asp:TextBox ID="txtMileage" runat="server" ></asp:TextBox>
            <br />
            &nbsp;<br />
            <asp:Label ID="lblBodyType" runat="server" Text="BodyType" Width="100px"></asp:Label>
            <asp:TextBox ID="txtBodyType" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1;" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>            
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" height="26px" Text="OK" width="61px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="26px" width="61px" OnClick="btnCancel_Click" />

</asp:Content>
