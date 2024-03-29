#pragma checksum "C:\Users\playn\source\repos\IbaraStatistics\Pages\IbaraStats.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35428d9deb8832a5eb726213764c522b4b3d6bc1"
// <auto-generated/>
#pragma warning disable 1591
namespace IbaraStatistics.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\playn\source\repos\IbaraStatistics\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\playn\source\repos\IbaraStatistics\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\playn\source\repos\IbaraStatistics\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\playn\source\repos\IbaraStatistics\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\playn\source\repos\IbaraStatistics\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\playn\source\repos\IbaraStatistics\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\playn\source\repos\IbaraStatistics\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\playn\source\repos\IbaraStatistics\_Imports.razor"
using IbaraStatistics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\playn\source\repos\IbaraStatistics\_Imports.razor"
using IbaraStatistics.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\playn\source\repos\IbaraStatistics\Pages\IbaraStats.razor"
using IbaraStatistics.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/IbaraStats")]
    public class IbaraStats : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>キャラクターステータス</h3>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\playn\source\repos\IbaraStatistics\Pages\IbaraStats.razor"
 if (workIbaraCharacterStats == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 12 "C:\Users\playn\source\repos\IbaraStatistics\Pages\IbaraStats.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Eno</th>\r\n                <th>CharacterName</th>\r\n                <th>Extraordinary</th>\r\n                <th>Item</th>\r\n                <th>Skill</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 27 "C:\Users\playn\source\repos\IbaraStatistics\Pages\IbaraStats.razor"
                     workIbaraCharacterStats.Eno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 28 "C:\Users\playn\source\repos\IbaraStatistics\Pages\IbaraStats.razor"
                     workIbaraCharacterStats.CharacterName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 29 "C:\Users\playn\source\repos\IbaraStatistics\Pages\IbaraStats.razor"
                     string.Join(", ", workIbaraCharacterStats.Extraordinary)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 30 "C:\Users\playn\source\repos\IbaraStatistics\Pages\IbaraStats.razor"
                     string.Join(", ", workIbaraCharacterStats.Item)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 31 "C:\Users\playn\source\repos\IbaraStatistics\Pages\IbaraStats.razor"
                     string.Join(", ", workIbaraCharacterStats.Skill)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 35 "C:\Users\playn\source\repos\IbaraStatistics\Pages\IbaraStats.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\playn\source\repos\IbaraStatistics\Pages\IbaraStats.razor"
       
    CharacterStats workIbaraCharacterStats = null;

    protected override async Task OnInitializedAsync()
    {
        var url = @"C:\Users\playn\source\repos\IbaraStatistics\html\[989] ソーンブラウン＝バレッタ－.html";
        workIbaraCharacterStats = await CharacterStatsService.GetCharacterStats_Pejuta(url);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CharacterStatsService CharacterStatsService { get; set; }
    }
}
#pragma warning restore 1591
