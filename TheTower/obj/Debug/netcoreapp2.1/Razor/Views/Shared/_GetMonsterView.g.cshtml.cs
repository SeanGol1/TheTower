#pragma checksum "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetMonsterView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca6be838b6e6c5247327ccca101a813cba5f15e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GetMonsterView), @"mvc.1.0.view", @"/Views/Shared/_GetMonsterView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_GetMonsterView.cshtml", typeof(AspNetCore.Views_Shared__GetMonsterView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6be838b6e6c5247327ccca101a813cba5f15e7", @"/Views/Shared/_GetMonsterView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d92abe2e15f2c7951b51652b150bddf3db5b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GetMonsterView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TheTower.Models.Monster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgMon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetMonsterView.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
            BeginContext(82, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(91, 9, false);
#line 6 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetMonsterView.cshtml"
   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(100, 15, true);
            WriteLiteral("</h2>\r\n    <h4>");
            EndContext();
            BeginContext(116, 11, false);
#line 7 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetMonsterView.cshtml"
   Write(item.Source);

#line default
#line hidden
            EndContext();
            BeginContext(127, 15, true);
            WriteLiteral("</h4>\r\n    <h4>");
            EndContext();
            BeginContext(143, 20, false);
#line 8 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetMonsterView.cshtml"
   Write(item.ChallengeRating);

#line default
#line hidden
            EndContext();
            BeginContext(163, 11, true);
            WriteLiteral("</h4>\r\n    ");
            EndContext();
            BeginContext(174, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2bbfee514c9420bb1c41950146c0900", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 199, "~/images/Monsters/", 199, 18, true);
#line 9 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetMonsterView.cshtml"
AddHtmlAttributeValue("", 217, item.ImagePath, 217, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(236, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetMonsterView.cshtml"
}

#line default
#line hidden
            BeginContext(241, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TheTower.Models.Monster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
