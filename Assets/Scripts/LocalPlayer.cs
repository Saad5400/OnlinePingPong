using UnityEngine;

public abstract class LocalPlayer : Racket
{
    protected abstract string VerticalAxis { get; }
    protected abstract bool IsLeftPlayer { get; }

    protected override void Update()
    {
        float directionY = 0f;

        foreach (Touch touch in Input.touches)
        {
            if (IsLeftPlayer ? touch.position.x < Screen.width / 2 : touch.position.x > Screen.width / 2)
            {
                // gameObject.transform.position = new Vector3(gameObject.transform.position.x, Camera.main.ScreenToWorldPoint(touch.position).y);
                var diff = worldCamera.ScreenToWorldPoint(touch.position).y - gameObject.transform.position.y;
                var absDiff = Mathf.Abs(diff);
                directionY = absDiff > 0.1 ? diff : 0;
                if (absDiff > 1) diff /= absDiff;
                racketDirection = new Vector2(0, directionY);
                return;
            }
        }
        directionY = Input.GetAxisRaw(VerticalAxis);
        racketDirection = new Vector2(0, directionY).normalized;
    }
}