using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField]
    private float speed = 6f; // ź���̵� �ӷ�
    private Rigidbody bulletRigidbody;

    private void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>(); // ���� ���� �ʿ� ����
        bulletRigidbody.velocity = transform.forward * speed; // ������ �̵��ϴ� ������ ���� �ӵ�

        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider _other)
    {
        if(_other.tag == "Player") // �浹�� �� �÷��̾��϶�
        {
            PlayerController playerController = _other.GetComponent<PlayerController>();
            if (playerController != null)
                playerController.Die();
        }
    }
}