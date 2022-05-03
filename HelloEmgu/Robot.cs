using System;
using System.IO.Ports;

namespace HelloEmgu
{
    public class Robot
    {
        public const byte FASTLEFT = (byte)'Z';
        public const byte MEDIUMLEFT = (byte)'X';
        public const byte SLOWLEFT = (byte)'C';
        public const byte STRAIGHT = (byte)'V';
        public const byte SLOWRIGHT = (byte)'B';
        public const byte MEDIUMRIGHT = (byte)'N';
        public const byte FASTRIGHT = (byte)'M';
        public const byte STOP = (byte)'S';

        SerialPort _serialPort;
        public bool Online { get; private set; }

        public Robot(String port)
        {
            SetupSerialComms(port);
        }

        public void SetupSerialComms(String port)
        {
            try
            {
                _serialPort = new SerialPort(port);
                _serialPort.BaudRate = 9600;
                _serialPort.DataBits = 8;
                _serialPort.Parity = Parity.None;
                _serialPort.StopBits = StopBits.Two;
                _serialPort.Open();
                Online = true;
                Console.WriteLine("Serial Port open.");
            }
            catch
            {
                Online = false;
            }
        }
        public void Move(byte motion)
        {
            try
            {
                if (Online)
                {
                    Console.WriteLine("Online.");
                    byte[] buffer = { motion };
                    _serialPort.Write(buffer, 0, 1);
                    Console.WriteLine("Byte sent.");
                }
            }
            catch
            {
                Online = false;
            }
        }
    }
}