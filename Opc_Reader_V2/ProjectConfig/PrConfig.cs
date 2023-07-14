using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opc_Reader_V2.ProjectConfig
{
    public static class PrConfig
    {
        public static string opcIP6 = "opc.tcp://192.168.1.84:56000";
        public static string opcIP10 = "opc.tcp://192.168.1.82:56000";
        public static string opcIP = opcIP6;

        public static string dbPath = @"OpcReaderDb";


    }
}
