using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spt_collide : MonoBehaviour
{
    private bool isAttached = false;
    private Transform hookTransform; // Reference to the hook's transform

    public int Count;
    public int coinValue=10;

    private void Start()
    {
        hookTransform = null; // Initialize the reference to null
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isAttached && other.CompareTag("Hook"))
        {
            isAttached = true;
            hookTransform = other.transform; // Assign the hook's transform
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.isKinematic = true; // Make the fish kinematic to prevent physics interactions
            AttachToHookCenter();

            Counter.instance.IncreaseCount(Count);
            Counter.instance.IncreaseCoins(coinValue);
        }
    }

    private void AttachToHookCenter()
    {
        if (hookTransform != null)
        {
            Vector3 center = hookTransform.position; // Get the center position of the hook
            transform.position = center; // Set the fish's position to the center of the hook
            transform.parent = hookTransform; // Make the hook the parent of the fish
        }
    }
}
