using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionBasket : MonoBehaviour
{
    public float roatationSpeedx;
    public float roatationSpeedy;
    public float roatationSpeedz;
    Vector3 newRotation;
    // Start is called before the first frame update
    void Start()
    {
        newRotation = new Vector3(roatationSpeedx, roatationSpeedy, roatationSpeedz);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Transform>().Rotate(newRotation);
    }
}
