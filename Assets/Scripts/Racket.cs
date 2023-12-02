using UnityEngine;

public class Racket : MonoBehaviour
{
    public Camera worldCamera;
    public float racketSpeed;
    private float startingRacketSpeed = 5f;
    private float currentRacketSpeed;
    private float racketAcceleration = 0.01f;
    private float currentRacketAcceleration;
    private float racketAccelerationOffset = 0.3f;

    private Rigidbody2D rb;
    protected Vector2 racketDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentRacketSpeed = startingRacketSpeed;
        currentRacketAcceleration = racketAcceleration;
    }

    private void FixedUpdate()
    {
        if (racketDirection.magnitude > racketAccelerationOffset && currentRacketSpeed < racketSpeed)
        {
            currentRacketSpeed += currentRacketAcceleration;
        }
        else if (racketDirection.magnitude < racketAccelerationOffset && currentRacketSpeed > startingRacketSpeed)
        {
            currentRacketSpeed -= currentRacketAcceleration;
        }

        if (racketDirection.magnitude > racketAccelerationOffset && currentRacketAcceleration < 2)
        {
            currentRacketAcceleration += currentRacketAcceleration;
        }
        else if (racketDirection.magnitude < racketAccelerationOffset)
        {
            currentRacketAcceleration = racketAcceleration;
            currentRacketSpeed = startingRacketSpeed;
        }

        if (currentRacketSpeed > racketSpeed)
        {
            currentRacketSpeed = racketSpeed;
        }
        if (currentRacketSpeed < startingRacketSpeed)
        {
            currentRacketSpeed = startingRacketSpeed;
        }

        rb.velocity = racketDirection * currentRacketSpeed;
    }
}
