using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameMode gameMode = GameMode.LocalPvP;
    public static GameState gameState = GameState.Menu;

    private static GameManager Instance = null;

    void Start()
    {
        if (Instance is null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

public enum GameMode
{
    LocalPvP,
    HostOnlinePvP,
    JoinOnlinePvP,
    EasyAI,
    MediumAI,
    HardAI,
}

public enum GameState
{
    Menu,
    Searching,
    Playing,
}