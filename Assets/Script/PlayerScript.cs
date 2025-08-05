using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{
    public float MoveSpeed = 10.0f;

    public Transform StarSparrow1;

    public float followSpeed = 10.0f;

    //[SerializeField] private GameObject Clouds;
   // private float speed = 300;
     //Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            move.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move.x += 1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            move.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move.y -= 1;
        }

        transform.position += move;

        // 入力を取得
        float moveX = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;

        // 現在の位置を取得
        Vector3 newPosition = transform.position;

        // x座標を更新
        newPosition.x += moveX;

        // x座標を -500〜500 に制限
        newPosition.x = Mathf.Clamp(newPosition.x, -250f, 250f);

        // 位置を更新
        transform.position = newPosition;



    }
}