using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_Hamilton_Dakota
{
    class Car
    {
        // Private string variable
        private string model;
        // Protected variable string
        public string Model { get { return model; } set { model = value; }  }
        // Automatic Property
        public string Make { get; set; }

    }
}
