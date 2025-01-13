namespace Proiect_POO_NR2;

public class Loc{
	public int Spot { get; set; }
	public bool Occupied{ get; set; }


	public Loc(int spot){
		Spot = spot;
		Occupied = false;
	}

	protected Loc(){
		throw new NotImplementedException();
	}
}