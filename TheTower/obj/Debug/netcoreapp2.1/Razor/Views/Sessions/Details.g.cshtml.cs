#pragma checksum "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "628d13867903ee7b9f305ab3a8c6b5b270b16fc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sessions_Details), @"mvc.1.0.view", @"/Views/Sessions/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sessions/Details.cshtml", typeof(AspNetCore.Views_Sessions_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"628d13867903ee7b9f305ab3a8c6b5b270b16fc9", @"/Views/Sessions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d92abe2e15f2c7951b51652b150bddf3db5b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Sessions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Level>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Levels", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
  
    ViewData["Title"] = "Details";

    bool mon = false;

    //int sessionID = Model.First().SessionID;

    //TowerContext _ctx = new TowerContext();
    //int currentRoom = _ctx.Session.Where(s => s.ID == sessionID).Select(s => s.CurrentLevel).SingleOrDefault();



#line default
#line hidden
            BeginContext(315, 159, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <h4>Session</h4>\r\n        </div>\r\n\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(474, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d45cb4b41ab4f4d85000b284a850f6c", async() => {
                BeginContext(545, 16, true);
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
            BeginContext(565, 83, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <h4></h4>\r\n    </div>\r\n\r\n\r\n    <div class=\"col-md-6\">\r\n");
            EndContext();
#line 33 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
         for (int i = 1; i < 21; i++)
        {
            mon = false;

#line default
#line hidden
            BeginContext(724, 99, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"form-group\">\r\n                    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 823, "\"", 836, 2);
            WriteAttributeValue("", 829, "txt", 829, 3, true);
#line 38 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
WriteAttributeValue("", 832, i, 832, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(837, 38, true);
            WriteLiteral(" class=\"col-xs-3 col-form-label\">Room ");
            EndContext();
            BeginContext(876, 1, false);
#line 38 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
                                                                         Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(877, 57, true);
            WriteLiteral("</label>\r\n                    <div class=\"col-xs-9 \">\r\n\r\n");
            EndContext();
#line 41 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
                         foreach (Level l in Model)
                        {
                            if (l.RoomLevel == i)
                            {

#line default
#line hidden
            BeginContext(1096, 50, true);
            WriteLiteral("                                <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1146, "\"", 1158, 2);
            WriteAttributeValue("", 1151, "txt", 1151, 3, true);
#line 45 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
WriteAttributeValue("", 1154, i, 1154, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1159, 21, true);
            WriteLiteral(" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1180, "\"", 1195, 1);
#line 45 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
WriteAttributeValue("", 1188, l.Name, 1188, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1196, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 46 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
                                mon = true;
                            }
                        }

#line default
#line hidden
            BeginContext(1302, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 49 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
                         if (mon == false)
                        {

#line default
#line hidden
            BeginContext(1373, 46, true);
            WriteLiteral("                            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1419, "\"", 1431, 2);
            WriteAttributeValue("", 1424, "txt", 1424, 3, true);
#line 51 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
WriteAttributeValue("", 1427, i, 1427, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1432, 24, true);
            WriteLiteral(" class=\"form-control\">\r\n");
            EndContext();
#line 52 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(1483, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 57 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1568, 42, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n");
            EndContext();
#line 61 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
         for (int i = -20; i < 0; i++)
        {
            mon = false;

#line default
#line hidden
            BeginContext(1687, 99, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"form-group\">\r\n                    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1786, "\"", 1799, 2);
            WriteAttributeValue("", 1792, "txt", 1792, 3, true);
#line 66 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
WriteAttributeValue("", 1795, i, 1795, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1800, 38, true);
            WriteLiteral(" class=\"col-xs-3 col-form-label\">Room ");
            EndContext();
            BeginContext(1839, 1, false);
#line 66 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
                                                                         Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1840, 56, true);
            WriteLiteral("</label>\r\n                    <div class=\"col-xs-9\">\r\n\r\n");
            EndContext();
#line 69 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
                         foreach (Level l in Model)
                        {
                            if (l.RoomLevel == i)
                            {

#line default
#line hidden
            BeginContext(2058, 50, true);
            WriteLiteral("                                <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2108, "\"", 2120, 2);
            WriteAttributeValue("", 2113, "txt", 2113, 3, true);
#line 73 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
WriteAttributeValue("", 2116, i, 2116, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2121, 21, true);
            WriteLiteral(" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2142, "\"", 2157, 1);
#line 73 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
WriteAttributeValue("", 2150, l.Name, 2150, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2158, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 74 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
                                mon = true;
                            }
                        }

#line default
#line hidden
            BeginContext(2264, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 77 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
                         if (mon == false)
                        {

#line default
#line hidden
            BeginContext(2335, 46, true);
            WriteLiteral("                            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2381, "\"", 2393, 2);
            WriteAttributeValue("", 2386, "txt", 2386, 3, true);
#line 79 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
WriteAttributeValue("", 2389, i, 2389, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2394, 24, true);
            WriteLiteral(" class=\"form-control\">\r\n");
            EndContext();
#line 80 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(2445, 72, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 84 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Sessions\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2528, 31, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2559, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1beab700572f4972b524874dd1ee04ca", async() => {
                BeginContext(2581, 12, true);
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
            BeginContext(2597, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
