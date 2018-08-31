using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_ : MonoBehaviour {

    private float Speed_;
    private float Bound_;

    private bool player2;

    private GameObject ball;

	// Use this for initialization
	void Start () {

        Speed_ = 0.1f;
        Bound_ = 3.2f;
	}
	
	// Update is called once per frame
	void Update () {

        SetMove();
        Bound();

	}

    void SetMove()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            transform.position = new Vector2(transform.position.x, transform.position.y + Speed_);

        }else if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.position = new Vector2(transform.position.x, transform.position.y - Speed_);

        }
    }

    void Bound()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, -Bound_, Bound_));
    }
}
