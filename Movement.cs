using Godot;
using System;

public class Movement : RigidBody
{
    public override void _PhysicsProcess(float delta)
    {
        if (Input.IsKeyPressed((int) KeyList.W))
        {
            AddCentralForce(Vector3.Forward * delta * 500);
        }
        if (Input.IsKeyPressed((int) KeyList.A))
        {
            AddCentralForce(Vector3.Left * delta * 500);
        }
        if (Input.IsKeyPressed((int) KeyList.S))
        {
            AddCentralForce(Vector3.Back * delta * 500);
        }
        if (Input.IsKeyPressed((int) KeyList.D))
        {
            AddCentralForce(Vector3.Right * delta * 500);
        }
    }
}
