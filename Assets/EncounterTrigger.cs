using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterTrigger : MonoBehaviour
{

    private bool encountered = false;
    [SerializeField]private string TriggerName;
    private Animator playerAnimator;
    [SerializeField] private Transform target;
    [SerializeField] private GameObject Particles;
    
    private UnityStandardAssets.Characters.FirstPerson.FirstPersonController firstPersonController;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        
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
            Particles.SetActive(false);
            //liftMap.SetBool("Up",true);
            //flipMap.SetBool("MapSide",true);
            Debug.Log("activate encounter animation");
            playerAnimator.SetTrigger(TriggerName);
            firstPersonController.m_Target = target;
            firstPersonController.canControl = false;
            encountered = true;
        }
    }
}
