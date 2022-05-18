using DataAccess;
using MyFinancer.Commands;
using System;
using System.Windows;
using System.Windows.Input;


namespace MyFinancer.ViewModels
{
    internal class BalanceControllerViewModel : ViewModelBase
    {
        private string _sum;
        private string _reason;
        private DateTime _date=DateTime.Now;
        public string Sum
        {
            get { return _sum; }
            set
            {
                if (!string.Equals(_sum, value))
                {
                    _sum = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Reason
        {
            get { return _reason; }
            set
            {
                if (!string.Equals(_reason, value))
                {
                    _reason = value;
                    OnPropertyChanged();
                }

            }
        }
        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (!string.Equals(_date, value))
                {
                    _date = value;
                    OnPropertyChanged();
                }
            }
        }
        private SqlCrud _sql = new SqlCrud(ConnectionString.GetConnection());
        public ICommand TakeNoteCommand { get; set; }
        private bool CanExecuteTakeNoteCommand(object p) => true;
        private void OnExecuteTakeNoteCommand(object p)
        {
            try
            {
                _sql.AddBalance(decimal.Parse(_sum), _reason, _date);
                MessageBox.Show("Data was inserted");
            }
            catch (Exception)
            {

             MessageBox.Show("Fail to insert");
            }
           
        }
       
        public BalanceControllerViewModel()
        {
            TakeNoteCommand = new RelayCommand(OnExecuteTakeNoteCommand, CanExecuteTakeNoteCommand);
        }
    }
}
