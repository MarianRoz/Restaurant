using System;

namespace Restaurant
{
    public class FoodReadyEventArgs : EventArgs
    {
        public IFood Food { get; set; }
    }
}
