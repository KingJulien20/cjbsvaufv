namespace Proiect_POO_NR2;


public class Reservation{
	private static HashSet<int> usedIDs = new HashSet<int>();
	private static Random random = new Random();
	public int ID{get; private set;}
	
	public int ParkingNumber { get; set; }

	public int OfficeNumber { get; set; }

	public string ReservedBy { get; set; }
	public RolAngajat RolAngajati { get; set; }


	public Reservation( int officeNumber, string reservedBy, int parkingNumber, RolAngajat rolAngajati){
		ID = GenerateID();
		ParkingNumber = parkingNumber;
		ReservedBy = reservedBy;
		OfficeNumber = officeNumber;
		RolAngajati = rolAngajati;
	}

	
	
	public override string ToString(){
		if(OfficeNumber == 0){
			return $"ID: {ID}, Parking Number : {ParkingNumber}, ReservedBy: {ReservedBy}";
		}
		else if(ParkingNumber == 0){
			return $"ID: {ID}, Office Number: {OfficeNumber}, ReservedBy: {ReservedBy}";
		}
		else{
			return $"ID: {ID}, Office Number: {OfficeNumber}, Parking Number : {ParkingNumber}, ReservedBy: {ReservedBy}";
		}
	}

	public int GenerateID(){
		int newID;
		do
		{
			newID = random.Next(1000, 9999);
		} while (usedIDs.Contains(newID));

		usedIDs.Add(newID);
		return newID;
	}
}
