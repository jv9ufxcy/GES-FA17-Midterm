using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;
    public Transform muzzleRotateAnchor;
    public Transform rocketMuzzle;
    public float fireRate;
    public float nextFire = 0f;


    // Use this for initialization
    private void PlayerShoot()
    {
        if (Input.GetAxisRaw("Fire1") > 0) fireBullet();
    }
    void fireBullet()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Vector3 offset = transform.rotation * bulletOffset;
            GameObject newbullet = Instantiate(bulletPrefab, rocketMuzzle.position, muzzleRotateAnchor.rotation);
        }
    }

            // Update is called once per frame
    void Update ()
    {
        PlayerShoot();
	}
}
