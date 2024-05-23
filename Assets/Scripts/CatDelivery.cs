using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDelivery : MonoBehaviour
{
    private bool hasKitten = false;
    [SerializeField] Color32 hasKittenColor = new Color32(1, 1, 1, 255);
    [SerializeField] Color32 noKittenColor = new Color32(1, 1, 1, 255);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
       if (collider.gameObject.CompareTag("Owner") && hasKitten)
        {
            hasKitten = false;
            Destroy(collider.gameObject);
            spriteRenderer.color = noKittenColor;
            Debug.Log("Kitten was delivered");
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Kitten"))
        {
            hasKitten = true;
            Destroy(other.gameObject);
            spriteRenderer.color = hasKittenColor;
            Debug.Log("Kitten was picked");
        }
    }
}
