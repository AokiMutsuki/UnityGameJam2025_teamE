using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;



public class boolScript : MonoBehaviour
{


    [SerializeField] private GameObject Clouds;
    [SerializeField] private Transform playerTransform;
    private float speed = 1000;



    //Start is called before the first frame update;
    void Start()
    {
        if (playerTransform == null)
        {
            GameObject player = GameObject.Find("StarSparrow1"); // �� �v���C���[�̖��O�ɕύX
            if (player != null)
            {
                playerTransform = player.transform;
            }
            else
            {
                Debug.LogError("StarSparrow1�I�u�W�F�N�g��������܂���I");
            }




        }
    }
        // Update is called once per frame


        void Update()
    {
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject ball = (GameObject)Instantiate(Clouds, playerTransform.position, Quaternion.identity);
                ball.name = ball.name.Replace("(Clone)", "");
                Destroy(ball, 0.3f); // 0.3�b��ɍ폜





                Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
                if (ballRigidbody != null)
                {
                    ballRigidbody.velocity = transform.forward * speed;
                }

            
            }
        }

    }

}
    




     


































  
