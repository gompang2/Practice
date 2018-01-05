using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterImage : MonoBehaviour {

    private SpriteRenderer rendere;

	// Use this for initialization
	void Start () {
        rendere = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        rendere.color -= new Color(0, 0, 0, 0.05f);
        if (rendere.color.a <= 0) Destroy(gameObject);		
	}
}
