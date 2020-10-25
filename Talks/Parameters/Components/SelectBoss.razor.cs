using Microsoft.AspNetCore.Components;
using Parameters.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parameters.Components
{
    public partial class SelectBoss
    {
        [Parameter]
        public string BossId { get; set; }

        [Parameter]
        public EventCallback<string> BossIdChanged { get; set; }

        List<Employee> employees;

        protected override void OnInitialized()
        {
            employees = EmployeeBusiness.EmployeesList();
        }

        private async Task ChangeSelection(ChangeEventArgs e)
        {
            BossId = e.Value.ToString();
            await BossIdChanged.InvokeAsync(BossId);
        }
    }
}
