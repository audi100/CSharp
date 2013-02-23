

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;


public class GSM
{
    //fields
    private string model;
    private string manufacturer;
    private decimal? price;
    private string owner;

    private static GSM iPhone4S;

    //properties
    public Display Display{get;set;}
    public Battery Battery{get;set;}

    public List<Call> CallHistory {get; set; }

    public static GSM IPhone4s
    {
        get { return iPhone4S; }
    }

   
    public string Model
    {
        get { return this.model; }
        set
        {
            if (value.Length > 0)
            {
                this.model = value;
            }
            else
            {
                System.Console.WriteLine("Model should contain at least one character!");
            }
        }
    }
    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value.Length > 0)
            {
                this.manufacturer = value;
            }
            else
            {
                System.Console.WriteLine("Manufacturer should contain at least one character!");
            }
        }
    }
    public decimal? Price
    {
        get { return this.price; }
        set
        {
            if (value>=0)
            {
                this.price = value;
            }
            else
            {
                Console.WriteLine("The price should be >=0!");
            }
        }

    }
    public string Owner
    {
        get { return this.owner; }
        set
        {
            if (value.Length > 0)
            {
                this.owner = value;
            }
            else
            {
                System.Console.WriteLine("Owner should contain at least one character!");
            }
        }
    }

    //constructors
    static GSM()
    {
        iPhone4S = new GSM("IPhone4s", "Apple", 235);
        iPhone4S.Owner = "BB";
        iPhone4S.Display = new Display(12, 64);
        iPhone4S.Battery = new Battery("NM9", 6, 3, BatteryType.NiCd);
    }
    public GSM(string model, string manufacturer)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        price = null;
        owner = null;
    }
    public GSM(string model, string manufacturer, decimal? price)
        : this(model, manufacturer)
    {
        this.price = price;
    }
    public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        : this(model, manufacturer, price)
    {
        this.owner = owner;
        this.Battery = battery;
        this.Display = display;
    }

    //override ToString()
    public override string ToString()
    {
        string result = string.Format("Info for your GSM device: \nModel:{0}\nManufacturer:{1}", this.Model, this.Manufacturer);
        if (this.Price!=null)
        {
            result = result + "\nPrice: "+ this.Price;
        }
        if (this.Owner!=null)
        {
             result = result + "\nOwner: "+ this.Owner;
        }
        if (this.Battery.Model != null)
        {
            result = result + "\nBattery Model: " + this.Battery.Model;
        }
        if (this.Battery.HoursIdle != null)
        {
            result = result + "\nBattery Hours Idle Time: " + this.Battery.HoursIdle;
        }
        if (this.Battery.HoursTalk != null)
        {
            result = result + "\nBattery Hours Talk Time: " + this.Battery.HoursTalk;
        }
        if (this.Battery.Type != null)
        {
            result = result + "\nBattery Type: " + this.Battery.Type;
        }
        if (this.Display.Size != null)
        {
            result = result + "\nDisplay Size: " + this.Display.Size;
        }
        if (this.Display.NumberOfColors != null)
        {
            result = result + "\nDisplay Number Of Colors: " + this.Display.NumberOfColors;
        }
        return result;
    }
    //Calls methods

    public void AddCall(Call call)
    {
        if (CallHistory==null)
        {
            CallHistory = new List<Call>();
        }
        this.CallHistory.Add(call);
    }
    public void RemoveCall(Call call)
    {
        this.CallHistory.Remove(call);
    }
    public void ClearHistory(List<Call> CallHistory)
    {
        CallHistory.Clear();
    }
    public decimal CalculatePriceAllCalls(List<Call> CallHistory, decimal pricePerMinute)
    {
        decimal price = 0;
        for (int i = 0; i < CallHistory.Count; i++)
        {
            price = price + this.CallHistory[i].DurationInSeconds * (pricePerMinute/60); //price per second=pricePerMinute/60
        }
        return Math.Round(price,2);
    }
    static void Main()
    {
        
    }
}

