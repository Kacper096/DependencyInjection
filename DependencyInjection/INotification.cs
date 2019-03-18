using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    interface INotification
    {
        void ActOnNotification(string message);
    }
}
