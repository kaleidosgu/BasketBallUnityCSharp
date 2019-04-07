using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketTriggerComponent : MonoBehaviour {

    public bool UpTrigger;
    public UIScoreComponent ScoreComponent;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TriggerAddScore()
    {
        ScoreComponent.AddScore();
    }
}
