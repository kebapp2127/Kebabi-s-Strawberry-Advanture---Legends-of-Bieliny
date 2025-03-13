using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D Kebabi;
    public float moveSpeed = 10;
    private Vector2 movement;
     void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        Kebabi.MovePosition(Kebabi.position + movement * moveSpeed * Time.deltaTime);
    }
}
