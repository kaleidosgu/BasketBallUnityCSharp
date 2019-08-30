using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootComponent : MonoBehaviour {

    public GameObject BallPrefab;
    public float ShootForceValue;
    public Camera PlayerCamera;

    public Rigidbody BallRigidbody;

    public Transform TakeBallPos;
    public Transform ShootBallPos;

    public float AngleOfShoot;
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
            GameObject objBall = Instantiate(BallPrefab, TakeBallPos.position, Quaternion.identity);
            //原先的版本
            //objBall.GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.forward * ShootForceValue);

            float fAngleOfCamera = Vector3.Angle(PlayerCamera.transform.forward, transform.forward);
            Quaternion rot = Quaternion.AngleAxis(fAngleOfCamera + AngleOfShoot,- PlayerCamera.transform.right);
            Vector3 vecShoot = rot * PlayerCamera.transform.forward;
            //Vector3 vecShoot = PlayerCamera.transform.rotation * PlayerCamera.transform.forward;
            objBall.GetComponent<Rigidbody>().AddForce(vecShoot * ShootForceValue);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if( collision.gameObject.tag == "BallTag" )
        {
            //BallRigidbody.detectCollisions = false;
            //BallRigidbody.useGravity = false;
            //BallRigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            //BallRigidbody.GetComponent<SphereCollider>().enabled = false;
            //collision.gameObject.transform.SetParent(TakeBallPos);
            //collision.gameObject.transform.localPosition = Vector3.zero;
        }
    }
}
