using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite {
    class Client {
        public Client() {
            Program program = new Program();

            // This way the client code can support the simple leaf
            // components...
            Leaf leaf = new Leaf();
            Console.WriteLine("Program: I get a simple component:");
            program.ProgramCode(leaf);

            // ...as well as the complex composites.
            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Program: Now I've got a composite tree:");
            program.ProgramCode(tree);

            Console.Write("Program: I don't need to check the components classes even when managing the tree:\n");
            program.ProgramCode2(tree, leaf);
        }
    }
}
