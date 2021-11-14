using System;
using H5;
using H5.Core;
using static H5.Core.es5;
using static H5.Core.dom;
using LinkedCode.Common;

namespace LinkedCode.h5
{
    class Program
    {
        static void Main(string[] args)
        {
            var element = document.createElement("div");
            
            element.textContent = HelloWorld.SayHi();

            document.body.appendChild(element);
        }
    }
}
