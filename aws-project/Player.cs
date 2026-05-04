using Godot;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

public partial class Player : CharacterBody3D
{
    [Export]
    public float speed { get; set; } = 0;
    private float strafeDirection = 0;
    private float walkDirection = 0;


    public void GetInput()
    {
        Godot.Vector2 inputData = Input.GetVector("walk_right","walk_left","walk_backward","walk_foreward");
        Godot.Vector3 inputDir = new Godot.Vector3(inputData.X, 0 ,inputData.Y);
        Velocity = inputDir * speed;
    }
    public override void _PhysicsProcess(double delta)
    {
        GetInput();
        MoveAndSlide();
    }
}
