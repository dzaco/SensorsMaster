using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Common.Exceptions
{
    public class SettingsExeption : Exception
    {
        public SettingsExeption(string message) : base(message)
        {
        }
    }
}
