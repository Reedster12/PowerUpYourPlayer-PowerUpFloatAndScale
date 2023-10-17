using UnityEngine;

public class PowerUpFloatAndScale : MonoBehaviour
{
    public float floatSpeed = 0.5f; // Speed at which the powerup floats up and down
    public float floatHeight = 0.5f; // Maximum height the powerup floats up and down
    public float scaleSpeed = 2f; // Speed at which the powerup scales up and down
    public float scaleAmount = 0.05f; // Amount the powerup scales up and down

    private Vector3 initialPosition;
    private Vector3 initialScale;

    void Start()
    {
        initialPosition = transform.position;
        initialScale = transform.localScale;
    }

    void Update()
    {
        // Floating
        float yOffset = Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = initialPosition + new Vector3(0, yOffset, 0);

        // Scaling
        float scaleOffset = (Mathf.Sin(Time.time * scaleSpeed) * scaleAmount) + 1;
        transform.localScale = initialScale * scaleOffset;
    }
}
