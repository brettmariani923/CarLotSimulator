using System;
using System.Collections.Generic;
using System.Net.Sockets;


namespace CarLotSimulator;


public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public string EngineNoise(string y)
        {
            return y;
        }

        public string HonkNoise(string x)
        {
            return x;
        }

        public int Year { get; set; }
        public bool Driveable { get; set; }
    }

