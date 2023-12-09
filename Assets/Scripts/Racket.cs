using UnityEngine;

public class Racket : MonoBehaviour
{
    public Camera worldCamera;
    public float racketSpeed;
    protected float startingRacketSpeed = 5f;
    protected float currentRacketSpeed;
    protected float racketAcceleration = 0.5f;
    protected float racketAccelerationOffset = 0.1f;

    protected Rigidbody2D rb;
    protected Vector2 racketDirection;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentRacketSpeed = startingRacketSpeed;
    }

    protected virtual void Update()
    {

    }

    protected virtual void FixedUpdate()
    {
        rb.velocity = racketDirection * racketSpeed;
        if (racketDirection.magnitude > racketAccelerationOffset && currentRacketSpeed < racketSpeed)
            currentRacketSpeed += racketAcceleration;
        else if (racketDirection.magnitude < racketAccelerationOffset && currentRacketSpeed > startingRacketSpeed)
            currentRacketSpeed -= racketAcceleration;

        if (currentRacketSpeed > racketSpeed)
            currentRacketSpeed = racketSpeed;
        if (currentRacketSpeed < startingRacketSpeed)
            currentRacketSpeed = startingRacketSpeed;

        rb.velocity = racketDirection * currentRacketSpeed;
    }
}
