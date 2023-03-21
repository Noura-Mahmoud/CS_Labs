// See https://aka.ms/new-console-template for more information
struct HiringDate
{
    byte day;
    byte month;
    int years;
    public HiringDate(byte _day, byte _month, int _years)
    {
        day = _day;
        month = _month;
        years = _years;
    }

    public override string ToString()
    {return $"{day}/{month}/{years} ";}
    public void setDay (byte _day){ day = _day;}
    public byte getDay() { return day; }
    public void setMonth (byte _month) { month = _month; }
    public byte getMonth() { return month; }
    public void setYear (int _year) { years = _year; }
    public int getYears() { return years; }
}





