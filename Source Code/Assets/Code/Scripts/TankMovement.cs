using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour {
	GameObject Tank;
	GameObject barrel;
	public GameObject Fire;
    public GameObject ChaseCamera;
	public GameObject FirstCamera;
	public Texture pointer;
	string diag;


	float CurrentVelocity = 0 ;


	// Use this for initialization
	void Start () {
		Tank = GameObject.Find ("UserTank");
		barrel = GameObject.Find ("barrel");
		ChaseCamera = GameObject.Find("Main Camera");
		FirstCamera = GameObject.Find("Camera");
		Debug.Log (Tank + " is loaded");
		FirstCamera.SetActive (false);


	}
	Vector3 movCamTO;
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("sam") != null) {
						audio.pitch = Mathf.Abs (CurrentVelocity / 11F) + 1;

						movCamTO = barrel.transform.position + barrel.transform.up * 17F - barrel.transform.forward * 35F;
						ChaseCamera.transform.position = movCamTO;
	
						ChaseCamera.transform.LookAt (barrel.transform.position);

			
						transform.Translate ((new Vector3 (0, 0, CurrentVelocity)) * Time.deltaTime, Space.Self);
						//Debug.Log (CurrentVelocity);
						if (Input.GetKey (KeyCode.W)) {
								CurrentVelocity = Tank.GetComponent<MovingDirection> ().Accelarate (CurrentVelocity);

						}
						if (Input.GetKey (KeyCode.S)) {
								CurrentVelocity = Tank.GetComponent<MovingDirection> ().Breaks (CurrentVelocity);
			
						}
						if (!Input.GetKey (KeyCode.S) && !Input.GetKey (KeyCode.W)) {
								CurrentVelocity = Tank.GetComponent<MovingDirection> ().Declarate (CurrentVelocity);
				
						}
						if (Input.GetKey (KeyCode.D)) {
								Tank.GetComponent<MovingDirection> ().TurnRight ();

						}
						if (Input.GetKey (KeyCode.A)) {
								Tank.GetComponent<MovingDirection> ().TurnLeft ();
								//Debug.Log("Got It");
						}
						if (Input.GetKey (KeyCode.C)) {
								if (FirstCamera.activeSelf) {
										FirstCamera.SetActive (false);
										ChaseCamera.SetActive (true);

								} else {
										if (ChaseCamera.activeSelf) {
												ChaseCamera.SetActive (false);
												FirstCamera.SetActive (true);
										}
								}



						}
						if (GameObject.Find ("muzel flash(Clone)") != null) {

								Destroy (GameObject.Find ("muzel flash(Clone)"), 3F);
						}
				} else {
				
				}
		//transform.Translate ((new Vector3(0,0,CurrentVelocity))*Time.deltaTime,Space.Self);
	}

	void OnGUI() {
		GUIStyle s;

		if (diag == null)
						diag = "Destroy All the Surface to Air Missile";
		GUI.Box(new Rect (10, 10, 300, 50),diag);

		if (GUI.Button(new Rect(1300,10,19,19),"x")) {
			Application.Quit();
				}


		if (GameObject.Find ("sam") == null) {
			GUI.Box(new Rect(490,200,300,180),"");
			GUI.Box(new Rect(560,250,160,40),"Ceasefire!\nWell done Soldier!\nYou made your\nCountry proud today");
				}

	}
	
}
