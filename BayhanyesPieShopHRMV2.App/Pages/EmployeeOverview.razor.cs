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
using BethanysPieShopHRM.Shared.Domain;
using BethanysPieShopHRM.App.Models;

namespace BayhanyesPieShopHRMV2.App.Pages
{
    public partial class EmployeeOverview
    {
        private List<Employee> Employees = new List<Employee>();
        private Employee? _selectedEmployee;
        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }
        private void ShowPopupView(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }

    }
}