#pragma checksum "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbacc0fed4c29722f8b60d1549add7ed67365486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\_ViewImports.cshtml"
using TheTower;

#line default
#line hidden
#line 2 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\_ViewImports.cshtml"
using TheTower.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbacc0fed4c29722f8b60d1549add7ed67365486", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d92abe2e15f2c7951b51652b150bddf3db5b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 25, true);
            WriteLiteral("<h2>Tower Levels</h2>\r\n\r\n");
            EndContext();
            BeginContext(68, 911, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf260312ace443098dedab125367bcdd", async() => {
                BeginContext(74, 30, true);
                WriteLiteral("\r\n    <div class=\"col-md-6\">\r\n");
                EndContext();
#line 8 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Home\Contact.cshtml"
         for (int i = 1; i < 21; i++)
        {

#line default
#line hidden
                BeginContext(154, 99, true);
                WriteLiteral("            <div class=\"row\">\r\n                <div class=\"form-group\">\r\n                    <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 253, "\"", 266, 2);
                WriteAttributeValue("", 259, "txt", 259, 3, true);
#line 12 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Home\Contact.cshtml"
WriteAttributeValue("", 262, i, 262, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(267, 40, true);
                WriteLiteral(" class=\"col-xs-3 col-form-label\"  >Room ");
                EndContext();
                BeginContext(308, 1, false);
#line 12 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Home\Contact.cshtml"
                                                                           Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(309, 97, true);
                WriteLiteral("</label>\r\n                    <div class=\"col-xs-9 \">\r\n                        <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 406, "\"", 418, 2);
                WriteAttributeValue("", 411, "txt", 411, 3, true);
#line 14 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Home\Contact.cshtml"
WriteAttributeValue("", 414, i, 414, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(419, 96, true);
                WriteLiteral(" class=\"form-control\">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 18 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Home\Contact.cshtml"
        }

#line default
#line hidden
                BeginContext(526, 42, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n");
                EndContext();
#line 22 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Home\Contact.cshtml"
         for (int i = -20; i < 0; i++)
        {

#line default
#line hidden
                BeginContext(619, 87, true);
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"form-group\">\r\n                <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 706, "\"", 719, 2);
                WriteAttributeValue("", 712, "txt", 712, 3, true);
#line 26 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Home\Contact.cshtml"
WriteAttributeValue("", 715, i, 715, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(720, 38, true);
                WriteLiteral(" class=\"col-xs-3 col-form-label\">Room ");
                EndContext();
                BeginContext(759, 1, false);
#line 26 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Home\Contact.cshtml"
                                                                     Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(760, 88, true);
                WriteLiteral("</label>\r\n                <div class=\"col-xs-9\">\r\n                    <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 848, "\"", 860, 2);
                WriteAttributeValue("", 853, "txt", 853, 3, true);
#line 28 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Home\Contact.cshtml"
WriteAttributeValue("", 856, i, 856, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(861, 84, true);
                WriteLiteral(" class=\"form-control\">\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 32 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Home\Contact.cshtml"
        }

#line default
#line hidden
                BeginContext(956, 16, true);
                WriteLiteral("    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
