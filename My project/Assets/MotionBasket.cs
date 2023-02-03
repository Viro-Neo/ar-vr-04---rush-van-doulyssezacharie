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
    public LevelHandler level;
    void Start()
    {
        newRotation = new Vector3(roatationSpeedx, roatationSpeedy, roatationSpeedz);
    }

    void FixedUpdate()
    {
        newRotation = new Vector3(roatationSpeedx * ((float)level.GetLevel()) / 2,
                                    roatationSpeedy * ((float)level.GetLevel()) / 2,
                                    roatationSpeedz * ((float)level.GetLevel()) / 2);
        gameObject.GetComponent<Transform>().Rotate(newRotation);
    }
    // Update is called once per frame
}
