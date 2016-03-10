using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public GameObject blood;
	public float healthValue = 15; //create health variable and set it at 100
	//public Camera Camera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		healthValue = healthValue + 0.01f;
		Debug.Log (healthValue);
		if (healthValue > 99) {
			healthValue = 100;
		}
		if (healthValue <= 30) 
		{
			Instantiate(blood, new Vector3 (this.transform.position.x, this.transform.position.y), Quaternion.identity);
			//blood.transform.localPosition.x;
		}
	}

}