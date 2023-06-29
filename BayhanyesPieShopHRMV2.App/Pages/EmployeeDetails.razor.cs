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
using BethanysPieShopHRM.App.Models;

namespace BayhanyesPieShopHRMV2.App.Pages
{
    public partial class EmployeeDetails
    {
        [Parameter]
        public Employee? Employee { get; set; }
        [Parameter]
        public string EmployeeId { get; set; }
        protected override Task OnInitializedAsync()
        {
            Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));
            return base.OnInitializedAsync();
        }
    }
}