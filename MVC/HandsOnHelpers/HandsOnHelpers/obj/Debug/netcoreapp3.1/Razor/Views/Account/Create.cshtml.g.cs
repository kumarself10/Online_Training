#pragma checksum "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff0a7e6cccf0824d4f3389c74cfe9e4b3ec70318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Create), @"mvc.1.0.view", @"/Views/Account/Create.cshtml")]
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
#nullable restore
#line 1 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\_ViewImports.cshtml"
using HandsOnHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\_ViewImports.cshtml"
using HandsOnHelpers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0a7e6cccf0824d4f3389c74cfe9e4b3ec70318", @"/Views/Account/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c7cf71790263c6dc52cd7ff3dacb6027c93547a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandsOnHelpers.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n<div class=\"container\">\r\n");
#nullable restore
#line 8 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
     using(Html.BeginForm("Add","Account"))
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<table class=\"table table-bordered\" style=\"width:500px\">\r\n\t\t<tr>\r\n\t\t\t<td>Name</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
#nullable restore
#line 14 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t");
#nullable restore
#line 15 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t\t<tr>\r\n\t\t\t<td>Gender</td>\r\n\t\t\t<td>\r\n\t\t\t\tMale ");
#nullable restore
#line 21 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
                Write(Html.RadioButtonFor(m => m.Gender, "Male"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\tFeMale ");
#nullable restore
#line 22 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
                  Write(Html.RadioButtonFor(m => m.Gender, "FeMale"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t\t<tr>\r\n\t\t\t<td>DOB</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
#nullable restore
#line 28 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.TextBoxFor(m => m.DOB, null, new { @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t");
#nullable restore
#line 29 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t\t<tr>\r\n\t\t\t<td>Email</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
#nullable restore
#line 35 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t");
#nullable restore
#line 36 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t\t<tr>\r\n\t\t\t<td>Mobile</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
#nullable restore
#line 42 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.TextBox("Mobile"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t");
#nullable restore
#line 43 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t\t<tr>\r\n\t\t\t<td>Country</td>\r\n\t\t\t<td>\r\n");
            WriteLiteral("\t\t\t\t");
#nullable restore
#line 50 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.DropDownListFor(m => m.Country, ViewData["country"] as SelectList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t");
#nullable restore
#line 51 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\r\n\r\n\t\t<tr>\r\n\t\t\t<td>Username</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
#nullable restore
#line 59 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.TextBox("Username"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t");
#nullable restore
#line 60 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t\t<tr>\r\n\t\t\t<td>Password</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
#nullable restore
#line 66 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.Password("Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t");
#nullable restore
#line 67 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t\t<tr>\r\n\t\t\t<td>Confirm Password</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
#nullable restore
#line 73 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.Password("ConfirmPassword"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t");
#nullable restore
#line 74 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t\t<tr>\r\n\t\t\t<td colspan=\"2\">\r\n\t\t\t\t");
#nullable restore
#line 79 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
           Write(Html.CheckBox("confirm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Accept all terms and conditions\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t\t<tr>\r\n\t\t\t<td colspan=\"2\">\r\n\t\t\t\t<input type=\"submit\" value=\"Register\" />\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t</table>\r\n");
#nullable restore
#line 88 "C:\OnlineBatch\MVC\HandsOnHelpers\HandsOnHelpers\Views\Account\Create.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandsOnHelpers.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
