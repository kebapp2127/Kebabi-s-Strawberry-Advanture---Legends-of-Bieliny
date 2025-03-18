using System;
using Unity.Mathematics;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject firePoint;
    public Rigidbody2D Kebabi;
    public float moveSpeed = 10;
    private Vector2 userInput;

    public Sprite KebabiLeft;  
    public Sprite KebabiRight;
    public Sprite KebabiUp;
    public Sprite KebabiDown;

    private SpriteRenderer spriteRenderer;
    private StrawberryShooter shooter;

    private void Awake()
    {
        shooter = GetComponent<StrawberryShooter>();
    }

    void Start()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        Kebabi = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        userInput.x =Input.GetAxisRaw("Horizontal");
        userInput.y = Input.GetAxisRaw("Vertical");

        shooter.UpdateShootingPosition((int)MathF.Ceiling(userInput.x), (int)MathF.Ceiling(userInput.y));
    }
    void FixedUpdate()
    {
        Kebabi.MovePosition(Kebabi.position + userInput * moveSpeed*Time.fixedDeltaTime);
        if (userInput.x > 0 && userInput.y == 0)
        {
            spriteRenderer.sprite = KebabiRight;
        }
        if (userInput.x < 0 && userInput.y == 0)
        {
            spriteRenderer.sprite = KebabiLeft;
        }
        if (userInput.y > 0)
        {
            spriteRenderer.sprite = KebabiUp;
        }
        if (userInput.y < 0)
        {
            spriteRenderer.sprite = KebabiDown;
        }
    }
}
