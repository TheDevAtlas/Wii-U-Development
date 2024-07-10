using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.WiiU;

public class PlayerMovement : MonoBehaviour {

	Rigidbody rb;

	void Start()
	{
		Remote rem = Remote.Access(0);

		MotionPlus mp = rem.motionPlus;
		mp.Enable(MotionPlusMode.Standard);

		rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
		RemoteState state = Remote.Access(0).state;

		if(state.IsTriggered(RemoteButton.A))
		{
			// a button press
		}

		// Triggered Is Single Press, Pressed Is Just If It Is Pressed Or Not //
		if (state.IsPressed(RemoteButton.Up))
		{

		}

		// Motion Controls //
		float x = state.acc.x;
		float y = state.acc.y;
		float z = state.acc.z;

		// Can Rotate Forward & Back //
		// var target = Quaternion.Euler(100 - y * 3, 0, 0);
		// transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 20);

		rb.AddForce(-x * 20, y, z * 20);
	}
}
