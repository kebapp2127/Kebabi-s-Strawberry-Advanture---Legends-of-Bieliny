using UnityEngine;

public class StrawberryShooter : MonoBehaviour
{
    [SerializeField]GameObject Strawberry;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           Instantiate(Strawberry,transform.position,new Quaternion(0,0,0,0));
        }
    }
}
