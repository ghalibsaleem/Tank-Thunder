using UnityEngine;
using System.Collections;

public class CanonDestroy : MonoBehaviour {
	public GameObject Fire;
	GameObject TurretBarrel;
	Transform pos;
	// Use this for initialization
	void Start () {
		TurretBarrel = GameObject.Find ("barrel");
		pos = TurretBarrel.transform;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (this.rigidbody.velocity);
		//this.rigidbody.velocity = Vector3.forward*500F;
		transform.Translate (Vector3.forward*500F*Time.deltaTime,pos);
	}
	void OnTriggerEnter(Collider other) {

		Vector3 firePosition = this.transform.position ;
		Fire = (GameObject)Instantiate(Resources.Load("explosion"),firePosition,Quaternion.identity);
		//Debug.Log ("collide");

		Debug.Log (other.gameObject);
		if (other.gameObject.name != "Terrain" && other.gameObject.name != "barn" && other.gameObject.name != "barn_with_texture") {
				
						//other.gameObject.rigidbody.AddForce (Vector3.forward);
						Destroy (other.gameObject, 2F);
				}
		Destroy (GameObject.Find ("Shot(Clone)"));

	}

	void OnDestroy() {
		//Debug.Log (this);
	}
}
