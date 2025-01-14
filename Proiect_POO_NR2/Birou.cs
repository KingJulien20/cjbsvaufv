namespace Proiect_POO_NR2;

public class Birou : Loc
{
	public Birou(int spot, bool occupied) : base(spot, occupied){
		Spot = spot;
		Occupied = false;
	}

	public override string ToString()
	{
		return $"Spot: {Spot}, Occupied: {(Occupied ? "Ocupat" : "Liber")}";	
	}
	
	
}