using UnityEngine;
using System.Collections;

public class CanonFire : MonoBehaviour {
	public GameObject Fire;
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) || Input.GetKey (KeyCode.Mouse0)) {
			if(GameObject.Find("muzel flash(Clone)") == null){
				audio.Play();
				GameObject a = GameObject.Find("FireOfShot");
				Vector3 firePosition = a.transform.position ;
				Fire = (GameObject)Instantiate(Resources.Load("muzel flash"),firePosition,Quaternion.identity);
				Fire.transform.position = a.transform.position;
				Fire.transform.parent = a.transform;
			
				GameObject shot = (GameObject)Instantiate(Resources.Load("Shot"),firePosition,Quaternion.identity);
				shot.transform.position = a.transform.position;

				shot.transform.parent = a.transform;


			}

		}
		if(Input.GetKey (KeyCode.Mouse1)){
			GameObject.Find("turret").audio.Play();

		}
	}


}
