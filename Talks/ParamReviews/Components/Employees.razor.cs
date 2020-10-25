using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using ParamReviews.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParamReviews.Components
{
    public partial class Employees
    {
        [Parameter]
        public string IdEmployee { get; set; }

        [Parameter]
        public EventCallback<string> IdEmployeeChanged { get; set; }

        List<Employee> employees;

        protected override void OnInitialized()
        {
            employees = EmployeeBusiness.EmployeesList();
        }

        private async Task ChangeSelection(ChangeEventArgs e)
        {
            IdEmployee = e.Value.ToString();

            await IdEmployeeChanged.InvokeAsync(IdEmployee);
        }
    }
}
