using Godot;
using System;

public class Coin : Area
{
    [Export] public NodePath PlayerPath;
    [Export] public NodePath ManagerPath;

    private RigidBody Player;
    private ScoreManager Manager;
    
    public override void _Ready()
    {
        Player = GetNode<RigidBody>(PlayerPath);
        Manager = GetNode<ScoreManager>(ManagerPath);
    }

    public override void _PhysicsProcess(float delta)
    {
        if (OverlapsBody(Player))
        {
            Manager.Score += 1;
            QueueFree();
        }
    }
}
