using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoController : MonoBehaviour
{
    public int speed;
    private bool temParede; // detecta se tem parede
    private Quaternion rotacao;

    // Use this for initialization
    void Start ()
    {
        speed = 1;
	}

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit = new RaycastHit ();
        Debug.DrawRay(transform.position, Vector3.forward, Color.magenta);

        temParede = Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 1.2f, transform.position.z), transform.forward, 0.60f); //testa se o Inimigo está vai bater na parede

        //if (Physics.Raycast(transform.position, Vector3.forward, out hit))
        if (!temParede)
        {
            speed = speed * 1;
        }
        else
        {
            speed = speed * (-1);
        }

        //Faz com que o Player olhe sempre para a direção do movimento
        //Debug.DrawRay (transform.position, transform.forward, Color.blue);
        if (Input.GetAxis("Vertical") != 0)
        {
            rotacao.SetLookRotation(new Vector3(Input.GetAxis("Vertical"), 0, 0));
            transform.rotation = rotacao;
        }

        transform.position += new Vector3 (0, 0, speed) * Time.deltaTime;   
    }
}
