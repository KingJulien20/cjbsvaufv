namespace Proiect_POO_NR2;

//gestionarea reservarilor:	-Stergere
//							-Adaugare
//							-Modificare
//							-Vizualizare



public class ReservationSystem
{
	private List<Reservation> reservations = new List<Reservation>();
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
		Console.WriteLine("These are all your reservations: ");
		foreach (var reservation in reservations)
		{
			if (reservation.ReservedBy == user || rolAngajat == RolAngajat.Manager || rolAngajat == RolAngajat.Admin)
			{
				Console.WriteLine(reservation);
			}
		}
	}

	public void AddReservation(int spotnumber)
	{
		if (reservations.Exists(r => r.SpotNumber == spotnumber))
		{
			Console.WriteLine("Reservation already exists");
		}
		else
		{
			reservations.Add(new Reservation { SpotNumber = spotnumber-1, ReservedBy = User });
		}
	}

	

	public void ModifyReservation(int newspotnumber, int Id)
	{
		var rez = reservations.Find(rezervation => rezervation.ID == Id);
		if (rez != null &&
		    (rez.ReservedBy == User || rolAngajat == RolAngajat.Manager || rolAngajat == RolAngajat.Admin))
		{
			Console.WriteLine("Choose another spotnumber: ");
			rez.SpotNumber = newspotnumber;
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
		    (rez.ReservedBy == User || rolAngajat == RolAngajat.Manager || rolAngajat == RolAngajat.Admin))
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
					if (!reservations.Exists(r => r.SpotNumber == i * 10 + j))
					{
						Console.Write(i * 10 + j + 1 + " ");
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
					if (!reservations.Exists(r => r.SpotNumber == i * 10 + j))
					{
						Console.Write(i * 10 + j + 1 + " ");
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
