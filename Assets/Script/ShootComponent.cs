using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootComponent : MonoBehaviour {

    public GameObject BallPrefab;
    public float ShootForceValue;

    public Rigidbody BallRigidbody;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetButtonDown("Fire1"))
        {
        }
        else if( Input.GetButtonUp("Fire1"))
        {
            GameObject objBall = Instantiate(BallPrefab, transform.position, Quaternion.identity);
            objBall.GetComponent<Rigidbody>().AddForce(transform.forward * ShootForceValue);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if( collision.gameObject.tag == "BallTag" )
        {
            //BallRigidbody.detectCollisions = false;
            BallRigidbody.useGravity = false;
            BallRigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            BallRigidbody.GetComponent<SphereCollider>().enabled = false;
            collision.gameObject.transform.SetParent(transform);
        }
    }
}
