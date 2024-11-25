using System;
using System.Collections;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    private void Awake()
    {
        GameplayStateManager.Instance.OnGameplayStateChanged += OnGameplayStateChanged;
    }

    private void OnDestroy()
    {
        GameplayStateManager.Instance.OnGameplayStateChanged -= OnGameplayStateChanged;
    }

    private void OnGameplayStateChanged(GameplayState newGameplayState)
    {
        Debug.Log(newGameplayState);
    }
}