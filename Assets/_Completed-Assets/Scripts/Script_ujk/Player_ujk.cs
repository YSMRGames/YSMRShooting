using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ujk : MonoBehaviour
{
    // 移動スピード
    public float Speed = 5f;
	
	void Start ()
    {

	}
	
	
	void Update ()
    {
        MovePlayer();
	}

    void MovePlayer()
    {
        // 右・左
        float x = Input.GetAxisRaw("Horizontal");

        // 上・下
        float y = Input.GetAxisRaw("Vertical");

        // 移動する向きを求める
        Vector2 direction = new Vector2(x, y).normalized;

        // 移動する向きとスピードを代入する
        GetComponent<Rigidbody2D>().velocity = direction * Speed;

    }
}
