using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Generic
{
    internal class Part : IEquatable<Part>
    {
        public string PartName { get; set; }
        public int PartId { get; set; }

        public override string ToString()
        {
            return "ID: " + PartId + " Name: " + PartName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part part = obj as Part;
            if (part == null) return false;
            return base.Equals(part);
        }
        public override int GetHashCode()
        {
            return PartId;
        }
        public bool Equals([AllowNull] Part other)
        {
            if(other == null) return false;
            return(this.PartId.Equals(other.PartId));
        }
    }

    internal class ListClass
    {

    }
}
