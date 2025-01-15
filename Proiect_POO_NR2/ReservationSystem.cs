namespace Proiect_POO_NR2;

//gestionarea reservarilor:	-Stergere
//							-Adaugare
//							-Modificare
//							-Vizualizare



public class ReservationSystem
{
	private static List<Reservation> reservations = new List<Reservation>();
	private List<User> users = new List<User>();
	private RolAngajat rolAngajat;
	private string User;

	public ReservationSystem(RolAngajat rolAngajat, string user)
	{
		this.rolAngajat = rolAngajat;
		this.User = user;
	}

	public void View1Reservations(string user)//modificare
	{
		Console.WriteLine("These are all reservations you have access to: ");
		foreach (var reservation in reservations)
		{
			if (reservation.ReservedBy == user || (rolAngajat == RolAngajat.Manager && reservation.RolAngajati != RolAngajat.Admin) || rolAngajat == RolAngajat.Admin)
			{
				Console.WriteLine(reservation);
			}
		}
	}

	public void AddReservation( Reservation reservation)
	{
		if (reservations.Exists(r => r.OfficeNumber == reservation.OfficeNumber || r.ParkingNumber == reservation.ParkingNumber))
		{
			Console.WriteLine("Reservation already exists");
		}
		else
		{
			reservations.Add(reservation);
		}
	}

	

	public void ModifyReservation(int newspotnumber, int Id)
	{
		var rez = reservations.Find(rezervation => rezervation.ID == Id);
		if (rez != null && (rez.ReservedBy == User || (rolAngajat == RolAngajat.Manager && rez.RolAngajati != RolAngajat.Admin) || rolAngajat == RolAngajat.Admin))
		{
			Console.WriteLine("Office or Parking number?");
			string type = Console.ReadLine();
			if(type == "Office")
			{
				Console.WriteLine("Choose another Office number: ");
				rez.OfficeNumber = newspotnumber;
			}
			else if(type == "Parking")
			{
				Console.WriteLine("Choose another Parking number: ");
				rez.ParkingNumber = newspotnumber;
			}
			else
			{
				Console.WriteLine("Invalid type");
			}
			
		    Console.WriteLine("The Reservation has been successfully modified.");

		}
		else
		{
			Console.WriteLine("you cant modify this reservation or the reservation doesn't exist.");
		}
	}

	public void DeleteReservation(int Id)
	{
		var rez = reservations.Find(r => r.ID == Id);
		if (rez != null &&
		    (rez.ReservedBy == User || (rolAngajat == RolAngajat.Manager && rez.RolAngajati != RolAngajat.Admin) || rolAngajat == RolAngajat.Admin))
		{
			reservations.Remove(rez);
			Console.WriteLine("The reservation has been deleted.");
		}
		else
		{
			Console.WriteLine("Permission denied or the reservation doesn't exist.");
		}

	}

	public void ViewReservations(string type)//modificare
	{
		if (type == "Parking")
		{
			Console.WriteLine("These are all the parking spots: ");
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					if (!reservations.Exists(r => r.ParkingNumber == i * 10 + j + 1))
					{
						Console.Write(0 + " ");
					}
					else
					{
						Console.Write("X ");
					}
				}

				Console.WriteLine();
			}
		}
		else if (type == "Office")
		{
			Console.WriteLine("These are all the office spots: ");
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					if (!reservations.Exists(r => r.OfficeNumber == i * 10 + j + 1))
					{
						Console.Write(0 + " ");
					}
					else
					{
						Console.Write("X ");
					}
				}

				Console.WriteLine();
			}
		}
		else
		{
			Console.WriteLine("Invalid type");
		}
	}
}
