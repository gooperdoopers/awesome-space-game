using Godot;
using System;

public partial class Raycast : Node3D
{
    private Camera3D camera;
    private const float RayLength = 1000.0f;
    public Vector3 currentMousePosition { get; private set; }

    public override void _Ready()
    {
        camera = GetViewport().GetCamera3D();
    }

    public override void _PhysicsProcess(double delta)
    {
        Vector3 mousePosition3D = GetMousePositionIn3D();
        if (mousePosition3D != Vector3.Zero)
        {
            currentMousePosition = mousePosition3D;
        }
    }

    public Vector3 GetMousePositionIn3D()
    {
        Vector2 mousePos2D = GetViewport().GetMousePosition();
        
        Vector3 rayOrigin = camera.ProjectRayOrigin(mousePos2D);
        Vector3 rayEnd = rayOrigin + camera.ProjectRayNormal(mousePos2D) * RayLength;

        var spaceState = GetWorld3D().DirectSpaceState;
        var query = PhysicsRayQueryParameters3D.Create(rayOrigin, rayEnd);

        var result = spaceState.IntersectRay(query);

        if (result.Count > 0)
        {
            return (Vector3)result["position"];
        }

        return Vector3.Zero;
    }
}
