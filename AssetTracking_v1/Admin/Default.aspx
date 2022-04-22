<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administrator.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AssetTracking_v1.Admin.Default" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h1 class="page-header">Dashboard</h1>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                   Asset Details
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-8">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        Asset Group
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-group">
                                            <asp:Chart runat="server" ID="ctl00" CssClass="morris-area-chart" DataSourceID="SqlDataSource1" Width="1000px">
                                                <Series>
                                                    <asp:Series Name="Series1" XValueMember="Asset_Name" YValueMembers="Quantity"></asp:Series>
                                                </Series>
                                                <ChartAreas>
                                                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                                </ChartAreas>
                                            </asp:Chart>
                                            <%--<asp:GridView ID="GridView1" CssClass="table table-hover" runat="server" />--%>
                                            <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:NRBAssetsConnectionString %>' SelectCommand="SELECT [Asset_Name], [Quantity] FROM [Asset] ORDER BY [Asset_Name]"></asp:SqlDataSource>
                                        </div>
                                    </div>
                                </div>

                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        Asset Group
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-group">
                                            <asp:Chart runat="server" ID="Chart2" CssClass="morris-area-chart">
                                                <Series>
                                                    <asp:Series Name="Series1" ChartType="Line"></asp:Series>
                                                </Series>
                                                <ChartAreas>
                                                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                                </ChartAreas>
                                            </asp:Chart>
                                            <%--<asp:GridView ID="GridView1" CssClass="table table-hover" runat="server" />--%>
                                        </div>
                                    </div>
                                </div>

                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        Asset Group
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-group">
                                            <asp:Chart runat="server" ID="Chart3" CssClass="morris-area-chart">
                                                <Series>
                                                    <asp:Series Name="Series1" ChartType="Line"></asp:Series>
                                                </Series>
                                                <ChartAreas>
                                                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                                </ChartAreas>
                                            </asp:Chart>
                                            <%--<asp:GridView ID="GridView1" CssClass="table table-hover" runat="server" />--%>
                                        </div>
                                    </div>
                                </div>

                            </div>

                            <div class="col-lg-4">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        Asset Group
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-group">
                                            <asp:Chart runat="server" ID="Chart1" CssClass="morris-area-chart" DataSourceID="SqlDataSource2">
                                                <Series>
                                                    <asp:Series Name="Series1" ChartType="Doughnut" XValueMember="Asset_Name" YValueMembers="Number"></asp:Series>
                                                </Series>
                                                <ChartAreas>
                                                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                                </ChartAreas>
                                            </asp:Chart>
                                            <%--<asp:GridView ID="GridView1" CssClass="table table-hover" runat="server" />--%>
                                            <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:NRBAssetsConnectionString %>' SelectCommand="select Asset_Name, count(*) as Number from asset group by Asset_Name"></asp:SqlDataSource>
                                        </div>
                                    </div>
                                </div>

                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        Asset Group
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-group">
                                            <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped"></asp:GridView>
                                            <%--<asp:GridView ID="GridView1" CssClass="table table-hover" runat="server" />--%>
                                            
                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>