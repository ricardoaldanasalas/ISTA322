#pragma checksum "C:\Users\Admin\Desktop\ISTA322\Labs\WorkingWithVisualStudio\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5abb16b4b0e18491afe2cb422877c18e0785f78d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5abb16b4b0e18491afe2cb422877c18e0785f78d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WorkingWithVisualStudio.Models.Product>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\ISTA322\Labs\WorkingWithVisualStudio\Views\Home\Index.cshtml"
   Layout = null; 

#line default
#line hidden
            BeginContext(81, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(106, 534, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5abb16b4b0e18491afe2cb422877c18e0785f78d3249", async() => {
                BeginContext(112, 521, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Working with Visual Studio</title>
    <link rel=""stylesheet"" href=""css/first.css"" />
    <link rel=""stylesheet"" href=""css/second.css"" />
    <script src=""js/third.js""></script>
    <script src=""js/fourth.js""></script>
    <style>
        #header {
            margin: 12px;
            border: 2px #006600 inset;
            padding: 18px;
            color: #b6ff00;
            background-color: mediumpurple
        }
    </style>
");
                EndContext();
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
            EndContext();
            BeginContext(640, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(642, 497, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5abb16b4b0e18491afe2cb422877c18e0785f78d4966", async() => {
                BeginContext(648, 109, true);
                WriteLiteral("\r\n    <table>\r\n        <h2 id=\"header\">My Products</h2>\r\n        <h3>Products</h3>\r\n        <p>Request Time: ");
                EndContext();
                BeginContext(758, 33, false);
#line 26 "C:\Users\Admin\Desktop\ISTA322\Labs\WorkingWithVisualStudio\Views\Home\Index.cshtml"
                    Write(DateTime.Now.ToString("HH:mm:ss"));

#line default
#line hidden
                EndContext();
                BeginContext(791, 108, true);
                WriteLiteral("</p>\r\n        <thead>\r\n            <tr><td>Name</td><td>Price</td></tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 31 "C:\Users\Admin\Desktop\ISTA322\Labs\WorkingWithVisualStudio\Views\Home\Index.cshtml"
             foreach (var p in Model)
            {

#line default
#line hidden
                BeginContext(953, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1000, 6, false);
#line 34 "C:\Users\Admin\Desktop\ISTA322\Labs\WorkingWithVisualStudio\Views\Home\Index.cshtml"
                   Write(p.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1006, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1039, 15, false);
#line 35 "C:\Users\Admin\Desktop\ISTA322\Labs\WorkingWithVisualStudio\Views\Home\Index.cshtml"
                    Write($"{p.Price:C2}");

#line default
#line hidden
                EndContext();
                BeginContext(1055, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 37 "C:\Users\Admin\Desktop\ISTA322\Labs\WorkingWithVisualStudio\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1100, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1139, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WorkingWithVisualStudio.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591