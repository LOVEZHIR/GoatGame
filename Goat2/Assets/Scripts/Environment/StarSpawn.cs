using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawn : MonoBehaviour {
	
	public GameObject Player;
	public GameObject Star;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < Random.Range(7,11); i++)
		{
		float xPos=Player.transform.position.x+Random.Range(-20f,20f);
		float yPos=Player.transform.position.y+50f+Random.Range(-10f,10f);
		float zPos=Player.transform.position.z+Random.Range(-20f,20f);
		Vector3 Pos;
		Pos.x=xPos;
		Pos.y=yPos;
		Pos.z=zPos;
		Instantiate(Star,Pos,Quaternion.identity);
		}
	}
	

}
