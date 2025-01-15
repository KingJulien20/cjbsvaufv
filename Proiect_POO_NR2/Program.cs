namespace Proiect_POO_NR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Reservation System!\n"); //modificare
            Console.WriteLine("Please press 1 to continue or 0 to exit."); //modificare

            int optiune1; //modificare
            while(!int.TryParse(Console.ReadLine(), out optiune1) || optiune1 < 0 || optiune1 > 1) //modificare
            {
                Console.WriteLine("Invalid option. Please press 1 to continue or 0 to exit."); //modificare
            }
            while (optiune1 != 0) //modificare
            {
                Console.WriteLine("User Name: ");
                string userName = Console.ReadLine();
                
                Console.WriteLine("Select Role: \n 1: Employee\n 2: Manager\n 3: Admin");
                RolAngajat role = (RolAngajat)(int.Parse(Console.ReadLine()) - 1);
                User currentUser = new User(userName, role);
                User.AddUser(currentUser);

                ReservationSystem system = new ReservationSystem(role, userName);
                string option;

                do
                {
                    Console.WriteLine(
                        "\n1. View Spots\n2. Make Reservation\n3. View Reservations\n4. Modify Reservation\n5. Delete Reservation\n6. Get user by ID" +
                        "\n7. Display all Users\n9. Exit");
                    option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Enter type (Office or Parking): ");
                            string type = Console.ReadLine();
                            system.ViewReservations(type);
                            break;//modificare

                        case "2":
                            Console.WriteLine("Enter Office number: ");
                            int spot = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Parking number: ");
                            int spot1 = int.Parse(Console.ReadLine());

                            Reservation reserve = new Reservation(spot ,userName,spot1, role);
                            system.AddReservation(reserve);
                            break;

                        case "3":
                            system.View1Reservations(userName);
                            break;//modificare

                        case "4":
                            //merge 
                            Console.WriteLine("Enter reservation ID: ");
                            int resId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter new spot number: ");
                            int newSpot = int.Parse(Console.ReadLine());
                            system.ModifyReservation(newSpot, resId);
                            break;

                        case "5":
                            Console.WriteLine("Enter reservation ID: ");
                            int delId = int.Parse(Console.ReadLine());
                            system.DeleteReservation(delId);
                            break;//Reservations

                        case "6":
                            Console.WriteLine("Enter the id that you want to see: ");
                            int id1 = int.Parse(Console.ReadLine());
                            User.GetUserById(id1);
                            break;//modificare

                        case "7":
                            User.DisplayAllUsers();
                            break;//modificare

                        case "9":
                            Console.WriteLine("Exiting to main menu...");
                            break;//modificare

                        default:
                            Console.WriteLine("Invalid option.");
                            break;//modificare
                    }

                } while (option != "9"); //modificare

                Console.WriteLine("Please press 1 to continue or 0 to exit."); //modificare
                while (!int.TryParse(Console.ReadLine(), out optiune1) || optiune1 < 0 || optiune1 > 1){
                     Console.WriteLine("Invalid option. Please press 1 to continue or 0 to exit."); //modificare
                }
            }
            
            Console.WriteLine("Exiting program...\nGoodbye!");//modificare
            Environment.Exit(0);
        }
    }
}