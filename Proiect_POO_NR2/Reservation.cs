namespace Proiect_POO_NR2;


public class Reservation{
	public int ID { get; set; }
	public int SpotNumber { get; set; }
	public string ReservedBy { get; set; }

	public override string ToString(){
		return $"ID: {ID}, SpotNumber: {SpotNumber}, ReservedBy: {ReservedBy}";
	}
}