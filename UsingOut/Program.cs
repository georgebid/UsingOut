using System;

namespace UsingOut
{
    class Program
    {

        static void Main(string[] args)
        {
            // print the string statement, which then changes to lowercase
            string statement = "GARRR";
            // what is the need of this bool and why is it a new one?
            Console.WriteLine(Whisper(statement, out bool randomName));
        }
        // declare the method. and pass the string and bool. 
        static string Whisper(string statement, out bool iAmWhispering)
        {
            // changing the bool too false still prints the same thing... so what's the need for it to be true?
            iAmWhispering = true;
            return statement.ToLower();
        }
    }
}
