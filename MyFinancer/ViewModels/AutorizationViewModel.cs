using MyFinancer.Commands;
using MyFinancer.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFinancer.ViewModels
{
    internal class AutorizationViewModel:ViewModelBase
    {
        public ICommand TakeNoteCommand { get; set; }
        private bool CanExecuteTakeNoteCommand(object p) => true;
        private void OnExecuteTakeNoteCommand(object p)
        {
            

        }
        public ICommand NavigateMainCommand;
        public AutorizationViewModel(NavigationStore navigation)
        {
           
        }
    }
}
