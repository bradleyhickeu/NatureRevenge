using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public GameObject blood; //create public gameobject blood
	public float healthValue = 15; //create health variable and set it at 100
	private int distance = 1;
	public bool bloodOnScreen = false;
	private GameObject clone;
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
		if (healthValue <= 30  && bloodOnScreen == false) //if health is less than 30
		{
			
			clone = Instantiate(blood, transform.position + transform.forward*distance, transform.rotation)as GameObject; //add blood to scene
			clone.transform.parent = GameObject.Find("Canvas").transform;
			bloodOnScreen = true;
		
			//blood.transform.localPosition.x;

		}
		if (healthValue > 30 && bloodOnScreen == true)
		{
			Debug.Log("kill");
			GameObject.Destroy (clone);
			bloodOnScreen = false;

		}
	}

}