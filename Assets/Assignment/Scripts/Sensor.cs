using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
 
    public SpriteRenderer spriteRenderer;
void Start()
{
if (spriteRenderer != null)
{
spriteRenderer.color = Color.blue;
    }
}
private void OnTriggerEnter2D(Collider2D collision)
{
Debug.Log(collision.gameObject + " is in the trigger");
if (spriteRenderer != null) spriteRenderer.color = Color.blue;
}
private void OnTriggerExit2D(Collider2D collision)
{
if (spriteRenderer != null) spriteRenderer.color = Color.red;
    }
}
