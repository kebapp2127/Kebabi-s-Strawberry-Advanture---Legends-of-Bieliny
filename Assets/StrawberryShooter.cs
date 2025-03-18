using UnityEngine;

public class StrawberryShooter : MonoBehaviour
{
    [SerializeField]GameObject Strawberry;
    public GameObject upTransform;
    public GameObject downTransform;
    public GameObject leftTransform;
    public GameObject rightTransform;

    private Transform currentShootingTransform;
    private Vector2 shootingDirection = Vector2.zero;

    void Start()
    {
        
    }

    public void UpdateShootingPosition(int x, int y)
    {
        shootingDirection = new (x, y);

        if (x>0 && y==0)
        {
            currentShootingTransform = rightTransform.transform;
        }
        if (x <0 && y == 0)
        {
            currentShootingTransform = leftTransform.transform;
        }
        if ( y > 0)
        {
            currentShootingTransform = upTransform.transform;
        }
        if(y < 0)
        {
            currentShootingTransform = downTransform.transform;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           Instantiate(Strawberry, currentShootingTransform.position,new Quaternion(0,0,0,0));
        }
    }
}
