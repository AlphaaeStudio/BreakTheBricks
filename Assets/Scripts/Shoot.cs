using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            var transformTemp = transform;
            GameObject bullet = Instantiate(bulletPrefab, transformTemp.position, transformTemp.rotation);
            Rigidbody rd = bullet.GetComponent<Rigidbody>();
            rd.velocity = Vector3.forward * 35;
        }
    }
}