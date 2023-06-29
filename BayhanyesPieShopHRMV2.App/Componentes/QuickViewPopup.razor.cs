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
using BethanysPieShopHRM.Shared.Domain;

namespace BayhanyesPieShopHRMV2.App.Componentes
{
    public partial class QuickViewPopup
    {
        [Parameter]
        public Employee? Employee { get; set; }
        private Employee? _employee;

        protected override void OnParametersSet()
        {
            _employee = Employee;
        }
        public void Close()
        {
            _employee = null;
        }
    }
}