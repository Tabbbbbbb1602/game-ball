using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    Transform enemy;
    private Rigidbody rb;
    [SerializeField] private Strigger strigger;

    Vector3 lastVelocity;

    public float PowEnemy;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        enemy = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
    
    public void changeWeapon(GameObject w)
    {
        Destroy(strigger.gameObject);
        GameObject wp = Instantiate(w, transform.position, transform.rotation);
        wp.transform.SetParent(transform);
        strigger = wp.GetComponent<Strigger>();
        Debug.Log(rb);
        strigger.rigidbodyParent = rb;
    }
}


