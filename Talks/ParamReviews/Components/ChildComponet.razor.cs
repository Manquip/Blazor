using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParamReviews.Components
{
    public partial class ChildComponet
    {
        [Parameter]
        public string IdEmployee { get; set; }
    }
}
