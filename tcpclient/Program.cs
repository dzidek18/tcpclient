using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
namespace tcpclient
{
    class Program
    {
        static void Main(string[] args)
        {


            TcpClient client = new TcpClient("62.75.224.28", 6789);
            int a = 0;
            try
            {//bla bla bla bla bla
                Stream s = client.GetStream();
                StreamReader sr = new StreamReader(s);
                StreamWriter sw = new StreamWriter(s);
                sw.AutoFlush = true;
                string ret;
                while (true)
                {
                    so what happens now?
                    //
                }
                s.Close();
            }
            finally
            {
                // code in finally block is guranteed 
                // to execute irrespective of 
                // whether any exception occurs or does 
                // not occur in the try block
                client.Close();
            } 


        }
    }
}
