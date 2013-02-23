//Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone 
//number and duration (in seconds).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Call
{
    public DateTime DateAndTime{get;set;}

    private string dialedPhone;
    private decimal durationInSeconds;

    public string DialedPhone
    {
        get { return this.dialedPhone; }
        set
        {
            if (value.Length >= 3)
            {
                this.dialedPhone = value;
            }
            else
            {
                Console.WriteLine("The length of the dialed phone should contain at least 3 characters!");
            }
        }
    }
    public decimal DurationInSeconds
    {
        get { return this.durationInSeconds; }
        set
        {
            if (value>0)
            {
                this.durationInSeconds = value;
            }
            else
            {
                Console.WriteLine("The duration should be at least one second!");
            }
        }
    }
    public Call(DateTime dateAndTime, string dialedPhone, decimal durationInSeconds)
    {
        this.DateAndTime = dateAndTime;
        this.DialedPhone = dialedPhone;
        this.DurationInSeconds = durationInSeconds;
    }
       
    public override string ToString()
    {
        string result = String.Format("Date and Time: "+this.DateAndTime+"\nDialed phone "+this.DialedPhone+
            "\nDuration in seconds: "+this.DurationInSeconds);
        return result;
    }
}

