namespace Proiect_POO_NR2;

public abstract class Loc{
	public int Spot { get; set; }
	public bool Occupied{ get; set; }


	public Loc(int spot, bool occupied){
		Spot = spot;
		Occupied = false;
	}
	public abstract override string ToString();
}