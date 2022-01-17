 class OneBHK
{
    double room_Area, hall_Area, price;
    public OneBHK()
    {

    }
   public  OneBHK(double room_Area,double hall_Area,double price)
    {
        this.room_Area = room_Area;
        this.hall_Area = hall_Area;
        this.price = price;
    }
    public virtual void show()
    {
        Console.WriteLine(" Room area:" + room_Area + " Hall area:" + hall_Area + " Price:" + price+" /-");
    }
}
 class TwoBHK : OneBHK
{
    double room2Area;
    public TwoBHK()
    {

    }
    public TwoBHK(double room2Area)
    {
        this.room2Area = room2Area;
       

    }
    public override void show()
    {
        base.show();
        { Console.WriteLine("Room2Area:" + room2Area); }
       
    }

}
class XYZ
{
    public static void Main()
    {
       OneBHK b1 = new OneBHK(200, 400, 12000);
        TwoBHK t1 = new TwoBHK(100);
        t1.show();
        
        

    }
}