﻿using System;
namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 4:
                    return new Car();

                case 2:
                    return new Motorcycle();
                       

                case 3:
                    return new ThreeWheeler();

                default:
                    return new Default();


 
            }
        }


            
    }
}
