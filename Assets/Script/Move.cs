using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    bool isStop = false;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // ゴールまでの方向ベクトルを計算
        Vector3 direction = Vector3.forward;

        // ゴールに到着した場合、停止する
        if (transform.position.z >= 10f)
        {
            if (!isStop)
            {
                _rigidBody.velocity = Vector3.zero;
                isStop = true;
            }
            return;
        }

        // プレイヤーを自動で進ませる
        _rigidBody.velocity = direction * 5f;
    }
}
