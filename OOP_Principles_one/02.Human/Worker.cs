using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Worker:Human
{
    private int weekSalary;
    private byte workHoursPerDay;

    public int WeekSalary { get; set; }
    public byte WorkHoursPerDay { get; set; }

    public Worker(string firstName, string lastName, int weekSalary, byte workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal MoneyPerHour(int weekSalary, byte workHoursPerDay)
    {
        decimal moneyPerDay=weekSalary/5;  // I assume working days are 5 in a week
        return moneyPerDay / workHoursPerDay;
    }
}

