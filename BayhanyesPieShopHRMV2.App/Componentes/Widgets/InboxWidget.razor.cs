using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using BayhanyesPieShopHRMV2.App;
using BayhanyesPieShopHRMV2.App.Shared;
using BayhanyesPieShopHRMV2.App.Componentes;

namespace BayhanyesPieShopHRMV2.App.Componentes.Widgets
{
    public partial class InboxWidget
    {
        public int MessageCount { get; set; }
        protected override void OnInitialized()
        {
            MessageCount = new Random().Next(10);

        }
    }
}