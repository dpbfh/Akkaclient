// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Akkaclient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\_Imports.razor"
using Akkaclient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\_Imports.razor"
using Akkaclient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\Pages\FetchFridge.razor"
using Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\Pages\FetchFridge.razor"
using AkkaClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\Pages\FetchFridge.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/smartfridge")]
    public partial class FetchFridge : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\domin\Downloads\akka-quickstart-java\CSharpClient\Akkaclient\Pages\FetchFridge.razor"
       
    private System.Collections.Generic.ICollection<ProductDto> state;
    private Temperature tempunit;
    private double temperatur;

     protected override async Task OnInitializedAsync()
    {
        getFridgeState();
    }

    public void getFridgeState(){
       state = fridgeService.getInventory().GetAwaiter().GetResult();
    }

    public void consumeProduct(ProductDto dto){
        var x =   fridgeService.consumeProduct(dto).GetAwaiter().GetResult();
        getFridgeState();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Fridgeservice fridgeService { get; set; }
    }
}
#pragma warning restore 1591