using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolManager : MonoBehaviour
{
    [SerializeField] private Transform container;

    private List<Symbol> symbolBase = new();

    private void Start()
    {
        foreach (Transform child in container)
        {
            symbolBase.Add(child.GetComponent<Symbol>());
        }
    }
    public void ShowAll()
    {
        for (int i = 0; i < symbolBase.Count; i++)
        {
            symbolBase[i].SetTranslationState(true);
        }
    }
    public void HideAll()
    {
        for (int i = 0; i < symbolBase.Count; i++)
        {
            symbolBase[i].SetTranslationState(false);
        }
    }
}
