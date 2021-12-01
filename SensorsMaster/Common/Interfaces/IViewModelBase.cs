using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Common.Interfaces
{
    public interface IViewModelBase : INotifyPropertyChanged
    {
        void OnPropertyChanged(string propertyName);
        void OnPropertyChanged(Object o);
    }
}
