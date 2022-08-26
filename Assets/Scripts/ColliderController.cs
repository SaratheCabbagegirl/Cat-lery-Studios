using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    public Collider2D m_collider;
    public Collider2D catCollider;
    public CharacterController2D characterController;
    
    void Start()
    {
        Physics2D.IgnoreCollision(m_collider, catCollider, true);
        characterController.OnInteractEvent.AddListener(InteractListener);
    }


    void InteractListener(bool interacting)
    {
        if (interacting)
        {
            Physics2D.IgnoreCollision(m_collider, catCollider, false);
        }
        else
        {
            Physics2D.IgnoreCollision(m_collider, catCollider, true);
        }
    }
}
