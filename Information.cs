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
            public string Name;
            public string Category;
            public string Structure;
            public string Definition;
            public Information() { }
            // Properties for the private fields 
            public string getName
            {
                get { return Name; }

            }

            public string getCategory

            {

                get { return Category; }

            }

            public string getStructure

            {

                get { return Structure; }

            }



            public string getDefinition

            {

                get { return Definition; }

            }



            public void setName(string newName)

            {

                Name = newName;



            }

            public void setCategory(string newCategory)

            {

                Category = newCategory;

            }

            public void setStructure(string newStructure)

            {

                Structure = newStructure;

            }



            public void setDefinition(string newDefinition)

            {

                Definition = newDefinition;

            }



            // IComparable implementation for sorting by Name 

            public int CompareTo(Information other)

            {

                return this.getName.CompareTo(other.getName);

            }

        }

    }



}
