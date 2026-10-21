using UnityEngine;

public class Script3 : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;

    void Start()
    {
        this.transform.LookAt(goal.position);
    }
    // Update is called once per frame
    void Update()
    {
        //Calcula el vector de dirección
        Vector3 direction = goal.position - this.transform.position;
        Debug.DrawRay(this.transform.position,direction,Color.red);
        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

    }
}
