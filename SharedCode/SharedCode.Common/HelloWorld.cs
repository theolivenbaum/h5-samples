using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCode.Common
{
    //This code is shared between both .NET and h5 projects

    public static class HelloWorld
    {
        public static string SayHi()
        {
            var message = "Hello world!";

            //You can also use conditional compilation to have h5-specific code run
#if H5
            message += " from h5!";       
#else
            message += " from .NET!";
#endif
            
            return message;
        }
    }
}
