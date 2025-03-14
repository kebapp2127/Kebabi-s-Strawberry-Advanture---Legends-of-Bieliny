using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D Kebabi;
    public float moveSpeed = 10;
    private Vector2 userInput;
    public Sprite KebabiLeft;  
    public Sprite KebabiRight;
    public Sprite KebabiUp;
    public Sprite KebabiDown;

    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Kebabi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        userInput.x = Input.GetAxisRaw("Horizontal");
        userInput.y = Input.GetAxisRaw("Vertical");
        if (userInput.x > 0 && userInput.y==0) 
        {
            spriteRenderer.sprite = KebabiRight;
        }
        else if(userInput.x<0 && userInput.y==0)
        {
            spriteRenderer.sprite = KebabiLeft;
        }
        else if(userInput.y>0)
        {
            spriteRenderer.sprite = KebabiUp;
        }
        else if (userInput.y < 0)
        {
            spriteRenderer.sprite = KebabiDown;
        }
    }

    private void FixedUpdate()
    {
        Kebabi.MovePosition(Kebabi.position + userInput * moveSpeed);
    }
}
