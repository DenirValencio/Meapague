using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EstalagControl : MonoBehaviour
{

    public GameObject Target;
    public GameObject ShotEstalagPrefab;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine (ShotEstalagRoutine());
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<NavMeshAgent> ().destination = Target.transform.position;
	}

    IEnumerator ShotEstalagRoutine()
    {
        while (true)
        {
            GameObject estalag = Instantiate(ShotEstalagPrefab, transform.position, Quaternion.identity);
            Destroy (estalag, 5f);
            yield return new WaitForSeconds (3.0f);
        }
    }
}
