#pragma checksum "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/Pages/Credential.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b897e5055d51d32fa524b6f108c0f61319b3a85"
// <auto-generated/>
#pragma warning disable 1591
namespace MedLab_Demo1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/_Imports.razor"
using MedLab_Demo1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/_Imports.razor"
using MedLab_Demo1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/credential/{verificationResponseId}")]
    public partial class Credential : CredentialBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-6");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.AddMarkupContent(6, "<h3>Verify your identity via Streetcred ID App</h3>\n        ");
            __builder.AddMarkupContent(7, "<p>Open your Streetcred ID app and select “scan code”.</p>\n        ");
            __builder.AddMarkupContent(8, "<p>Scan the code here to verify to the MedLab you are a person. Once this verification is valid, MedLab can send you credentials.</p>\n        ");
            __builder.AddMarkupContent(9, "<p>Click \"Continue\" once you\'ve verified you are a person.</p>\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "text-align: center;");
            __builder.AddMarkupContent(12, "\n");
#nullable restore
#line 11 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/Pages/Credential.razor"
             if(credentialContract != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenComponent<MedLab_Demo1.Shared.QrImage>(14);
            __builder.AddAttribute(15, "ImageData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/Pages/Credential.razor"
                                     credentialContract.OfferUrl

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\n");
#nullable restore
#line 14 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/Pages/Credential.razor"
            }
            else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                ");
            __builder.AddMarkupContent(18, "<p>If you haven\'t verified you are a person, the credential QR will not appear here.</p>\n");
#nullable restore
#line 17 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/Pages/Credential.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "   \n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n    ");
            __builder.AddMarkupContent(22, "<div class=\"col-sm-3\" style=\"text-align: center;\">\n        <img src=\"assets/Scan_Image.png\" width=\"300\">\n    </div>\n    ");
            __builder.AddMarkupContent(23, "<div class=\"col-sm-3\" style=\"text-align: center;\">\n        <img src=\"assets/Credential_Details.png\" width=\"300\">\n    </div>\n  ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
