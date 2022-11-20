using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    [SerializeField]
    Transform barrelRotator;
    [SerializeField]
    Transform firePoint;
    [SerializeField]
    GameObject bulletToFire;
    public float firePower;
    [SerializeField]
    float moveSpeed = 5f;
    public bool hasFired = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {

        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime * Input.GetAxis("Player1"));

        barrelRotator.RotateAround(Vector3.forward, Input.GetAxis("Vertical") * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && hasFired == false)
        {
            GameObject b = Instantiate(bulletToFire, firePoint.position, firePoint.rotation);
            b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * firePower, ForceMode2D.Impulse);
            hasFired = true;

        }
        firePower = Mathf.Clamp(firePower, 5, 50);

        if (Input.GetKey(KeyCode.E))
        {
            firePower += 8f * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.Q))
        {
            firePower -= 8f * Time.deltaTime;
        }
        if (hasFired == true)
        {
            moveSpeed = 0;
        }
        else if (hasFired == false)
        {
            moveSpeed = 5;
        }
    }
}