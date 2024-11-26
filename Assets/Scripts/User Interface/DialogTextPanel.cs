using System;
using System.Collections.Generic;
using UnityEngine;

public class DialogTextPanel : DevObject
{

    [HideInInspector]
    public List<string> textQueue = new List<string>();

    private int _nextTextIndex;
    
    // TODO ajouter une méthode qui écoute un clic sur le dialogue, et call la méthode dialog(_nextTextIndex)
    
    private void Show()
    {
        var spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer)
        {
            spriteRenderer.enabled = true;
        }
    }
    
    private void Hide()
    {
        var spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer)
        {
            spriteRenderer.enabled = false;
        }
    }

    public void Dialog(int index)
    {
        if (index > textQueue.Count - 1) // Il n'y a plus de dialogues à afficher
        {
            Hide();
            ResetQueue();
            GameState().monk.Disappear();
            return;
        }
        if (index == 0)
        {
            _nextTextIndex = 1;
            SetText(textQueue[0]);
            Show();
            return;
        }
        SetText(textQueue[index]);
        _nextTextIndex++;
    }

    private void SetText(string text)
    {
        // TODO ajouter un objet de texte à l'objet DialogTextPanel puis changer son texte avec cette méthode
    }

    private void ResetQueue()
    {
        textQueue.Clear();
        _nextTextIndex = 0;
    }

    private void Awake()
    {
        GameState().dialogTextPanel = this;
    }
}
