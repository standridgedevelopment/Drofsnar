using Drofsnar;
using Drofsnar.Points;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drofsnar_
{
    class UI
    {
       
        static void Main(string[] args)
        {
            System.Media.SoundPlayer sound =
            new System.Media.SoundPlayer();
            sound.SoundLocation = @"\ElevenFiftyProjects\SD 65\Drofsnar\pacman_beginning.wav";
            sound.Load();
            sound.Play();
            Thread.Sleep(5000);
            Drofsnar player = new Drofsnar(5000, 3);
            


            string[] gameInput = System.IO.File.ReadAllText(@"\Drofsnar\GameInput.txt").Split(',');
            for (int i = 0; i < gameInput.Length; i++)
            {
                switch (gameInput[i])
                {
                    case "Stopper":
                        player.EatStopper();
                        break;
                    case "BirdHunter":
                        player.EatBirdHunter();
                        break;
                    case "Bird":
                        player.GetPoints(new Bird());
                        break;
                    case "CrestedIbis":
                        player.GetPoints(new CrestedIbis());
                        break;
                    case "GreatKiskudee":
                        player.GetPoints(new GreatKiskudee());
                        break;
                    case "RedCrossbill":
                        player.GetPoints(new RedCrossbill());
                        break;
                    case "Red-neckedPhalarope":
                        player.GetPoints(new RedneckedPhalarope());
                        break;
                    case "EveningGrosbeak":
                        player.GetPoints(new EveningGrosbeak());
                        break;
                    case "GreaterPrairieChicken":
                        player.GetPoints(new GreaterPrairieChicken());
                        break;
                    case "IcelandGull":
                        player.GetPoints(new IcelandGull());
                        break;
                    case "Orange-belliedParrot":
                        player.GetPoints(new OrangebelliedParrot());
                        break;
                }
                if (player.elScore >= 10000) player.ExtraLife();
                if (player.lives == 0) break;
                player.StopperCount -= 1;
                if (player.StopperCount == 0) { player.stopper = false; }

            }
            //Console.Clear();
            player.DisplayScore();
            Console.ReadKey();
        }
    }
}
