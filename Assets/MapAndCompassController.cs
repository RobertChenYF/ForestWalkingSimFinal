using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapAndCompassController : MonoBehaviour
{
    private Animator animator;
    [SerializeField]private Animator MapAnimator;
    [SerializeField]private UnityStandardAssets.Characters.FirstPerson.FirstPersonController firstPersonController;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (firstPersonController.canControl)
        {
            if (Input.GetMouseButton(0))
            {
                animator.SetBool("Up", true);
            }
            else
            {
                animator.SetBool("Up",false);
            }

            if (Input.GetMouseButtonDown(1)&&animator.GetBool("Up"))
            {
                MapAnimator.SetBool("MapSide",!MapAnimator.GetBool("MapSide"));
            }
        }
    }
}
