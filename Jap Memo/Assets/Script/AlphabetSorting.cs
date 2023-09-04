using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetSorting : MonoBehaviour
{
    [SerializeField] private Transform container;
    private List<Transform> transforms = new();
    private List<Transform> transformBase = new();

    private void Start()
    {
        foreach (Transform child in container)
        {
            transforms.Add(child);
            transformBase.Add(child);
        }
    }

    public void Shuffle()
    {
        for (int i = 0; i < transforms.Count; i++)
        {
            int rdmId = Random.Range(i, transforms.Count);
            (transforms[rdmId], transforms[i]) = (transforms[i], transforms[rdmId]);
        }
        for (int i = 0; i < transforms.Count; i++)
        {
            transforms[i].SetSiblingIndex(i);
        }
    }
    public void Order()
    {
        for (int i = 0; i < transformBase.Count; i++)
        {
            transformBase[i].SetSiblingIndex(i);
        }
    }
}