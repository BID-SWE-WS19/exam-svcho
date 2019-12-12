using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise5 : IExercise5
    {
       
        public object Method1(string str, int i)
        {
            List<string> list = new List<string>();

            int byteCount = 0;
            byte[] bytes = new byte[256];

            Socket clientSocket = new Socket(AddressFamily.InterNetwork,
        SocketType.Stream,
        ProtocolType.Tcp);

            clientSocket.Connect(str, i);

            byteCount = clientSocket.Receive(bytes, 0, clientSocket.Available,
                                   SocketFlags.None);

            if (byteCount > 0)
            {
                string[] receivedLines = Encoding.UTF8.GetString(bytes, 0, bytes.Length).Split("\n");

                foreach (string line in receivedLines)
                {
                    list.Add(line);
                }
            }

            return list;
        }
    }
}