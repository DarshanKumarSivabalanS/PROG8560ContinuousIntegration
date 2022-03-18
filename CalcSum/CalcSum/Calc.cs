using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalcSum
{
    //this class is our ViewModel
    //we really don't have a Model layer, because we don't have a database
    class Calc : INotifyPropertyChanged
    {
        //private variables -- cannot be seen outside this class
        int _operand1;
        int _operand2;
        int _result;

        //public Property
        public int Operand1
        {
            //return the private variable when asked
            get { return _operand1; }
            //set the private variable, and let anyone listening know it was changed
            set { _operand1 = value;  NotifyPropertyChanged(); }
        }

        //public Property
        public int Operand2
        {
            get { return _operand2; }
            set { _operand2 = value; NotifyPropertyChanged(); }
        }

        public int Result
        {
            get { return _result; }
            set { _result = value; NotifyPropertyChanged(); }
        }

        //a public method -- someone outside this class may call this method
        public void Add()
        {
            Result = _operand1 + _operand2;
        }

        #region PropertyChangedImplementation
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
