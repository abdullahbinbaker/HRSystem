#pragma checksum "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adba87461fe933dedad05f76bd56a5064dddfd42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmployeeDetails), @"mvc.1.0.view", @"/Views/Home/EmployeeDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EmployeeDetails.cshtml", typeof(AspNetCore.Views_Home_EmployeeDetails))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adba87461fe933dedad05f76bd56a5064dddfd42", @"/Views/Home/EmployeeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmployeeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.ViewsModels.EmployeeDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/logo4.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive center-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("MyDetailsPageBody"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
  
    ViewData["Title"] = "EmployeeDetails";

#line default
#line hidden
            BeginContext(101, 8247, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adba87461fe933dedad05f76bd56a5064dddfd424920", async() => {
                BeginContext(133, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
     if (ViewBag.ErrorMessage != null)
    {

#line default
#line hidden
                BeginContext(182, 78, true);
                WriteLiteral("        <script>\r\n        $(document).ready(function () {\r\n            alert(\'");
                EndContext();
                BeginContext(261, 21, false);
#line 10 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
              Write(ViewBag.ViewBag.Error);

#line default
#line hidden
                EndContext();
                BeginContext(282, 37, true);
                WriteLiteral("\');\r\n        });\r\n        </script>\r\n");
                EndContext();
#line 13 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
    }

#line default
#line hidden
                BeginContext(326, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 14 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
     if (ViewBag.ErrorMessage == null)
    {

#line default
#line hidden
                BeginContext(373, 1043, true);
                WriteLiteral(@"        <!--START OF THE NAVBAR-->
        <nav class=""navbar navbar-default navbar-fixed-top"">
            <div class=""container"">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class=""navbar-header"">
                    <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#bs-example-navbar-collapse-1"" aria-expanded=""false"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>
                    <a class=""navbar-brand"" href=""#"">HR<span> System</span></a>
                </div>
                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class=""collapse navbar-collapse"" id=""bs-example-navbar-collapse-1"">
                    <ul class=""nav navbar-nav");
                WriteLiteral(" navbar-right\">\r\n\r\n");
                EndContext();
#line 33 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                         if (ViewBag.UserRole.Equals("Admin") || ViewBag.UserRole.Equals("Manager"))
                        {

#line default
#line hidden
                BeginContext(1545, 303, true);
                WriteLiteral(@"                            <li class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Employees<span class=""caret""></span></a>
                                <ul class=""dropdown-menu"">

");
                EndContext();
#line 39 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                                     if (ViewBag.UserRole.Equals("Admin"))
                                    {

#line default
#line hidden
                BeginContext(1963, 46, true);
                WriteLiteral("                                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2009, "\"", 2051, 1);
#line 41 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 2016, Url.Action("CreateAccount","Home"), 2016, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2052, 157, true);
                WriteLiteral(">Add New Manager</a></li>\r\n                                        <li role=\"separator\" class=\"divider\"></li>\r\n                                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2209, "\"", 2263, 1);
#line 43 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 2216, Url.Action("RetrieveManagersEmployees","Home"), 2216, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2264, 44, true);
                WriteLiteral(">Managers Under My Administration</a></li>\r\n");
                EndContext();
#line 44 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"

                                    }

#line default
#line hidden
                BeginContext(2349, 36, true);
                WriteLiteral("                                    ");
                EndContext();
#line 46 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                                     if (ViewBag.UserRole.Equals("Manager"))
                                    {

#line default
#line hidden
                BeginContext(2466, 46, true);
                WriteLiteral("                                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2512, "\"", 2554, 1);
#line 48 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 2519, Url.Action("CreateAccount","Home"), 2519, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2555, 158, true);
                WriteLiteral(">Add New Employee</a></li>\r\n                                        <li role=\"separator\" class=\"divider\"></li>\r\n                                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2713, "\"", 2767, 1);
#line 50 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 2720, Url.Action("RetrieveManagersEmployees","Home"), 2720, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2768, 41, true);
                WriteLiteral(">Employees Under My Management</a></li>\r\n");
                EndContext();
#line 51 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"

                                    }

#line default
#line hidden
                BeginContext(2850, 74, true);
                WriteLiteral("                                </ul>\r\n                            </li>\r\n");
                EndContext();
#line 55 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"

                        }

#line default
#line hidden
                BeginContext(2953, 327, true);
                WriteLiteral(@"                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Vacation <span class=""caret""></span></a>
                            <ul class=""dropdown-menu"">
                                <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3280, "\"", 3324, 1);
#line 60 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 3287, Url.Action("RequestVacation","Home"), 3287, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3325, 143, true);
                WriteLiteral(">Request a Vaction</a></li>\r\n                                <li role=\"separator\" class=\"divider\"></li>\r\n                                <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3468, "\"", 3518, 1);
#line 62 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 3475, Url.Action("ListEmployeeVacations","Home"), 3475, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3519, 31, true);
                WriteLiteral(">List My Vacations</a></li>\r\n\r\n");
                EndContext();
#line 64 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                                 if (ViewBag.UserRole.Equals("HR"))
                                {

#line default
#line hidden
                BeginContext(3654, 122, true);
                WriteLiteral("                                    <li role=\"separator\" class=\"divider\"></li>\r\n                                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3776, "\"", 3835, 1);
#line 67 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 3783, Url.Action("ListEmployeesVacationsRequests","Home"), 3783, 52, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3836, 35, true);
                WriteLiteral(">List Employees Requests</a></li>\r\n");
                EndContext();
#line 68 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                                }

#line default
#line hidden
                BeginContext(3906, 432, true);
                WriteLiteral(@"                            </ul>
                        </li>

                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false""><span class=""glyphicon glyphicon-user""></span><span class=""caret""></span></a>
                            <ul class=""dropdown-menu"">
                                <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4338, "\"", 4382, 1);
#line 75 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 4345, Url.Action("EmployeeDetails","Home"), 4345, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4383, 100, true);
                WriteLiteral(">My Profile</a></li>\r\n\r\n                                <li role=\"separator\" class=\"divider\"></li>\r\n");
                EndContext();
#line 78 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                                 if (!ViewBag.UserRole.Equals("Admin"))
                                {

#line default
#line hidden
                BeginContext(4591, 42, true);
                WriteLiteral("                                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4633, "\"", 4680, 1);
#line 80 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 4640, Url.Action("ShowManagerDetails","Home"), 4640, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4681, 107, true);
                WriteLiteral(">Manager Profile</a></li>\r\n                                    <li role=\"separator\" class=\"divider\"></li>\r\n");
                EndContext();
#line 82 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                                }

#line default
#line hidden
                BeginContext(4823, 42, true);
                WriteLiteral("\r\n\r\n                                <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4865, "\"", 4900, 1);
#line 85 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 4872, Url.Action("Logout","Home"), 4872, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4901, 254, true);
                WriteLiteral(">Logout<span class=\"glyphicon glyphicon-log-out\"></span></a></li>\r\n                            </ul>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n        <!--END OF THE NAVBAR-->\r\n");
                EndContext();
                BeginContext(5157, 149, true);
                WriteLiteral("        <div class=\"requestVacationDiv col-lg-offset-3 col-lg-6 col-md-offset-3 col-md-6\">\r\n            <div class=\"brand-wrapper\">\r\n                ");
                EndContext();
                BeginContext(5306, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "adba87461fe933dedad05f76bd56a5064dddfd4218223", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5390, 93, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"RequestVacationForm \">\r\n                <div>\r\n");
                EndContext();
#line 100 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                     if (Model.employee.Gender.Equals("Male"))
                    {

#line default
#line hidden
                BeginContext(5570, 107, true);
                WriteLiteral("                        <p class=\"Signup-card-description\">Welcome Mr:<span style=\"background-color:aqua\"> ");
                EndContext();
                BeginContext(5678, 19, false);
#line 102 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                                                                                                      Write(Model.employee.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5697, 14, true);
                WriteLiteral(" </span></p>\r\n");
                EndContext();
#line 103 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"

                    }
                    else
                    {

#line default
#line hidden
                BeginContext(5785, 108, true);
                WriteLiteral("                        <p class=\"Signup-card-description\">Welcome Mrs:<span style=\"background-color:aqua\"> ");
                EndContext();
                BeginContext(5894, 19, false);
#line 107 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                                                                                                       Write(Model.employee.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5913, 14, true);
                WriteLiteral(" </span></p>\r\n");
                EndContext();
#line 108 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                    }

#line default
#line hidden
                BeginContext(5950, 279, true);
                WriteLiteral(@"                </div>
                <div>
                    <button class=""editYourProfileButton btn btn-primary"">Edit My Profile<span class=""glyphicon glyphicon-pencil""></span></button>
                </div>
                <div class=""card-body employeeDetailsDiv"">
");
                EndContext();
#line 114 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                     using (Html.BeginForm("UpdateAccount", "Home"))
                    {

#line default
#line hidden
                BeginContext(6322, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(6346, 1899, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adba87461fe933dedad05f76bd56a5064dddfd4222431", async() => {
                    BeginContext(6352, 159, true);
                    WriteLiteral("\r\n\r\n                            <p>Employee Name</p>\r\n                            <input type=\"text\" name=\"EmployeeName\" id=\"EmployeeName\" class=\"form-control\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 6511, "\"", 6539, 1);
#line 119 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 6519, Model.employee.Name, 6519, 20, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(6540, 163, true);
                    WriteLiteral(" readonly />\r\n                            <p>Employee ID</p>\r\n                            <input type=\"text\" name=\"EmployeeId\" id=\"EmployeeId\" class=\"form-control\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 6703, "\"", 6729, 1);
#line 121 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 6711, Model.employee.Id, 6711, 18, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(6730, 169, true);
                    WriteLiteral(" readonly />\r\n                            <p>Mobile Number</p>\r\n                            <input type=\"text\" name=\"MobileNumber\" id=\"MobileNumber\" class=\"form-control\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 6899, "\"", 6935, 1);
#line 123 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 6907, Model.employee.MobileNumber, 6907, 28, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(6936, 176, true);
                    WriteLiteral(" readonly />\r\n                            <p>Birth Date</p>\r\n                            <input type=\"date\" name=\"EmployeeBirthDate\" id=\"EmployeeBirthDate\" class=\"form-control\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 7112, "\"", 7168, 1);
#line 125 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 7120, Model.employee.BirthDate.ToString("yyyy-MM-dd"), 7120, 48, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(7169, 153, true);
                    WriteLiteral(" readonly />\r\n                            <p>Employee Role</p>\r\n                            <input type=\"text\" name=\"role\" id=\"role\" class=\"form-control\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 7322, "\"", 7350, 1);
#line 127 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 7330, Model.employee.Role, 7330, 20, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(7351, 140, true);
                    WriteLiteral(" readonly />\r\n\r\n                            <p>Gender</p>\r\n                            <input id=\"Gender\" name=\"Gender\" class=\"form-control\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 7491, "\"", 7521, 1);
#line 130 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 7499, Model.employee.Gender, 7499, 22, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(7522, 156, true);
                    WriteLiteral(" readonly />\r\n                            <p>Email Address</p>\r\n                            <input type=\"email\" name=\"email\" id=\"email\" class=\"form-control\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 7678, "\"", 7714, 1);
#line 132 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 7686, Model.employee.EmailAddress, 7686, 28, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(7715, 156, true);
                    WriteLiteral(" readonly />\r\n                            <p>Password</p>\r\n                            <input type=\"text\" id=\"password\" name=\"password\" class=\"form-control\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 7871, "\"", 7894, 1);
#line 134 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
WriteAttributeValue("", 7879, Model.password, 7879, 15, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(7895, 343, true);
                    WriteLiteral(@" readonly />

                            <div class=""form-group mb-4"">
                                <label for=""update"" class=""sr-only"">Signup</label>
                                <input name=""update"" id=""signup"" class=""form-control"" type=""submit"" value=""Update"" hidden>
                            </div>
                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8245, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 141 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
                    }

#line default
#line hidden
                BeginContext(8270, 64, true);
                WriteLiteral("                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n");
                EndContext();
#line 147 "C:\Users\user\Desktop\New folder (2)\HRT2\Web\Views\Home\EmployeeDetails.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8348, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.ViewsModels.EmployeeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
