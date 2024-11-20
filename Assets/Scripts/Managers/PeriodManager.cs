using UnityEngine;

/// <summary>
/// Utiliser cette classe pour gérer tout ce qui touche aux périodes de la journée.
/// </summary>
public class PeriodManager : DevObject
{
    public static PeriodManager Instance { get; private set; }

    [SerializeField]
    [Header("Périodes d'une journée")]
    private Period[] periods;
    
    private int _currentPeriodIndex;

    public int CurrentDay { get; private set; } = 1;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning($"PeriodManager already exists on {gameObject.name}. Object has been marked for destruction");
            Destroy(gameObject);
            return;
        }
        Instance = this;

        if (periods.Length == 0)
        {
            throw new UnityException("PeriodManager is empty. You must add at least one period.");
        }
        _currentPeriodIndex = 0;
    }

    public Period getCurrentPeriod()
    {
        return periods[_currentPeriodIndex];
    }

    public void NextPeriod()
    {
        if (_currentPeriodIndex == periods.Length - 1)
        {
            NextDay();
            return;
        }
        _currentPeriodIndex++;
    }

    private void NextDay()
    {
        CurrentDay++;
        _currentPeriodIndex = 0;
    }
    
}
