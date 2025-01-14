namespace Proiect_POO_NR2;


public class Reservation{
	private static HashSet<int> usedIDs = new HashSet<int>();
	private static Random random = new Random();
	public int ID{get; private set;}
	
	public int SpotNumber { get; set; }
	public string ReservedBy { get; set; }
	public RolAngajat RolAngajat { get; set; }


	public Reservation( int spotNumber, string reservedBy){
		ID = GenerateID();
		SpotNumber = spotNumber;
		ReservedBy = reservedBy;
	}

	public override string ToString(){
		return $"ID: {ID}, SpotNumber: {SpotNumber}, ReservedBy: {ReservedBy}, {RolAngajat}";
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
