
using Drofsnar;
using Drofsnar.Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Drofsnar_
{
    public class Drofsnar
    {
        private int _score;
        private int _elScore;
        private int _lives;
        private int _stopperCount;
        public bool stopper;
        private int _hunterCount;

        public int score => _score;
        public int elScore => _elScore;
        public int lives => _lives;

        public int StopperCount { 
            get { return _stopperCount; }
            set 
            { 
                if (value <= 0)
                {
                    _stopperCount = 0;
                }
                else { _stopperCount = value; }
            }
        }
        public int HunterCount
        {
            get { return _hunterCount; }
            set { }
        }

        public void GetPoints(IPoints creature)
        {
            _score += creature.Value;
            _elScore += creature.Value;
            
            if (creature.Name == "Bird")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You have saved a {creature.Name}");
                Console.WriteLine($"+{creature.Value} points");
                System.Media.SoundPlayer sound =
                new System.Media.SoundPlayer();
                sound.SoundLocation = @"\Drofsnar\munch_1.wav";
                sound.LoadAsync();
                sound.Play();
                Thread.Sleep(250);
                System.Media.SoundPlayer sound2 =
               new System.Media.SoundPlayer();
                sound2.SoundLocation = @"\Drofsnar\munch_2.wav";
                sound2.LoadAsync();
                sound2.Play();
                Thread.Sleep(200);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"You have saved a {creature.Name}");
                Console.WriteLine($"+{creature.Value} points");
                System.Media.SoundPlayer sound =
                new System.Media.SoundPlayer();
                sound.SoundLocation = @"\Drofsnar\Pacman_Eating_Cherry_Sound_Effect.wav";
                sound.Load();
                sound.Play();
                Thread.Sleep(500);
            }
        }
        public void DisplayScore()
        {
            Console.WriteLine($"Congratulations! You got {_score} points!");
        }
        public void EatBirdHunter()
        {
            _hunterCount += 1;
            if (_stopperCount == 0) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                LoseLife(); 
            }
            else {
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Media.SoundPlayer sound =
                new System.Media.SoundPlayer();
                sound.SoundLocation = @"\Drofsnar\eat_ghost.wav";
                sound.Load();
                sound.Play();
                switch (_hunterCount)
                {
                    case 1:
                        Console.WriteLine("You consumed a Vulnerable Bird Hunter!");
                        //Thread.Sleep(500);
                        Console.WriteLine("+200 points");
                        _elScore += 200;
                        _score += 200;
                        break;
                    case 2:
                        Console.WriteLine("You consumed your 2nd Vulnerable Bird Hunter!");
                        //Thread.Sleep(500);
                        Console.WriteLine("+400 points");
                        _elScore += 400;
                        _score += 400;
                        break;
                    case 3:
                        Console.WriteLine("You consumed your 3nd Vulnerable Bird Hunter!");
                        //Thread.Sleep(500);
                        Console.WriteLine("+800 points!");
                        _elScore += 800;
                        _score += 800;
                        break;
                    case 4:
                        Console.WriteLine("You consumed your 4th! Vulnerable Bird Hunter!");
                        //Thread.Sleep(500);
                        Console.WriteLine("+1600 points!");
                        _elScore += 1600;
                        _score += 1600;
                        break;
                }
                Thread.Sleep(500);
            }
        }
        public void EatStopper()
        {
            Console.ForegroundColor = ConsoleColor.White;
            stopper = true;
            _stopperCount += 6;
            Console.WriteLine("You got a Stopper! You have 5 seconds to turn the tables on those Bird Hunters!");
        }
        public void LoseLife()
        {
           
            Console.WriteLine($"Oof! That was an Invincible Bird Hunter! Wait until you have a stopper.");
            System.Media.SoundPlayer sound =
              new System.Media.SoundPlayer();
            sound.SoundLocation = @"\Drofsnar\pacman_death.wav";
            sound.Load();
            sound.Play();
            _hunterCount = 0;
            _lives -= 1;
            if (_lives == 0){ Console.WriteLine("Game Over dude"); }
            else if (_lives == 1) { Console.WriteLine("Only 1 life left! Make it count"); }
            else { Console.WriteLine( $"{_lives} lives remaining"); }
            Thread.Sleep(3000);
        }
        public void ExtraLife()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _elScore -= 10000;
            _lives += 1;
            Console.WriteLine($"You've reached 10,000 points! That deserves an extra life!");
            System.Media.SoundPlayer sound =
              new System.Media.SoundPlayer();
            sound.SoundLocation = @"\Drofsnar\extend.wav";
            sound.Load();
            sound.Play();
            Thread.Sleep(2000);
            
        }
       

        public Drofsnar(int score, int lives)
        {
            _score = score;
            _elScore = score;
            _lives = lives;
            _hunterCount = 0;
            _stopperCount = 0;
            stopper = false;
        }
    }
}
