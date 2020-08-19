using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalcLibrary
{
    public static class DIAdapter
    {
        // Interface property
        public static ISimpleCalcRepository IAdapter { get; set; }

        public static void PlugAdapter()
        {
            // Initializing my Calculator Methods
            SimpleCalcRepository adapter = new SimpleCalcRepository();
            // Assigning it to the Interface Property
            IAdapter = adapter;
        }
    }
}
