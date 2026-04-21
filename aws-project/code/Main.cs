using Godot;
using AWSLib.ConstructsLib;
using AWSLib.ComponentsLib;
public partial class Main : Node2D
{
	public override void _Ready()
	{
		Constructs.visualTemp = GetNode<Polygon2D>("../grid");
		Spacecraft testShip = Constructs.CreateShip([500,500]);
        Constructs.AddComponent(new awesomeMachine(), testShip,[0,0]);
		Constructs.AddComponent(new awesomeMachine(), testShip,[0,4]);
		Constructs.AddComponent(new awesomeMachine(), testShip,[4,4]);
		Constructs.VisualizeShip(testShip);
	}
}
