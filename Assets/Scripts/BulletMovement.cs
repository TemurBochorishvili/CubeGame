using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BulletMovement : MonoBehaviour
{
    public float AmmoLife = 2f;
    public float AmmoSpeed = 10f;
    public Text ScoreText;

    IEnumerator Start()
    {
        transform.position = new Vector3(GameObject.Find("Sphere").transform.position.x, 0, 0);

        yield return new WaitForSeconds(AmmoLife);

        Destroy(gameObject);
        Player.score -= 1;
        //ScoreText.text = "Score: " + Player.score;
    }

    void Update()
    {
        transform.Translate(0, AmmoSpeed * Time.deltaTime, 0);
    }
}

