using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3f; 
    public float moveDistance = 5f; 

    private int moveDirection = 1; 
    private Vector3 initialPosition; 

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {

        Vector3 targetPosition = initialPosition + Vector3.right * moveDirection * moveDistance;


        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);


        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            moveDirection *= -1;
            Flip();
        }
    }
    void Flip()
    {
        // Düþmanýn lokal ölçek vektörünü tersine çevir
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
