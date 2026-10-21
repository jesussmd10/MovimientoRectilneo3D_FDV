using UnityEngine;

public class Script2 : MonoBehaviour
{
    public Vector3 goal;
    public float speed;

    // Update is called once per frame
    void Update()
    {

        //Modifica coord abs del mundo, sin importar rotación.
        //this.transform.position += goal.normalized * speed * Time.deltaTime;

        //Modifica las coord relativas al objeto, respetando rotación
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
    }
}
