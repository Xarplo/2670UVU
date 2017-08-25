using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter () {
		print ("Enter");
	
	}
	
	// Update is called once per frame
	void OnTriggerExit () {
		print ("Exit");
	
	}
}
