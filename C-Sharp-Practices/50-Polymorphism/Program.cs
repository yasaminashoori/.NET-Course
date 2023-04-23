using System;

namespace _50_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var bigRoom = new Rooms();
            var oldElevator = new Elevator();

            Building[] buildingComponents = {bigRoom, oldElevator};
            foreach (var component in buildingComponents)
            {
                component.CostofRepair();
            }
        }

        public class Building
        {
            public double Name { get; set; }
            public virtual void CostofRepair()
            {
                Console.WriteLine("The whole cost for repair Building : 1M $");
            }
        }

        public class Rooms : Building
        {
            public override void CostofRepair()
            {
                Console.WriteLine("The whole cost for repair Rooms  500k $: ");
            }
        }

        public class Elevator : Building
        {
            public override void CostofRepair()
            {
                Console.WriteLine("The whole cost for repair Elevator : 100k $");
            }
        }
    }
}
