#pragma checksum "D:\dotnet\.NET programiranje\vjezba3\PasswordGenerator\Pages\Check.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77622724c2825636e7f8dded4c5a55b51df30737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PasswordGenerator.Pages.Pages_Check), @"mvc.1.0.razor-page", @"/Pages/Check.cshtml")]
namespace PasswordGenerator.Pages
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
#line 1 "D:\dotnet\.NET programiranje\vjezba3\PasswordGenerator\Pages\_ViewImports.cshtml"
using PasswordGenerator;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77622724c2825636e7f8dded4c5a55b51df30737", @"/Pages/Check.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7914a07e674e9a2519734aee8af8079820637a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Check : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\dotnet\.NET programiranje\vjezba3\PasswordGenerator\Pages\Check.cshtml"
  
    ViewData["Title"] = "Check Password";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\dotnet\.NET programiranje\vjezba3\PasswordGenerator\Pages\Check.cshtml"
 if (ViewData.ContainsKey("password")) {

#line default
#line hidden
#nullable disable
            WriteLiteral("  <div class=\"alert alert-info\" role=\"alert\">\r\n    ");
#nullable restore
#line 9 "D:\dotnet\.NET programiranje\vjezba3\PasswordGenerator\Pages\Check.cshtml"
Write(ViewData["password"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </div>\r\n");
#nullable restore
#line 11 "D:\dotnet\.NET programiranje\vjezba3\PasswordGenerator\Pages\Check.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-lg-6 mb-4\">\r\n  <div class=\"card shadow mb-4\">\r\n    <div class=\"card-header py-3\">\r\n      <h6 class=\"m-0 font-weight-bold text-primary\">Password check</h6>\r\n    </div>\r\n    <div class=\"card-body\">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77622724c2825636e7f8dded4c5a55b51df307374182", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
          <label for=""password"">Password</label>
          <input type=""password"" class=""form-control"" id=""password"" placeholder=""Enter password you want to check"" name=""password"">
        </div>

        <button type=""submit"" class=""btn btn-primary"">Check now</button>
      ");
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
            WriteLiteral("\r\n    </div>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CheckModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CheckModel>)PageContext?.ViewData;
        public CheckModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591