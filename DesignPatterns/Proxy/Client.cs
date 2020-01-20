using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy {
    class Client {
        public Client() {
            Program program = new Program();

            Console.WriteLine("Program: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            program.ProgramCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Program: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            program.ProgramCode(proxy);
        }
    }
}
