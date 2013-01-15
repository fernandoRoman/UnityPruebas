using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ToborRising.Assets.Scripts.Utils
{
	public class Log
	{
        private static Log instance = null;
        private StreamWriter writer;
        
        private Log()
        {
            writer = new StreamWriter("log.txt");
        }

        public static Log getInstance()
        {
            if (instance == null)
                instance = new Log();
            return instance;
        }

        public void writeLine(string line)
        {
            writer.WriteLine(line);
            Console.WriteLine("Log: " + line);
        }
		
		public void close() 
		{
			writer.Close();
		}
	}
}
