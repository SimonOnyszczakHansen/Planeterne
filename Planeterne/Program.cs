namespace Planeterne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Our list for the planets
            List<Planet> planets = new List<Planet>();

            //Objects
            Planet mercury = new Planet("Mercury", 167, 4879);
            Planet venus = new Planet("Venus", 464, 12104);
            Planet earth = new Planet("Earth", 15, 12756);
            Planet mars = new Planet("Mars", -65, 6792);
            Planet jupiter = new Planet("Jupiter", -110, 142984);
            Planet saturn = new Planet("Saturn", -140, 120536);
            Planet uranus = new Planet("Uranus", -195, 51118);
            Planet neptune = new Planet("Neptune", -200, 49528);
            Planet pluto = new Planet("Pluto", -225, 2370);

            //We add the objects to the lsit
            planets.Add(mercury);
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);
            planets.Insert(1, venus);
            planets.Remove(pluto);
            planets.Add(pluto);


            //write their names in console
            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet.Name);
            }
            //Writes the list count in console
            Console.WriteLine(" ");
            Console.WriteLine("Der er " + planets.Count + " elementer i listen");
            Console.WriteLine(" ");

           //We make a new llist
            List<Planet> temperature = new List<Planet>();
            foreach(Planet planet in planets)
            {
                //If the temperature is below 0 we add the planet to the list
                if (planet.Temperature < 0)
                {
                    temperature.Add(planet);
                }                
            }
            foreach (Planet planet in temperature)
            {
                //Write the planets names in console
                Console.WriteLine(planet.Name);
            }

            //Space
            Console.WriteLine(" ");

            //New list
            List<Planet> diameter = new List<Planet>();
            foreach(Planet planet in planets)
            {
                //We add the planet to  the list if its diameter is above 10000 and below 50000
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                {
                    diameter.Add(planet);
                }
            }
            foreach(Planet planet in diameter)
            {
                //write the planets name in console
                Console.WriteLine(planet.Name);
            }
            
            //Clear the planets
            planets.Clear();
            foreach(Planet planet in planets)
            {
                Console.WriteLine(planet.Name);
            }
        }
        class Planet
        {
            //Instance variables
            private string name;
            private int temperature;
            private int diameter;

            //Incapsulations
            public string Name { get { return name; } }
            public double Temperature { get { return temperature; } }
            public int Diameter { get { return diameter; } }

            //Constructor
            public Planet(string Name, int Temperature, int Diameter)
            {
                this.name = Name;
                this.temperature = Temperature;
                this.diameter = Diameter;
            }
        }
    }
}