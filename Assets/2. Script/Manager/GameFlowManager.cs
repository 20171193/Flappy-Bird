using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public enum GameState
{
    Ready,
    Play,
    GameOver
}

public class GameFlowManager : MonoBehaviour
{
    GameState state;

    public UnityEvent OnReady;
    public UnityEvent OnPlay;
    public UnityEvent OnGameOver;

    private void Start()
    {
        ChangeState(GameState.Ready);
    }
    public void ChangeState(GameState state)
    {
        this.state = state;
        switch (state)
        {
            case GameState.Ready:
                OnReady?.Invoke();
                break;
            case GameState.Play:
                OnPlay?.Invoke();
                break;
            case GameState.GameOver:
                OnGameOver?.Invoke();
                break;
        }
    }

    public void OnClickScreenButton()
    {
        if (state == GameState.Ready)
            ChangeState(GameState.Play);
    }
}
