<%@ Page Title="" Language="C#" MasterPageFile="~/GLY/管理员母版.Master" AutoEventWireup="true" CodeBehind="批量添加student.aspx.cs" Inherits="web.GLY.学生管理.批量添加student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-12" style="margin-bottom: 4px; margin-left: 10px;">
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Excel批量导入" CssClass="btn btn-spotify  icon-arrow-up" OnClick="Button1_Click" />
        </div>
    </div>

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>




    <!--/.列表-->
    <div class="row">
        <div class="col-lg-12">
            <div class="card">
                <div class="card-header">
                    <i class="fa fa-align-justify"></i>学生列表
                </div>
                <div class="card-block">
                    <table class="table table-bordered table-striped table-condensed">
                        <thead>
                            <tr>
                                <th>学号</th>
                                <th>姓名</th>
                                <th>电话</th>
                                <th>QQ</th>
                                <th>操作状态</th>
                            </tr>
                        </thead>
                        <tbody>

                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <tr>      
                                        <td><%#Eval("学号")%> </td>
                                        <td><%#Eval("姓名")%> </td>
                                        <td><%#Eval("电话")%>  <td>
                                        <td><%#Eval("QQ")%> </td>
                                        <td><%#Eval("QQ")%> </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>



                        </tbody>
                    </table>
                    <nav>
                        <ul class="pagination">
                            <li class="page-item"><a class="page-link" href="#">Prev</a>
                            </li>
                            <li class="page-item active">
                                <a class="page-link" href="#">1</a>
                            </li>
                            <li class="page-item"><a class="page-link" href="#">2</a>
                            </li>
                            <li class="page-item"><a class="page-link" href="#">Next</a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
        <!--/.col-->
    </div>
    <!--/.列表-->
</asp:Content>
