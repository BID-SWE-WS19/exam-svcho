using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    //Aufgabe: Socket verbindung zu einem vorhandenen Server erstellen und jede zeile an strings empfangen und in eine Liste geben und die Liste returnen
    public class Exercise5 : IExercise5
    {
       
        public object Method1(string str, int i)
        {
            List<string> list = new List<string>();

            var client = new TcpClient();
            client.Connect(str, i);

            var stream = client.GetStream();

            using (StreamReader streamReader = new StreamReader(stream))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    list.Add(line);
                }
            }

            client.Close();

            return list;
        }
    }
}