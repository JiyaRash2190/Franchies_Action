using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranchiesAction.Model
{
   public class PlayersModel 
    {
        private int randomNumber;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public int RandomNumber
        {
            get
            {
                return randomNumber;
            }
            set
            {
                randomNumber = value;
                OnPropertyChanged("RandomNumber");
            }
        }
    }
}
