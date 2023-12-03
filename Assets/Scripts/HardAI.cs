public class HardAI : EasyAI
{
    void Awake()
    {
        enabled = GameManager.gameMode == GameMode.HardAI;
    }
}