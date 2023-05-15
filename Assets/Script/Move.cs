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
        // �S�[���܂ł̕����x�N�g�����v�Z
        Vector3 direction = Vector3.forward;

        // �S�[���ɓ��������ꍇ�A��~����
        if (transform.position.z >= 10f)
        {
            if (!isStop)
            {
                _rigidBody.velocity = Vector3.zero;
                isStop = true;
            }
            return;
        }

        // �v���C���[�������Ői�܂���
        _rigidBody.velocity = direction * 5f;
    }
}
