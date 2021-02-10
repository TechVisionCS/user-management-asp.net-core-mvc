using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Utilities
{
    public static class DropDownListUtility
    {
        public static IEnumerable<SelectListItem> GetExpenseList(object selectedValue)
        {
            return new List<SelectListItem>
        {
            new SelectListItem{ Text="Select Expense Type", Value = "1", Selected = "1" == selectedValue.ToString()},
            new SelectListItem{ Text="Office Expense", Value = "2", Selected = "2" == selectedValue.ToString()},
            new SelectListItem{ Text="Kitchen Expense", Value = "3", Selected = "3" == selectedValue.ToString()},
            new SelectListItem{ Text="Lib Expense", Value = "4", Selected = "4" == selectedValue.ToString()},
        };
        }
    }
}
