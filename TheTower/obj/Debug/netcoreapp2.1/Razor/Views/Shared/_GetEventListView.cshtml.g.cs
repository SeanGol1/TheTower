#pragma checksum "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\_GetEventListView.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d59e46e9a2ed7a0d0770d5dc26eeb00441412dfa75e46f9e2c6be088ced29503"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GetEventListView), @"mvc.1.0.view", @"/Views/Shared/_GetEventListView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_GetEventListView.cshtml", typeof(AspNetCore.Views_Shared__GetEventListView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d59e46e9a2ed7a0d0770d5dc26eeb00441412dfa75e46f9e2c6be088ced29503", @"/Views/Shared/_GetEventListView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8aef1332fa1dae2333c7e830cb4472718ea525972c926f9a2a2a5a4bb8fb7d5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GetEventListView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#line 1 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\_GetEventListView.cshtml"
       IEnumerable<TheTower.Models.Event>

#line default
#line hidden
    >
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 22, true);
            WriteLiteral("    <div class=\"row\">\n");
            EndContext();
#line 3 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\_GetEventListView.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden

            BeginContext(112, 32, true);
            WriteLiteral("            <p>\n                ");
            EndContext();
            BeginContext(145, 45, false);
            Write(
#line 7 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\_GetEventListView.cshtml"
                 Html.DisplayFor(modelItem => item.RollNumber)

#line default
#line hidden
            );
            EndContext();
            BeginContext(190, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(194, 39, false);
            Write(
#line 7 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\_GetEventListView.cshtml"
                                                                  Html.DisplayFor(modelItem => item.Name)

#line default
#line hidden
            );
            EndContext();
            BeginContext(233, 18, true);
            WriteLiteral("\n            </p>\n");
            EndContext();
#line 9 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\_GetEventListView.cshtml"

        }

#line default
#line hidden

            BeginContext(262, 11, true);
            WriteLiteral("    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TheTower.Models.Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
