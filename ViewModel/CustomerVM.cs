using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Model;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace MVVM_ViewModel
{
    public class CustomerVM
    {

        //public ObservableCollection<Customer> obj = new ObservableCollection<Customer>();

        public CustomerVM()
        {
            LoadCustomers();
        }

        public ObservableCollection<Customer> CustomerList
        {
            get; set;
        }

        public void LoadCustomers ()
        {
            ObservableCollection<Customer> custObj = new ObservableCollection<Customer>();

            custObj.Add(new Customer { CustomerFirstName = "Hassan", CustomerLastName = "Tariq", Amount = 30000, Married = true });
            custObj.Add(new Customer { CustomerFirstName = "Ali", CustomerLastName = "Tufail", Amount = 200, Married = false });
            custObj.Add(new Customer { CustomerFirstName = "Akram", CustomerLastName = "Rahi", Amount = 50000, Married = true });
            custObj.Add(new Customer { CustomerFirstName = "Suriya", CustomerLastName = "Bajiya", Amount = 400, Married = false});
            custObj.Add(new Customer { CustomerFirstName = "Sana", CustomerLastName = "Tahir", Amount = 5000, Married = false });

            CustomerList = custObj;
        }

        
    }


}
