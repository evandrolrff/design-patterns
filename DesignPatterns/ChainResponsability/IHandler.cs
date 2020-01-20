using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainResponsability {

    // The Handler interface declares a method for building the chain of
    // handlers. It also declares a method for executing a request.
    interface IHandler {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }
}
