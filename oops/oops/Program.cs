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

        public void envapsulation()
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
            classobjectdeepdemo2.a = 222;
            classobjectdeepdemo3.a = 333;
            classobjectdeepdemo4.a = 444;
            classobjectdeepdemo5.a = 555;
            classobjectdeepdemo6.a = 666;
            classobjectdeepdemo7.a = 777;
            classobjectdeepdemo8.a = 888;
            classobjectdeepdemo9.a = 999;
            classobjectdeepdemo10.a = 1010;
            classobjectdeepdemo11.a = 1111;
            classobjectdeepdemo12.a = 1212;

            Console.WriteLine("Value of ClassObjectDeepDemo1.a:" + classobjectdeepdemo1.a);
            Console.WriteLine("Value of ClassObjectDeepDemo2.a:" + classobjectdeepdemo2.a);
            Console.WriteLine("Value of ClassObjectDeepDemo3.a:" + classobjectdeepdemo3.a);
            Console.WriteLine("Value of ClassObjectDeepDemo4.a:" + classobjectdeepdemo4.a);
            Console.WriteLine("Value of ClassObjectDeepDemo5.a:" + classobjectdeepdemo5.a);
            Console.WriteLine("Value of ClassObjectDeepDemo6.a:" + classobjectdeepdemo6.a);
            Console.WriteLine("Value of ClassObjectDeepDemo7.a:" + classobjectdeepdemo7.a);
            Console.WriteLine("Value of ClassObjectDeepDemo8.a:" + classobjectdeepdemo8.a);
            Console.WriteLine("Value of ClassObjectDeepDemo9.a:" + classobjectdeepdemo9.a);
            Console.WriteLine("Value of ClassObjectDeepDemo10.a:" + classobjectdeepdemo10.a);
            Console.WriteLine("Value of ClassObjectDeepDemo11.a:" + classobjectdeepdemo11.a);
            Console.WriteLine("Value of ClassObjectDeepDemo12.a:" + classobjectdeepdemo12.a);

            structurereferencedeepdemo structurereferencedeepdemo1 = new structurereferencedeepdemo();
            structurereferencedeepdemo structurereferencedeepdemo2 = new structurereferencedeepdemo();
            structurereferencedeepdemo structurereferencedeepdemo3 = new structurereferencedeepdemo();
            structurereferencedeepdemo structurereferencedeepdemo4 = new structurereferencedeepdemo();
            structurereferencedeepdemo structurereferencedeepdemo5 = new structurereferencedeepdemo();
            structurereferencedeepdemo structurereferencedeepdemo6 = new structurereferencedeepdemo();
            structurereferencedeepdemo structurereferencedeepdemo7 = new structurereferencedeepdemo();
            structurereferencedeepdemo structurereferencedeepdemo8 = new structurereferencedeepdemo();
            structurereferencedeepdemo structurereferencedeepdemo9 = new structurereferencedeepdemo();
            structurereferencedeepdemo structurereferencedeepdemo10 = new structurereferencedeepdemo();
            structurereferencedeepdemo structurereferencedeepdemo11 = new structurereferencedeepdemo();
            structurereferencedeepdemo structurereferencedeepdemo12 = new structurereferencedeepdemo();

            structurereferencedeepdemo1.a = 111;
            structurereferencedeepdemo2.a = 222;
            structurereferencedeepdemo3.a = 333;
            structurereferencedeepdemo4.a = 444;
            structurereferencedeepdemo5.a = 555;
            structurereferencedeepdemo6.a = 666;
            structurereferencedeepdemo7.a = 777;
            structurereferencedeepdemo8.a = 888;
            structurereferencedeepdemo9.a = 999;
            structurereferencedeepdemo10.a = 1010;
            structurereferencedeepdemo11.a = 1111;
            structurereferencedeepdemo12.a = 1212;

            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + structurereferencedeepdemo1.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + structurereferencedeepdemo2.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + structurereferencedeepdemo3.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + structurereferencedeepdemo4.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + structurereferencedeepdemo5.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + structurereferencedeepdemo6.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + structurereferencedeepdemo7.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + structurereferencedeepdemo8.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + structurereferencedeepdemo9.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + structurereferencedeepdemo10.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + structurereferencedeepdemo11.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + structurereferencedeepdemo12.a);

            encapsulation en = new encapsulation();
            en.i = 100;
            en.pi = 101;
            en.pu = 102;

            encapsulationandinheritancedemo eni = new encapsulationandinheritancedemo();
            eni.i = 100;
            eni.pi = 101;
            eni.pu = 102;

            Console.WriteLine("Internal variable value:" + en.i + "-" + eni.i);
            Console.WriteLine("Protected Intenal Variable Value:" + en.pi + "-" + eni.pi);
            Console.WriteLine("Public Variable Value:" + en.pu + "-" + eni.pu);

            encapsulationandinheritancedemosubchild enic = new encapsulationandinheritancedemosubchild();
            enic.i = 100;
            enic.pi = 101;
            enic.pu = 102;

            Console.WriteLine("Intenal Variable Value:" + en.i + "-" + enI.i + "-" + enic.i);
            Console.WriteLine("Protected Intenal Variable Value:" + en.pi + "-" + enI.pi + "-" + enic.pi);
            Console.WriteLine("Public Variable Value:" + en.pu + "-" + enI.pu + "-" + enic.pu);

            OOPS_Demo_Inheritance.EncapsulationAndInheritanceDemoInDifferentNameSpace OOPSD_EnI = new OOPS_Demo_Inheritance.EncapsulationAndInheritanceDemoInDifferentNameSpace();
            OOPSD_EnI.i = 100; // Internal can be access in same name space at anywhere.
            OOPSD_EnI.pi = 101; // Protected Internal can be access in same name space at anywhere as well as it can be access by using child class object.
            OOPSD_EnI.pu = 102; // Public can be access anywhere in project.
            Console.WriteLine("Intenal Variable Value:" + en.i + "-" + eni.i + "-" + OOPSD_EnI.i);
            Console.WriteLine("Protected Intenal Variable Value:" + en.pi + "-" + eni.pi + "-" + OOPSD_EnI.pi);
            Console.WriteLine("Public Variable Value:" + en.pu + "-" + eni.pu + "-" + OOPSD_EnI.pu);

            polymorphism_functionoverloading polyfunoverloading= new polymorphism_functionoverloading();
            polyfunoverloading.demo();
            polyfunoverloading.demo(1);
            polyfunoverloading.demo(1, 'a');

            base_cls b_cls=new base_cls();
            b_cls.demofunction();
            b_cls.demofunction2();

            derived_cls d_cls=new derived_cls();
            d_cls.demofunction();
            d_cls.demofunction2();

            childcls_absdemo ccls_absdemo=new childcls_absdemo();
            ccls_absdemo.demonormal_fun();
            ccls_absdemo.demoabs_fun();
            ccls_absdemo.demochildnormal_fun();
            ccls_absdemo.demoparentabsnormal_fun();
            ccls_absdemo.demoparentabsabstract_fun();

            abstract_cls abcls=new abstract_cls();
            abcls.demoabs_fun();
            abcls.demoparentabsnormal_fun();
            abcls.demonormal_fun();
            abcls.demoparentabsabstract_fun();

            IParent icls=new InterfaceDemo_CLS();
            icls.IAbsDemo();
            icls= new InterfaceDemo_CLS2();
            icls.IAbsDemo();
            icls=new InterfaceDemo_CLS3();
            icls.IAbsDemo();

            demostatic_cls.a = 10;
            demostaticclswithnormal dswn=new demostaticclswithnormal();
            dswn.a1 = 100;

            demostaticclswithnormal.b = 200;
            
            demoparcls dpc=new demoparcls();
            dpc.p1 = 300;
            dpc.p2 = 400;
            
            childcld ccls=new childcld();
            ccls.p1 = 1000;
            ccls.p2 = 1000;

            Console.ReadKey();
        }
    }
}

namespace OOPS_Demo_Inheritance
{

    // Inheritance in different namespace.
    // OOPS is a name of namespace
    class EncapsulationAndInheritanceDemoInDifferentNameSpace : OOPS.Encapsulation
    {
        // This is a child class - ITS EMPTY BECAUSE I NEED TO GAVE DEMO FOR ENCAPSULATION AS WELL AS INHERITANCE.
        public void AccessibleDemoFunOfDirectChildClassInDifferentNameSpace()
        {
            // This is a child class - ITS EMPTY BECAUSE I NEED TO GAVE DEMO FOR ENCAPSULATION AS WELL AS INHERITANCE.
            //pr = 10; // Private variable pr cannot be accessed inside the direct child class.
            prot = 20; // Protected variable can accessed inside the direct child class but not in the sub chhild class.
            pi = 30; //Protected Internal variable can accessed inside the same class as well as direct child class in same namespace.
            i = 20; // Internal variable accessed within the same class as well as same namespace or assembly child class.
            pp = 60;// Private Protected can be accessed inside the same class as well as direct child class.
        }
    }

}

