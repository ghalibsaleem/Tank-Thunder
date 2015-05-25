using UnityEngine;
using System.Collections;

public class TurretMotion : MonoBehaviour {
	GameObject TurretBarrel;
	// Use this for initialization
	void Start () {
		TurretBarrel = GameObject.Find ("barrel");
		//TurretBarrel.camera.transform.position = new Vector3 (0, TurretBarrel.camera.transform.position.y , 0);
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.UpArrow)){
			float speed = 10 * Time.deltaTime;
			if(TurretBarrel.transform.localEulerAngles.x >350 || TurretBarrel.transform.localEulerAngles.x < 12)
				TurretBarrel.transform.Rotate(-speed,0,0,Space.Self);

		}
		if(Input.GetKey(KeyCode.DownArrow)){
			float speed = 10 * Time.deltaTime;
			if(TurretBarrel.transform.localEulerAngles.x >340 || TurretBarrel.transform.localEulerAngles.x <10)
				TurretBarrel.transform.Rotate(speed,0,0,Space.Self);

		}


		//Debug.Log (Input.GetAxis("Mouse Y"));
		if(Input.GetKey(KeyCode.RightArrow)){
			float speed = 20 * Time.deltaTime;
			if(transform.localEulerAngles.y < 150 || transform.localEulerAngles.y > 198 )
				transform.Rotate(0,speed,0,Space.Self);

		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			float speed = 20 * Time.deltaTime;
			if(transform.localEulerAngles.y > 200 || transform.localEulerAngles.y < 152)
				transform.Rotate (0,-speed , 0,Space.Self);

		}
	
	}
}
