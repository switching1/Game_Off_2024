using UnityEngine;

public class GameplayStateManager
{
    private static GameplayStateManager _instance;

    public static GameplayStateManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameplayStateManager();
            }

            return _instance;
        }
    }

    public GameplayState CurrentGameplayState { get; private set; }

    public delegate void GameplayStateChangeHandler(GameplayState newGameplayState);
    public event GameplayStateChangeHandler OnGameplayStateChanged;

    private GameplayStateManager()
    {
        CurrentGameplayState = GameplayState.Menu;
    }

    public void SetState(GameplayState newGameplayState)
    {
        if (newGameplayState == CurrentGameplayState) return;

        CurrentGameplayState = newGameplayState;
        OnGameplayStateChanged?.Invoke(newGameplayState);
    }
}