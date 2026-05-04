using Godot;
using System;

public partial class MeshInstance3d : MeshInstance3D
{
    public override void _PhysicsProcess(double delta)
    {
        Raycast raycast = GetNode<Raycast>("Raycast");
        LookAt(raycast.currentMousePosition);

        GD.Print(raycast.currentMousePosition);
    }

    public override void _Process(double delta)
    {
        Vector3 currentRotation = Rotation;
        currentRotation.X = 0;
        Rotation = currentRotation;
    }

}
