using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _moveDirection;

    private void Start()
    {
        _moveDirection = Vector3.forward;
    }

    private void Update()
    {
        transform.Translate(_moveDirection * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.TryGetComponent(out Block block))
        {
            block.Break();
            Destroy(gameObject);
        }
    }
}
