using System;
using System.IO;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise4 : IExercise4
    {
        public object Method1()
        {
            MemoryStream memoryStream = new MemoryStream();

            using (StreamWriter streamWriter = new StreamWriter(memoryStream, leaveOpen: true))
            {
                streamWriter.WriteLine("Frohe Weihnachten");
                streamWriter.WriteLine("42");
                streamWriter.WriteLine("false");
                streamWriter.Flush();
            }

            memoryStream.Position = 0;
            return memoryStream;
        }

        public object Method2(object obj)
        {
            using (StreamReader streamReader = new StreamReader((Stream)obj))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();

                    if (int.TryParse(line, out int numVal))
                    {
                        Console.WriteLine($"Found num {numVal}");
                    }
                    else if (bool.TryParse(line, out bool boolVal))
                    {
                        Console.WriteLine($"Found num {boolVal}");
                    }
                    else
                    {
                        //found string
                        return line;
                    }
                }
            }

            return string.Empty;
        }
    }
}