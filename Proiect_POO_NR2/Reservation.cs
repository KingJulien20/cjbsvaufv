namespace Proiect_POO_NR2;


public class Reservation{
	public int ID { get; set; }
	public int SpotNumber { get; set; }
	public string ReservedBy { get; set; }
//aici trebuie sa faci cumva, sa mostenesti id-ul din User, pentru ca nu l afiseaza pe cel introdus
//la case 6 , imi merge cand il caut dupa id
//doar aici cred ca trebuie sa schimbi , ca sa mearga toate
	public override string ToString(){
		return $"ID: {ID}, SpotNumber: {SpotNumber+1}, ReservedBy: {ReservedBy}";
	}
}