using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHelper : MonoBehaviour
{
    public Transform StartPosition;
    public GameObject RacePregab;

    GameObject _playerCar;

    // Start is called before the first frame update
    void Start()
    {
        _playerCar = Instantiate(RacePregab/*, StartPosition.transform.position, StartPosition.transform.rotation*/) as GameObject;

        _playerCar.transform.position = new Vector3(0, 0, 0);
        _playerCar.transform.rotation = Quaternion.identity;
        _playerCar.transform.SetParent(StartPosition, false);

        _playerCar.GetComponent<ChangeColorHelper>().LoadCar(SettingClass.PlayerCar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
