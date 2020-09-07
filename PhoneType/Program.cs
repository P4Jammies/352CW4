using System;

namespace PhoneType
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneTypeChecker ptc;
            Console.WriteLine("Which manufacturer would you like to check?\n" +
                              "1. Samsung\n" +
                              "2. HTC\n" +
                              "3. Nokia\n" +
                              "4. IPhone\n");
            
            for (int i = 1; i < 5; i++)
            {
                ptc = new PhoneTypeChecker((Manufacturers)i);
                Console.Write(i + ". ");
                ptc.CheckProducts();
            }
        }
    }
    public enum Manufacturers
    {
        SAMSUNG = 1, HTC = 2, NOKIA = 3
    }
    class PhoneTypeChecker
    {
        IPhoneFactory factory;
        Manufacturers manu;

        public PhoneTypeChecker(Manufacturers manu)
        {
            if (manu == (Manufacturers)1)
                factory = new SamsungFactory();
            else if (manu == (Manufacturers)2)
                factory = new HTCFactory();
            else if (manu == (Manufacturers)3)
                factory = new NokiaFactory();
            else
                factory = null;
        }
        public void CheckProducts()
        {
            if (factory == null)
                Console.WriteLine("There are no available products from this Manufacturer.\n");
            else
                Console.WriteLine("Available Products:\n     " +
                                    factory.GetSmart().getName() + "\n     " +
                                    factory.GetDumb().getName() + "\n");
        }
    }
    abstract class IPhoneFactory
    {
        public virtual ISmart GetSmart()
        {
            ISmart smart = null;
            return smart;
        }
        public virtual IDumb GetDumb()
        {
            IDumb dumb = null;
            return dumb;
        }
    }
    class SamsungFactory : IPhoneFactory
    {
        public override ISmart GetSmart()
        {
            ISmart smart = new GalaxyS2();
            return smart;
        }
        public override IDumb GetDumb()
        {
            IDumb dumb = new Primo();
            return dumb;
        }
    }
    class HTCFactory : IPhoneFactory
    {
        public override ISmart GetSmart()
        {
            ISmart smart = new Titan();
            return smart;
        }
        public override IDumb GetDumb()
        {
            IDumb dumb = new Gene();
            return dumb;
        }
    }
    class NokiaFactory : IPhoneFactory
    {
        public override ISmart GetSmart()
        {
            ISmart smart = new Lumia();
            return smart;
        }
        public override IDumb GetDumb()
        {
            IDumb dumb = new Asha();
            return dumb;
        }
    }
    abstract class ISmart
    {
        public virtual string getName()
        {
            return "IPhone <Smart>";
        }
    }
    class Lumia : ISmart
    {
        public override string getName()
        {
            return "Nokia Lumia";
        }
    }
    class GalaxyS2 : ISmart
    {
        public override string getName()
        {
            return "Samsung GalaxyS2";
        }
    }
    class Titan : ISmart
    {
        public override string getName()
        {
            return "HTC Titan";
        }
    }
    abstract class IDumb
    {
        public virtual string getName()
        {
            return "Iphone <Dumb>";
        }
    }
    class Asha : IDumb
    {
        public override string getName()
        {
            return "Nokia Asha";
        }
    }
    class Gene : IDumb
    {
        public override string getName()
        {
            return "HTC Gene";
        }
    }
    class Primo : IDumb
    {
        public override string getName()
        {
            return "Samsung Primo";
        }
    }
}
