static class QuestLogic
{
    //if knight is sleeping fast attack is possbile
    public static bool CanFastAttack(bool knightIsAwake)
    {
        
        if(!knightIsAwake) return true;
        if(knightIsAwake) return false;
        return false; 
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        
        if(knightIsAwake || archerIsAwake || prisonerIsAwake) return true;
           return false;  
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {

        if(!archerIsAwake && prisonerIsAwake) return true;
        return false;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(!archerIsAwake && knightIsAwake && petDogIsPresent) return true;
    
        if(!archerIsAwake && !knightIsAwake && petDogIsPresent ) return true;
        if( prisonerIsAwake && !petDogIsPresent && !archerIsAwake && !knightIsAwake) return true;

        return false;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
