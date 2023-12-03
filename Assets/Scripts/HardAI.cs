public class HardAI : EasyAI
{
    void Awake()
    {
        enabled = GameManager.gameMode == GameMode.HardAI;
    }

    protected override void Start()
    {
        base.Start();
        ballMovement.maxExtraSpeed = 16;
    }
}