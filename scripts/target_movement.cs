using UnityEngine;

public class Target_movement : MonoBehaviour
{
    public enum MoveDirection
    {
        Horizontal,
        Vertical,
        Depth
    }

    public MoveDirection moveDirection;
    public float moveDistance = 5f;
    public float moveSpeed = 2f;

    private Vector3 initialPosition;
    private Rigidbody rigidbody;

    void Start()
    {
        initialPosition = transform.position;
        rigidbody = GetComponent<Rigidbody>();

        // Asegúrate de que el Rigidbody sea cinético
        if (rigidbody)
        {
            rigidbody.isKinematic = true;
        }
    }

    void Update()
    {
        float movement = Mathf.Sin(Time.time * moveSpeed) * moveDistance;
        Debug.Log(Time.time);
        Debug.Log(moveSpeed);
        Debug.Log(Time.time * moveSpeed);
        Vector3 newPosition = initialPosition;

        switch (moveDirection)
        {
            case MoveDirection.Horizontal:
                newPosition.x += movement;
                break;
            case MoveDirection.Vertical:
                newPosition.y += movement;
                break;
            case MoveDirection.Depth:
                newPosition.z += movement;
                break;
        }

        if (rigidbody)
        {
            // Mueve el Rigidbody utilizando MovePosition para que la física lo gestione
            rigidbody.MovePosition(newPosition);
        }
        else
        {
            // Si no hay Rigidbody, simplemente actualiza la posición del transform
            transform.position = newPosition;
        }
    }
}
