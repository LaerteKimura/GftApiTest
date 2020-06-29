using MealApplication.MealEngine.MealEngine.CoreEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealApplication.MealEngine.MealEngine.Objects
{
    public class MealItem: MealItemBase
    {
      
        public override int SequenceNumber {
            get => _SequenceNumber;
            set => _SequenceNumber = value;
        }
     
        public override string MealItemName
        {
            get => _MealItemName;
            set => _MealItemName = value;
        }
        public override int Quantity
        {
            get => _Quantity;
            set {
                _Quantity = value;
                if (Quantity > OrderLimit){
                    Error = true;
                }
            }
        }
        public override int OrderLimit
        {
            get => _OrderLimit;
            set => _OrderLimit = value;
        }
        public override bool Error
        {
            get => _Error;
            set => _Error = value;
        }
        private int _SequenceNumber;
        private string _MealItemName;
        private int _Quantity;
        private int _OrderLimit;
        private bool _Error;
        
    }
}
