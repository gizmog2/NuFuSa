using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorHelper : MonoBehaviour
{

    public GameObject[] CarParts;
    public GameObject[] CarSpoils;

    CarModel _carModel = new CarModel();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadCar(CarModel model)
    {
        ChangeColor(model.Color);
        ChangeSpoils(model.Spoil);
    }

    public void SaveCar() 
    { 
        SettingClass.PlayerCar = _carModel;
    }

    public void ChangeSpoils(int id)
    {
        foreach (var item in CarSpoils)
        {
            item.SetActive(false);
        }

        CarSpoils[id].SetActive(true);

        _carModel.Spoil = id;

        SaveCar();
    }

    public void ChangeColor(int color)
    {
        Color newColor = Color.red;

        if (color == 0)
        {
            newColor = Color.blue;
        }
        else if (color == 1)
        {
            newColor = Color.green;
        }
        else if (color == 2)
        {
            newColor = Color.magenta;
        }

        foreach (var item in CarParts)
        {
            item.GetComponent<MeshRenderer>().material.color = newColor;
        }

        _carModel.Color = color;

        SaveCar();
    }
}
