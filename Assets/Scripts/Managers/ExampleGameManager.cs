using System;
using UnityEngine;

public class ExampleGameManager : Singleton<ExampleGameManager>
{
    public static event Action<GameState> OnBeforeStateChanged;
    public static event Action<GameState> OnAfterStateChanged;

    public GameState State { get; private set; }

    private void Start()
    {
        ChangeState(GameState.Starting);
    }

    public void ChangeState(GameState newState)
    {
        if (State == newState) return;

        OnAfterStateChanged?.Invoke(newState);

        State = newState;
        switch(newState)
        {
            case GameState.Starting:
                HandleStarting();
                break;
            case GameState.SpawningHeroes:
                HandleSpawningHeroes();
                break;
            case GameState.SpawningEnemies:
                HandleSpawningEnemies();
                break;
            case GameState.HeroTurn:
                HandleHeroTurn();
                break;
            case GameState.EnemyTurn:
                break;
            case GameState.Win:
                break;
            case GameState.Lose:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);

        }

        OnBeforeStateChanged?.Invoke(newState);

        Debug.Log($"New state: {newState}");
    }

    private void HandleStarting()
    {

    }

    private void HandleSpawningHeroes()
    {
        ExampleUnitManager.Instance.SpawnHeroes();
    }

    private void HandleSpawningEnemies()
    {
        ExampleUnitManager.Instance.SpawnEnemies();
    }

    private void HandleHeroTurn()
    {

    }
}

public enum GameState
{
    Starting,
    SpawningHeroes,
    SpawningEnemies,
    HeroTurn,
    EnemyTurn,
    Win,
    Lose
}