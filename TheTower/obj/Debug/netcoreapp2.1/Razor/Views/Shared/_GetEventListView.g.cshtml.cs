#pragma checksum "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetEventListView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7a464a62cd7e657d2d2f5cc31857603f6d2e3b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GetEventListView), @"mvc.1.0.view", @"/Views/Shared/_GetEventListView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_GetEventListView.cshtml", typeof(AspNetCore.Views_Shared__GetEventListView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a464a62cd7e657d2d2f5cc31857603f6d2e3b0", @"/Views/Shared/_GetEventListView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d92abe2e15f2c7951b51652b150bddf3db5b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GetEventListView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TheTower.Models.Event>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 23, true);
            WriteLiteral("    <div class=\"row\">\r\n");
            EndContext();
#line 3 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetEventListView.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(117, 33, true);
            WriteLiteral("            <p>\r\n                ");
            EndContext();
            BeginContext(151, 45, false);
#line 7 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetEventListView.cshtml"
           Write(Html.DisplayFor(modelItem => item.RollNumber));

#line default
#line hidden
            EndContext();
            BeginContext(196, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(200, 39, false);
#line 7 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetEventListView.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(239, 20, true);
            WriteLiteral("\r\n            </p>\r\n");
            EndContext();
#line 9 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_GetEventListView.cshtml"

        }

#line default
#line hidden
            BeginContext(272, 12, true);
            WriteLiteral("    </div>\r\n");
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
