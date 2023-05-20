using UnityEngine;

public class Block : MonoBehaviour
{
    public void Break()
    {
        Destroy(gameObject);
    }
}
