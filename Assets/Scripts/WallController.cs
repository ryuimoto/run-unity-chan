using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{

    public float speed = 0.05f;
    public float max_x = 10.0f;


    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(speed, 0, 0);

        if (this.gameObject.transform.position.x > max_x || this.gameObject.transform.position.x < (-max_x))
        {
            speed *= -1;
        }
    }
}
