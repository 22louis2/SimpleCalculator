using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalcLibrary
{
    public static class DIAdapter
    {
        public static ISimpleCalcRepository IAdapter { get; set; }

        public static void PlugAdapter()
        {
            SimpleCalcRepository adapter = new SimpleCalcRepository();
            IAdapter = adapter;
        }
    }
}
