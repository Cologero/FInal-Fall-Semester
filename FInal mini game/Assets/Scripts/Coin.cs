using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioSource _coinAudio;

    private void Start()
    {
        _coinAudio = GetComponet<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collected the coin.");
            GameObject.Find("Canvas").GetComponent<UIManager>().UpdateCoinCount();
            _coinAudio.Play(coinSound);
            Destroy(this.gameObject);
        }
    }
                                                                                                                                
}
