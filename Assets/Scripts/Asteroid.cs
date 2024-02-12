using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other) {
        GameObject collide = other.gameObject;
        if (collide.CompareTag("Weapon")){
            Debug.Log(collide.name);
            collide.GetComponent<Axe>().OnAsteroidDestroyed();
            Destroy(this.gameObject);
        }
    }
}
