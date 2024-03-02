
// function return num
//


public class Length
{
    public string X { set; get; }

    public Length(string m)
    {
        
        X= m;
    }
    public int LengthOfLastWord()
    {
        X=X.Trim();
        int count = 0;
        for(int i = X.Length-1; i >= 0 ; i--)
        {
        
            if (X[i] !=' ')
            {
                count++;
            }
            else { break; }
            
        }
        if(count == 0) { return 1; }
            return count; 

    }
    public static void Main(string[] args)
    {
        Length y = new Length("fly me   to   the moon ");

        Console.Write(y.LengthOfLastWord()); 
    }
}

  