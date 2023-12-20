namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ertekek = new List<int>();

            File.ReadAllLines("melyseg.txt").ToList().ForEach(x=>ertekek.Add(Convert.ToInt16(x)));

            Console.WriteLine("Az értékek száma(1. feladat): "+ertekek.Count);

            //2. + 6. feladat
            int bekertErtek = Convert.ToInt32(Console.ReadLine());
            int godorKEzdo;
            int godorVegso;


            if (ertekek[bekertErtek]!=0)
            {
                Console.WriteLine("A "+bekertErtek+". érték(2. feladat):"+ertekek[bekertErtek-1]);

                for (godorVegso = bekertErtek; godorVegso < ertekek.Count; godorVegso++)
                {
                    if (ertekek[godorVegso - 1] ==0)
                    {
                        break;
                    }
                }
                for (godorKEzdo = bekertErtek; godorKEzdo > 0; godorKEzdo--)
                {
                    if (ertekek[godorKEzdo - 2] == 0)
                    {
                        break;
                    }
                }
                Console.WriteLine($"A gödör kezdőpontja(6.feladat/a):{godorKEzdo}");
                Console.WriteLine($"A gödör végpontja(6.feladat/a):{godorVegso}");

            }
            else
            {
                Console.WriteLine("ez nem gödör!");
            }

            //3.feladat
            Console.WriteLine("Az adatok ennyi százaléka nem gödör(3. feladat):"+Math.Round(Convert.ToDouble(ertekek.Count(x => x == 0)) / ertekek.Count * 100,2)+"%");

            //4. feladat
            for (int i = 1; i < ertekek.Count; i++)
            {
                string valami = "";
                if (ertekek[i] !=0 && ertekek[i-1]==0)
                {
                    while (ertekek[i]!=0)
                    {
                        valami += ertekek[i] + " ";
                        i++;
                    }
                    File.Delete("godrok.txt");
                    File.AppendAllText("godrok.txt",valami+"\n");
                }
            }
            Console.WriteLine("A fájlbaírás (4. feladat) kész!");

            //5.feladat
            int godrokSzama = 0;

            for (int i = 1; i < ertekek.Count; i++)
            {
                if (ertekek[i - 1] == 0 && ertekek[i]!=0)
                {
                    godrokSzama++;
                }
            }
            Console.WriteLine("5.feladat:"+godrokSzama);


        }
    }
}