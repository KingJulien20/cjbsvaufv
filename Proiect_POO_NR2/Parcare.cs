namespace Proiect_POO_NR2;

public class Parcare : Loc
{
	
	public Parcare(int spot, bool occupied) : base(spot, occupied){
		Spot = spot;
		Occupied = false;
	}
}