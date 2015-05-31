using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_l1
{
    public interface IPlugin
    {
        string NameOfShape { get; }
        Type ShapeType { get; }
        int pointV { get; }
    }
}
