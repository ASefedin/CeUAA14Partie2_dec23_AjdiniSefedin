namespace CeUAA14Partie2_dec23_AjdiniSefedin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reset = " ";
            PaintBallGun arme1 = new PaintBallGun(30, 0, "oui", 14, 16);
            Console.WriteLine(arme1.TotalBall());
            Console.WriteLine(arme1.ArmeSansBalle());
            Console.WriteLine();    

            do
            {
                Console.WriteLine();
                Console.WriteLine("Espace : pour tirer");
                Console.WriteLine("r : pour recharger");
                Console.WriteLine("+ : pour reprendre des munitions");
                Console.WriteLine("q : pour quitter");
                string reponse = Console.ReadLine();
                switch (reponse)
                {
                    case " ":
                        Console.Clear();
                        if (arme1.NombreDeBallesInterrieur > 0)
                        {
                            Console.WriteLine(arme1.Tirer());
                        }
                        else
                        {
                            Console.WriteLine(arme1.ArmeSansBalle());
                        }
                        break;
                    case "r":
                        Console.Clear();
                        if (arme1.NombreDeBallesInterrieur == 0 || arme1.NombreDeBallesInterrieur < 30)
                        {
                            Console.WriteLine(arme1.Recharger());
                        }
                        Console.WriteLine(arme1.TotalBall());
                        break;
                    case "+":
                        Console.Clear();
                        Console.WriteLine(arme1.ReprendreMunitions());
                        break;
                    case "q":
                        Console.Clear();
                        Console.WriteLine("Vous pouvez quitter la page !");
                        break;
                }
            } while (reset == " ") ;
            }
        }
    }