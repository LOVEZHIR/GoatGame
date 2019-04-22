using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ruller : MonoBehaviour
{
	public float startTime;
	public int k;
	public GameObject Player;
	public ParticleSystem Rain;
	[SerializeField]
	private float RainDur;
	[SerializeField]
	private float TimeUntilRain;

	
	void Awake()
	{
		TimeUntilRain=Random.Range(600f,1200f); //Время до первого дождя (сек)
	}

	public void RainStart ()
    {
		ParticleSystem rain=Rain.GetComponent<ParticleSystem>();
		var main=rain.main;
		main.duration=Random.Range(240f,480f) / 60; //Длительность дождя
		TimeUntilRain +=main.duration*60 + Random.Range(600f,1200f); //Время до следующего дождя 
		Invoke("Weather",main.duration*60);
		RainDur=main.duration*60;
		
		for (int i = 0; i < Random.Range(7,11); i++)  //Спавн источников дождя
		{
			float xPos=Player.transform.position.x+Random.Range(-20f,20f);
			float yPos=Player.transform.position.y+50f+Random.Range(-10f,10f);
			float zPos=Player.transform.position.z+Random.Range(-20f,20f);
			Vector3 Pos;
			Pos.x=xPos;
			Pos.y=yPos;
			Pos.z=zPos;
			Instantiate(Rain,Pos,Quaternion.identity);  
		}
		
	}


	void Update ()
    {
	    if (TimeUntilRain<0)
	    {
		    RainStart();
	    }
	    TimeUntilRain -= Time.deltaTime*k;

	    startTime += Time.deltaTime*k;
	}

	
}
