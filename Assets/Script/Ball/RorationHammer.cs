using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RorationHammer : MonoBehaviour
{
    private GameObject playerPostion;
    public GameObject childObj;
    private void Awake()
    {
        playerPostion = GameObject.FindGameObjectWithTag("Player");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocityHammer = playerPostion.transform.position - transform.position;
        Debug.DrawRay(transform.position, velocityHammer, Color.green);
        Quaternion targetRotation = Quaternion.LookRotation(velocityHammer);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 0.1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            /*Debug.Log(childObj.transform.rotation.eulerAngles);*/
        }
    }
}
