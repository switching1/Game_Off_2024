using UnityEngine;

/// <summary>
/// Utiliser cette classe comme une classe globale permettant de stocker des informations qui doivent être accessibles
/// depuis tous les objets du jeu.
/// </summary>
public class GameState : MonoBehaviour
{
    public static GameState Instance { get; private set; }
    
    public Monk monk;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning($"GameState already exists on {gameObject.name}. Object has been marked for destruction");
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
}
