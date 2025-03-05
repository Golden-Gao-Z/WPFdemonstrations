using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindCommandToComboBoxItemViaControlTemplate.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        private readonly ICustomerStoreService _customerStore;

        public MainWindowViewModel(ICustomerStoreService customerStore)
        {
            this._customerStore = customerStore;
            this._selectedCustomer = string.Empty;
            this._clickCMBBItemCommand = new DelegateCommand<object>(ClickCMBBItem);
            this.Customers.Clear();
            this.Customers.AddRange(this._customerStore.GetAll());
        }


        public ObservableCollection<string> Customers { get; private set; } = [];


        private string _selectedCustomer;
        public string SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                if (SetProperty<string>(ref _selectedCustomer, value))
                {
                    Debug.WriteLine(_selectedCustomer ?? "no customer selected");
                }
            }
        }

        private readonly DelegateCommand<object> _clickCMBBItemCommand;
        public DelegateCommand<object> ClickCMBBItemCommand => this._clickCMBBItemCommand;

        private void ClickCMBBItem(object content)
        {
            Debug.WriteLine($"item click. [{content}]");
        }
    }
}
