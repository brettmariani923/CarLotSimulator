﻿using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{ 
    public List<Car> Cars { get; set; } = new List<Car>();

    public static int NumberOfCars;

    public static int CarIncrease(Car car)
    {
            return NumberOfCars++;
    }
    
}