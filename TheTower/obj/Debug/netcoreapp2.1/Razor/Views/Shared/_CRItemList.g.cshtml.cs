#pragma checksum "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_CRItemList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9a2959607fb189b6003166f50b66366f05dcea3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CRItemList), @"mvc.1.0.view", @"/Views/Shared/_CRItemList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CRItemList.cshtml", typeof(AspNetCore.Views_Shared__CRItemList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9a2959607fb189b6003166f50b66366f05dcea3", @"/Views/Shared/_CRItemList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d92abe2e15f2c7951b51652b150bddf3db5b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CRItemList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TheTower.Models.CRRoll>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_CRItemList.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(79, 23, true);
            WriteLiteral("    <h4>You rolled a : ");
            EndContext();
            BeginContext(103, 45, false);
#line 5 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_CRItemList.cshtml"
                  Write(Html.DisplayFor(modelItem => item.RollNumber));

#line default
#line hidden
            EndContext();
            BeginContext(148, 34, true);
            WriteLiteral(" </h4>\r\n    <h4>Challenge Rating: ");
            EndContext();
            BeginContext(183, 42, false);
#line 6 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_CRItemList.cshtml"
                     Write(Html.DisplayFor(modelItem => item.CRLevel));

#line default
#line hidden
            EndContext();
            BeginContext(225, 35, true);
            WriteLiteral("</h4>\r\n    <h5>Number of Monsters: ");
            EndContext();
            BeginContext(261, 45, false);
#line 7 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_CRItemList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MonsterQTY));

#line default
#line hidden
            EndContext();
            BeginContext(306, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 8 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\_CRItemList.cshtml"
    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TheTower.Models.CRRoll>> Html { get; private set; }
    }
}
#pragma warning restore 1591
