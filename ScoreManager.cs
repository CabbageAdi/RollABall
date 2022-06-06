using Godot;
using System;

public class ScoreManager : Control
{
    [Export] public NodePath LabelPath;
    [Export] public int CoinCount;
    
    public int Score;

    public Label Label;
    
    public override void _Ready()
    {
        Score = 0;
        Label = GetNode<Label>(LabelPath);
    }

    public override void _Process(float delta)
    {
        if (Score >= CoinCount)
        {
            Label.Text = "Win!";
        }
        else
        {
            Label.Text = "Score: " + Score;
        }
    }
}
