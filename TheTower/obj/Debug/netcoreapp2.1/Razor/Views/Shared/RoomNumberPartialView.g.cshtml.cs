#pragma checksum "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\RoomNumberPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "537180197676b819852f81bc48fcf5bae312f7ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_RoomNumberPartialView), @"mvc.1.0.view", @"/Views/Shared/RoomNumberPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/RoomNumberPartialView.cshtml", typeof(AspNetCore.Views_Shared_RoomNumberPartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"537180197676b819852f81bc48fcf5bae312f7ab", @"/Views/Shared/RoomNumberPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d92abe2e15f2c7951b51652b150bddf3db5b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_RoomNumberPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoomRoll>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\RoomNumberPartialView.cshtml"
  

    int newRoom = 0;
    foreach (var item in Model)
    {
        newRoom = ViewBag.CRoomLevel + item.RoomMove;
    }
    ViewBag.NewRoom = newRoom;


#line default
#line hidden
            BeginContext(197, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\RoomNumberPartialView.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(232, 23, true);
            WriteLiteral("    <h4>You rolled a : ");
            EndContext();
            BeginContext(256, 43, false);
#line 15 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\RoomNumberPartialView.cshtml"
                  Write(Html.DisplayFor(modelItem => item.DiceRoll));

#line default
#line hidden
            EndContext();
            BeginContext(299, 31, true);
            WriteLiteral(" </h4>\r\n    <h4>Going Up/Down: ");
            EndContext();
            BeginContext(331, 43, false);
#line 16 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\RoomNumberPartialView.cshtml"
                  Write(Html.DisplayFor(modelItem => item.RoomMove));

#line default
#line hidden
            EndContext();
            BeginContext(374, 50, true);
            WriteLiteral(" Floors</h4>\r\n    <h5>Next Floor: <b id=\"newroom\">");
            EndContext();
            BeginContext(425, 7, false);
#line 17 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\RoomNumberPartialView.cshtml"
                               Write(newRoom);

#line default
#line hidden
            EndContext();
            BeginContext(432, 11, true);
            WriteLiteral("</b></h5>\r\n");
            EndContext();
#line 18 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\RoomNumberPartialView.cshtml"
     if (ViewBag.LevelExist == false)
    {

#line default
#line hidden
            BeginContext(489, 54, true);
            WriteLiteral("        <h5>You have not entered this room yet!</h5>\r\n");
            EndContext();
#line 21 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\RoomNumberPartialView.cshtml"
        if (newRoom == 0)
        {

#line default
#line hidden
            BeginContext(581, 75, true);
            WriteLiteral("            <h3>This is Ground Zero! <br /> Short Rest and Reroll...</h3>\r\n");
            EndContext();
#line 24 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\RoomNumberPartialView.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(691, 58, true);
            WriteLiteral("        <h5>YOU HAVE ALREADY BEEN HERE!</h5>\r\n        <h5>");
            EndContext();
            BeginContext(750, 12, false);
#line 29 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\RoomNumberPartialView.cshtml"
       Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(762, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 30 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\RoomNumberPartialView.cshtml"

    }

#line default
#line hidden
#line 31 "C:\Users\seang\source\repos\The Tower App\TheTower\Views\Shared\RoomNumberPartialView.cshtml"
     




}

#line default
#line hidden
            BeginContext(789, 575, true);
            WriteLiteral(@"
<script>
    $(document).ready(function () {


   /*  $(""#btnSubmitRoom"").click(function () {
            $.ajax({
                type: ""POST"",
                url: 'Url.Action(""SubmitRoom"", ""Levels"")',
                contentType: ""application/json; charset=utf-8"",
                data: { id: ""ViewBag.CSessionID"" , newRoom : ""newRoom"" },
                dataType: ""json"",
                success: function () { alert('Success'); },
                error: function () { alert('Error'); },
                
            });
        });
    });*/
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoomRoll>> Html { get; private set; }
    }
}
#pragma warning restore 1591
