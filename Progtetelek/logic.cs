using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progtetelek
{
    internal class logic
    {

        public string getDescription(string thesis)
        {
            StreamReader reader = new StreamReader("descriptions/" + thesis + ".txt");

            return reader.ReadLine();
        }
        public string getPseudo(string thesis) {
            StreamReader reader = new StreamReader("descriptions/" + thesis + ".txt");
            reader.ReadLine();
            reader.ReadLine();
            return reader.ReadToEnd();
        }

        public string getExample(string thesis)
        {
            StreamReader reader = new StreamReader("descriptions/" + thesis + ".txt");
            reader.ReadLine();
            return reader.ReadLine();
           
        }
    }
}
