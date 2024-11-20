using UnityEngine;

public class Monk : DevObject
{
    [Header("Nombre maximum d'apparitions du moine par jour :")]
    [SerializeField]
    private int maxAppearancePerDay;

    [Header("Probabilité d'appartion du moine à chaque heure, entre 0 et 1")]
    [Tooltip("[0.0 ; 1.0] - 0.5 équivaut à une probabilité de 50% d'appartion.")]
    [Range(0.0f, 1.0f)]
    [SerializeField]
    private float appearanceProbability;
    
    private int _appearanceCountThisDay;
    
    public void ShowText(string text)
    {
        // TODO implémenter la méthode pour afficher les dialogues du moine
    }

    public void Appear()
    {
        _appearanceCountThisDay++;
        // TODO implémenter la méthode pour faire apparaitre le moine dans une période
    }

    public void Disappear()
    {
        // TODO implémenter la méthode pour faire disparaitre le moine dans une période
    }

    private void Awake()
    {
        GameState().monk = this;
    }

    public void AppearanceRoll()
    {
        if (Random.value < appearanceProbability && _appearanceCountThisDay < maxAppearancePerDay) Appear();
    }
}
