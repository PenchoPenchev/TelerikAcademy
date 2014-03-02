/*16. * Create a class Group with properties GroupNumber and DepartmentName. 
 * Introduce a property Group in the Student class. 
 * Extract all students from "Mathematics" department. 
 * Use the Join operator.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Student
{
    public class Group
    {
        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        public Group(int groupNumber, string depName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = depName;
        }
    }
}
