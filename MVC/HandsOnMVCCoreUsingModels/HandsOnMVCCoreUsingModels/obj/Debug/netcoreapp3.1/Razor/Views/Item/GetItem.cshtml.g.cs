#pragma checksum "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\Item\GetItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af9d568c103c316a3f79b2a7860ad0a021c10a00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_GetItem), @"mvc.1.0.view", @"/Views/Item/GetItem.cshtml")]
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
#line 1 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\_ViewImports.cshtml"
using HandsOnMVCCoreUsingModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\_ViewImports.cshtml"
using HandsOnMVCCoreUsingModels.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af9d568c103c316a3f79b2a7860ad0a021c10a00", @"/Views/Item/GetItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb88db6a31c8539a674a4481cba51f9dabe079c", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_GetItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandsOnMVCCoreUsingModels.Models.Item>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\Item\GetItem.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af9d568c103c316a3f79b2a7860ad0a021c10a003564", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>GetItem</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af9d568c103c316a3f79b2a7860ad0a021c10a004625", async() => {
                WriteLiteral("\r\n    <pre style=\"color:blue\">\r\n    ItemId:");
#nullable restore
#line 15 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\Item\GetItem.cshtml"
      Write(Model.ItemId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ItemName:");
#nullable restore
#line 16 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\Item\GetItem.cshtml"
        Write(Model.ItemName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    Price:");
#nullable restore
#line 17 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\Item\GetItem.cshtml"
     Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    Stock:");
#nullable restore
#line 18 "C:\OnlineBatch\MVC\HandsOnMVCCoreUsingModels\HandsOnMVCCoreUsingModels\Views\Item\GetItem.cshtml"
     Write(Model.Stock);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n</pre>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandsOnMVCCoreUsingModels.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
