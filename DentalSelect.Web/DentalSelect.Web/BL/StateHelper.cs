using System.Collections.Generic;
using System.Web.Mvc;

namespace DentalSelect.Web.BL
{
    /// <summary>
    /// Helper class used to populate the State DropDown list
    /// </summary>
    public static class StateHelper
    {
        /// <summary>
        /// Gets the state list (only 5 as per spec)
        /// There are many ways to do this, but this is simple and quick for test
        /// </summary>
        /// <returns>List of states</returns>
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