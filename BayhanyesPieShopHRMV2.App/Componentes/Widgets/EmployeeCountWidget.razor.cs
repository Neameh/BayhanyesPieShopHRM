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
using BethanysPieShopHRM.App.Models;

namespace BayhanyesPieShopHRMV2.App.Componentes.Widgets
{
    public partial class EmployeeCountWidget
    {
        [Parameter]
        public int EmployeeCount { get; set; }
        protected override void OnInitialized()
        {
            EmployeeCount = MockDataService.Employees.Count();
        }
    }
}