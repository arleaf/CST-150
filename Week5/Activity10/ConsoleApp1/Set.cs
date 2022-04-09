using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Set
    {
        private List<int> elements;
        public Set()
        {
            elements = new List<int>();
        }
        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val); 
                return true; 
            }
        }
        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                else
                    //Loop will only execute once. Only checking elements[0]
                    // return false;
                    continue;
            }
            return false;
        }
        public override string ToString()
        { 
            string str = ""; 
            foreach (int i in elements) 
            { 
                str += i + " "; 
            } return str; 
        }
        public void clearSet()
        { 
            elements.Clear(); 
        }
        public Set union(Set rhs) 
        {
            //Creating new set in order to create union and not modify orginal sets A & B
            Set union = new Set();
            //Copying Set A to union set
            foreach(int item in this.elements)
            {
                union.elements.Add(item);
            }
            for (int i = 0; i < rhs.elements.Count; i++) 
            {
                //Will add elements to Set A. Instead we will use union as to not change orignal set
                //this.addElement( rhs.elements[ i ] );
                union.addElement(rhs.elements[i]);
            } 
            // Returning set B instead of new union set.
            //return rhs;
            return union; 
        }
    }
}
