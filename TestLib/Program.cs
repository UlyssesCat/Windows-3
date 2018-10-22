using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyClass myClass = CreateMyClass();
            Console.WriteLine(myClass.Add(3,4));
        }
        public static IMyClass CreateMyClass()
        {
            IMyClass iMyClass = null;
            try
            {
                Guid guid = new Guid("F0239BF9-0A6E-49A6-8853-BADE1B95E66F");
                Type myClassType = Type.GetTypeFromCLSID(guid);
                object myClass = Activator.CreateInstance(myClassType);
                iMyClass = myClass as IMyClass;
            }
            catch (Exception e)
            {
            }
            return iMyClass;
        }
    }
}
