using UnityEngine;

/// <summary>
/// Utiliser cette classe pour gérer tout ce qui touche aux périodes de la journée.
/// </summary>
public class PeriodManager : MonoBehaviour
{
    public static PeriodManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError($"PeriodManager already exists on {gameObject.name}. Object has been marked for destruction");
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    
    // TODO implémenter les méthodes et attributs permettant la gestion des périodes
}
