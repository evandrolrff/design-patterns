using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter {
    class Adapter: ITarget {

        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee) {
            this._adaptee = adaptee;
        }

        public string GetRequest() {
            return string.Format("This is {0}", this._adaptee.GetSpecificRequest());
        }
    }
}
