using UnityEngine;

public class StrawberryController : MonoBehaviour
{
    public float slowingFactor = 0.9f;
    public Vector2 force;
    Rigidbody2D Strawberry;

    private void Start()
    {
        Strawberry = GetComponent<Rigidbody2D>();
        Strawberry.AddForce(force);
    }

    void FixedUpdate()
    {
        Strawberry.linearVelocity *= slowingFactor;
        Strawberry.angularVelocity *= slowingFactor;
    }
}
