using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderMovement : MonoBehaviour
{
    public float lateralMovementSpeed = 5f;
    public float verticalMovementSpeed = 10f;
    public float lateralDisplacement = 20f;
    public float verticalDisplacement = 2f;
    private Vector3 originalPosition;
    private Vector3 targetPosition;

    private void Start()
    {
        //Get the starting position
        originalPosition = transform.position;

        //Defining the first target position as lateralDisplacement in the positive direction
        targetPosition = new Vector3(originalPosition.x + lateralDisplacement, originalPosition.y, originalPosition.z);
    }

    private void Update()
    {
        //Every frame, move towards the target position using the speed defined in lateralMovementSpeed
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * lateralMovementSpeed);

        //Check if you are within .001 units of the target
        if (Mathf.Abs((transform.position - targetPosition).x) < .001f)
        {
            //if you are...move down by verticalDisplacement amount
            transform.position = new Vector3(transform.position.x, transform.position.y - verticalDisplacement, transform.position.z);
            //then move the target position to the opposite side
            targetPosition = new Vector3(targetPosition.x * -1f, transform.position.y, transform.position.z);
        }
    }
}
