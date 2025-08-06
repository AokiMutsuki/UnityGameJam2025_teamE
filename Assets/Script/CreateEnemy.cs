using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    Vector3 startPos;
    Vector3 startRot;




    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        float posY = startPos.y + Mathf.Sin(Time.time) * 4;
        transform.position = new Vector3(transform.position.x, posY, transform.position.z);

        float rotZ = startRot.z + Mathf.Sin(Time.time) * 30;
        transform.rotation = Quaternion.Euler(startRot.x, startRot.y, rotZ);
    }
}
