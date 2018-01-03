using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentalSelect.Web.BL
{
    public static class StateHelper
    {
        public static IEnumerable<SelectListItem> StateList()
        {
            var items = new List<SelectListItem>
            {
                new SelectListItem() {Text = "Colorado", Value = "CO"},
                new SelectListItem() {Text = "Nevada", Value = "NV"},
                new SelectListItem() {Text = "New Mexico", Value = "NM"},
                new SelectListItem() {Text = "Utah", Value = "UT"},
                new SelectListItem() {Text = "Wyoming", Value = "WY"}
            };
            return items;
        }
    }
}