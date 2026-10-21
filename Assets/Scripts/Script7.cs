using UnityEngine;

public class Script7 : MonoBehaviour
{
    public Transform player;
    public Transform goal;

    public float goalSpeed = 5f;
    public float playerSpeed = 2f;
    public float boostPlayerSpeed = 2f;
    //public float accuracy = 0.1f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 cuboMove = new Vector3(moveX, 0, moveZ);
        goal.Translate(cuboMove * goalSpeed * Time.deltaTime, Space.World);

        /*Metodo A
        Vector3 direction = goal.position - player.position;

        if (direction.magnitude > accuracy)
        {
            player.LookAt(goal.position);
            player.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
        }
        */

        /*Metodo B
        float distance = Vector3.Distance(player.position, goal.position);

        if (distance > accuracy)
        {
            player.LookAt(goal.position);
            player.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
        }
        */

        float currentSpeed = playerSpeed;
        if (Input.GetKey(KeyCode.Space))
        {
            currentSpeed *= boostPlayerSpeed;
        }

        player.LookAt(goal.position);

        player.position = Vector3.MoveTowards(player.position, goal.position, currentSpeed * Time.deltaTime);

        Debug.DrawRay(player.position, goal.position - player.position, Color.red);
    }
}