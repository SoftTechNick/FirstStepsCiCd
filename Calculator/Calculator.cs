namespace Calculator;

public class Calculator
{
    // Your code goes here ;) <3
    // We need 
    // - Add
    // - Sub
    // - Div
    // - Mul
    // - Faculty - Recursive faculty calculation

    public int Add(int nbr1,int nbr2)
    {
        return nbr1 + nbr2; 
    }
    public int Sub(int nbr1,int nbr2)
    {
        return nbr1 - nbr2;
    }
    public int Mul(int nbr1,int nbr2)
    {
        return nbr1 * nbr2;     
    }
    public int Div(int nbr1,int nbr2)
    {
        return nbr1 / nbr2;
    }

    public int Faculty(int nbr1)
    {
        if(nbr1 ==1)
        {
            return 1;
        }
        return nbr1 * Faculty(nbr1 - 1);
    }
}