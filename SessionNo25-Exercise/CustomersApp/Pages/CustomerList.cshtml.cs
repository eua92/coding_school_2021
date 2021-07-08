using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customers.Model;
using CustomersApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomersApp.Pages
{
    public class CustomerListModel : PageModel
    {

        public List<Customer> Customers = new List<Customer>();

        private IItemStorage _storage { get; set; }

        public CustomerListModel(IItemStorage storage)
        {
            _storage = storage;
        }

        public void OnGet()
        {
            Customers = _storage.GetAllCustomers();
        }
    }
}
