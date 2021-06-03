using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borders : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (other.gameObject.tag == "left_border")
        {
            transform.position = new Vector3(transform.position.x + 7, 0, transform.position.z);
        }
        if (other.gameObject.tag == "right_border")
        {
            transform.position = new Vector3(transform.position.x - 7, 0, transform.position.z);
        }
        if (other.gameObject.tag == "top_border")
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z-7);
        }
        if (other.gameObject.tag == "buttom_border")
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z+7);
        }
    }
}
