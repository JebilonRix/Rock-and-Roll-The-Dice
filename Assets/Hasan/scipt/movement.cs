using UnityEngine;

public class movement : MonoBehaviour
{

    private Rigidbody rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        dashTime = startDashTime;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (direction == 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                direction = 1;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                direction = 2;
            }
        }
        else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector3.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;        
                
                if (direction == 1)
                {
                    rb.velocity = Vector3.left * dashSpeed;
                }
                else if (direction == 2)
                {
                    rb.velocity = Vector3.right * dashSpeed;
                }
            }
        }
    }
}





