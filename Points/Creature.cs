using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar.Points
{
        public class Bird : IPoints
        {
            public string Name { get { return "Bird"; } }
            public string ID { get { return "Bird"; } }
            public int Value { get { return 10; } }
        }
        public class CrestedIbis : IPoints
        {
            public string Name { get { return "Crested Ibis"; } }
            public string ID { get { return "CrestedIbis"; } }
            public int Value { get { return 100; } }
        }
        public class GreatKiskudee : IPoints
        {
            public string Name { get { return "Great Kiskudee"; } }
            public string ID { get { return "GreatKiskudee"; } }
            public int Value { get { return 300; } }
        }
        public class RedCrossbill : IPoints
        {
            public string Name { get { return "Red Crossbill"; } }
            public string ID { get { return "RedCrossBill"; } }
            public int Value { get { return 500; } }
        }
        public class RedneckedPhalarope : IPoints
        {
            public string Name { get { return "Red-Necked Phalarope"; } }
            public string ID { get { return "Red-neckedPhalarope"; } }
            public int Value { get { return 700; } }
        }
        public class EveningGrosbeak : IPoints
        {
            public string Name { get { return "EveningGrosbeak"; } }
            public string ID { get { return "EveningGrosbeak"; } }
            public int Value { get { return 1000; } }
        }
        public class GreaterPrairieChicken : IPoints
        {
            public string Name { get { return "Greater Prairie Chicken"; } }
            public string ID { get { return "GreaterPrairieChicken"; } }
            public int Value { get { return 2000; } }
        }
        public class IcelandGull : IPoints
        {
            public string Name { get { return "Iceland Gull"; } }
            public string ID { get { return "IcelandGull"; } }
            public int Value { get { return 3000; } }
        }
        public class OrangebelliedParrot : IPoints
        {
            public string Name { get { return "Orange-Bellied Parrot"; } }
            public string ID { get { return "Orange-belliedParrot"; } }
            public int Value { get { return 5000; } }
        }
        public class InvincibleBirdHunter : IPoints
        {
            public string Name { get { return "InvincibleBirdHunter"; } }
            public string ID { get { return "InvincibleBirdHunter"; } }
            public int Value { get { return 0; } }
        }
        public class VulnerableBirdHunter : IPoints
        {
            public string Name { get { return "VulnerableBirdHunter"; } }
            public string ID { get { return "VulnerableBirdHunter"; } }
            public int Value { get { return 200; } }
        }
    }
