using UnityEngine;
using System.Collections;

public class MineScript : MonoBehaviour {
	public GameObject Fire;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){

		if(other.gameObject.name == "hull"){
			Vector3 firePosition = this.transform.position ;
			Fire = (GameObject)Instantiate(Resources.Load("explosion"),firePosition,Quaternion.identity);
			//GameObject.Find ("UserTank").SetActive(false);
			Debug.Log(other.gameObject.audio);
			other.gameObject.audio.Play();
			Destroy (GameObject.Find ("UserTank"),2F);
			Destroy(this.gameObject);
			//GameObject.Find("Main Camera").SetActive(true);
		}
	}
}
