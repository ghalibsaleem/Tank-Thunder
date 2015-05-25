using UnityEngine;
using System.Collections;

public class TerrainScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("UserTank") != null) {
						Screen.showCursor = false;
				} else {
						Screen.showCursor = true;
				}

		if (Input.GetKey (KeyCode.End)) {
			Application.Quit();
			
		}
	}
	void OnGUI() {

		if (GUI.Button(new Rect(1300,10,19,19),"x")) {
			Application.Quit();
		}
		//Debug.Log (GameObject.Find ("UserTank"));
		if (GameObject.Find ("UserTank") == null) {
			GUI.Box(new Rect(490,200,300,180),"");
			GUI.Box(new Rect(560,250,160,40),"Game Over");
				

					if(GUI.Button(new Rect(600,300,80,40),"Try Again!")){
						Application.LoadLevel("scene4");

				}
			}
			
		}
}
