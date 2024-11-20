using UnityEngine;

public abstract class Period : DevObject
{
    [Header("Durée de la période en heures")] [Min(0)] [SerializeField]
    private int periodDuration;

    [Header("Durée d'une heure en secondes")] [Min(0)] [SerializeField]
    private float hourDuration;

    private int _remainingHours;
    private GameObject _timerObject;

    public void StartPeriod()
    {
        Debug.Log(gameObject.name + " is starting period");
        _remainingHours = periodDuration;
        StartHour(); // Démarre la première heure
    }

    private void OnPeriodEnd()
    {
        GameState().periodManager.NextPeriod();
    }

    public void StartHour()
    {
        Debug.Log(_remainingHours);
        _timerObject = new GameObject("Timer");
        var t = _timerObject.AddComponent<Timer.Timer>();
        t.RemainingSeconds = hourDuration;
        t.OnTimerEnd += OnHourEnd;
    }

    private void OnHourEnd()
    {
        Destroy(_timerObject);
        GameState().monk.AppearanceRoll(); // Appelle la fonction qui peut faire apparaitre le moine.
    }

    public void NextHour()
    {
        _remainingHours--;

        if (_remainingHours <= 0)
        {
            OnPeriodEnd();
            return;
        }
        
        StartHour(); // Démarre l'heure suivante.
    }
}