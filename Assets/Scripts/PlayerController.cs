using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float rotationSpeed = 100.0f;

    public int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        
        float xMoveValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float yMoveValue = 0f;
        float zMoveValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        // Make a object move around on X, Y, Z plane
        transform.Translate(xMoveValue, yMoveValue, zMoveValue);



    }
}
