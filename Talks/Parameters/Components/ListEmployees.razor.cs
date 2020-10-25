using Microsoft.AspNetCore.Components;
using Parameters.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parameters.Components
{
    public partial class ListEmployees
    {
        [Parameter]
        public string BossId { get; set; }

        [Parameter]
        public EventCallback<string> BossIdChanged { get; set; }


        private List<Employee> employees = new List<Employee>();

        private void EmployeeList()
        {
            employees = EmployeeBusiness.EmployeesByBoss(BossId);
        }

        protected override async Task OnInitializedAsync()
        {
            await BossIdChanged.InvokeAsync(BossId);
            employees = EmployeeBusiness.EmployeesByBoss(BossId);
        }
    }
}
