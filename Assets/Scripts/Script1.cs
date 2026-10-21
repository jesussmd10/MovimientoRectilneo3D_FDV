using UnityEngine;

public class Script1 : MonoBehaviour
{
    public Vector3 goal = new Vector3(1f, 5f, 5f);
    public float speed = 2f;
    Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        // Calculamos la dirección
        direction = goal - transform.position;
        // Normalizamos y movemos
        direction.Normalize();
        transform.position += speed * direction * Time.deltaTime;

        // Creamos la rotación y aplicamos al objeto
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = targetRotation;
    }
}