using Godot;
using AWSLib.ConstructsLib;
using AWSLib.ComponentsLib;
// 4.40gb
// at 500x500 4.63gb uses 0.28gb
// at 1000x1000 5.18gb uses 0.78gb
// at 1500x1500 6.00gb uses 1.6gb
// at 2000x2000 7.35g uses 2.95gb
// at cool super awesome use like 0gb


public partial class Main : Node3D
{
	public override void _Ready()
	{
		Constructs.visualTemp = GetNode<Node3D>("../datrat");
		Spacecraft testShip = Constructs.CreateShip([1000,1000]);
		Constructs.AddComponent(AwesomeMachine.Instance, testShip,[0,0]);
		Constructs.AddComponent(AwesomeMachine.Instance, testShip,[0,4]);
		Constructs.AddComponent(AwesomeMachine.Instance, testShip,[4,4]);
		Constructs.VisualizeShip(testShip);
	}
}
