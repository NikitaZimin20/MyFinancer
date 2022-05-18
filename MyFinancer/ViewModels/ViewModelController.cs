using MyFinancer.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancer.ViewModels
{
    internal class ViewModelController : ViewModelBase
    {
        NavigationStore _navigationStore;
        public ViewModelBase CurrentModel => _navigationStore.CurrentViewModel;
        public ViewModelController(NavigationStore navigationStore)
        {
            
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentModel));
        }

       
    }
}
