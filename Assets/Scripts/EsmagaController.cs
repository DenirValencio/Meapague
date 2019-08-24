using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsmagaController : MonoBehaviour
{
    public int speed;    

    // Use this for initialization
    void Start()
    {
        speed = 1;      
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit = new RaycastHit();

       // Debug.DrawRay(transform.position, -Vector3.up, Color.magenta);

        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
        {
            speed = speed * +1;
        }
        else
        {
            speed = speed * -1;
        }     

        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("esmaga"))
        {
            speed = speed * -1;
        }
    }
}
