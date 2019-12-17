using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype {
    class Client {

        public Client() {
            ThunderStormCarPrototype thunderPrototype = new ThunderStormCarPrototype();

            PrototypeCar thunderNew = thunderPrototype.clone();
            thunderNew.setBuyCost(17000.00);
            PrototypeCar thunderOld = thunderPrototype.clone();
            thunderOld.setBuyCost(15000.00);

            Console.WriteLine(thunderNew.Show());
            Console.WriteLine(thunderOld.Show());

        }
    }
}
