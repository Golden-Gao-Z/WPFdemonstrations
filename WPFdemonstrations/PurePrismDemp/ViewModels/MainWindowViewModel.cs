using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePrismDemp.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        private readonly ICustomerStoreService _customerStore;

        public MainWindowViewModel(ICustomerStoreService customerStore)
        {
            this._customerStore = customerStore;
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

        private DelegateCommand _commandLoad;
        public DelegateCommand CommandLoad => this._commandLoad ??= new DelegateCommand(CommandLoadExecute);

        private void CommandLoadExecute()
        {
            Customers.Clear();
            List<string> list = _customerStore.GetAll();
            foreach (string item in list)
                Customers.Add(item);
        }
    }
}
