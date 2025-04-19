using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventor;

namespace InventorAutomationProject
{
    public static class Console
    {
        public static Action<string> LogAction;

        public static void Log(string message)
        {
            LogAction?.Invoke($"[{DateTime.Now:HH:mm:ss}] {message}");
        }


    }

}
