using UnityEngine;
using System.Collections;

public class CollisionForwarder : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		transform.parent.gameObject.SendMessage("OnCollisionEnter", col);
	}
}
