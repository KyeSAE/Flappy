using UnityEngine;


public class PipePoints : MonoBehaviour
{
    private int points;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetPoint();
        }
    }
    public void GetPoint() 
    {
        points = + 1;
        Debug.Log(points);
    }
}
