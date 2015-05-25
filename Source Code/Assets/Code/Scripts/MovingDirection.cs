using UnityEngine;
using System.Collections;

public class MovingDirection : MonoBehaviour {
	float MaxVelocity = 10F;
	float MaxRevVelocity = -8F;

	float BreakAcc = -5F;
	float Accelaration = 6F;
	float Declaration = -3F;
	//float CurrentVelocity = 0;


	public float Accelarate(float CurrentVelocity){
        if (CurrentVelocity < MaxVelocity && CurrentVelocity >= 0) {
			CurrentVelocity += Accelaration * Time.deltaTime;
				}
		if (CurrentVelocity < 0) {
			CurrentVelocity = Declarate(CurrentVelocity)*0.9F;

		}

		//transform.Translate ((new Vector3(0,0,CurrentVelocity))*Time.deltaTime,Space.Self);
		return CurrentVelocity;
		}
	public float Breaks(float CurrentVelocity){
		if (CurrentVelocity > 0)
						CurrentVelocity =  Declarate(CurrentVelocity)*0.9F;
				else {
						if (CurrentVelocity > MaxRevVelocity) {
							CurrentVelocity += BreakAcc * Time.deltaTime;
							}
						
						
				}

		return CurrentVelocity;	
		}
	public float Declarate(float CurrentVelocity){
		if (CurrentVelocity > 0) {

						CurrentVelocity += Declaration * Time.deltaTime;
						if (CurrentVelocity < 0) {
								CurrentVelocity = 0;
						}
				} else {
						CurrentVelocity -= Declaration * Time.deltaTime;
						if (CurrentVelocity > 0) {
							CurrentVelocity = 0;
						}
				}

		//transform.Translate ((new Vector3(0,0,CurrentVelocity))*Time.deltaTime,Space.Self);
		return CurrentVelocity;
		}
	public void TurnRight(){
        
		float speed = 20 * Time.deltaTime;

		transform.Rotate(0,speed,0,Space.World);
		}
	public void TurnLeft(){
		float speed = 20 * Time.deltaTime;
		transform.Rotate (0,-speed , 0,Space.World);

		}


}
