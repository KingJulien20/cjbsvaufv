namespace Proiect_POO_NR2;

//gestionarea reservarilor:	-Stergere
//							-Adaugare
//							-Modificare
//							-Vizualizare



public class ReservationSystem{
	private List<Reservation> reservations = new List<Reservation>();
	private RolAngajat rolAngajat;
	private string User;
	private int Id = 1;

	public ReservationSystem(RolAngajat rolAngajat, string user){
		this.rolAngajat = rolAngajat;
		this.User = user;
	}

	public void ViewReservations(string user){
		Console.WriteLine("These are all your reservations: ");
		foreach (var reservation in reservations){
			if (reservation.ReservedBy == user || rolAngajat == RolAngajat.Manager || rolAngajat == RolAngajat.Admin){
				Console.WriteLine(reservation);
			}
		}
	}

	public void AddReservation(int spotnumber){
		if (reservations.Exists(r => r.SpotNumber == spotnumber)){
			Console.WriteLine("Reservation already exists");
		}
		else{
			reservations.Add(new Reservation{ ID =  Id++, SpotNumber =  spotnumber, ReservedBy = User });
		}
	}

	public void ModifyReservation(int newspotnumber, int Id){
		var rez = reservations.Find(rezervation => rezervation.ID == Id);
			if(rez != null && (rez.ReservedBy == User || rolAngajat == RolAngajat.Manager || rolAngajat == RolAngajat.Admin)){
				Console.WriteLine("Choose another spotnumber: ");
				rez.SpotNumber = newspotnumber;
				Console.WriteLine("The Reservation has been successfully modified.");
			}
			else{
				Console.WriteLine("you cant modify this reservation or the reservation doesn't exist.");
			} 
	}
	
	public void DeleteReservation(int Id){
		var rez = reservations.Find(r => r.ID == Id);
		if(rez != null && (rez.ReservedBy == User || rolAngajat == RolAngajat.Manager || rolAngajat == RolAngajat.Admin))
		{
			reservations.Remove(rez);
			Console.WriteLine("The reservation has been deleted.");
		}
		else{
			Console.WriteLine("Permission denied or the reservation doesn't exist.");
		}
		
	}
	
	
	
	
	
	
	
	
}



	
	
