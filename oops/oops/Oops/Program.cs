using System;
namespace oops
{
    class classobjectdeepdemo
    {
        public int a;
    }

    struct structurereferencedeepdemo
    {
        public int a;
    }

    public class encapsulation
    {
        private int pr;
        internal int i;
        protected int prot;
        public int pu;
        protected internal int pi;
        private protected int pp;

        public envapsulation()
        {
            pr = 100;
        }
        public void accessibledemofun()
        {
            pr = 10;
            i = 20;
            prot = 30;
            pi = 40;
            pp = 50;


        }
    }
    class encapsulationandinheritancedemo:encapsulation
    {
        public void accessibledemofunofdirectchildclass()
        {
            i = 20;
            prot = 30;
            pi = 40;
            pp = 60;
        }
    }

    class encapsulationandinheritancedemosubchild: encapsulationandinheritancedemo
    {
        public void accessibledemofunofsubchildclass()
        {
            prot = 20;
            pi = 30;
            i = 20;
            pp = 60;
        }
    }

    class polymorphism_functionoverloading
    {
        public void demo()
        {
            Console.WriteLine("1st demo function in polymorphism_functionoverloading class- no return type, no parameter.");
        }
        public void demo(int a)
        {
            Console.WriteLine("1st demo function in polymorphism_functionoverloading class- no return type, one parameter.");
        }
        public void demo(int a,char b)
        {
            Console.WriteLine("1st demo function in polymorphism_functionoverloading class- no return type, two parameter.");
        }

    }
    class base_cls
    {
        public virtual void demofunction()
        {
            Console.WriteLine("Base_Cls Saying Hello!");
        }
        public void demofunction2()
        {
            Console.WriteLine("Base_Cls Saying Hello second time!");
        }
    }

    class derived_cls:base_cls
    {
        public override void demofunction()
        {
            base.demofunction();

            Console.WriteLine("Derived_cls saying hello!");
        }
        public void demofunction2()
        {
            Console.WriteLine("Derived_cls saying hello second time");
        }


    }
    class derived_sub_class:derived_cls
    {
        public override void demofunction()
        {
            base.demofunction();
            Console.WriteLine("Derived_sub_cls saying hello");
        }
        public void demofunction2()
        {
            Console.WriteLine("Derived_sub_cls saying hello second time");   
        }
    }
    abstract class parent_abscls
    {
        public void demoparentabsnormal_fun()
        {
            Console.WriteLine("Normal Method of Normal Class Named - Parent_AbsCls is called.");
        }
        public abstract void demoparentabsabstract_fun();
    }
    abstract class abstract_cls:parent_abscls
    {
        public abstract void demoabs_fun();
        public void demonormal_fun()
        {
            Console.WriteLine("Normal Method of Abstract Class Named - Abstract_CLS is called.");
        }
        public override void demoparentabsabstract_fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - Parent_AbsCls is called IN Abstract_CLS.");
        }
    }
    class childcls_absdemo:abstract_cls
    {
        public override void demoabs_fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - Abstract_CLS is called.");

        }
        public void demochildnormal_fun()
        {
            Console.WriteLine("Normal Method of Child Class Named - ChildCLS_AbsDemo is called.");

        }
        public override void demoparentabsabstract_fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - Parent_AbsCls is called IN ChildCLS_AbsDemo.");

        }
    }


    interface IParent
    {
        void IAbsDemo();
    }
    interface IParent2
    {
        void IAbsDemo();
    }
    class InterfaceDemo_CLS : IParent, IParent2
    {
        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }
    class InterfaceDemo_CLS2 : IParent, IParent2
    {

        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }
    class InterfaceDemo_CLS3 : IParent, IParent2
    {

        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }

    static class demostatic_cls
    {
        public static int a;
    }

    class demostaticclswithnormal
    {
        public int a1;
        public static int b;
    }

    public class normalsealedclsdemo
    {
        public int a2 = 300;
    }
    sealed class demosealedcls:normalsealedclsdemo
    {
        public int inheritdemo;
    }
    public partial class demoparcls
    {
        public int p1;

    }
    public partial class demoparcls
    {
        public int p2;
    }
    public class childcld:demoparcls
    {
        public int child;
    }

    class program
    {
        static void Main(string[] args)
        {
            classobjectdeepdemo classobjectdeepdemo1 = new classobjectdeepdemo();
            classobjectdeepdemo classobjectdeepdemo2 = new classobjectdeepdemo();
            classobjectdeepdemo classobjectdeepdemo3 = new classobjectdeepdemo();
            classobjectdeepdemo classobjectdeepdemo4 = new classobjectdeepdemo();
            classobjectdeepdemo classobjectdeepdemo5 = new classobjectdeepdemo();
            classobjectdeepdemo classobjectdeepdemo6 = new classobjectdeepdemo();
            classobjectdeepdemo classobjectdeepdemo7 = new classobjectdeepdemo();
            classobjectdeepdemo classobjectdeepdemo8 = new classobjectdeepdemo();
            classobjectdeepdemo classobjectdeepdemo9 = new classobjectdeepdemo();
            classobjectdeepdemo classobjectdeepdemo10 = new classobjectdeepdemo();
            classobjectdeepdemo classobjectdeepdemo11 = new classobjectdeepdemo();
            classobjectdeepdemo classobjectdeepdemo12 = new classobjectdeepdemo();

            classobjectdeepdemo1.a = 111;
            classobjectdeepdemo2.a = 111;
            classobjectdeepdemo3.a = 111;
            classobjectdeepdemo4.a = 111;
            classobjectdeepdemo5.a = 111;
            classobjectdeepdemo6.a = 111;
            classobjectdeepdemo7.a = 111;
            classobjectdeepdemo8.a = 111;
            classobjectdeepdemo9.a = 111;
            classobjectdeepdemo10.a = 111;
            classobjectdeepdemo11.a = 111;
            classobjectdeepdemo12.a = 111;
        }
    }
}

