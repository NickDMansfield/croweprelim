using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public static class sharedActions
    {
        public static void writeMessage(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);
        }
    }
}