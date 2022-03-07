using System;

namespace DependencyInjectionDemo
{
    //constructor injection
    public interface i1
    {
        void Demo();
    }
    
    class child1:i1
    {
        public void Demo()
        {
            Console.WriteLine("Demo Function Called of child1 Class - Constructor Injection.");
        }
    }
    
    class child2 : i1
    {
        public void Demo()
        {
            Console.WriteLine("Demo Function Called of child2 Class - Constructor Injection.");
        }
    }

    public class constructorinjection
    {
        private i1 _i1;

        public constructorinjection(i1 _i1)
        {
            this._i1 = _i1;
        }
        public void Demo()
        {
            _i1.Demo();
        }
    }

    //property injection
    public interface i2
    {
        void DemoPropertyInjection(string message);
    }

    class LogWriterClass : i2
    {
        public void DemoPropertyInjection(string message)
        {
            Console.WriteLine("DemoPropertyInjection Method Called of LogWriterClass - Property Injection.");
        }
    }
    class LogWriterClass2 : i2
    {
        public void DemoPropertyInjection(string message)
        {
            Console.WriteLine("DemoPropertyInjection Method Called of LogWriterClass2 - Property Injection.");
        }
    }
    class PropertyInjectionClass
    {
        i2 _i2 = null;
        public void DemoPropertyInjectionFunctionOfClass(i2 _i2, string messages)
        {
            this._i2 = _i2;
            _i2.DemoPropertyInjection(messages);
        }
    }
    
    //region method injection
    public interface i3
    {
        void Demo3();
    }

    public class ServiceClass : i3
    {
        public void Demo3()
        {
            Console.WriteLine("Demo3 Method Overriding - Service Class.");
        }
    }


    public class ClientClass
    {
        private i3 _i3;
        public void ClientClassMethod(i3 _i3)
        {
            this._i3 = _i3;
            Console.WriteLine("Client Class Method Statement Called.");
            this._i3.Demo3();
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            //constructor injection
            constructorinjection cs = null;

            cs = new constructorinjection(new child1());
            cs.Demo();

            cs = new constructorinjection(new child2());
            cs.Demo();
          
            //property injection
            PropertyInjectionClass PIC = new PropertyInjectionClass();
            
           
            PIC.DemoPropertyInjectionFunctionOfClass(new LogWriterClass(), "Message - Property Value Passed.");
            PIC.DemoPropertyInjectionFunctionOfClass(new LogWriterClass2(), "Message - Property Value Passed.");
            
            //method injection
            ClientClass CCLS = new ClientClass();
            
            CCLS.ClientClassMethod(new ServiceClass());
            
            Console.ReadKey();
        }
    }
}
