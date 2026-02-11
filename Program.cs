namespace _02._11
{
    internal class Program
    {
        static int Szamol(int a, char op, int b)
        {
            
            
            if (op== '+')
            {
               
                return a+b;
            }
            else if(op == '-')
            {
                return a-b;
            }
            else if (op == '*')
            {
                return a*b;
            }
            else if (op == '/')
            {
                return a / b;
            }
            else 
            {
                return a % b;
            }

        }
        static void Main(string[] args)
        {





//1.feladat------------------------------------------------------------------------------------
            Console.WriteLine("adja meg  abeolvasni kívánt filenak a nevét: ");
            string fajlnev=Console.ReadLine();
             List<string[]> muveletek = new List<string[]>();
            List<int> eredmenyek = new List<int>();

            if (File.Exists(fajlnev))
            {
                StreamReader sr = new StreamReader(fajlnev);
                
            while (!sr.EndOfStream)
            {

                    string[] sor = sr.ReadLine().Split(' ');
                muveletek.Add(sor);
                    //eredmenyek.Add(Szamol(Convert.ToInt32( sor[0]) , Convert.ToChar(sor[1] , Convert.ToInt32(sor[2])));   
            }
            sr.Close();
            }
            else
            {
                while (!File.Exists(fajlnev))
                {
                    Console.WriteLine("adjon meg uj filenevet: ");
                    fajlnev = Console.ReadLine();
                }
                
            }






            //2.feladat---------------------------------------------------------------------------------------------------

            foreach (var item in muveletek)
            {
                if (item[1] == "+")
                {
                    eredmenyek.Add(Convert.ToInt32(item[0]) + Convert.ToInt32(item[2]));
                }
                else if (item[1] == "-")
                {
                    eredmenyek.Add(Convert.ToInt32(item[0]) - Convert.ToInt32(item[2]));
                }
                else if (item[1] == "*")
                {
                    eredmenyek.Add(Convert.ToInt32(item[0]) * Convert.ToInt32(item[2]));
                }
                else if (item[1] == "/")
                {
                    eredmenyek.Add(Convert.ToInt32(item[0]) / Convert.ToInt32(item[2]));
                }
                else if (item[1] == "%")
                {
                    eredmenyek.Add(Convert.ToInt32(item[0]) % Convert.ToInt32(item[2]));
                }
            }


            foreach (var item in eredmenyek)
            {
                Console.WriteLine(item);
            }

            //3.feladat------------------------------------------------------------------------------------------
            Console.WriteLine();
            int i = 0;
            StreamWriter sw = new StreamWriter("eredmeny.txt");

            foreach (var item in muveletek)
            {
                Console.WriteLine($"{item[0]}{item[1]}{item[2]} = {eredmenyek[i]}");
                i++;

            }
            
            //4.feladat--------------------------------------------------------------------------------------------
            Console.WriteLine();
            int osszeadas = 0;
            int legnagyobbszam = 0;
            foreach (var item in muveletek)
            {
                if (item[1]=="+")
                {
                    osszeadas++;
                }
                if (Convert.ToInt32( item[0])>legnagyobbszam)
                {
                    legnagyobbszam = Convert.ToInt32(item[0]);
                }
                else if(Convert.ToInt32(item[2]) > legnagyobbszam)
                {
                    legnagyobbszam = Convert.ToInt32(item[2]);
                }
            }
            Console.WriteLine($"a legnagyobb szám az operátusok között{legnagyobbszam}");
            Console.WriteLine($"{osszeadas} db osszeadas volt");
        }
    }
}
