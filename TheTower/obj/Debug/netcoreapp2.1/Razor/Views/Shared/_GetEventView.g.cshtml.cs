#pragma checksum "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetEventView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea24dc6e0d225b6e20cc9e262ed1e83f7fad0f99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GetEventView), @"mvc.1.0.view", @"/Views/Shared/_GetEventView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_GetEventView.cshtml", typeof(AspNetCore.Views_Shared__GetEventView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea24dc6e0d225b6e20cc9e262ed1e83f7fad0f99", @"/Views/Shared/_GetEventView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d92abe2e15f2c7951b51652b150bddf3db5b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GetEventView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheTower.Models.Event>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("imgEvent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetEventView.cshtml"
  
    string source = "";
    switch (Model.RollNumber)
    {
        case 1:
            source = "uno-reverse.png";
            break;
        case 2:
            source = "resize.jpg";
            break;
        case 3:
            source = "ArrowImg.jpg";
            break;
        case 4:
            source = "EntertainedImg.jpg";
            break;
        case 5:
            source = "holeImg.png";
            break;
        case 6:
            source = "electricityImg.jpg";
            break;
        case 7:
            source = "resize.jpg";
            break;
        case 8:
            source = "heartImg.jpg";
            break;
        default:
            break;
    }

#line default
#line hidden
            BeginContext(757, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(770, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "177f71072af042f892057ed03c4962cd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 794, "~/images/Events/", 794, 16, true);
#line 37 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetEventView.cshtml"
AddHtmlAttributeValue("", 810, source, 810, 7, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(844, 10, true);
            WriteLiteral("\r\n    <h2>");
            EndContext();
            BeginContext(855, 10, false);
#line 38 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetEventView.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(865, 14, true);
            WriteLiteral("</h2>\r\n    <p>");
            EndContext();
            BeginContext(880, 17, false);
#line 39 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetEventView.cshtml"
  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(897, 24, true);
            WriteLiteral("</p>\r\n    \r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheTower.Models.Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
