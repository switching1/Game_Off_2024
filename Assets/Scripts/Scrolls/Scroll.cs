using UnityEngine;

public abstract class Scroll : DevObject
{
    [SerializeField]
    [Header("Destination pour fin conspiration")]
    private EScrollDestination cDestination;
    
    [SerializeField]
    [Header("Destination pour fin héroïque")]
    private EScrollDestination hDestination;
    
    // TODO Ajouter l'attribut texte
}