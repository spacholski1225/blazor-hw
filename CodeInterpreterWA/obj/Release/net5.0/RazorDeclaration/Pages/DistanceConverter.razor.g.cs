// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CodeInterpreterWA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bld\Downloads\BlazorWebAssembly-master\BlazorWebAssembly-master\CodeInterpreterWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bld\Downloads\BlazorWebAssembly-master\BlazorWebAssembly-master\CodeInterpreterWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bld\Downloads\BlazorWebAssembly-master\BlazorWebAssembly-master\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bld\Downloads\BlazorWebAssembly-master\BlazorWebAssembly-master\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bld\Downloads\BlazorWebAssembly-master\BlazorWebAssembly-master\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bld\Downloads\BlazorWebAssembly-master\BlazorWebAssembly-master\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bld\Downloads\BlazorWebAssembly-master\BlazorWebAssembly-master\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bld\Downloads\BlazorWebAssembly-master\BlazorWebAssembly-master\CodeInterpreterWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bld\Downloads\BlazorWebAssembly-master\BlazorWebAssembly-master\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bld\Downloads\BlazorWebAssembly-master\BlazorWebAssembly-master\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bld\Downloads\BlazorWebAssembly-master\BlazorWebAssembly-master\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA.Models;

#line default
#line hidden
#nullable disable
    public partial class DistanceConverter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\bld\Downloads\BlazorWebAssembly-master\BlazorWebAssembly-master\CodeInterpreterWA\Pages\DistanceConverter.razor"
       

    double? _inches = null;
    double? _meters = null;

    public double? Meters
    {
        get => _meters;
        set
        {
            _meters = value;
            ConvertDistance();
        }
    }

    private void ConvertDistance()
    {
        _inches = Meters / 0.0254d;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
