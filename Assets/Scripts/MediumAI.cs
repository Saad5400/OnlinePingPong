public class MediumAI : EasyAI
{
    void Awake()
    {
        enabled = GameManager.gameMode == GameMode.MediumAI;
    }

    protected override void Start()
    {
        base.Start();
        ballMovement.maxExtraSpeed = 14;
    }
}