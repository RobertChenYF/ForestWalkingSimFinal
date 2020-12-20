using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassController : MonoBehaviour
{
    [SerializeField]private Transform CursorTransform;
    [SerializeField] private Transform CompassTransform;
    private Quaternion thisRotation;
    public float a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //thisRotation.eulerAngles = new Vector3(CursorTransform.eulerAngles.x, CursorTransform.eulerAngles.y,a+CursorTransform.eulerAngles.z);
        //CursorTransform.rotation = thisRotation;

        Quaternion target = Quaternion.Euler(-90, a, 0);

        // Dampen towards the target rotation

        CursorTransform.Rotate(new Vector3(0,0,Quaternion.Slerp(CursorTransform.rotation, target, Time.deltaTime * 3).z),Space.Self);
        //CursorTransform.Rotate = 0,0, ,);
    }
}
