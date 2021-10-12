using System;
using System.Collections.Generic;
namespace CityManager1
{
    public class Building : IHasValue
    {
        private string type;
        private float area;

        public float Value {get;}
        public Building (string type, float value ,float area)
        {
            this.type = type;
            this.area = area;
            Value = value;
        }

        public override string ToString()
        {
            return $"{type, -20}, {Value, 8 :f2},{area, 8 :f2}";
        }

        public bool Equals(IHasValue other)
        {
            if(other == null) return false;
            return Value == other.Value;
        }
    }
}