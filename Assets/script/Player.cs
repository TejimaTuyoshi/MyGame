using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    private Rigidbody2D rbody2D;//�����蔻��̖��O�̒�`
    [SerializeField] float speed = 0.05f;//�ړ�����ۂ̈�t���[��������̈ړ�����
    [SerializeField] float jumpPower = 0.05f;//�ړ�����ۂ̈�t���[��������̈ړ�����
    public int jumpCount = 0;
    bool notmove = false;
    private new SpriteRenderer renderer;//���]����
    [SerializeField] GameObject goalPanel;
    float _h;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 position = transform.position;

        _h = Input.GetAxisRaw("Horizontal");

        if (notmove == false)
        {
            rbody2D.AddForce(Vector2.right * _h * speed, ForceMode2D.Force);
        }
        if(Input.GetButtonDown("Jump")&& jumpCount <= 1 && notmove == false)
        {
            rbody2D.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jumpCount++;
        }
    }
    void LateUpdate()
    {
        if (_h != 0)
        {
            renderer.flipX = (_h < 0);
        }
    }
    public void Addspeed(int power)
    {
        speed += power;

        if (speed > 0)
        {
            Debug.Log("�X�^����...");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            jumpCount = 0;
        }
        if (collision.gameObject.tag == "Goal")
        {
            goalPanel.SetActive(true);
            notmove = true;
        }
    }
}   