using UnityEngine;
using UnityEngine.UI;  
using TMPro;

public class FizzBuzz : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    public Image panelImage;
    public AudioSource richtig;
    public AudioSource falsch;
    private int randomNumber;
   

    private void Start()
    {
        GenerateRandomNumber();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CheckFizzBuzz("Fizz");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CheckFizzBuzz("Buzz");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CheckFizzBuzz("FizzBuzz");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CheckFizzBuzz("Kein FizzBuzz");
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateRandomNumber();
            panelImage.color = Color.magenta;
        }

    }

    public void CheckFizzBuzz(string choice)
    {
        string fizzBuzz = GetFizzBuzz(randomNumber);

        if (choice == fizzBuzz)
        {
            Debug.Log("Richtig!");
            richtig.Play();
            panelImage.color = Color.green;
        }
        else
        {
            Debug.Log("Falsch!");
            falsch.Play();
            panelImage.color = Color.red;
        }
    }

    public void GenerateRandomNumber()
    {
        randomNumber = Random.Range(0, 1001);
        numberText.text = randomNumber.ToString();
    }

    private string GetFizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (number % 3 == 0)
        {
            return "Fizz";
        }
        else if (number % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return "Kein FizzBuzz";
        }
    }
}
