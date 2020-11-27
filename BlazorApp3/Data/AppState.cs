using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BlazorApp3.Data
{
    public class AppState : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //public event Action OnChange;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //private string color;

        //public string getColor
        //{
        //    get { return color; }
        //    set
        //    {
        //        if (value != color)
        //        {
        //            color = value;
        //            NotifyPropertyChanged();
        //        }
        //    }
        //}
    }
}
