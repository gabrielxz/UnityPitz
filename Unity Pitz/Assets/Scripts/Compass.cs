using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour {

	public Quaternion missionDirection;

    public Transform arrow;

	public Transform missionplace;
	
	// Update is called once per frame
	void Update () {
		ChangeMissionDirection();
	}

	 void ChangeMissionDirection(){
		 Vector3 dir = transform.position - missionplace.position;
		missionDirection = Quaternion.LookRotation(dir);
		missionDirection.z = -missionDirection.y;
		missionDirection.x = 0;
		missionDirection.y = 0;
		arrow.rotation = missionDirection;
	}
}
