using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField] private KeyCode pauseKeyCode;

    private void Update()
    {
        if (Input.GetKeyDown(pauseKeyCode))
        {
            GameplayState currentGameplayState = GameplayStateManager.Instance.CurrentGameplayState;

            if (currentGameplayState == GameplayState.Menu) return;

            GameplayState newGameplayState = currentGameplayState == GameplayState.Gameplay 
                ? GameplayState.Paused 
                : GameplayState.Gameplay;

            GameplayStateManager.Instance.SetState(newGameplayState);
        }
    }
}