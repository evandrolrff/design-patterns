using System;

namespace DesignPatterns {
    class Program {
        static string[] menu_options = new string[] {"Factory Method", "Abstract Factory", "Builder", "Prototype", "Singleton",
            "Adapter", "Bridge", "Composite", "Decorator", "Facade", "Flyweight", "Proxy", "Interpreter",
            "Template Method", "Chain of Responsability", "Command", "Iterator", "Mediator", "Memento", "Observer", "State",
            "Strategy", "Visitor"};

        private static void CheckOption(string option) {
            foreach (var item in menu_options) {
                if (item.ToLower().Equals(option) || item.ToLower().Contains(option)) {
                    switch (item) {
                        case "Factory Method":
                            new FactoryMethod.Client();
                            break;
                        case "Abstract Factory":
                            new AbstractFactory.Client();
                            break;
                        case "Builder":
                            new Builder.Client();
                            break;
                        case "Prototype":
                            new Prototype.Client();
                            break;
                        case "Singleton":
                            new Singleton.Client();
                            break;
                        case "Adapter":
                            new Adapter.Client();
                            break;
                        case "Bridge":
                            new Bridge.Client();
                            break;
                        case "Composite":
                            new Composite.Client();
                            break;
                        case "Decorator":
                            new Decorator.Client();
                            break;
                        case "Facade":
                            new Facade.Client();
                            break;
                        case "Flyweight":
                            new Flyweight.Client();
                            break;
                        case "Proxy":
                            new Proxy.Client();
                            break;
                        case "Interpreter":
                            break;
                        case "Template Method":
                            break;
                        case "Chain of Responsability":
                            new ChainResponsability.Client();
                            break;
                        case "Command":
                            new Command.Client();
                            break;
                        case "Iterator":
                            break;
                        case "Mediator":
                            break;
                        case "Memento":
                            break;
                        case "Observer":
                            break;
                        case "State":
                            break;
                        case "Strategy":
                            break;
                        case "Visitor":
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                }
            }
        }

        static void Main() {
            Console.WriteLine("Design Patterns");

            for (int i = 0; i < menu_options.Length; i++)
                Console.WriteLine("\t {0}", menu_options[i]);

            try {
                Console.Write("\nSelect option => ");
                var option = (Console.ReadLine()).ToLower();
                CheckOption(option);
            } catch (Exception) {
                Console.WriteLine("Process fail");
            }
        }

    }
}
