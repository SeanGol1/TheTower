#pragma checksum "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99e7c1c757b5f25ce43fdbf05755bf469dd7d63a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Levels_Create), @"mvc.1.0.view", @"/Views/Levels/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Levels/Create.cshtml", typeof(AspNetCore.Views_Levels_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e7c1c757b5f25ce43fdbf05755bf469dd7d63a", @"/Views/Levels/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d92abe2e15f2c7951b51652b150bddf3db5b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Levels_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheTower.Models.Level>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtRoomRoll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtBiome"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtEvent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtMonRoll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtMonsterRoll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Monsters", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Levels", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
  
    //ViewData["Title"] = "Create";


#line default
#line hidden
            BeginContext(80, 494, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8"">
        <h1>TOWER OF LUCK'N ASSHOLES</h1>
    </div>
    <div class=""col-md-2"">
        <!--<span style=""font-size:48px"" class=""fa"">&#8505;</span>
        <span class=""fa fa-info-circle""></span>-->
    </div>
    <div class=""col-md-2"">
        <div class=""row"">
            <h3 class=""col-xs-6"">Current Room:</h3>
            <div class=""col-xs-6"">
                <input class=""input-lg txtCurrentRoll"" id=""txtCurrentRoom"" type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 574, "\"", 601, 1);
#line 21 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
WriteAttributeValue("", 582, ViewBag.CRoomLevel, 582, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(602, 163, true);
            WriteLiteral(" />\r\n                <button type=\"button\" class=\"btn btn-default\" id=\"btnSubmitRoom\">Update</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(765, 5657, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e074bd39f46a4493ad311103ba344510", async() => {
                BeginContext(815, 306, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-sm-6"">

            <!--   Roll For Room    -->

            <div class=""col-md-12"">
                <div class=""row rollWindow-Content"">
                    <h4>Roll for Room (d12)</h4>
                    <div class=""row"">
                        ");
                EndContext();
                BeginContext(1121, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ac620056a7784dacad86ff5db93828a9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 39 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoomLevel);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1188, 99, true);
                WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-info\" id=\"btnRoomGen\">Gen</button>\r\n");
                EndContext();
                BeginContext(1395, 1539, true);
                WriteLiteral(@"
                    </div>
                    <div id=""divNewRoom""></div>
                    <div class=""popup"">
                        <button type=""button"" class=""btn btn-info"" onclick=""myFunction()"">View List</button>
                        <div class=""popuptext"" id=""myPopup"">
                            <div class=""row"">
                                <div class=""col-xs-6"">
                                    <p>12 - +6</p>
                                    <p>11 - +5</p>
                                    <p>10 - +4</p>
                                    <p>9 - +3</p>
                                    <p>8 - +2</p>
                                    <p>7 - +1</p>
                                </div>
                                <div class=""col-xs-6"">
                                    <p>6 - -1</p>
                                    <p>5 - -2</p>
                                    <p>4 - -3</p>
                                    <p>3 - -4</p>
                    ");
                WriteLiteral(@"                <p>2 - -5</p>
                                    <p>1 - -6</p>
                                </div>

                            </div>
                        </div>

                    </div>
                </div>
            </div>

            <!--   Roll For Biome  -->

            <div class=""col-md-12"">
                <div class=""row rollWindow-Content"">
                    <h4>Roll for Biome (d12)</h4>
                    <div class=""row"">
                        ");
                EndContext();
                BeginContext(2934, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f95cf0da9af400f877aa0da136b48d2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 79 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BiomeID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2996, 182, true);
                WriteLiteral("\r\n                        <button type=\"button\" id=\"btnBiomeGen\" class=\"btn btn-info\">Gen</button>\r\n                    </div>\r\n                    <div id=\"divBiomeDetails\"></div>\r\n");
                EndContext();
                BeginContext(3223, 267, true);
                WriteLiteral(@"                    <button type=""button"" id=""btnBiomeList"" class=""btn btn-info"" onclick=""BiomeList()"">View List</button>
                    <div class=""popuptext"" id=""BiomePopup"">
                        <div id=""divBiomeList""></div>
                    </div>
");
                EndContext();
                BeginContext(3522, 293, true);
                WriteLiteral(@"                </div>
            </div>

            <!--   Roll for Event   -->

            <div class=""col-md-12"">
                <div class=""row rollWindow-Content"">
                    <h4>Roll for Event (d8)</h4>
                    <div class=""row"">
                        ");
                EndContext();
                BeginContext(3815, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0b699ee2c604c79a50f51c428de39c5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 98 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EventID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3877, 182, true);
                WriteLiteral("\r\n                        <button type=\"button\" id=\"btnEventGen\" class=\"btn btn-info\">Gen</button>\r\n                    </div>\r\n                    <div id=\"divEventDetails\"></div>\r\n");
                EndContext();
                BeginContext(4104, 267, true);
                WriteLiteral(@"                    <button type=""button"" id=""btnEventList"" class=""btn btn-info"" onclick=""EventList()"">View List</button>
                    <div class=""popuptext"" id=""EventPopup"">
                        <div id=""divEventList""></div>
                    </div>
");
                EndContext();
                BeginContext(4403, 363, true);
                WriteLiteral(@"                </div>
            </div>
        </div>



        <div class=""col-sm-6"">

            <!--   Roll For Monster CR   -->
            <div class=""col-md-12"">
                <div class=""row rollWindow-Content"">
                    <h4>Roll for Monster Challenge (d20)</h4>
                    <div class=""row"">
                        ");
                EndContext();
                BeginContext(4766, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f1789a21c6e0468ebd9c5ac431c272b0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 121 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CRLevel);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4830, 811, true);
                WriteLiteral(@"
                        <button type=""button"" id=""btnMonGen"" class=""btn btn-info"">Gen</button>
                    </div>
                    <div id=""divCRDetails"">

                    </div>
                    <button class="" btn btn-info"" id=""btnMonCRList"" onclick=""MonCRList()"">View List</button>
                    <div class=""popuptext"" id=""MonCRPopup"">
                        <div id=""divMonCRList""></div>
                    </div>
                </div>
            </div>


            <!--    Roll for Monster   -->
            <div class=""col-md-12"">
                <div class=""row rollWindow-Content"">
                    <div id=""divEachMonster"">
                        <h4>Roll for Monster(d4)</h4>
                        <div class=""row"">
                            ");
                EndContext();
                BeginContext(5641, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35b37a2ae3d34ae6adeeff445214390e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 141 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MonsterID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5711, 430, true);
                WriteLiteral(@"
                            <button type=""button"" id=""btnMonsterGen"" class=""btn btn-info"">Gen</button>
                            <button type=""button"" class=""btn btn-info"">View Stats</button>
                            <button type=""button"" class=""btn btn-info"">View Image</button>
                        </div>
                        <div id=""divMonsterDetails""></div>
                    </div>
                    ");
                EndContext();
                BeginContext(6141, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51d9c2caa2684e32bd225fecec16f89b", async() => {
                    BeginContext(6210, 9, true);
                    WriteLiteral("View List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6223, 192, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <button type=\"submit\" class=\"btn btn-primary\">Generate Level</button>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6422, 139, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <!--<a class=\"btn btn-danger\" asp-controller=\"Sessions\" asp-action=\"Details\" asp-route-id=\"\">Back to List</a>-->\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6579, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 165 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
            BeginContext(6652, 1146, true);
            WriteLiteral(@"
<script>
    function myFunction() {
  var popup = document.getElementById(""myPopup"");
  popup.classList.toggle(""show"");
}

        function BiomeList() {
  var popup = document.getElementById(""BiomePopup"");
    if( popup.style.display === ""none""){
  popup.classList.toggle(""show"");
    }else{
    popup.classList.toggle(""hide"");
    }
}

    function EventList() {
        var popup = document.getElementById(""EventPopup"");
        if (popup.style.display === ""none"") {
            popup.classList.toggle(""show"");
        } else {
            popup.classList.toggle(""hide"");
        }
    }

      function MonCRList() {
            var popup = document.getElementById(""MonCRPopup"");
            if( popup.style.display === ""none""){
                popup.classList.toggle(""show"");
            }else{
                popup.classList.toggle(""hide"");
            }
      }


    $(document).ready(function () {
        $(""#btnRoomGen"").click(function () {
            var roomroll = $(""#t");
            WriteLiteral("xtRoomRoll\").val();\r\n            $(\"#divNewRoom\").load(\"/Levels/GetNewLevel\",\r\n                { roll: roomroll, curRoom: ");
            EndContext();
            BeginContext(7799, 18, false);
#line 206 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
                                      Write(ViewBag.CRoomLevel);

#line default
#line hidden
            EndContext();
            BeginContext(7817, 14, true);
            WriteLiteral(" , sessionid: ");
            EndContext();
            BeginContext(7832, 18, false);
#line 206 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
                                                                       Write(ViewBag.CSessionID);

#line default
#line hidden
            EndContext();
            BeginContext(7850, 117, true);
            WriteLiteral("});\r\n        });\r\n    });\r\n\r\n    $(\"#btnSubmitRoom\").click(function () {\r\n        var data = {};\r\n        data.id = \'");
            EndContext();
            BeginContext(7968, 18, false);
#line 212 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
              Write(ViewBag.CSessionID);

#line default
#line hidden
            EndContext();
            BeginContext(7986, 131, true);
            WriteLiteral("\';\r\n        data.newRoom = $(\"#txtCurrentRoom\").val();\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \'");
            EndContext();
            BeginContext(8118, 34, false);
#line 216 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
                 Write(Url.Action("SubmitRoom", "Levels"));

#line default
#line hidden
            EndContext();
            BeginContext(8152, 1270, true);
            WriteLiteral(@"',
                contentType: ""application/json; charset=utf-8"",
                data: JSON.stringify(data),
                dataType: ""json""
            });
    });
    $(document).ready(function () {
        $(""#btnBiomeGen"").click(function () {
            var Biomeroll = $(""#txtBiome"").val();
            $(""#divBiomeDetails"").load(""/Levels/GetNewBiome"",
                { roll: Biomeroll });
        });
    });

    $(document).ready(function () {
        $(""#btnBiomeList"").click(function () {
            $(""#divBiomeList"").load(""/Levels/GetBiomeList"");
        });
    });

    $(document).ready(function () {
        $(""#btnEventGen"").click(function () {
            var Eventroll = $(""#txtEvent"").val();
            $(""#divEventDetails"").load(""/Levels/GetNewEvent"",
                { roll: Eventroll });
        });
    });

    $(document).ready(function () {
        $(""#btnEventList"").click(function () {
            $(""#divEventList"").load(""/Levels/GetEventList"");
        })");
            WriteLiteral(";\r\n    });\r\n\r\n    $(document).ready(function () {\r\n        $(\"#btnMonGen\").click(function () {\r\n            var CRroll = $(\"#txtMonRoll\").val();\r\n            $(\"#divCRDetails\").load(\"/Levels/GetNewCR\",\r\n                { roll: CRroll, sessionid: ");
            EndContext();
            BeginContext(9423, 18, false);
#line 254 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
                                      Write(ViewBag.CSessionID);

#line default
#line hidden
            EndContext();
            BeginContext(9441, 334, true);
            WriteLiteral(@" });
        });
    });

    $(document).ready(function () {
        $(""#btnMonsterGen"").click(function () {
            var monroll = $(""#txtMonsterRoll"").val();
            var CRroll = $(""#txtMonRoll"").val();
            $(""#divMonsterDetails"").load(""/Levels/GetNewMonDetail"",
                { roll: monroll, sessionid: ");
            EndContext();
            BeginContext(9776, 18, false);
#line 263 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
                                       Write(ViewBag.CSessionID);

#line default
#line hidden
            EndContext();
            BeginContext(9794, 219, true);
            WriteLiteral(" , cr: CRroll });\r\n        });\r\n    });\r\n\r\n    $(document).ready(function () {\r\n        $(\"#btnMonCRList\").click(function () {\r\n            $(\"#divMonCRList\").load(\"/Levels/GetMonCRList\",\r\n                {  sessionid: ");
            EndContext();
            BeginContext(10014, 18, false);
#line 270 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Levels\Create.cshtml"
                         Write(ViewBag.CSessionID);

#line default
#line hidden
            EndContext();
            BeginContext(10032, 321, true);
            WriteLiteral(@" });
        });
    });



    /*
    $(document).ready(function () {
        $(""#txtMonRoll"").focusout(function () {
            var CRroll = $(""#txtMonRoll"").val();
            $(""#divMonsterDetails"").load(""/Levels/GetMonQTYinput"",
                { cr: CRroll });
        });
    });
    */
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheTower.Models.Level> Html { get; private set; }
    }
}
#pragma warning restore 1591
