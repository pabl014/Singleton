using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;
using static Singleton.Database;


namespace Singleton {

    public class Database {

        private char[] tab = new char[100];
        private static Database database;
        private Database() {

        }
        private static Database GetInstance() {

            if (database == null) {
                database = new Database();
            }
            return database;
        }
        public static IConnection GetConnection() {

            return Connection.GetInstance();
        }





        public class Connection : IConnection {

            private static int i = 0;
            private static Connection[] connectionsTab = {

                new Connection(),
                new Connection(),
                new Connection()
            };
            private Connection() { 
            
            }
            public static IConnection GetInstance() {

                if (database == null) {
                    database = Database.GetInstance();
                }
                if (i == connectionsTab.Length) {
                    i = 0;
                }
                return connectionsTab[i++];
            }
            public char Get(int index) {

                return database.tab[index];
            }
            public void Set(int index, char c) {

                database.tab[index] = c;
            }
            public int Length() { 

                return database.tab.Count();
            }
        }
    }
}
