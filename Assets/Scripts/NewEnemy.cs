using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemy : MonoBehaviour
{
    public Material[] Colors;
    public Renderer renderer;
    private int index;

    private void Start()
    {
        renderer = GetComponent<Renderer>();

        renderer.enabled = true;

        index = Random.Range(0, Colors.Length - 1);
        renderer.sharedMaterial = Colors[index];
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

            Player.score += 1;
        }
    }

}
