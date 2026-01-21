using System;
using BerryAIGC.Common;
using System.Windows.Threading;

namespace BerryAIGC.Toolkit.Services
{
    public class NotificationService
    {
        public event EventHandler<string> Notify;

        public void SetNotification(string text)
        {
            Notify?.Invoke(this, text);
        }

        public void Toast(string copiedPathToClipboard)
        {
            throw new NotImplementedException();
        }
    }
}







