using System;

namespace UsingOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "GARRRR";
            bool marker;
            string murmur = Whisper(statement, out marker);
            Console.WriteLine(murmur);
        }

        static string Whisper(string phrase, out bool wasWhisperCalled)
        {
            wasWhisperCalled = true;
            return phrase.ToLower();
        }
    }
}