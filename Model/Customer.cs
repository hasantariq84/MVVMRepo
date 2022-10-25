using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Model
{
    public class Customer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _firstName;
        private string _lastName;
        private string _amount;
        private bool _married;

        public int Amount{ get; set; }
        public string CustomerFirstName { get { return _firstName; }
        set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged("CustomerFirstName");
                    RaisePropertyChanged("CustomerFullName");

                }
            }
        }

        public string CustomerLastName {
            get
            {
                return _lastName;
            }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged("CustomerFullName");
                    RaisePropertyChanged("CustomerLastName");
                }
            }
        }

        public string CustomerFullName { get { return CustomerFirstName + " " + CustomerLastName; }  }
        public bool Married
        {
            get { return _married; }
            set
            {
                if (_married != value)
                {
                    _married = value;
                    RaisePropertyChanged("Married");
                }
            }
        }

        private double _Tax;

        

        public double Tax
        {
            get { return _Tax; }
        }

        public void CalculateTax()
        {
            if (Amount > 2000)
            {
                _Tax = 20;
                
            }
            else if (Amount > 1000)
            {
                _Tax = 10;
            }
            else
            {
                _Tax = 5;
            }

            RaisePropertyChanged("Tax");
        }

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}

