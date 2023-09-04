using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Symbol : MonoBehaviour
{
    [SerializeField] private GameObject translation;
    public void SetTranslationState()
    {
        translation.SetActive(!translation.activeSelf);
    }
    public void SetTranslationState(bool state)
    {
        translation.SetActive(state);
    }
}