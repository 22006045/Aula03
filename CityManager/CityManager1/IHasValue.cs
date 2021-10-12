using System;
using System.Collections.Generic;
namespace CityManager1
{
    public interface IHasValue : IEquatable<IHasValue>
    {
        float Value{ get; }
    }
}