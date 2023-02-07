using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceObject
{
    public interface IDataProcessor
    {
        void showInformation();
    }

    public interface IDataInput
    {
        void Input();
    }

    public interface IDataParsing
    {
        void Parsing();
    }
}
