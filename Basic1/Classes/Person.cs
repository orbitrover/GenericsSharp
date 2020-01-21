﻿using System.Collections.Generic;
using Basic1.Interfaces;

namespace Basic1.Classes
{
    public class Person : IAnimal
    {
        public string Speak() => "Hello";
        public string Name { get; set; }
        public string Information { get; set; }

        protected bool Equals(Person other)
        {
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person) obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }



    }
}
