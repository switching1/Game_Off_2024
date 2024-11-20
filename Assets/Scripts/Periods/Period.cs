using UnityEngine;

public abstract class Period : DevObject
{

    [Header("Durée de la période en heures")]
    [Min(0)]
    [SerializeField]
    private float periodDuration;
    
    public void StartPeriod()
    {
        // Starter une période
    }

    private void OnPeriodEnd()
    {
        // Quand la période se termine
    }

    public void StartHour()
    {
        // Starter une heure [Le timer doit être créé ici]
    }

    public void OnHourEnd()
    {
        // Quand une heure se termine [Méthode appelée lors de la fin du timer]
    }
}
