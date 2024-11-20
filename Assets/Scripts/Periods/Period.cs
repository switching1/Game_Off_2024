using UnityEngine;

public abstract class Period : DevObject
{
    [Header("Durée de la période en heures")] [Min(0)] [SerializeField]
    private int periodDuration;

    [Header("Durée d'une heure en secondes")] [Min(0)] [SerializeField]
    private float hourDuration;

    private int _remainingHours;

    public void StartPeriod()
    {
        _remainingHours = periodDuration;
        StartHour(); // Démarre la première heure
    }

    private void OnPeriodEnd()
    {
    }

    public void StartHour()
    {
        var timer = new Timer.Timer(hourDuration);
        timer.OnTimerEnd += OnHourEnd;
    }

    private void OnHourEnd()
    {
        GameState().monk.AppearanceRoll(); // Appelle la fonction qui peut faire apparaitre le moine.
    }

    public void NextHour()
    {
        _remainingHours--;

        if (_remainingHours == 0)
        {
            OnPeriodEnd();
            return;
        }
        
        StartHour(); // Démarre l'heure suivante.
    }
}