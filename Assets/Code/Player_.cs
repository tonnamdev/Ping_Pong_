using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ : MonoBehaviour {

    private float upBound = 4.2f;

    int Direction = 0;
    float PositionY;

    private float Speed = 0.15f;

    Transform tf1;
	
	void Start () {

        //tf1 = transform;
        //PositionY = transform.position.y;
        
	}
	
    void MoveUp_()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y+Speed);

    }

    void MoveDown_()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - Speed);
    }

    void UpBound_()
    {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, -upBound, upBound));
        /////////// Mathf.Clamp เอาไว้ "กั๊กบริเวณ"!! ///////////////

    }

	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            MoveUp_();
            print(transform.position.y);

        }else if (Input.GetKey(KeyCode.S))
        {
            MoveDown_();
            print(transform.position.y);

        }

        UpBound_();
	}
}
