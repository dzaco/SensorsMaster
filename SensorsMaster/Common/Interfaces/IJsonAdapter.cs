using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Common.Interfaces
{
    public interface IJsonAdapter<TResult>
    {
        TResult Convert();
    }
}
