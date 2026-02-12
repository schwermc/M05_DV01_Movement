using UnityEngine;

public class ClimbController : MonoBehaviour
{
    [SerializeField] GameObject xrRig;

    void Start()
    {
     if (xrRig == null)
        {
            xrRig = GameObject.Find("XR Rig");
        }   
    }

    public void Grab()
    {
        
    }

    public void Pull(Vector3 distance)
    {
        xrRig.transform.Translate(distance);
    }

    public void Release()
    {

    }
}
