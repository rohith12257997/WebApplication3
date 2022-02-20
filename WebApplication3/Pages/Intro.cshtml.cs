using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;

namespace WebApplication3.Pages
{
    public class IntroModel : PageModel
    {

        public string Output { get; set; }
        public void OnGet()
        {
        }
        public void OnPostSubmit(Model numbers)
        {
            if (numbers.NumberInput1 != null && numbers.NumberInput2 != null)
            {
                this.Output = string.Format("First number: {0} \n Second number: {1}", numbers.NumberInput1, numbers.NumberInput2);
            }
            else
            {
                this.Output = string.Empty;
            }
        }
    }
} 