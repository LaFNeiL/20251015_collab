using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //���ӿ��� UI �����;���
    private bool isDead = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDead) return; //�̹� �׾����� ����

        if (collision.gameObject.CompareTag("Pipe")) //�������� ������ Die�޼��� ȣ��
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
