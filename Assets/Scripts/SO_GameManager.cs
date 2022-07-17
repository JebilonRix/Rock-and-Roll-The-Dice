using UnityEngine;

public class SO_GameManager : ScriptableObject
{
    private GameStates _gameStates;

    public void ChangeState(int index)
    {
        if (index == 0)
        {
            _gameStates = GameStates.MainMenu;
        }
        else if (index == 1)
        {
            _gameStates = GameStates.Game;
        }
        else if (index == 2)
        {
            _gameStates = GameStates.Win;
        }
        else if (index == 3)
        {
            _gameStates = GameStates.Lose;
        }
    }
}

public enum GameStates
{
    MainMenu,
    Game,
    Win,
    Lose
}