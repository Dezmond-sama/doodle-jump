using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speedX = .15f;
    [SerializeField] private float _speedY = .15f;
    private Vector3 _currentVelocity;

    private void LateUpdate()
    {
        MoveUp();
        MoveHorizontal();
    }
    private void MoveUp()
    {
        if (_target.position.y > transform.position.y)
        {
            Vector3 pos = new Vector3(transform.position.x, _target.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, pos, ref _currentVelocity, _speedY);
        }
    }
    private void MoveHorizontal()
    {

        Vector3 pos = new Vector3(_target.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref _currentVelocity, _speedX);

    }
}
