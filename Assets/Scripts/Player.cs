using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Bullet;
    private float X_speed = 5f;
    private float Up_speed = 10f;

    [HideInInspector]
    public static int score = 0;

    private void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        if (transform.position.x >= 5)
        {
            X_speed = -X_speed;
        }

        if (transform.position.x <= -5)
        {
            X_speed = -X_speed;
        }

        transform.Translate(X_speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet); 
        }
    }
}
