#pragma checksum "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\_GetEventView.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e0444c0bb69966d26e2b25811773a8ad486d6fb70f3f21a242a1d9ccf0a122fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GetEventView), @"mvc.1.0.view", @"/Views/Shared/_GetEventView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_GetEventView.cshtml", typeof(AspNetCore.Views_Shared__GetEventView))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Visual Studio Projects\TheTower\TheTower\Views\_ViewImports.cshtml"
using TheTower

    ;
#line 2 "D:\Visual Studio Projects\TheTower\TheTower\Views\_ViewImports.cshtml"
using TheTower.Models

    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e0444c0bb69966d26e2b25811773a8ad486d6fb70f3f21a242a1d9ccf0a122fa", @"/Views/Shared/_GetEventView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8aef1332fa1dae2333c7e830cb4472718ea525972c926f9a2a2a5a4bb8fb7d5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GetEventView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#line 1 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\_GetEventView.cshtml"
       TheTower.Models.Event

#line default
#line hidden
    >
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive imgEvent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\_GetEventView.cshtml"
  
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
            source = "health.png";
            break;
        default:
            break;
    }

#line default
#line hidden

            BeginContext(721, 11, true);
            WriteLiteral("\n<div>\n    ");
            EndContext();
            BeginContext(732, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0444c0bb69966d26e2b25811773a8ad486d6fb70f3f21a242a1d9ccf0a122fa4807", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 742, "~/images/Events/", 742, 16, true);
            AddHtmlAttributeValue("", 758, 
#line 37 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\_GetEventView.cshtml"
                               source

#line default
#line hidden
            , 758, 7, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(801, 9, true);
            WriteLiteral("\n    <h2>");
            EndContext();
            BeginContext(811, 10, false);
            Write(
#line 38 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\_GetEventView.cshtml"
         Model.Name

#line default
#line hidden
            );
            EndContext();
            BeginContext(821, 13, true);
            WriteLiteral("</h2>\n    <p>");
            EndContext();
            BeginContext(835, 17, false);
            Write(
#line 39 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\_GetEventView.cshtml"
        Model.Description

#line default
#line hidden
            );
            EndContext();
            BeginContext(852, 19, true);
            WriteLiteral("</p>\n    \n</div>\n\n\n");
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
