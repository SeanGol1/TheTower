#pragma checksum "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCharacterView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfda57366c9a270da1af35d45e20d281e04d6518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GetCharacterView), @"mvc.1.0.view", @"/Views/Shared/_GetCharacterView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_GetCharacterView.cshtml", typeof(AspNetCore.Views_Shared__GetCharacterView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfda57366c9a270da1af35d45e20d281e04d6518", @"/Views/Shared/_GetCharacterView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d92abe2e15f2c7951b51652b150bddf3db5b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GetCharacterView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TheTower.Models.Session>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgChar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCharacterView.cshtml"
  
    List<string> images = new List<string>();
    images.Add("bard.jpg");
    images.Add("druid.jpg");
    images.Add("monk.jpg");
    images.Add("SmallWarrior.jpg");
    images.Add("rogue.jpg");
    Random rd = new Random();

#line default
#line hidden
#line 11 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCharacterView.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(318, 23, true);
            WriteLiteral("    <div class=\"row\">\r\n");
            EndContext();
#line 14 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCharacterView.cshtml"
         for (int i = 0; i < item.PlayerQty; i++)
        {

#line default
#line hidden
            BeginContext(403, 65, true);
            WriteLiteral("            <div class=\"col-sm-4 opacityback\" >\r\n                ");
            EndContext();
            BeginContext(468, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f645dc2cddc5436b83a882dad82d7958", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 494, "~/images/Characters/", 494, 20, true);
#line 17 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCharacterView.cshtml"
AddHtmlAttributeValue("", 514, images[rd.Next(images.Count)], 514, 32, false);

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
            BeginContext(550, 29, true);
            WriteLiteral("\r\n                <h4>Player ");
            EndContext();
            BeginContext(581, 3, false);
#line 18 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCharacterView.cshtml"
                       Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(585, 27, true);
            WriteLiteral("</h4>\r\n            </div>\r\n");
            EndContext();
#line 20 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCharacterView.cshtml"
        }

#line default
#line hidden
            BeginContext(623, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 22 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCharacterView.cshtml"


}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TheTower.Models.Session>> Html { get; private set; }
    }
}
#pragma warning restore 1591
