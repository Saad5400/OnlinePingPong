public class MediumAI : EasyAI
{
    void Awake()
    {
        enabled = GameManager.gameMode == GameMode.MediumAI;
    }
}