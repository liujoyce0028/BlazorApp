using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BlazorApp3.Data
{
    public class NumberViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _number = 101;

        public int number
        {
            get { return _number; }
            set
            {
                if (value != _number)
                {
                    _number = value;
                    NotifyPropertyChanged();

                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Number)));

                }
            }
        }


    }
}
