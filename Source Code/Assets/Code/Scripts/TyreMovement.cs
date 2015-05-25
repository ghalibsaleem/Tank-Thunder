using UnityEngine;
using System.Collections;

public class TyreMovement : MonoBehaviour {

	GameObject gear_left,gear_right ;
	GameObject pully_l,pully_r;
	GameObject tyre1_l,tyre2_l,tyre3_l,tyre4_l,tyre5_l,tyre6_l;
	GameObject tyre1_r,tyre2_r,tyre3_r,tyre4_r,tyre5_r,tyre6_r;
	float speed;
	// Use this for initialization
	void Start () {
		speed = 100;
		gear_left = GameObject.Find ("gear_left");
		gear_right = GameObject.Find ("gear_r");
		pully_l = GameObject.Find ("pully_l");
		pully_r = GameObject.Find ("pully_r");
		tyre1_l = GameObject.Find ("tyre1_l");
		tyre2_l = GameObject.Find ("tyre2_l");
		tyre3_l = GameObject.Find ("tyre3_l");
		tyre4_l = GameObject.Find ("tyre4_l");
		tyre5_l = GameObject.Find ("tyre5_l");
		tyre6_l = GameObject.Find ("tyre6_l");

		tyre1_r = GameObject.Find ("tyre1_r");
		tyre2_r = GameObject.Find ("tyre2_r");
		tyre3_r = GameObject.Find ("tyre3_r");
		tyre4_r = GameObject.Find ("tyre4_r");
		tyre5_r = GameObject.Find ("tyre5_r");
		tyre6_r = GameObject.Find ("tyre6_r");

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.W)){
			gear_left.transform.Rotate(speed*Time.deltaTime,0,0);
			gear_right.transform.Rotate(speed*Time.deltaTime,0,0);
			pully_l.transform.Rotate(speed*Time.deltaTime,0,0);
			pully_r.transform.Rotate(speed*Time.deltaTime,0,0);

			tyre1_l.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre2_l.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre3_l.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre4_l.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre5_l.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre6_l.transform.Rotate(speed*Time.deltaTime,0,0);

			tyre1_r.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre2_r.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre3_r.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre4_r.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre5_r.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre6_r.transform.Rotate(speed*Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.S)){
			gear_left.transform.Rotate(-speed*Time.deltaTime,0,0);
			gear_right.transform.Rotate(-speed*Time.deltaTime,0,0);
			pully_l.transform.Rotate(-speed*Time.deltaTime,0,0);
			pully_r.transform.Rotate(-speed*Time.deltaTime,0,0);
			
			tyre1_l.transform.Rotate(-speed*Time.deltaTime,0,0);
			tyre2_l.transform.Rotate(-speed*Time.deltaTime,0,0);
			tyre3_l.transform.Rotate(-speed*Time.deltaTime,0,0);
			tyre4_l.transform.Rotate(-speed*Time.deltaTime,0,0);
			tyre5_l.transform.Rotate(-speed*Time.deltaTime,0,0);
			tyre6_l.transform.Rotate(-speed*Time.deltaTime,0,0);
			
			tyre1_r.transform.Rotate(-speed*Time.deltaTime,0,0);
			tyre2_r.transform.Rotate(-speed*Time.deltaTime,0,0);
			tyre3_r.transform.Rotate(-speed*Time.deltaTime,0,0);
			tyre4_r.transform.Rotate(-speed*Time.deltaTime,0,0);
			tyre5_r.transform.Rotate(-speed*Time.deltaTime,0,0);
			tyre6_r.transform.Rotate(-speed*Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.A)){
			//gear_left.transform.Rotate(-speed*Time.deltaTime,0,0);
            //pully_l.transform.Rotate(-speed*Time.deltaTime,0,0);
            //tyre1_l.transform.Rotate(-speed*Time.deltaTime,0,0);
            //tyre2_l.transform.Rotate(-speed*Time.deltaTime,0,0);
            //tyre3_l.transform.Rotate(-speed*Time.deltaTime,0,0);
            //tyre4_l.transform.Rotate(-speed*Time.deltaTime,0,0);
            //tyre5_l.transform.Rotate(-speed*Time.deltaTime,0,0);
            //tyre6_l.transform.Rotate(-speed*Time.deltaTime,0,0);

			gear_right.transform.Rotate(speed*Time.deltaTime,0,0);
			pully_r.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre1_r.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre2_r.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre3_r.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre4_r.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre5_r.transform.Rotate(speed*Time.deltaTime,0,0);
			tyre6_r.transform.Rotate(speed*Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.D)){
            gear_left.transform.Rotate(speed * Time.deltaTime, 0, 0);
            pully_l.transform.Rotate(speed * Time.deltaTime, 0, 0);
            tyre1_l.transform.Rotate(speed * Time.deltaTime, 0, 0);
            tyre2_l.transform.Rotate(speed * Time.deltaTime, 0, 0);
            tyre3_l.transform.Rotate(speed * Time.deltaTime, 0, 0);
            tyre4_l.transform.Rotate(speed * Time.deltaTime, 0, 0);
            tyre5_l.transform.Rotate(speed * Time.deltaTime, 0, 0);
            tyre6_l.transform.Rotate(speed * Time.deltaTime, 0, 0);

            //gear_right.transform.Rotate(speed * Time.deltaTime, 0, 0);
            //pully_r.transform.Rotate(speed * Time.deltaTime, 0, 0);
            //tyre1_r.transform.Rotate(speed * Time.deltaTime, 0, 0);
            //tyre2_r.transform.Rotate(speed * Time.deltaTime, 0, 0);
            //tyre3_r.transform.Rotate(speed * Time.deltaTime, 0, 0);
            //tyre4_r.transform.Rotate(speed * Time.deltaTime, 0, 0);
            //tyre5_r.transform.Rotate(speed * Time.deltaTime, 0, 0);
            //tyre6_r.transform.Rotate(speed * Time.deltaTime, 0, 0);
		}
	}
}
