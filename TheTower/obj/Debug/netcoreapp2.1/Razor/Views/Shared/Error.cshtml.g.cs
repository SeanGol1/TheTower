#pragma checksum "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\Error.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c491cf3a27e57c935822e8f9fe62855249bf6585b2414035c363da05c390e9d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c491cf3a27e57c935822e8f9fe62855249bf6585b2414035c363da05c390e9d7", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8aef1332fa1dae2333c7e830cb4472718ea525972c926f9a2a2a5a4bb8fb7d5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#line 1 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\Error.cshtml"
       ErrorViewModel

#line default
#line hidden
    >
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden

            BeginContext(60, 116, true);
            WriteLiteral("\n<h1 class=\"text-danger\">Error.</h1>\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\n\n");
            EndContext();
#line 9 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden

            BeginContext(204, 51, true);
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(256, 15, false);
            Write(
#line 12 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\Error.cshtml"
                                            Model.RequestId

#line default
#line hidden
            );
            EndContext();
            BeginContext(271, 17, true);
            WriteLiteral("</code>\n    </p>\n");
            EndContext();
#line 14 "D:\Visual Studio Projects\TheTower\TheTower\Views\Shared\Error.cshtml"
}

#line default
#line hidden

            BeginContext(290, 554, true);
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>Development environment should not be enabled in deployed applications</strong>, as it can result in sensitive information from exceptions being displayed to end users. For local debugging, development environment can be enabled by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>, and restarting the application.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
