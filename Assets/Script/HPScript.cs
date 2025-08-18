using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPScript : MonoBehaviour
{
    public int life = 3; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            TakeDamage();

            Destroy(gameObject);
        }
    }

    void TakeDamage()
    {
        if (life <= 0) return;

        life--;
        Debug.Log("ダメージ！残りライフ: " + life);

        if (life <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("ゲームオーバー！");
        gameObject.SetActive(false);
    }
}


    

