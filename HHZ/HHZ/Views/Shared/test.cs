//@using Microsoft.AspNet.Identity
//@using MLMS.Common.Extensions
//@if (Request.IsAuthenticated)
//{
//    using (Html.BeginForm("LogOff", "Account", FormMethod.Post, new { id = "logoutForm", @class = "navbar-right" }))
//    {
//        @Html.AntiForgeryToken()

//        < ul class="nav navbar-nav navbar-nav-bordered navbar-nav-margin-right">
//        <!-- user -->
//        <li class="dropdown user" >
//          @* @Html.ActionLink("Hello " + User.Identity.GetUserName() + "!", "Index", "Manage", routeValues: null, htmlAttributes: new { title = "Manage" })*@
     
//            <a href = "#" class="dropdown-toggle" data-toggle="dropdown">
//                Hi, @User.Identity.GetUserFirstname()<span class="caret"></span>
//            </a>
//            <ul class="dropdown-menu" role="menu">
//                @if(User.IsInRole("Instructor"))
//                {
//                <li><a href = "@Url.Action("Dashboard", "Instructor")"><i class="fa fa-bar-chart-o"></i> Dashboard</a></li>
//                @*<li><a href = "#" >< i class="fa fa-mortar-board"></i> My Courses</a></li>*@

//                <li><a href = "@Url.Action("MyProfile", "Instructor")"><i class="fa fa-user"></i> Profile</a></li>

//                }
//                else if(User.IsInRole("Student"))
//                {
//                    <li><a href = "@Url.Action("Dashboard", "Student")"><i class="fa fa-bar-chart-o"></i> Dashboard</a></li>
//                    <li><a href = "#" >< i class="fa fa-mortar-board"></i> My Courses</a></li>

//                <li><a href = "@Url.Action("MyProfile", "Student")"><i class="fa fa-user"></i> Profile</a></li>
//                }
//                else if (User.IsInRole("Ambassador"))
//                {
//                    <li><a href = "@Url.Action("Dashboard", "Ambassador")"><i class="fa fa-bar-chart-o"></i> Dashboard</a></li>
//                    <li><a href = "@Url.Action("MyProfile", "Ambassador")"><i class="fa fa-user"></i> Profile</a></li>
//                }
//                <li><a href = "javascript:document.getElementById('logoutForm').submit()" >< i class="fa fa-sign-out"></i> Logout</a></li>
//            </ul>
//        </li>
//        <!-- // END user -->
//    </ul>
//    }
//}
//else
//{
//    <ul class="nav navbar-nav navbar-right">
//        <li>@Html.ActionLink("Log in", "Login", "Account", routeValues: null, htmlAttributes: new { id = "loginLink" })</li>
//        <li>@Html.ActionLink("Register", "Register", "Account", routeValues: null, htmlAttributes: new { id = "loginLink" })</li>
//    </ul>
//}
