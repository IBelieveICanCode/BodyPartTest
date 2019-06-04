using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] BodyParts = new GameObject[5];

    void OnEnable()
    {
        foreach (GameObject part in BodyParts)
        {
           ChooseParts(part);            
        }
    }

    void ChooseParts(GameObject part)
    {
        BodyParts bodyPart = part.GetComponent<BodyParts>();
        List<int> indexes = ConvertNumbers.ConvertedNumbers;
        switch (bodyPart.PartType)
        {
            case Parts.Head:
                bodyPart.PartVariant[indexes[0] - 1].SetActive(true);
                break;
            case Parts.Arms:
                bodyPart.PartVariant[indexes[1] - 1].SetActive(true);
                break;
            case Parts.Legs:
                bodyPart.PartVariant[indexes[2] - 1].SetActive(true);
                break;
            case Parts.Body:
                bodyPart.PartVariant[indexes[3] - 1].SetActive(true);
                break;
            case Parts.Hair:
                bodyPart.PartVariant[indexes[4] - 1].SetActive(true);
                break;
        }
    }
}
