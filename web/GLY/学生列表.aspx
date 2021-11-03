<%@ Page Title="" Language="C#" MasterPageFile="~/GLY/管理员母版.Master" AutoEventWireup="true" CodeBehind="学生列表.aspx.cs" Inherits="web.GLY.学生列表" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <!--/.列表-->
    <div class="row">
        <div class="col-lg-12">
            <div class="card">
                <div class="card-header">
                    <i class="fa fa-align-justify"></i>学生信息列表
                </div>
                <div class="card-block">
                    <table class="table table-bordered table-striped table-condensed">
                        <thead>
                            <tr>
                                <th>学号</th>
                                <th>姓名</th>
                                <th>班级</th>
                                <th>密码</th>
                                <th>电话</th>
                                <th>QQ</th>
                                <th>选题</th>
                                <th>状态</th>
                                <th>备注</th>
                            </tr>
                        </thead>
                        <tbody>

                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <tr>
                                    <td><%#Eval("StudentId") %></td>
                                    <td> <%#Eval("StudentName") %></td>
                                    <td> <%#Eval("Banji") %></td>
                                    <td> <%#Eval("Pwd") %></td>
                                    <td> <%#Eval("phone") %></td>
                                    <td> <%#Eval("QQ") %></td>
                                    <td> <%#Eval("tmid") %></td>
                                    <td> <%#Eval("stated") %></td>
                                    <td><%#Eval("remark") %></td>
                                  </tr>
                                </ItemTemplate>
                            </asp:Repeater>

                        </tbody>
                    </table>
                    <nav>
                        <ul class="pagination">
                            <li class="page-item"><a class="page-link" href="#">上一页</a>
                            </li>
                            <li class="page-item active">
                                <a class="page-link" href="#">1</a>
                            </li>
                            <li class="page-item"><a class="page-link" href="#">2</a>
                            </li>
                            <li class="page-item"><a class="page-link" href="#">下一页</a>
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
