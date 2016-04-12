using UnityEngine;
using System.Collections;
using DG.Tweening;

[RequireComponent(typeof(BaseCollisionTrap))]
public class FlameTrap : MonoBehaviour {

	// Use this for initialization
	[Range(0, 10)]
	public float maxHeight;
	[Range(0, 5)]
	public float timeToReachMaxHeight;
	[Range(0, 10)]
	public float maxDuration;
	float duration;
	bool active = false;
	private float height;
	private Vector3 initialSize;

	private BoxCollider boxCollider;

	void Start()
	{
		GetComponent<Collider>().enabled = false;
	}

	void SetSize(Vector3 size)
	{
		boxCollider.size = size;
		boxCollider.center = ((size - initialSize)/2);
	}

	Vector3 GetSize()
	{
		return boxCollider.size;
	}

	void OnActivate()
	{
		duration = maxDuration;
		boxCollider = GetComponent<BoxCollider>();
		initialSize = boxCollider.size;

		GetComponent<Collider>().enabled = true;
		active = true;
		var newSize = boxCollider.size;
		newSize.y = maxHeight;
		DOTween.To(GetSize, SetSize, newSize, timeToReachMaxHeight);
		//transform.DOScaleY(2, 1).SetLoops(1, LoopType.Yoyo).SetRelative();

		duration = maxDuration;
	}

	void OnPlayerCollision()
	{
		//todo Kill player
	}

	// Update is called once per frame
	void Update()
	{

		if (active == true)
		{
			duration -= Time.deltaTime;
			if (duration <= 0)
			{
				SendMessage("DeactivateTrap");
				active = false;
				GetComponent<Collider>().enabled = false;
				boxCollider.size = initialSize;
			}
		}
	}
}

