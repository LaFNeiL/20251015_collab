using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //���ӿ��� UI �����;���
    private bool isDead = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDead) return; //�̹� �׾����� ����

        if (collision.gameObject.CompareTag("Pipe") || transform.position.y < -25.0f) //�������� ������ Die�޼��� ȣ��
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        //UI������Ʈ ���� �����;���
    }
}
