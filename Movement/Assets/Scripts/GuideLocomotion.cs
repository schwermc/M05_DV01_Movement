using UnityEngine;

public class GuideLocomotion : MonoBehaviour
{
    [SerializeField] Transform rigRoot;
    [SerializeField] Transform trackedTransform; // camera or controller, null  for thumbstick
    [SerializeField] float velocity = 2f;
    [SerializeField] float rotationSpeed = 100f; // degrees per second

    void Start()
    {
        if (rigRoot == null)
        {
            rigRoot = transform;
        }
    }


    void Update()
    {
        float forward = Input.GetAxis("XRI_Right_Primary2DAxis_Vertical");
        if (forward != 0f)
        {
            Vector3 moveDirection = Vector3.forward;
            if (trackedTransform != null)
            {
                moveDirection = trackedTransform.forward;
                moveDirection.y = 0f;
            }
            moveDirection *= -forward * velocity * Time.deltaTime;
            rigRoot.Translate(moveDirection);
        }

        if (trackedTransform == null)
        {
            float sideways = Input.GetAxis("XRI_Right_Primary2DAxis_Horizontal");
            if (sideways != 0f)
            {
                float rotation = sideways * rotationSpeed * Time.deltaTime;
                rigRoot.Rotate(0, rotation, 0);
            }
        }
    }
}
