using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korelskiy.BlazorTrainingApp.Pages
{
    public partial class Counter
    {
        [Inject] SingltonServices singlton { get; set; }
        [Inject] TransientServices transient { get; set; }
        private int currentCount = 0;
        private void IncrementCount()
        {
            currentCount++;

            singlton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}
