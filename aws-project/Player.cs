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
}
