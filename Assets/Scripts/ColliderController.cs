using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    [SerializeField] private GameObject m_colliderParent;

    //public GameObject player;
    //private bool interacting = false;
    public CharacterController2D characterController;
    void Start()
    {
        
        //characterController = player.GetComponent<CharacterController2D>();
        characterController.OnInteractEvent.AddListener(InteractListener);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void InteractListener(bool interacting)
    {
        if (interacting)
        {
            m_colliderParent.SetActive(true);
            //m_leftCollider.enabled = false;
            //m_rightCollider.enabled = false;
        }
        else
        {
            m_colliderParent.SetActive(false);
            //m_leftCollider.enabled = true;
            //m_rightCollider.enabled = true;
        }
    }
}
