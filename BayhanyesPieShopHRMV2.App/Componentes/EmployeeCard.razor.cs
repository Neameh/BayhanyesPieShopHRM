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

namespace BayhanyesPieShopHRMV2.App.Componentes
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;
        [Parameter]
        public EventCallback<Employee> OnViewClicked { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
      

        public void NavigateTo(Employee employee)
        {
            NavigationManager.NavigateTo($"/employeedetails/{employee.EmployeeId}");
        }
        protected override void OnInitialized()
        {
            if(string.IsNullOrEmpty(Employee.LastName))
            {
                throw new Exception("Last name can not be empty");
            }
        }
    }
}