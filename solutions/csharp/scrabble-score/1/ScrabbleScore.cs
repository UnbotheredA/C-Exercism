public static class ScrabbleScore
{
    public static int Score(string input)
    {        
        int total = 0;     
        for (int x = 0; x < input.Length; ++x) 
        {
            switch(input[x].ToString()) 
            {
                case "a": case "A": case "E": case "e": case "I": case "i": case "O": case "o": case "U": case "u": case "L": case "l": case "N": case "n": case "R": case "r": case "S": case "s": case "T": case "t":
                     total = total + 1;
                break;
                case "D": case "d": case "G": case "g":
                    total = total + 2;
                    break;
                case "B": case "b": case "C": case "c": case "M": case "m": case "P": case "p":
                    total = total + 3;
                    break;
                case "F": case "f": case "H": case "h": case "V": case "v": case "W": case "w": case "Y": case "y":
                    total = total + 4;
                    break;
                case "K": case "k":
                    total = total + 5;
                    break;
                case "J": case "j": case "X": case "x":
                    total = total + 8;
                    break;
                case "Q": case"q": case "Z": case "z": 
                    total = total + 10;
                    break;
            }   
        }
          return total;
    }
}