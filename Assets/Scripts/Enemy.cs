using UnityEngine;
using System.Collections;

public class Enemy :Token {

	// Use this for initialization
	void Start () {
        float size = Random.Range(1, 5);
        SetSize(size, size);
        float pos = Random.Range(0, 1);
        SetPosition(SpriteWidth * pos, SpriteHeight);

        float direction = Random.Range(0, 359);
        float speed = 2;
        SetVelocity(direction, speed);
	}

    /// 更新
    void Update()
    {
        // カメラの左下座標を取得
        Vector2 min = GetWorldMin();
        // カメラの右上座標を取得する
        Vector2 max = GetWorldMax();

        if (X < min.x || max.x < X)
        {
            // 画面外に出たので、X移動量を反転する
            VX *= -1;
            // 画面内に移動する
            //ClampScreen();
        }
    }
    void OnBecameInvisible()
    {
        DestroyObj();
    }
}
