#pragma checksum "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\CustomComponents\Buttons\BaseButtonComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "882507ba7ecf49194ae2afcd27911ed9d6a79674"
// <auto-generated/>
#pragma warning disable 1591
namespace MealOrder.Client.CustomComponents.Buttons
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using MealOrder.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using MealOrder.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using MealOrder.Client.CustomComponents.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using MealOrder.Client.CustomComponents.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\_Imports.razor"
using MealOrder.Client.Utils;

#line default
#line hidden
#nullable disable
    public partial class BaseButtonComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 1 "C:\Users\Safak\RiderProjects\MealOrder\MealOrder\Client\CustomComponents\Buttons\BaseButtonComponent.razor"
       
    [Parameter]
    public string Caption { get; set; }
    
    [Parameter]
    public string Color { get; set; }
    
    [Parameter]
    public string Icon { get; set; }
    
    [Parameter]
    public string TooltipStr { get; set; }
    
    [Parameter]
    public bool IsOutline { get; set; }
    
    [Parameter]
    public bool IsBusy { get; set; }
    
    [Parameter]
    public bool IsBusyCaption { get; set; }
    
    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
