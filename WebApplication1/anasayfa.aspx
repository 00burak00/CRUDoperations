<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anasayfa.aspx.cs" Inherits="WebApplication1.anasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 653px;
        }
        .auto-style3 {
            margin-left: 174px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>Seçim yapınız</asp:ListItem>
                            <asp:ListItem Value="1">Ürün</asp:ListItem>
                            <asp:ListItem Value="2">Musteri</asp:ListItem>
                            <asp:ListItem Value="3">Sepet</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" CssClass="auto-style3" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>Silme ve Güncelleme işlemleri listeleme tablosundan yapılır</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
