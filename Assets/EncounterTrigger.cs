using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterTrigger : MonoBehaviour
{

    private bool encountered = false;
    [SerializeField]private string TriggerName;
    private Animator playerAnimator;
    private Animator liftMap;
    private Animator flipMap;
    private UnityStandardAssets.Characters.FirstPerson.FirstPersonController firstPersonController;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        liftMap = GameObject.Find("Map and compass").GetComponent<Animator>();
        flipMap = GameObject.Find("Map").GetComponent<Animator>();
        firstPersonController = FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (encountered == false && other.gameObject.CompareTag("Player"))
        {
            playerAnimator.enabled = true;
            liftMap.SetBool("Up",true);
            flipMap.SetBool("MapSide",true);
            Debug.Log("activate encounter animation");
            playerAnimator.SetTrigger(TriggerName);
            firstPersonController.canControl = false;
        }
    }
}
