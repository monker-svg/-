<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="web.GLY.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>首页</title>
    <link rel="shortcut icon" href="../static/img/favicon.png" />


    <!-- Icons -->
    <link href="../static/css/font-awesome.min.css" rel="stylesheet" />
    <link href="../static/css/simple-line-icons.css" rel="stylesheet" />

    <!-- Main styles for this application -->
    <link href="../static/css/style.css" rel="stylesheet" />


</head>
<body>
    <form id="form1" runat="server">
        <div>

            <%-- ------------------------------------------------头开始-------------------------------------------------------------- --%>
            <header class="app-header navbar">
                <button class="navbar-toggler mobile-sidebar-toggler hidden-lg-up" type="button">☰</button>
                <a class="navbar-brand" href="#"></a>
                <ul class="nav navbar-nav hidden-md-down">
                    <li class="nav-item">
                        <a class="nav-link navbar-toggler sidebar-toggler" href="#">☰</a>
                    </li>

                    <li class="nav-item px-1">
                        <a class="nav-link" href="#">首页</a>
                    </li>
                    <li class="nav-item px-1">
                        <a class="nav-link" href="#">用户</a>
                    </li>
                    <li class="nav-item px-1">
                        <a class="nav-link" href="#">设置</a>
                    </li>
                </ul>
                <ul class="nav navbar-nav ml-auto">
                    <li class="nav-item hidden-md-down">
                        <a class="nav-link" href="#"><i class="icon-bell"></i><span class="badge badge-pill badge-danger">5</span></a>
                    </li>
                    <li class="nav-item hidden-md-down">
                        <a class="nav-link" href="#"><i class="icon-list"></i></a>
                    </li>
                    <li class="nav-item hidden-md-down">
                        <a class="nav-link" href="#"><i class="icon-location-pin"></i></a>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle nav-link" data-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">
                            <img src="../static/img/avatars/6.jpg" class="img-avatar" alt="admin@bootstrapmaster.com" />
                            <span class="hidden-md-down">admin</span>
                        </a>
                        <div class="dropdown-menu dropdown-menu-right">

                            <div class="dropdown-header text-center">
                                <strong>Account</strong>
                            </div>

                            <a class="dropdown-item" href="#"><i class="fa fa-bell-o"></i>Updates<span class="badge badge-info">42</span></a>
                            <a class="dropdown-item" href="#"><i class="fa fa-envelope-o"></i>Messages<span class="badge badge-success">42</span></a>
                            <a class="dropdown-item" href="#"><i class="fa fa-tasks"></i>Tasks<span class="badge badge-danger">42</span></a>
                            <a class="dropdown-item" href="#"><i class="fa fa-comments"></i>Comments<span class="badge badge-warning">42</span></a>

                            <div class="dropdown-header text-center">
                                <strong>Settings</strong>
                            </div>

                            <a class="dropdown-item" href="#"><i class="fa fa-user"></i>Profile</a>
                            <a class="dropdown-item" href="#"><i class="fa fa-wrench"></i>Settings</a>
                            <a class="dropdown-item" href="#"><i class="fa fa-usd"></i>Payments<span class="badge badge-default">42</span></a>
                            <a class="dropdown-item" href="#"><i class="fa fa-file"></i>Projects<span class="badge badge-primary">42</span></a>
                            <div class="divider"></div>
                            <a class="dropdown-item" href="#"><i class="fa fa-shield"></i>Lock Account</a>
                            <a class="dropdown-item" href="#"><i class="fa fa-lock"></i>Logout</a>
                        </div>
                    </li>
                    <li class="nav-item hidden-md-down">
                        <a class="nav-link navbar-toggler aside-menu-toggler" href="#">☰</a>
                    </li>

                </ul>
            </header>
            <%-- ---------------------------------------------头结束----------------------------------------------------------------- --%>



            <div class="app-body">
                <div class="sidebar">
                    <nav class="sidebar-nav">
                        <ul class="nav">
                            <li class="nav-item">
                                <a class="nav-link" href="index.html"><i class="icon-speedometer"></i>首页 <span class="badge badge-info">新建</span></a>
                            </li>

                            <li class="nav-title">UI 组件
                            </li>
                            <li class="nav-item nav-dropdown">
                                <a class="nav-link nav-dropdown-toggle" href="#"><i class="icon-puzzle"></i>组件</a>
                                <ul class="nav-dropdown-items">
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/components-buttons.html"><i class="icon-puzzle"></i>按钮</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/components-social-buttons.html"><i class="icon-puzzle"></i>图标按钮</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/components-cards.html"><i class="icon-puzzle"></i>卡片</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/components-forms.html"><i class="icon-puzzle"></i>表单</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/components-modals.html"><i class="icon-puzzle"></i>情景按钮</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/components-switches.html"><i class="icon-puzzle"></i>滑块</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/components-tables.html"><i class="icon-puzzle"></i>表格</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/components-tabs.html"><i class="icon-puzzle"></i>标签</a>
                                    </li>
                                </ul>
                            </li>
                            <li class="nav-item nav-dropdown">
                                <a class="nav-link nav-dropdown-toggle" href="#"><i class="icon-star"></i>图标</a>
                                <ul class="nav-dropdown-items">
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/icons-font-awesome.html"><i class="icon-star"></i>文字图标</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/icons-simple-line-icons.html"><i class="icon-star"></i>简单的线条图标</a>
                                    </li>
                                </ul>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="../static/widgets.html"><i class="icon-calculator"></i>图表 <span class="badge badge-info">新建</span></a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="../static/charts.html"><i class="icon-pie-chart"></i>图表</a>
                            </li>
                            <li class="divider"></li>
                            <li class="nav-title">Extras
                            </li>
                            <li class="nav-item nav-dropdown">
                                <a class="nav-link nav-dropdown-toggle" href="#"><i class="icon-star"></i>页面</a>
                                <ul class="nav-dropdown-items">
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/pages-login.html" target="_top"><i class="icon-star"></i>登录</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/pages-register.html" target="_top"><i class="icon-star"></i>注册</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/pages-404.html" target="_top"><i class="icon-star"></i>404页面</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="../static/pages-500.html" target="_top"><i class="icon-star"></i>500页面</a>
                                    </li>
                                </ul>
                            </li>
                            <li class="nav-item nav-dropdown">
                                <a class="nav-link nav-dropdown-toggle" href="#"><i class="icon-star"></i>学生管理</a>
                                <ul class="nav-dropdown-items">
                                    <li class="nav-item">
                                        <a class="nav-link" href="批量添加student.aspx" target="_top"><i class="icon-star"></i>批量添加</a>
                                    </li>
                                </ul>
                            </li>
                        </ul>







                    </nav>
                </div>

                <!-- Main content -->
                <main class="main">

                    <!-- Breadcrumb -->
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item">首页</li>
                        <li class="breadcrumb-item"><a href="#">管理员</a>
                        </li>
                        <li class="breadcrumb-item active">首页</li>
                    </ol>
                </main>

            </div>

            <footer class="app-footer">
                Copyright &copy; 2017.呼伦贝尔学院
       
            </footer>

        </div>
    </form>


    <!-- Bootstrap and necessary plugins -->
    <script src="../static/assets/js/libs/jquery.min.js"></script>
    <script src="../static/assets/js/libs/tether.min.js"></script>
    <script src="../static/assets/js/libs/bootstrap.min.js"></script>
    <script src="../static/assets/js/libs/pace.min.js"></script>
    <!-- Plugins and scripts required by all views -->
    <script src="../static/assets/js/libs/Chart.min.js"></script>

    <!-- GenesisUI main scripts -->
    <script src="../static/js/app.js"></script>
    <!-- Plugins and scripts required by this views -->
    <!-- Custom scripts required by this view -->
    <script src="../static/js/views/main.js"></script>
</body>
</html>
