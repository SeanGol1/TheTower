#pragma checksum "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6d29dc01be83b4930b87d87cc463be51260759f9e4ae06da539b17b48ff0d0dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sessions_Details), @"mvc.1.0.view", @"/Views/Sessions/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sessions/Details.cshtml", typeof(AspNetCore.Views_Sessions_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6d29dc01be83b4930b87d87cc463be51260759f9e4ae06da539b17b48ff0d0dd", @"/Views/Sessions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8aef1332fa1dae2333c7e830cb4472718ea525972c926f9a2a2a5a4bb8fb7d5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Sessions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#line 1 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
       IEnumerable<Level>

#line default
#line hidden
    >
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Levels", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
  
    ViewData["Title"] = "Details";

    bool mon = false;

    //int sessionID = Model.First().SessionID;

    //TowerContext _ctx = new TowerContext();
    //int currentRoom = _ctx.Session.Where(s => s.ID == sessionID).Select(s => s.CurrentLevel).SingleOrDefault();



#line default
#line hidden

            BeginContext(301, 126, true);
            WriteLiteral("\n<script>\n    document.addEventListener(\"DOMContentLoaded\", function(){\n        var divname = document.getElementById(\"txt\" + ");
            EndContext();
            BeginContext(428, 18, false);
            Write(
#line 18 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                                       ViewBag.CRoomLevel

#line default
#line hidden
            );
            EndContext();
            BeginContext(446, 412, true);
            WriteLiteral(@");
        divname.style.backgroundColor = ""Green"";
        divname.style.color = ""white"";

});


</script>

<h2>Details</h2>

<div>
    <div class=""row"">
        <div class=""col-md-2"">
            <h4>Session</h4>
        </div>
        <div class=""col-md-8"">
            <label for=""txtCurrentRoom"" class=""col-md-6"">Current Room =</label>
            <input type=""text"" class=""form-control"" id=""txtCurrentRoom""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 858, "\"", 885, 1);
            WriteAttributeValue("", 866, 
#line 36 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                                                                ViewBag.CRoomLevel

#line default
#line hidden
            , 866, 19, false);
            EndWriteAttribute();
            BeginContext(886, 89, true);
            WriteLiteral(" style=\"max-width : 50px;\" />\n\n        </div>\n        <div class=\"col-md-2\">\n            ");
            EndContext();
            BeginContext(975, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d29dc01be83b4930b87d87cc463be51260759f9e4ae06da539b17b48ff0d0dd6774", async() => {
                BeginContext(1046, 16, true);
                WriteLiteral("Create New Level");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1066, 83, true);
            WriteLiteral("\n        </div>\n\n\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-md-6\">\n");
            EndContext();
#line 48 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
             for (int i = 1; i < 21; i++)
            {

                mon = false;

#line default
#line hidden

            BeginContext(1235, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1255, "\"", 1267, 2);
            WriteAttributeValue("", 1260, "div", 1260, 3, true);
            WriteAttributeValue("", 1263, 
#line 52 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                              i

#line default
#line hidden
            , 1263, 4, false);
            EndWriteAttribute();
            BeginContext(1268, 89, true);
            WriteLiteral(" class=\"row\">\n                    <div class=\"form-group\">\n                        <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1357, "\"", 1370, 2);
            WriteAttributeValue("", 1363, "txt", 1363, 3, true);
            WriteAttributeValue("", 1366, 
#line 54 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                         i

#line default
#line hidden
            , 1366, 4, false);
            EndWriteAttribute();
            BeginContext(1371, 38, true);
            WriteLiteral(" class=\"col-xs-3 col-form-label\">Room ");
            EndContext();
            BeginContext(1410, 1, false);
            Write(
#line 54 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                                                                   i

#line default
#line hidden
            );
            EndContext();
            BeginContext(1411, 58, true);
            WriteLiteral("</label>\n                        <div class=\"col-xs-9 \">\n\n");
            EndContext();
#line 57 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                             foreach (Level l in Model)
                            {
                                if (l.RoomLevel == i)
                                {

#line default
#line hidden

            BeginContext(1643, 54, true);
            WriteLiteral("                                    <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1697, "\"", 1709, 2);
            WriteAttributeValue("", 1702, "txt", 1702, 3, true);
            WriteAttributeValue("", 1705, 
#line 61 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                                                i

#line default
#line hidden
            , 1705, 4, false);
            EndWriteAttribute();
            BeginContext(1710, 21, true);
            WriteLiteral(" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1731, "\"", 1746, 1);
            WriteAttributeValue("", 1739, 
#line 61 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                                                                                 l.Name

#line default
#line hidden
            , 1739, 7, false);
            EndWriteAttribute();
            BeginContext(1747, 38, true);
            WriteLiteral(">                                    \n");
            EndContext();
#line 62 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                    mon = true;
                                }
                            }

#line default
#line hidden

#line 65 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                             if (mon == false)
                            {

#line default
#line hidden

            BeginContext(1974, 50, true);
            WriteLiteral("                                <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2024, "\"", 2036, 2);
            WriteAttributeValue("", 2029, "txt", 2029, 3, true);
            WriteAttributeValue("", 2032, 
#line 67 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                                            i

#line default
#line hidden
            , 2032, 4, false);
            EndWriteAttribute();
            BeginContext(2037, 23, true);
            WriteLiteral(" class=\"form-control\">\n");
            EndContext();
#line 68 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                            }

#line default
#line hidden

            BeginContext(2090, 82, true);
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 73 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
            }

#line default
#line hidden

            BeginContext(2186, 48, true);
            WriteLiteral("\n\n        </div>\n        <div class=\"col-md-6\">\n");
            EndContext();
#line 78 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
             for (int i = -20; i < 0; i++)
            {
                mon = false;

#line default
#line hidden

            BeginContext(2320, 109, true);
            WriteLiteral("                <div class=\"row\">\n                    <div class=\"form-group\">\n                        <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2429, "\"", 2442, 2);
            WriteAttributeValue("", 2435, "txt", 2435, 3, true);
            WriteAttributeValue("", 2438, 
#line 83 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                         i

#line default
#line hidden
            , 2438, 4, false);
            EndWriteAttribute();
            BeginContext(2443, 38, true);
            WriteLiteral(" class=\"col-xs-3 col-form-label\">Room ");
            EndContext();
            BeginContext(2482, 1, false);
            Write(
#line 83 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                                                                   i

#line default
#line hidden
            );
            EndContext();
            BeginContext(2483, 57, true);
            WriteLiteral("</label>\n                        <div class=\"col-xs-9\">\n\n");
            EndContext();
#line 86 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                             foreach (Level l in Model)
                            {
                                if (l.RoomLevel == i)
                                {

#line default
#line hidden

            BeginContext(2714, 54, true);
            WriteLiteral("                                    <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2768, "\"", 2780, 2);
            WriteAttributeValue("", 2773, "txt", 2773, 3, true);
            WriteAttributeValue("", 2776, 
#line 90 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                                                i

#line default
#line hidden
            , 2776, 4, false);
            EndWriteAttribute();
            BeginContext(2781, 21, true);
            WriteLiteral(" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2802, "\"", 2817, 1);
            WriteAttributeValue("", 2810, 
#line 90 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                                                                                 l.Name

#line default
#line hidden
            , 2810, 7, false);
            EndWriteAttribute();
            BeginContext(2818, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 91 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                    mon = true;
                                }
                            }

#line default
#line hidden

#line 94 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                             if (mon == false)
                            {

#line default
#line hidden

            BeginContext(3009, 50, true);
            WriteLiteral("                                <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3059, "\"", 3071, 2);
            WriteAttributeValue("", 3064, "txt", 3064, 3, true);
            WriteAttributeValue("", 3067, 
#line 96 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                                                            i

#line default
#line hidden
            , 3067, 4, false);
            EndWriteAttribute();
            BeginContext(3072, 23, true);
            WriteLiteral(" class=\"form-control\">\n");
            EndContext();
#line 97 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
                            }

#line default
#line hidden

            BeginContext(3125, 81, true);
            WriteLiteral("                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 101 "D:\Visual Studio Projects\TheTower\TheTower\Views\Sessions\Details.cshtml"
            }

#line default
#line hidden

            BeginContext(3220, 43, true);
            WriteLiteral("        </div>\n    </div>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(3263, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d29dc01be83b4930b87d87cc463be51260759f9e4ae06da539b17b48ff0d0dd18529", async() => {
                BeginContext(3285, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3301, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Level>> Html { get; private set; }
    }
}
#pragma warning restore 1591
