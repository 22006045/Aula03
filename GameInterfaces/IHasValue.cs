using System;
using System.Collections.Generic;
namespace GameInterfaces
{
    public interface IHasValue : IEquatable<IHasValue>
    {
        float Value{ get; }
    }
}