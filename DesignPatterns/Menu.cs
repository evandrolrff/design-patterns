using System;

namespace DesignPatterns
{
    class Menu
    {
        private int menu;
        public Menu()
        {
            this.ExibeMenu();
        }
        public void ExibeMenu()
        {
            Console.WriteLine("Selecione um tipo:");
            Console.WriteLine("1 - Criacao");
            Console.WriteLine("2 - Estrutura");
            Console.WriteLine("3 - Comportamento");
            Console.Write("Valor => ");
            this.menu = int.Parse(Console.ReadLine());
        }
        public void SubMenu()
        {
            switch (this.menu)
            {
                case 1:
                    Console.WriteLine("1 - Factory Method");
                    Console.WriteLine("2 - Abstract Factory");
                    Console.WriteLine("3 - Builder");
                    Console.WriteLine("4 - Prototype");
                    Console.WriteLine("5 - Singleton");
                    break;
                case 2:
                    Console.WriteLine("1 - Class Adapter");
                    Console.WriteLine("2 - Object Adapter");
                    Console.WriteLine("3 - Bridge");
                    Console.WriteLine("4 - Composite");
                    Console.WriteLine("5 - Decorator");
                    Console.WriteLine("6 - Facade");
                    Console.WriteLine("7 - Flyweight");
                    Console.WriteLine("8 - Proxy");
                    break;
                case 3:
                    Console.WriteLine("1 - Interpreter");
                    Console.WriteLine("2 - Template Method");
                    Console.WriteLine("3 - Chain of Responsability");
                    Console.WriteLine("4 - Command");
                    Console.WriteLine("5 - Iterator");
                    Console.WriteLine("6 - Mediator");
                    Console.WriteLine("7 - Memento");
                    Console.WriteLine("8 - Observer");
                    Console.WriteLine("9 - State");
                    Console.WriteLine("10 - Strategy");
                    Console.WriteLine("11 - Visitor");
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }
    }
}
