using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCube : MonoBehaviour
{

    public static SpawnCube Instance { get; private set; }

    public new GameObject gameObject;
    private GameObject cube;

    public float spawnInterval;

    public InputField spawnIntervalInput;
    public InputField distanceInput;
    public InputField speedInput;

    public int dictanceX = 10;
    public int speed = 10;

    Vector3 SpawnPosition;

    private void Start()
    {
        InvokeRepeating("SpawnCubes", 0, spawnInterval);

        PlayerPrefs.SetInt("dictanceX", dictanceX);
        PlayerPrefs.SetInt("speed", speed);
    }

    void SpawnCubes()
    {
        SpawnPosition = new Vector3(-50f, 0.5f, 0f);

        cube = Instantiate(gameObject, SpawnPosition, Quaternion.identity);
    }

    public void ChangeIntervalDecrease()
    {
        CancelInvoke("SpawnCubes");

        int integerValue;
        integerValue = int.Parse(spawnIntervalInput.text);
        spawnInterval = integerValue;

        InvokeRepeating("SpawnCubes", 0, spawnInterval);
    }

    public void ChangeDistance()
    {
        int integerValue;
        integerValue = int.Parse(distanceInput.text);
        dictanceX = integerValue;

        PlayerPrefs.SetInt("dictanceX", dictanceX);
    }

    public void ChangeSpeed()
    {
        int integerValue;
        integerValue = int.Parse(speedInput.text);
        speed = integerValue;

        PlayerPrefs.SetInt("speed", speed);
    }
}
