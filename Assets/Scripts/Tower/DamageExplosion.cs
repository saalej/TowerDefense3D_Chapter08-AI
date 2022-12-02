using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageExplosion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && other.GetComponent<Tank>().hasShield == false)
        {
            other.GetComponent<Tank>().lifeTotal -= 1;
        }
    }
}
