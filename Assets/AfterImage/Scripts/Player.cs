using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject afterImg;
    public float moveSpeed;
    public float afterImgDelay;
    public const float afterImgMaxDelay = 0.08f;

    private Vector3 moveVector;

    // Use this for initialization
    void Start () {
        afterImgDelay = afterImgMaxDelay;
        moveVector = new Vector3(0, 0);
    }
	
	// Update is called once per frame
	void Update () {

        if (moveVector != new Vector3(0, 0)) moveVector = new Vector3(0, 0);

        if (Input.GetKey(KeyCode.A))
        {
            moveVector += new Vector3(-1, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveVector += new Vector3(1, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            moveVector += new Vector3(0, 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveVector += new Vector3(0, -1);
        }

        if (moveVector != new Vector3(0, 0))
        {
            AfterImage();
            transform.position += moveVector.normalized * moveSpeed * Time.deltaTime;
        }

        if (afterImgDelay > 0) afterImgDelay -= Time.deltaTime;
    }

    void AfterImage()
    {
        if(afterImgDelay <= 0)
        {
            Instantiate(afterImg).transform.position = transform.position;
            afterImgDelay = afterImgMaxDelay;
        }
    }
}
