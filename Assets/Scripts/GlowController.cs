using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowController : MonoBehaviour
{
    public GameObject glowSprite;
    private Collider2D m_collider2D;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Cat")
        {
            Debug.Log("Glowing");
            glowSprite.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Cat")
        {
            glowSprite.SetActive(false);
        }
    }
}
