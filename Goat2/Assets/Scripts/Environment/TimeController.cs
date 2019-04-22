using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour {
	private float startTime;
	private float nast;
	private float pred = 0;
	private float buffer = 0;
	private int K;
	
	void Start(){
		GameObject go = GameObject.Find("UiController");
		Ruller koef= go.GetComponent<Ruller>();
		K =koef.k;
		startTime=koef.startTime+60000;	
	}
	
	void Update () {
		startTime += Time.deltaTime*K;
		nast=((startTime % 86400) / 240);
		gameObject.transform.Rotate(buffer,0,0);
		buffer=nast-pred;
		pred=nast;
		
	}
}
