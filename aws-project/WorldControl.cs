using Godot;
using System;

public partial class WorldControl : Node3D
{
    [Export]
    public float wallHeight {get; set;} = 0;

    public override void _Ready()
    {
        StaticBody3D wall1Collision = GetNode<StaticBody3D>("Wall1/CollisionShape3D");
        StaticBody3D wall1Mesh = GetNode<StaticBody3D>("Wall1/MeshInstance3D");
        
        StaticBody3D wall2Collision = GetNode<StaticBody3D>("Wall2/CollisionShape3D");
        StaticBody3D wall2Mesh = GetNode<StaticBody3D>("Wall2/MeshInstance3D");
        
        StaticBody3D wall3Collision = GetNode<StaticBody3D>("Wall3/CollisionShape3D");
        StaticBody3D wall3Mesh = GetNode<StaticBody3D>("Wall3/MeshInstance3D");
        
        StaticBody3D wall4Collision = GetNode<StaticBody3D>("Wall4/CollisionShape3D");
        StaticBody3D wall4Mesh = GetNode<StaticBody3D>("Wall4/MeshInstance3D");

        wall1Collision.Scale *= new Vector3(1, wallHeight, 1);
        wall1Mesh.Scale *= new Vector3(1, wallHeight, 1);

        wall2Collision.Scale *= new Vector3(1, wallHeight, 1);
        wall2Mesh.Scale *= new Vector3(1, wallHeight, 1);

        wall3Collision.Scale *= new Vector3(1, wallHeight, 1);
        wall3Mesh.Scale *= new Vector3(1, wallHeight, 1);

        wall4Collision.Scale *= new Vector3(1, wallHeight, 1);
        wall4Mesh.Scale *= new Vector3(1, wallHeight, 1);
    }
}
