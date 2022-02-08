using Classes;

Donut doug = new Donut("Jelly Filled");
// doug.donutType = "Jelly Filled";
doug.SetDonutType("Glazed");
Console.WriteLine(doug.GetDonutType());

// Filling Property
doug.Filling = "Strawberry Jam";
Console.WriteLine(doug.Filling);

doug.Topping = "Sprinkles";
doug.IsSpecial = false;
doug.Price = 1.98;
Console.WriteLine($"This donut is {doug.GetDonutType()}, full of {doug.Filling}, and topped with {doug.Topping} for ${doug.Price}.");

namespace Classes
{
    //Class declaration
    class Donut
    {
        //Private field for the donut type
        private string donutType;

        // Constructor
        public Donut(string type)
        {
            donutType = type;
        }

        // Properties with get and set accessors
        public string Filling { get; set; }
        public string Topping { get; set; }
        public double Price { get; set; }
        public bool IsSpecial {get; set; }

        // Methods to get and set the value for the donutType field
        public string GetDonutType()
        {
            return donutType;
        }

        public void SetDonutType(string type)
        {
            donutType = type;
        }
    }
}
//accessModifier returnType MethodName(parameterType parameterName)
//{
    // Statements that get run here;
//}














