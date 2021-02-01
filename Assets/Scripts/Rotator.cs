using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float theta = 0.0f;
    public float Float1Y;
    public float Float2Y;

    void Update()
    {
        //Rotates the game object that the script is attached to by 15 in the X axis,
        //30 in the Y axis and 45 in the z Axis multiplied by deltaTime in order to make it persecond
        //rather than per frame.
        float py;
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        /*
         * this bit of code is used to create the bobbing effect and be eddityable in script
         */
        py = Float1Y + Float2Y * Mathf.Cos(theta);
        theta += 2 * Mathf.PI * Time.deltaTime;
        Vector3 nv;
        nv = new Vector3(gameObject.transform.position.x, py, gameObject.transform.position.z);
        gameObject.transform.position = nv;
    }
}
