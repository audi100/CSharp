public class Display
{
    private double? size;
    private int? numberOfColors;

    public double? Size
    {
        get
        {return this.size;}
        set
        {
            if (value>0)
            {
                this.size = value; 
            }
            else
            {
                System.Console.WriteLine("Size should be positive number!");
            }
        }
    }
    public int? NumberOfColors
    {
        get { return this.numberOfColors; }
        set
        {
            if (value>0)
            {
                this.numberOfColors = value;
            }
            else
            {
                System.Console.WriteLine("Number of colors should be positive integer, bigger than 0!");
            }
        }
    }
    public Display()
    {
        this.size = null;
        this.numberOfColors = null;
    }
    public Display(double? size)
        : this()
    {
        this.size = size;
    }
    public Display(double? size, int? numberOfColors)
        : this(size)
    {
        this.numberOfColors = numberOfColors;
    }
}




