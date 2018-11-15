using System;
using System.Collections.Generic;

#pragma warning disable 
namespace OOPH1Eksamen
{
    /*
     * I alle de følgende opgaver er der en tilstødende klasse. Det er
     * den der skal arbejdes med i den givne opgave.
     * Navnene på klasserne er irrelevante for jer og må IKKE ændres
     * 
    */


    class Program {
        public static void Main() {
            // Test of age
            B b = new B();
            b.age = 5;
            Console.WriteLine("Age is " + b.age);

            // Test of brand
            E e = new E();
            e.brand = "iMac";
            Console.WriteLine(e.brand);

            // Test of increment a
            C c = new C();
            c.a = 5;
            Console.WriteLine("c is " + c.a);
            c.IncrementA();
            Console.WriteLine("c is " + c.a);
            c.IncrementA();
            Console.WriteLine("c is " + c.a);

            // Test of getA()
            G g = new G();
            Console.WriteLine(g.getA());

            // Test of adding number to numbers
            F f = new F();
            f.Insert(12345);

            // Tets of encapsulation
            D d = new D(1, "abc");
            Console.WriteLine("A is: " + d.GetA() + " and B is: " + d.GetB());

            // Test of constructor
            A a = new A(1, "hey", 0.5);
            Console.WriteLine("a is {0} and b is {1} and c is {2}", a.a, a.b, a.c);

            // Test of A reference in H
            H h = new H(a);
            Console.WriteLine("h.a.b is: " + h.a.b);

            // Test of printM
            I i = new I();
            i.PrintM();

            // Test of null reference when constructing object
            J j = new J(null);
            j.Invoke();

            MyClass mc = new MyClass();
            mc.myString = "Heyo";
            mc.a = 22;

            Console.WriteLine("myString is: " + mc.myString + " and mc.a " + mc.a);
        }
    }

    //OPG Tilføj en property for Alder kaldet "age" til den følgende class
    class B
    {
        public string name = "";
        public int legs = 2;
        public int age;
    }

    //OPG Tilføj en string property kaldet 'brand' til følgende class
    class E
    {
        public string brand;
    }

    //OPG Tilføj en metode der kan forstørre 'a' med 1 hver gang den kaldes
    class C
    {
        public int a;

        public void IncrementA()
        {
            a += 1;
        }
    }

    //OPG Tilføj en metode kaldet "getA" der kan returnere værdien i a
    class G
    {
        string a = "Hello!";

        public string getA()
        {
            return a;
        }
    }

    //OPG Tilføj en metode der kan tilføje et tal til numbers. Numbers skal
    //forblive private.
    class F
    {
        List<int> numbers = new List<int>();

        public void Insert(int number)
        {
            numbers.Add(number);
        }
    }

    //OPG Implementer encapsulation i denne klasse, men gør således det stadig 
    //er muligt at læse værdierne 'a' og 'b'
    class D
    {
        private int a;
        private string b;

        public D(int a, string b)
        {
            this.a = a;
            this.b = b;
        }

        public int GetA()
        {
            return a;
        }

        public string GetB()
        {
            return b;
        }
    }

    //OPG Lav en constructor der sætter alle properties af følgende klasse
    class A
    {
        public int a;
        public string b;
        public double c;

        public A(int a, string b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    //OPG klassen H skal have en reference til klasse A, kaldet 'a'. Lav en constructor der
    //sætter denne til reference til et objekt af A
    class H
    {
        public A a;

        public H(A a)
        {
            this.a = a;
        }
    }

    //OPG Ændre funktionen PrintM, således at den ikke crasher programmet hvis den køres.
    class I 
    {
        public string text;

        public void PrintM(){
            if (text != null)
            {
                Console.WriteLine("Text is " + text.Length + "long");
            }
        }
    }

    //OPG Invoke kan faile hvis der gives en null værdi til dens constructor.
    //sørg for at dette ikke kan forekomme ved kun at ændre på Invoke
    class J
    {
        public I i;

        public void Invoke() {
            if (i != null)
            {
                i.PrintM();
            }
        }

        public J(I i) {
            this.i = i;
        }
    }

    //OPG Herunder skal du selv implementere en class kaldet MyClass der
    //er subclass til C. Tilføj et public string felt kaldet 'myString'.

    class MyClass : C {
        public string myString;
    }



}
