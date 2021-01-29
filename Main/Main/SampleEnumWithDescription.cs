using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using System.ComponentModel.DataAnnotations;

namespace Main
{
    public enum SampleEnumWithDescription
    {
        [Display(Description = "First")]
        One,
        [Display(Description = "Second")]
        Two,
        [Display(Description = "Third")]
        Three
    }
}