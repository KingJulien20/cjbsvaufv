namespace Proiect_POO_NR2;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("User Name: ");
		string userName = Console.ReadLine();
		
		Console.WriteLine("Select Role: \n 1: Employee\n 2: Manager\n 3: Admin");
		RolAngajat role = (RolAngajat)(int.Parse(Console.ReadLine()) - 1);
		
		ReservationSystem system = new ReservationSystem(role, userName);
		string option;

		do
		{
			Console.WriteLine("\n1. View Spots\n2. Make Reservation\n3. View Reservations\n4. Modify Reservation\n5. Delete Reservation\n6. Exit");
			option = Console.ReadLine();
			
			switch (option)
			{
				case "1":
					Console.WriteLine("Enter type (Office or Parking): ");
					string type = Console.ReadLine();
					system.ViewReservations(type);
					break;

				case "2":
					//Console.WriteLine("Enter type (Office or Parking): ");
					//string resType = Console.ReadLine();
					Console.WriteLine("Enter spot number: ");
					int spot = int.Parse(Console.ReadLine());
					system.AddReservation(spot);
					break;

				case "3":
					system.ViewReservations(userName);
					break;

				case "4":
					Console.WriteLine("Enter reservation ID: ");
					int resId = int.Parse(Console.ReadLine());
					Console.WriteLine("Enter new spot number: ");
					int newSpot = int.Parse(Console.ReadLine());
					system.ModifyReservation(resId, newSpot);
					break;

				case "5":
					Console.WriteLine("Enter reservation ID: ");
					int delId = int.Parse(Console.ReadLine());
					system.DeleteReservation(delId);
					break;
			}
		} while (option != "6");
	}
}