using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 0.5f);
    }
}