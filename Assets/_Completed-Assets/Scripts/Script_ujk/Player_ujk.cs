using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ujk : MonoBehaviour
{
    // 移動スピード
    public float Speed = 5f;
    public GameObject _bullet;
	void Start ()
    {

	}


    void Update()
    {
        MovePlayer();
        ShotBullet();
    }
    
    void ShotBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_bullet, transform.position, transform.rotation);
        }
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
