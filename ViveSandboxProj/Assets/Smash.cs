using UnityEngine;
using System.Collections;

public class Smash : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Katana")
        {
            Destroy(gameObject);
        }
    } 
}
