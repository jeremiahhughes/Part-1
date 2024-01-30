using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 movementDirection = new Vector3(1f, 0f, 0f);
    public float movementSpeed = 1f;
    public float movementDistance = 5f;

    private Vector3 startingPosition;
    private bool movingForward = true;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        // Calculate the total movement distance in both directions
        float currentMovementDistance = Vector3.Distance(startingPosition, transform.position);

        // Reverse the direction if the platform has moved the specified distance
        if (currentMovementDistance >= movementDistance)
        {
            movingForward = !movingForward;
            // Reset starting position for the next movement cycle
            startingPosition = transform.position;
        }

        // Determine the direction of movement
        Vector3 direction = movingForward ? movementDirection.normalized : -movementDirection.normalized;

        // Move the platform
        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }
}
