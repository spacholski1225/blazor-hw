#pragma checksum "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\Pages\CaesarCipher.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29219b2af713db025eda7ee303df837c91067a4e"
// <auto-generated/>
#pragma warning disable 1591
namespace CodeInterpreterWA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\Pages\CaesarCipher.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/caesarCipher")]
    public partial class CaesarCipher : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Caesar Cipher</h1>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddAttribute(3, "style", "height: 600px;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-6 h-100");
            __builder.OpenElement(6, "textarea");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "placeholder", "Enter text...");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\Pages\CaesarCipher.razor"
                                                                          EncryptText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EncryptText = __value, EncryptText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        <br>\n        ");
            __builder.AddMarkupContent(12, "<label>Number of shift letters</label>\n        <br>\n        ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "number");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "placeholder", "0");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\Pages\CaesarCipher.razor"
                                                                         ShiftValue

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ShiftValue = __value, ShiftValue, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n        <br>\n        <br>\n\n        ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-success");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\Pages\CaesarCipher.razor"
                                                  Encrypt

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<span class=\"oi oi-key\" aria-hidden=\"true\"></span> Decrypt\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "<br>");
#nullable restore
#line 19 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\Pages\CaesarCipher.razor"
         if (@_outputText != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row blockquote mt-5");
            __builder.OpenElement(27, "span");
            __builder.AddContent(28, "Result: ");
            __builder.AddContent(29, 
#nullable restore
#line 22 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\Pages\CaesarCipher.razor"
                               _outputText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\Pages\CaesarCipher.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\C#Projects\CodeInterpreter\CodeInterpreterWA\Pages\CaesarCipher.razor"
       

    string _inputText = string.Empty;
    private StringBuilder _outputText = new StringBuilder();
    int? _shiftValue = 0;

    public string EncryptText
    {
        get => _inputText;
        set
        {
            _inputText = value;
            Encrypt();
        }
    }

    public int? ShiftValue
    {
        get => _shiftValue;
        set
        {
            _shiftValue = value;
            _outputText.Clear();
            Encrypt();
        }
    }

    private void Encrypt()
    {
        _outputText.Clear();
        foreach (var sign in _inputText)
        {
            if (char.IsLetter(sign))
            {
                var ch = char.IsUpper(sign) ? 'A' : 'a';
                _outputText.Append((char)((((sign + _shiftValue) - ch) % 26) + ch));
            }
            else
            {
                _outputText.Append(sign);
            }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
