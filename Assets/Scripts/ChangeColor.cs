using UnityEngine;

public class ChangeColor : MonoBehaviour
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

    void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            index = Random.Range(0, Colors.Length - 1);
            renderer.sharedMaterial = Colors[index];
        }
	}
}
