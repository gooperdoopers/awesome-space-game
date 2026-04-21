using Godot;
using System;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Player : CharacterBody3D
{
    [Export]
    public float speed { get; set; } = 0;
    private float strafeDirection = 0;
    private float walkDirection = 0;
    
    
    public override void _Ready() 
    {
        Camera3D playerCamera = GetNode<Camera3D>("Camera3D");
        playerCamera.MakeCurrent();
    }

    public override void _Input(InputEvent @event)
    {
        strafeDirection = Input.GetAxis("walk_left", "walk_right");
        walkDirection = Input.GetAxis("walk_foreward", "walk_backward");
    }
    public override void _PhysicsProcess(double delta)
    {
        Vector2 mousePos2D = GetViewport().GetMousePosition();
        //Converting this 2d -> 3d is confusing me
        Vector3 mousePos3D = new Vector3(mousePos2D.Y, 0, mousePos2D.X);


        LookAt(mousePos3D);
        GD.Print(strafeDirection, " ", walkDirection);
    }

}
