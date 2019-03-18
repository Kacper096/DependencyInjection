using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class AppPoolWatcher
    {
        //Handler do którego zostanie przypisana akcja
        INotification action = null;
        public void Notify(INotification concreteaction, string message)
        {
            this.action = concreteaction;
            action.ActOnNotification(message);
        }
    }
}
