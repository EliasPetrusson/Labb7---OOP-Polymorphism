namespace Labb7___OOP_Polymorphism
{
        public class Geometri //Parent class med return type double
        {
            public virtual double Area()
            {
                return 0;
            }
        }

        public class Rektangel : Geometri //Rektangel klass som ärver från Geometri
        {
            public double Length { get; set; } //Egenskap 1
            public double Width { get; set; } //Egenskap 2

            public Rektangel() //Konstruktor
            {
                Length = 6;
                Width = 8;
            }

            public override double Area()
            {
                return Length * Width;
            }
        }

        public class Fyrkant : Geometri //Fyrkant klass som ärver från Geometri
        {
            public double Side { get; set; } //Egenskap

            public Fyrkant() //Konstruktor
            {
                Side = 8;
            }

            public override double Area()
            {
                return Side * Side;
            }
        }

        public class Cirkel : Geometri //Cirkel klass som ärver från Geometri
        {
            public double Radius { get; set; } //Egenskap 

            public Cirkel() //Konstruktor
            {
                Radius = 8;
            }

            public override double Area()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class Parallellogram : Geometri //Paralellogram klass som ärver från Geometri
        {
            public double Base { get; set; } //Egenskap 1
            public double Height { get; set; } //Egenskap 2

            public Parallellogram() //Konstruktor
            {
                Base = 7;
                Height = 8;
            }

            public override double Area() 
            {
                return Base * Height;
            }
        }

        public class Ellips : Geometri //Ellips klass som ärver från Geometri
        {
            public double MajorAxis { get; set; } //Egenskap 1
            public double MinorAxis { get; set; } //Egenskap 2

            public Ellips() //Konstruktor
            {
                MajorAxis = 8;
                MinorAxis = 5;
            }

            public override double Area()
            {
                return Math.PI * MajorAxis * MinorAxis;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Geometri[] former = new Geometri[]
                {
                  new Rektangel(),
                  new Fyrkant(),
                  new Cirkel(),
                  new Parallellogram(),
                  new Ellips()
                };

                foreach (Geometri form in former)
                {
                    Console.WriteLine($"Area på {form.GetType().Name}: {form.Area()}");
                }
            }
        }
}