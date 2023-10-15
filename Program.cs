
namespace Singleton {
    class Program {
        static void Main(string[] args) {

            //  3 different connections to database:
            IConnection connection1 = Database.GetConnection();
            IConnection connection2 = Database.GetConnection();
            IConnection connection3 = Database.GetConnection();

            // Test of different connections:
            Console.WriteLine("connection1 == connection2: " + (connection1 == connection2));
            Console.WriteLine("connection2 == connection3: " + (connection2 == connection3));

            // New con4 and test if con4 == con1:
            IConnection connection4 = Database.GetConnection();
            Console.WriteLine("connection1 == connection4: " + (connection1 == connection4));

            // Test if con1 will give the same value as con2
            connection1.Set(0, 'a');
            connection2.Set(1, 'b');

            Console.WriteLine("connection1.get(0) == connection2.get(0): " + (connection1.Get(0) == connection2.Get(0)));
            Console.WriteLine("connection1.get(1) == connection2.get(1): " + (connection1.Get(1) == connection2.Get(1)));
        }
    }
}