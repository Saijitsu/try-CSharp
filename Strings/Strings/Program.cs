﻿using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Nicolas"; //class.System.String
           // String lastname = "T";
           var lastName = "T";

           var fullName = firstName + " " + lastName;
           Console.WriteLine(fullName);
           var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
           Console.WriteLine(myFullName);

           var names = new string[3] {"Nicolas", "Michel", "Julio"};
           var formattedNames = string.Join(", ", names);
           Console.WriteLine(formattedNames);

           //Verbatim string
           var text = @"Hello Johnny,
Look the following paths:
c:\fakefolder\folderultrafake\file1
Have a nice day!";
           Console.WriteLine(text);
        }
    }
}
