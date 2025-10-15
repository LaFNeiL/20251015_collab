using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //게임오버 UI 가져와야함
    private bool isDead = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDead) return; //이미 죽었으면 무시

        if (collision.gameObject.CompareTag("Pipe")) //파이프에 닿으면 Die메서드 호출
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        //UI오브젝트 실행 가져와야함
    }
}
