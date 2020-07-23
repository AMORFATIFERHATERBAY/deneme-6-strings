using System;

namespace deneme_6_strings
{
    class Program
    {
        static void Main(string[] args)
        {   
            string txt = "StringOlarakBelirtilenTextinUzunluğu";
            Console.WriteLine(txt);
            
            // Stringin uzunluğunu hesapalar "lenght" metodu
            Console.WriteLine("The lenght of the txt strings is :" + txt.Length);

            //ToUpper  ve ToLower metodu
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine();

            //string "concat" metodu ve ($)interpolation metodu 
            string firstname="Amor ";
            string secondname="Fati";
            string fullname=firstname + secondname;
            Console.WriteLine(fullname);
            string fullname1=string.Concat(firstname , secondname);
            Console.WriteLine();
            Console.WriteLine(fullname1);
            Console.WriteLine();
            Console.WriteLine(string.Concat(firstname , secondname));
            string name=$"My full name is :{firstname} {secondname}";
            Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine($"My full name is :{firstname} {secondname}");

            // Access String
            Console.WriteLine();
            Console.WriteLine(fullname1[0]);
            Console.WriteLine(fullname1[1]);
            Console.WriteLine(fullname1[2]);
            Console.WriteLine(fullname1.IndexOf("A"));
            Console.WriteLine(fullname1.IndexOf("m"));
            Console.WriteLine(fullname1.IndexOf("o"));

            // Substring
            string adisoyadi = "Amor Fati";
            int charPos = adisoyadi.IndexOf("F");
            string soyadi = adisoyadi.Substring(charPos);
            Console.WriteLine();
            Console.WriteLine(adisoyadi.IndexOf("o"));
            Console.WriteLine(soyadi);
            Console.WriteLine();
            Console.WriteLine("we are the so-called \"VİKİNGS\" from the north.");
            Console.WriteLine("The character \\ is called bachslash.");
            Console.WriteLine("The character \n is called newline.");
            Console.WriteLine("The character \t is called tab.");
            Console.WriteLine("The character \b is called backspace.");  

            // C# Booleans
            // Booleans Values
            Console.WriteLine(10<5);
            Console.WriteLine(10<15);




            







        }
    }
}
