#pragma checksum "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/Pages/Registrations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d00cfacbddf0d8884e40040d78690b659c24cc2"
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
    public partial class Registrations : RegistrationBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/Pages/Registrations.razor"
 if (@Ready)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __Blazor.MedLab_Demo1.Pages.Registrations.TypeInference.CreateCascadingValue_0(__builder, 1, 2, "AgencyServiceClient", 3, 
#nullable restore
#line 5 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/Pages/Registrations.razor"
                                                       AgencyServiceClient

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.AddMarkupContent(5, "\n        ");
                __builder2.AddContent(6, 
#nullable restore
#line 6 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/Pages/Registrations.razor"
         ChildContent

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(7, "\n    ");
            }
            );
            __builder.AddMarkupContent(8, "\n");
#nullable restore
#line 8 "/Users/jaredrussellworkman/Projects/MedLab_Demo1/MedLab_Demo1/Pages/Registrations.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.MedLab_Demo1.Pages.Registrations
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
