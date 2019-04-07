using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreComponent : MonoBehaviour {

    public Text TxtScore;
    private int m_nCurrentScore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AddScore()
    {
        m_nCurrentScore += 1;
        TxtScore.text = string.Format("{0}", m_nCurrentScore);
    }
}
