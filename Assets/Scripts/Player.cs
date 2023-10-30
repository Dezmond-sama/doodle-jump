using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Rigidbody2D _rb;
    private float _movement = 0f;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _movement = Input.GetAxis("Horizontal") * _speed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = _rb.velocity;
        velocity.x = _movement;
        _rb.velocity = velocity;
    }
    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
