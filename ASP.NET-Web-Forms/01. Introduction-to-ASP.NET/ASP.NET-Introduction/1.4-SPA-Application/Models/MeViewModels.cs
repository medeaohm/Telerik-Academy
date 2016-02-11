using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _1._4_SPA_Application.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string Hometown
        {
            get; set;
        }
    }
}