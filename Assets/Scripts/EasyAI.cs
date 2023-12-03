using UnityEngine;

public class EasyAI : Racket
{
    public GameObject ball;
    protected BallMovement ballMovement;
    public float ballSpeed = 12;

    void Awake()
    {
        enabled = GameManager.gameMode == GameMode.EasyAI;
    }

    protected override void Start()
    {
        base.Start();
        ballMovement = ball.GetComponent<BallMovement>();
        ballMovement.maxExtraSpeed = ballSpeed;
    }

    void Update()
    {
        var diff = ball.transform.position.y - gameObject.transform.position.y;
        var absDiff = Mathf.Abs(diff);
        float directionY = absDiff > racketSpeed / 180 ? diff / absDiff : 0;
        racketDirection = new Vector2(0, directionY).normalized;
    }
}
