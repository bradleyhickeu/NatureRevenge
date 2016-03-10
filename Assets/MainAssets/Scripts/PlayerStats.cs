using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public GameObject blood; //create public gameobject blood
	public float healthValue = 15; //create health variable and set it at 100
	//public Camera Camera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		healthValue = healthValue + 0.01f; //health gradually increases during gameplay
		Debug.Log (healthValue);
		if (healthValue > 99) { //if health is more than 99
			healthValue = 100; //make health 100 (done this so health doesn't surpass 100
		}
		if (healthValue <= 30) //if health is less than 30
		{
			//Instantiate(blood, new Vector3 (this.transform.position.x, this.transform.position.y), Quaternion.identity); //add blood to scene
			//blood.transform.localPosition.x;
		}
	}

}