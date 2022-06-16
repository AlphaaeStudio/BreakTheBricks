using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksManager : MonoBehaviour {
    public GameObject brickPrefab;

    void Start() {
        for (int i = -8; i <= 8; i++) {
            for (int j = 0; j <= 8; j++) {
                var transformTemp = transform;
                Instantiate(brickPrefab, transformTemp.position + new Vector3(i, j, 0), transformTemp.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update() { }
}