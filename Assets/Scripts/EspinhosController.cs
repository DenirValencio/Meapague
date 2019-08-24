using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspinhosController : MonoBehaviour
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

        Debug.DrawRay(transform.position, -Vector3.forward, Color.magenta);

        if (Physics.Raycast(transform.position, -Vector3.forward, out hit))
        {
            speed = speed;
        }
        else
        {
            speed = speed * -1;
        }

        transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("chaoespinho") || other.gameObject.CompareTag("portaespinhocolisor"))
        {
            speed = speed * -1;
        }
    }
}
