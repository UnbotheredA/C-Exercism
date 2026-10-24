
//using System;
public class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40; 
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven)  => ExpectedMinutesInOven() - minutesInOven;
  

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layersOfLasagna) => layersOfLasagna * 2;


    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layersOfLasagna, int numOfMinutes) =>  PreparationTimeInMinutes(layersOfLasagna)  + numOfMinutes;
}

  