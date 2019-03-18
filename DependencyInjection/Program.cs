using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {

            EventLog writer = new EventLog();
            EmailSender sender = new EmailSender();
            AppPoolWatcher watcher = new AppPoolWatcher();
            watcher.Notify(writer, "IIS przestał odpowiadać");
            //watcher.Notify(sender, "Wysyłanie wiadomości do Admina.");
        }
    }
}
