using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OTAKURAO_wasm.Pages
{
    public partial class Index
    {
        private int currentCount = 0;

        public Index()
        {

        }

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
