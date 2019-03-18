using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DependencyInjection
{
    class EventLog : INotification
    {
        public void ActOnNotification(string message)
        {
            //zapis logów do dziennika
            Console.WriteLine("Zapisywanie do dziennika: {0}",message);
            WriteLogToFile(message);
        }
        private void WriteLogToFile(string message)
        {

            StringBuilder messageText = new StringBuilder("WARNING !" + Environment.NewLine).AppendLine(message);
            messageText.Append("Data i czas: ").Append(DateTime.Now + Environment.NewLine);

            using (FileStream fs = new FileStream("Logi.txt", FileMode.Append))
            {
                using (StreamWriter outputWriter = new StreamWriter(fs, Encoding.UTF8))
                {
                    outputWriter.WriteLine(messageText);
                    outputWriter.Close();
                }
                fs.Close();
            }
        }
    }
}
