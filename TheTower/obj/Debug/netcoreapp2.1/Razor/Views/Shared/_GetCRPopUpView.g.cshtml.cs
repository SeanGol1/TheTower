#pragma checksum "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCRPopUpView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6ef1c49e1b26e9852710e42a509d93d9ead38a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GetCRPopUpView), @"mvc.1.0.view", @"/Views/Shared/_GetCRPopUpView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_GetCRPopUpView.cshtml", typeof(AspNetCore.Views_Shared__GetCRPopUpView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ef1c49e1b26e9852710e42a509d93d9ead38a5", @"/Views/Shared/_GetCRPopUpView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d92abe2e15f2c7951b51652b150bddf3db5b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GetCRPopUpView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TheTower.Models.CRRoll>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 25, true);
            WriteLiteral("\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 4 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCRPopUpView.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(118, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(134, 15, false);
#line 6 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCRPopUpView.cshtml"
          Write(item.RollNumber);

#line default
#line hidden
            EndContext();
            BeginContext(149, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(153, 7, false);
#line 6 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCRPopUpView.cshtml"
                             Write(item.XP);

#line default
#line hidden
            EndContext();
            BeginContext(160, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 7 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetCRPopUpView.cshtml"
        }

#line default
#line hidden
            BeginContext(177, 10, true);
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TheTower.Models.CRRoll>> Html { get; private set; }
    }
}
#pragma warning restore 1591
