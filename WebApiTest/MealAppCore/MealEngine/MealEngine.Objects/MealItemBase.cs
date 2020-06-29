using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MealApplication.MealEngine.MealEngine.CoreEngine.Interfaces
{
    public abstract class MealItemBase
    {
        public abstract int SequenceNumber { get; set; }
        public abstract string MealItemName { get; set; }
        public abstract int OrderLimit { get; set; }
        public abstract int Quantity { get; set; }
        public abstract bool Error { get; set; }


    }
}
