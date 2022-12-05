using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    [SerializeField]
    private float speed = 3f;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>(); // ���� �巡�� �� �ʿ� ���� �ڵ�󿡼� ����
    }
    private void Update()
    {
        // playerAddForce();

        float xInput = Input.GetAxis("Horizontal"); // x�� y�� �� ���� �̵����� �ޱ�
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed; // �̵����� ����� �̵� �ӵ�!
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // ���������� �̵� �� ���������� �ӵ� ! --> �밢�� ������ �Էµ� ���� �����ϱ�!
        // ���� �ڵ������ �� �Ʒ��θ� �̵� ����

        playerRigidbody.velocity = newVelocity;
    }

    // AddForce : ������ ����Ǿ� ���԰� ������. ������ ������ ������ ���� �ӵ� !
    // �ݴ���� �̵� �� ������ ���� �� ��� --> ��ȯ ����
    private void playerAddForce()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
            playerRigidbody.AddForce(0f, 0f, speed);
        if (Input.GetKey(KeyCode.DownArrow) == true)
            playerRigidbody.AddForce(0f, 0f, -speed);
        if (Input.GetKey(KeyCode.RightArrow) == true)
            playerRigidbody.AddForce(speed, 0f, 0f);
        if (Input.GetKey(KeyCode.LeftArrow) == true)
            playerRigidbody.AddForce(-speed, 0f, 0f);
    }

    public void Die() // ����� �÷��̾� ��Ȱ��ȭ --> �ܺο��� ���ٵ� !!! public
    {
        gameObject.SetActive(false); // ���⼭�� ���� ������Ʈ�� �÷��̾� ��ü
    }
}