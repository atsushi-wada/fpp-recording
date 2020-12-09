using UnityEngine;

public class GraphAttributeTest : MonoBehaviour
{
    [Graph(100)]
    public int fps;

    [Graph(100)]
    public float positionX;

    [Graph(100)]
    public Vector2 positionXY;

    [Graph(50)]
    public Vector3 position;

    [Graph(50)]
    public Quaternion rotation;

    [Graph(20)]
    public Color color;


    void Start()
    {
        Application.runInBackground = true;
    }

    void Update ()
    {
        float t = Time.time * 1f;
        transform.Translate(new Vector3(
            Mathf.PerlinNoise(0, t) - 0.5f,
            Mathf.PerlinNoise(0.3f, t) - 0.5f,
            Mathf.PerlinNoise(0.7f, t) - 0.5f
        ) * 0.1f);

        transform.Rotate(new Vector3(
            Mathf.PerlinNoise(0.8f, t) - 0.5f,
            Mathf.PerlinNoise(0.46f, t) - 0.5f,
            Mathf.PerlinNoise(0.2f, t) - 0.5f
        ) * 30f);


        fps = Time.captureFramerate;
        position = transform.localPosition;
        positionX = position.x;
        positionXY = position;
        rotation = transform.localRotation;
    }
}
