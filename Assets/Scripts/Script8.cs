using UnityEngine;

public class Script8 : MonoBehaviour
{
    public Transform player;
    public Transform goal;

    public float goalSpeed = 5f;
    public float playerSpeed = 2f;
    public float boostPlayerSpeed = 2f;
    public float rotationSpeed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 cuboMove = new Vector3(moveX, 0, moveZ);
        goal.Translate(cuboMove * goalSpeed * Time.deltaTime, Space.World);

        float currentSpeed = playerSpeed;
        if (Input.GetKey(KeyCode.Space))
        {
            currentSpeed *= boostPlayerSpeed;
        }

        player.position = Vector3.MoveTowards(player.position, goal.position, currentSpeed * Time.deltaTime);

        // Obtenemos la dirección vector
        Vector3 direction = goal.position - player.position;

        // Crea la rotación necesaria para mirar en esa dirección
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        // Interpolamos suavemente desde la rotación actual hasta la rotación objetivo frame a frame
        player.rotation = Quaternion.Slerp(player.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        Debug.DrawRay(player.position, goal.position - player.position, Color.red);
    }
}