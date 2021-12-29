<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administrator.Master" AutoEventWireup="true" CodeBehind="View_Asset_Issuance.aspx.cs" Inherits="AssetTracking_v1.Admin.View_Asset_Issuance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">Asset Issuances</h1>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i></i>

                    <div class="pull-right">
                        <div class="btn-group">
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:GridView ID="GridView1" Width="100%" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

                            <EditRowStyle BackColor="#2461BF"></EditRowStyle>

                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></FooterStyle>

                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>

                            <PagerStyle HorizontalAlign="Center" BackColor="#2461BF" ForeColor="White"></PagerStyle>

                            <RowStyle BackColor="#EFF3FB"></RowStyle>

                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                            <SortedAscendingCellStyle BackColor="#F5F7FB"></SortedAscendingCellStyle>

                            <SortedAscendingHeaderStyle BackColor="#6D95E1"></SortedAscendingHeaderStyle>

                            <SortedDescendingCellStyle BackColor="#E9EBEF"></SortedDescendingCellStyle>

                            <SortedDescendingHeaderStyle BackColor="#4870BE"></SortedDescendingHeaderStyle>
                        </asp:GridView>
                    </div>
                    <div class="form-group">
                        <div>
                            <center>
                                <asp:Label ID="MsgLabel" runat="server" Font-Size="X-Large" Style="font-size: small"></asp:Label>
                            </center>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>