using UnityEngine;

public class Script5 : MonoBehaviour
{
    public Transform player;
    public Transform goal;

    public float goalSpeed = 5f;
    public float playerSpeed = 2f;
    public float boostPlayerSpeed = 2f;
    
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 cuboMove = new Vector3 (moveX,0,moveZ);
        goal.Translate(cuboMove * goalSpeed * Time.deltaTime, Space.World);

        player.LookAt(goal.position);

        Vector3 direction = goal.position - player.position;

        Debug.DrawRay(player.position,direction,Color.red);

        float currentSpeed = playerSpeed;
        if(Input.GetKey(KeyCode.Space))
        {
            currentSpeed *= boostPlayerSpeed;
        }

        player.Translate(direction.normalized * currentSpeed * Time.deltaTime, Space.World);
    }
}
