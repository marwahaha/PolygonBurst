﻿using UnityEngine;
using System.Collections;

public class PolygonBehaviour : MonoBehaviour {

	public Polygon			poly;

	float					speed;
	Color					color;
	Vector3					direction;
	Vector3					initialDirection;

	new SpriteRenderer		renderer;
	float					lifetime;

	void OnEnable()
	{
		renderer = GetComponent< SpriteRenderer >();
		lifetime = 0;
	}

	void OnBecameInvisible()
	{
		enabled = false;
		GameObject.Destroy(gameObject);
	}

	public void UpdateParams(Vector3 direction, Polygon p)
	{
		poly = p;
		this.direction = direction;
		initialDirection = direction;
		transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
		transform.localScale = p.scale.x * Vector3.one;
	}

	void Start()
	{
		// transform.localScale = Vector3.one * scale;
		Update();
	}

	void Update()
	{
		//WARNING: DO NOT CHANGE poly ATTRIBUTES VALUES !

		if (direction != Vector3.zero)
			transform.position += direction * 0.1f;
	}
}