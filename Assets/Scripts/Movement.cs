using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    private float _speed = 3.0f;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, v, 0) * (_speed * Time.deltaTime));
    }
}