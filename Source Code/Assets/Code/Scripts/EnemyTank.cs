using UnityEngine;
using System.Threading;
using System.Collections;

public class EnemyTank : MonoBehaviour {
	public GameObject userTank;
	public GameObject mybarrel;
	public GameObject myturret;
	Vector3 userVector;
	int i = 0;
	public Thread t;

	void Start () {
		Debug.Log (0);
		if(userTank == null){
			userTank = GameObject.Find("UserTank");

		}
		t = new Thread(ThreadMethod);
		t.Start ();
	}
	
	void Update () {
		if(userTank != null){
			userVector = userTank.transform.position;
			float distance = Vector3.Distance(this.transform.position,userVector);
			if(userTank!=null && distance < 100){
				
				this.transform.LookAt(new Vector3(userTank.transform.position.x,this.transform.position.y,userTank.transform.position.z));
				mybarrel.transform.LookAt(userTank.transform.position+(Vector3.up*5F));
				//Debug.Log(t.IsAlive);
				if (distance > 50) {

				}
				
			}
		}

	}

	void ThreadMethod(){
		while (true) {
			Thread.Sleep(10000);
		}
	}
}
