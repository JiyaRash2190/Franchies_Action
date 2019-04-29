using System;
using FranchiesAction.Model;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace FranchiesAction.ViewModel
{
    //connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=fantacyLeague_db;Integrated Security=SSPI;"
    public class PlayerViewModel : BindableBase
    {
        private ICommand randomNumberCommand { get; set; }

        public PlayerViewModel()
        {

        }

        public int X
        {
            get { return _x; }
            set
            {
                SetProperty(ref _x, value);
                OnPropertyChanged(() => Z);
            }
        }
        public ICommand RandomNumberCommand
        {
            get
            {
                return randomNumberCommand;
            }
            set
            {
                randomNumberCommand = value;
                OnPropertyChanged("RandomNumber");
            }
        }

    }


    
}
   
