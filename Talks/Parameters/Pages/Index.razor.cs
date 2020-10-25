using Microsoft.AspNetCore.Components;
using Parameters.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parameters.Pages
{
    public partial class Index
    {
        [Parameter]
        public string BossId { get; set; }        
    }
}
