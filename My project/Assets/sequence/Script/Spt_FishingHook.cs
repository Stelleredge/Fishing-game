using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingHook : MonoBehaviour
{
    public float ascendingSpeed;
    public float descendingSpeed;
    public float maxDistance = 10f;
    public float speed = 5f;
    public float leftBound = -10f;
    public float rightBound = 10f;

    private bool movingRight = true;

    private Vector3 startPosition;
    private bool isAscending = true;

    public void depthupdate()
    {
        maxDistance = maxDistance + 10;
        Debug.Log("updated");
    }
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float mouseX = Input.mousePosition.x;
        float screenWidth = Screen.width;
        float positionX = (mouseX / screenWidth) * (rightBound - leftBound) + leftBound;

        transform.position = new Vector3(positionX, transform.position.y, transform.position.z);

        if (movingRight)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        }

        if (transform.position.x >= rightBound)
        {
            movingRight = false;
        }
        else if (transform.position.x <= leftBound)
        {
            movingRight = true;
        }


        if (isAscending)
        {
            transform.Translate(Vector3.down * ascendingSpeed * Time.deltaTime);
            if (transform.position.y <= startPosition.y - maxDistance)
            {
                isAscending = false;
            }
        }
        else
        {
            transform.Translate(Vector3.up * descendingSpeed * Time.deltaTime);
            if (transform.position.y >= startPosition.y)
            {
                isAscending = true;
            }
        }
    }
}
