﻿/*4. Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.
*/

namespace CommonTypeSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class test
    {
        public string str { get; set; }
    }

    public class MainClass
    {
        Person virusa = new Person("Virusa", 26);
        Person someone = new Person("Someone");
    }
}
