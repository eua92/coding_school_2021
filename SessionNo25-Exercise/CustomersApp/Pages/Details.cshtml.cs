using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Customers.Model;
using CustomersApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomersApp.Pages
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public Customer SelectedCustomer { get; set; }

        private IItemStorage _storage { get; set; }

        public DetailsModel(IItemStorage storage)
        {
            _storage = storage;
        }

        public void OnGet(int id)
        {
            if (id == 0)
            {
                SelectedCustomer = new Customer();
                return;
            }

            SelectedCustomer = _storage.GetById(id);
        }

        public IActionResult OnPost()
        {           
              _storage.AddCustomer(SelectedCustomer);

              return RedirectToPage("CustomerList");           
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("CustomerList");
        }

        public IActionResult OnPostDelete()
        {
            _storage.RemoveCustomer(SelectedCustomer.Id);
            return RedirectToPage("CustomerList");
        }
    }
}
