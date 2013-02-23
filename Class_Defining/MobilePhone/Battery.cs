public enum BatteryType
{
    LiIon, NiCd, NiMH
}

public class Battery
{
    //fields
    private string model;
    private double? hoursIdle;
    private double? hoursTalk;
    private BatteryType type;

    //properties
    public string Model
    {
        get { return this.model; }
        set
        {
            if (value.Length>0)
            {
                this.model = value;
            }
            else
            {
                System.Console.WriteLine("Model should contain at least one character!");
            }
        }
    }
    public double? HoursIdle
    {
        get { return this.hoursIdle; }
        set
        {
            if (value>0)
            {
                this.hoursIdle = value;
            }
            else
            {
                System.Console.WriteLine("Hours idle time should be positive number!");
            }
        }
    }
    public double? HoursTalk
    {   
        get{return this.hoursTalk;}
        set
        {
            if (value>0)
            {
                this.hoursTalk = value;
            }
            else
            {
                System.Console.WriteLine("Hours talk time should be positive number!");
            }
        }
    }
    public BatteryType Type {
        get { return this.type; } 
    }

    //constructors
    public Battery(string model, BatteryType type)
    {
        this.Model = model;
        this.type = type;
    }
    public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryType type)
        : this(model, type)
    {
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
    }
}
