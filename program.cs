using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reflection_practice
{
    [AttributeUsage(AttributeTargets.All)]
    public class HelpAttribute:Attribute
    {

        public readonly string url;
        public string Topic { get; set; }

        public HelpAttribute(string Url)
        {
            this.url = Url;
        }
            

    }
    [HelpAttribute("Information on the class Myclass")]
    public class myclass
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(myclass);
            object[] attribytes = info.GetCustomAttributes(true);

            for(int i=0;i<attribytes.Length;i++)
            {
                Console.WriteLine(attribytes);
            }
            Console.ReadLine();
        }
    }
}
