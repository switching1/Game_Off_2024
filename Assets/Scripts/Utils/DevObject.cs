using UnityEngine;

/// <summary>
///     Override de MonoBehaviour permettant d'accéder au GameState depuis n'importe quel objet. Presque tous les scripts
///     du jeu devraient hériter de cette classe plutot que de MonoBehaviour. Toujours créer un objet avec la GameState
///     avant d'utiliser les DevObject.
/// </summary>
public abstract class DevObject : MonoBehaviour
{
    protected GameState GameState()
    {
        if (global::GameState.Instance == null)
            throw new UnityException(
                "GameState is not initialized. Please initialize the GameState before using a DevObject.");

        return global::GameState.Instance;
    }
}