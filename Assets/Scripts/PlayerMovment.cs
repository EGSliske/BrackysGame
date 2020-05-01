using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f; //adds this into unity script
    public float sidewaysForce = 500f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime); //add a fwd force

        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
}
}