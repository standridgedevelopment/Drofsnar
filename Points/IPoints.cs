using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar
{
    public interface IPoints
    {
        string Name { get; }
        int Value { get; }
        string ID { get; }
    }
}
