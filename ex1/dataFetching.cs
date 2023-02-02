using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interfaceImplementation
{
    interface IDataFetching
    {
        void convertDataType(string[] data);
        void fetchData();
    }
}