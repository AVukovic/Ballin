using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

    public Quaternion startPosition;


    void Start ()
    {
        startPosition = transform.rotation;
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(-transform.forward * (Mathf.Cos(Time.time/2) * Time.deltaTime * 8), Space.World);
        //if (!Input.anyKey)
           // transform.rotation = Quaternion.Slerp(transform.rotation, startPosition, Time.time * 0.005f);
    }
}
