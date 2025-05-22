using System;
using Menu.Entities.Enums;



namespace Menu.Entities
{

    class HourContract
    {
        public DateTime Date {get; set;}
        public double ValuePerHours {get; set;}
        public int Hours {get; set;}


        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHours, int hour)
        {
            Date = date;
            ValuePerHours = valuePerHours;   
            Hours = hour;
        }


        public double TotalValue()
        {
            return ValuePerHours * Hours;
        }
    }
}