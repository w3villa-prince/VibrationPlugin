using UnityEngine;

public class RotateCube : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 30f;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 2 * speed * Time.deltaTime, -speed * Time.deltaTime);
    }
}
