namespace CatLady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CatLady
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var siameseCats = new List<Siamese>();
            var cymricCats = new List<Cymric>();
            var streetExtraordinaireCats = new List<StreetExtraordinaire>();

            while (inputLine != "End")
            {
                var catInfo = inputLine.Split();

                switch (catInfo[0])
                {
                    case "Siamese":
                        siameseCats.Add(new Siamese(catInfo[1], int.Parse(catInfo[2])));
                        break;
                    case "Cymric":
                        cymricCats.Add(new Cymric(catInfo[1], double.Parse(catInfo[2])));
                        break;
                    case "StreetExtraordinaire":
                        streetExtraordinaireCats.Add(new StreetExtraordinaire(catInfo[1], int.Parse(catInfo[2])));
                        break;
                }

                inputLine = Console.ReadLine();
            }

            var catName = Console.ReadLine();

            if (siameseCats.SingleOrDefault(c => c.Name == catName) != null)
            {
                Console.WriteLine(siameseCats.Single(c => c.Name == catName));
            }
            else if (cymricCats.SingleOrDefault(c => c.Name == catName) != null)
            {
                Console.WriteLine(cymricCats.Single(c => c.Name == catName));
            }
            else
            {
                Console.WriteLine(streetExtraordinaireCats.Single(c => c.Name == catName));
            }
        }
    }
}