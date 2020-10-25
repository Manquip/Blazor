using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParamReviews.Pages
{
    public partial class Index
    {
        [Parameter]
        public string IdEmployee { get; set; }
    }
}
