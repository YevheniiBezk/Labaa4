using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaa4
{
    internal class Computer
    {
            public string ModelName { get; set; }
            public string Processor { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public double Price { get; set; }
        internal bool HasGraphicsCard { get; set; }
        internal bool HasWiFi { get; set; }

        public Computer()
        {
        }

        public Computer(string modelName, string processor, int ram, int storage, double price, bool hasGraphicsCard, bool hasWiFi)
            {
                ModelName = modelName;
                Processor = processor;
                RAM = ram;
                Storage = storage;
                Price = price;
                HasGraphicsCard = hasGraphicsCard;
                HasWiFi = hasWiFi;
            }

            public double CostPerGB
            {
                get
                {
                    return GetCostPerGB();
                }
            }

            public double GetCostPerGB()
            {
                if (RAM == 0)
                {
                    return 0;
                }
                return Price / RAM;
            }
        }
    }


