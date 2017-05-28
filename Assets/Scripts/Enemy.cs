using UnityEngine.UI;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Text ScoreText;
    public GameObject NewEnemy;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Vector3 destroyedEnemyPos = transform.position;
            Destroy(collision.gameObject);
            Destroy(gameObject);

            Player.score += 1;

            init(destroyedEnemyPos);

            ScoreText.text = "Score: " + Player.score;
        }
    }

    void init(Vector3 vec)
    {
        new  WaitForSeconds(10f);
        Instantiate(NewEnemy,vec,transform.rotation);
    }
}
