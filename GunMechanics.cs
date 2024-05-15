using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMechanics : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public Transform bulletSpawn;
    public float bulletSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject _bullet = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            Rigidbody rb = _bullet.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * bulletSpeed;
        }
    }
}
