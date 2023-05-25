using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Basket : MonoBehaviour
{
     [SerializeField] TextMeshPro count;

    void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Basket") && other.CompareTag("Paper"))
        {
            string c = (int.Parse(count.text.ToString()) + 1).ToString();
            count.text = c;
            other.gameObject.active = false;
        }
    }
}
