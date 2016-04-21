﻿using UnityEngine;
using System.Collections;

public class TerrainHit : MonoBehaviour {

	public GameObject goTerrain;

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (goTerrain.GetComponent<Collider>().Raycast (ray, out hit, Mathf.Infinity)) {
				transform.position = hit.point;
			}
		}
	}
}
