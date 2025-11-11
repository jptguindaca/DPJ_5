using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    private Transform PointA;
    private Transform PointB;

    float waitingTime = 0f;
    float movingSpeed =2f;

    Transform targetPoint;
    float waitTimer;
    bool isWaiting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
