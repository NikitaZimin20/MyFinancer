using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinancer.ViewModels;

namespace MyFinancer.Stores
{
    internal class NavigationStore
    {
        public event Action CurrentViewModelChanged;
        private ViewModelBase _curentviewmodel;
        public ViewModelBase CurrentViewModel
        {
            get { return _curentviewmodel; }
            set { _curentviewmodel = value;
                OnCurrentViewModelChanged(); }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
