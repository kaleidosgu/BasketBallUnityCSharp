using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCoreComponent : MonoBehaviour {

    private bool m_bTriggerUp;
    private bool m_bTriggerDown;
    public LayerMask TriggerLayer;
    private bool m_bBadBall;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (((1 << other.gameObject.layer) & TriggerLayer) != 0)
        {
            BasketTriggerComponent _trigCom = other.gameObject.GetComponent<BasketTriggerComponent>();
            if (_trigCom.UpTrigger == true )
            {
                m_bTriggerUp = true;
                if(m_bTriggerDown == true)
                {
                    m_bBadBall = true;
                }
            }
            if( _trigCom.UpTrigger == false )
            {
                m_bTriggerDown = true;
                if(m_bTriggerUp == true)
                {
                    if(m_bBadBall == false)
                    {
                        _trigCom.TriggerAddScore();
                        m_bBadBall = true;
                    }
                }
            }
        }
    }
}
