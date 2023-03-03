using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable
{
    using System;

    namespace wiki
    {
        class Information : IComparable<Information>
        {
            // Private fields for data structure
            private string name;
            private string category;
            private string structure;
            private string definition;

            // Properties for the private fields
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Category
            {
                get { return category; }
                set { category = value; }
            }

            public string Structure
            {
                get { return structure; }
                set { structure = value; }
            }

            public string Definition
            {
                get { return definition; }
                set { definition = value; }
            }

            // IComparable implementation for sorting by Name
            public int CompareTo(Information other)
            {
                return this.Name.CompareTo(other.Name);
            }
        }
    }

}
