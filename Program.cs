using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ArduinoWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Command format is com port, baud, string to be written
            SerialPort sPort = new SerialPort("COM" + args[0], int.Parse(args[1]), Parity.None, 8, StopBits.One);
            sPort.Open();
            sPort.Write(args[2]);
            sPort.Close();
        }
    }
}
