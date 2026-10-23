public class Player
{
    public int RollDie()
    {
        Random rnd = new();
        return rnd.Next(1,19);
    }

    public double GenerateSpellStrength()
    {
        Random rnd = new();
        return rnd.NextDouble() * 100;
    }
}
