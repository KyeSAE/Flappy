using UnityEngine;

public class PipeScript : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftmovement();

    }
    /// <summary>
    /// makes the pipes continuesly move left
    /// </summary>
    public void leftmovement()
    {

        transform.Translate(Vector3.left * Time.deltaTime);

    }
}
