using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(MovementRotater))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _transform;
    private Rigidbody2D _rigidBody;
    private MovementRotater _selfMovementRotater;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _selfMovementRotater = GetComponent<MovementRotater>();
    }
    public void Move(Vector2 direction)
    {
        Vector2 position = new Vector2(_transform.position.x, transform.position.y);
        Vector2 offset = position + direction * _speed;
        _rigidBody.MovePosition(offset);
        _selfMovementRotater.Rotate(direction);
    }
}
