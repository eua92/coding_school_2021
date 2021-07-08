using Customers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersApp.Services
{
    public interface IItemStorage
    {
        public void AddCustomer(Customer customer);
        public void RemoveCustomer(int id);
        public List<Customer> GetAllCustomers();
        public Customer GetById(int id);
    }

    public class MemoryCustomerStorage : IItemStorage
    {
        private List<Customer> innerList { get; set; }

        public MemoryCustomerStorage()
        {
            innerList = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            if (customer.Id == 0)
            {
                customer.Id = innerList.Count + 1;
                innerList.Add(customer);
                return;
            }

            var selectedCustomer = GetById(customer.Id);
            selectedCustomer.Name = customer.Name;
            selectedCustomer.Surname = customer.Surname;
            selectedCustomer.AFM = customer.AFM;
            selectedCustomer.Active = customer.Active;
        }

        public List<Customer> GetAllCustomers()
        {
            return innerList;
        }

        public Customer GetById(int id)
        {
            return innerList.FirstOrDefault(customer => customer.Id == id);
        }

        public void RemoveCustomer(int id)
        {
            var selectedCustomer = GetById(id);
            if (selectedCustomer == null)
                throw new Exception(string.Format("Customer with id '{0}' was not found.", id));

            innerList.Remove(selectedCustomer);
        }
    }
}
