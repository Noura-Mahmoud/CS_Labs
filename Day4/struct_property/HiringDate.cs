// See https://aka.ms/new-console-template for more information
struct HiringDate
{
    byte day, month;
    int years;
    public byte Day
    {
        set
        { day = value; }
        get
        { return day; }
    }
    public byte Month
    {
        set
        { month = value; }
        get
        { return month; }
    }
    public int Years
    {
        set
        { years = value; }
        get
        { return years; }
    }
    public HiringDate(byte _day, byte _month, int _years)
    {
        day = _day;
        month = _month;
        years = _years;
    }

    public override string ToString()
    { return $"{day}/{month}/{years} "; }

}





