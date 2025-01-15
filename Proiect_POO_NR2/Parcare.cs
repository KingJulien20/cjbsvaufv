namespace Proiect_POO_NR2;

public class Parcare : Loc
{
	
	public Parcare(int spot, bool occupied) : base(spot, occupied){
		Spot = spot;
		Occupied = false; //status 
	}

	public override string ToString()
	{
		return $"Spot: {Spot}, Occupied: {(Occupied ? "Ocupat" : "Liber")}";

	}
	
	public override string ToString1()
	{
		return $"Spot: {Spot}, Occupied: {(Occupied ? "Ocupat" : "Liber")}";

	}
	
	public override string ToString2()
	{
		return $"Spot: {Spot}, Occupied: {(Occupied ? "Ocupat" : "Liber")}";

	}
}