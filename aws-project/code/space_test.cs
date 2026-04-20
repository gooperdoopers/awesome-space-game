using Godot;
using System;
using AWSLib.MatrixesLib;
using AWSLib.ConstructsLib;

public partial class space_test : Node
{
	// Called when the node enters the scene tree for the first time.
	public int[][][][] ourShip;
	public override void _Ready()
	{
		ourShip = Matrixes.Create(20,20,3,5);
		int yuh = Matrixes.Search(ourShip,0,0,0,0);
		Spacecraft craft = Constructs.CreateShip();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
