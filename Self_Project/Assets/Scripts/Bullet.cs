using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField]
    private float speed = 8f; // ź���̵� �ӷ�
    private Rigidbody bulletRigidbody;

    private void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>(); // ���� ���� �ʿ� ����
        bulletRigidbody.velocity = transform.forward * speed; // ������ �̵��ϴ� ������ ���� �ӵ�
    }
}
