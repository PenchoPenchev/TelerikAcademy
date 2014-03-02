/*1. Define a class that holds information about a mobile phone device: 
 * model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and 
 * display characteristics (size and number of colors). 
 * Define 3 separate classes (class GSM holding instances of the classes Battery and Display).*/

/*2. Define several constructors for the defined classes 
 * that take different sets of arguments (the full information for the class or part of it). 
 * Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.*/

/*3. Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.*/

/*4. Add a method in the GSM class for displaying all information about it. Try to override ToString().*/

/*5. Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. 
 * Ensure all fields hold correct data at any given time.*/

/*6. Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.*/

namespace _01.DefineClassesGSM_Battery_Display
{
    using System;
    using System.Text;

    public class MainClass
    {
        static void Main()
        {
        }
    }

    public class GSM
    {
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private static string iPhone4S;

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, double? price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, double? price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public double? Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public string IPhone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }

        Battery newBattery = new Battery("Li-Ion 3100 mAh", 980, 35, BatteryType.LiIon);

        Display newDisplay = new Display(5.55, 16000000);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Model: " + this.Model);
            sb.AppendLine("Manufacturer: " + this.Manufacturer);
            sb.AppendLine("Price: " + this.Price + "lv");
            sb.AppendLine("Owner: " + this.Owner);
            sb.AppendLine("Battery model: " + newBattery.Model);
            sb.AppendLine("Battery type: " + newBattery.Type);
            sb.AppendLine("Hours idle: " + newBattery.HoursIdle);
            sb.AppendLine("Hours talk: " + newBattery.HoursTalk);
            sb.AppendLine("Display size: " + newDisplay.Size);
            sb.AppendLine("Display colors: " + newDisplay.NumberOfColors);

            return sb.ToString();
        }
    }

    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }

    public class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType type;

        public Battery()
        {

        }

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, double? hoursIdle)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk)
            : this(model, hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryType type)
            : this(model, hoursIdle, hoursTalk)
        {
            this.Type = type;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double? HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public double? HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public BatteryType Type
        {
            get { return type; }
            set { type = value; }
        }
    }

    public class Display
    {
        private double? size;
        private int? numberOfColors;

        public Display()
        {

        }

        public Display(double? size)
        {
            this.Size = size;
        }

        public Display(double? size, int? numberOfColors)
            : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }

        public double? Size
        {
            get { return size; }
            set { size = value; }
        }

        public int? NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }
    }
}
