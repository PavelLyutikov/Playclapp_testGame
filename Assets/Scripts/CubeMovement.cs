using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    Vector3 destinationPoint;

    int dictanceX;
    int speed;

    void Start()
    {

        dictanceX = PlayerPrefs.GetInt("dictanceX");
        speed = PlayerPrefs.GetInt("speed");
    }

    void Update()
    {

        destinationPoint = new Vector3(dictanceX, 0.5f, 0f);

        transform.position = Vector3.MoveTowards(transform.position, destinationPoint, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, destinationPoint) <= 0)
        {
            destroyCube();
        }
    }

    void destroyCube() {
        Destroy(this.gameObject);
    }

}
