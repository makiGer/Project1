using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class respawnScript : MonoBehaviour
{
    
    [SerializeField] InputField inputField;

    [SerializeField] InputField inputTopField;
    [SerializeField] InputField inputBottomField;


    public GameObject start;
    public GameObject end;
    public GameObject ball;
    public GameObject star;
    
    public GameObject zero;


    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject P5;
    
    public GameObject YP1;
    public GameObject YP2;
    public GameObject YP3;
    public GameObject YP4;
    public GameObject YP5;

    public GameObject N1;
    public GameObject N2;
    public GameObject N3;
    public GameObject N4;
    public GameObject N5;

    public GameObject YN1;
    public GameObject YN2;
    public GameObject YN3;
    public GameObject YN4;
    public GameObject YN5;

    //for positive and positive
    public GameObject OneOne;
    public GameObject OneTwo;
    public GameObject OneThree;
    public GameObject OneFour;
    public GameObject OneFive;
    public GameObject TwoOne;
    public GameObject TwoTwo;
    public GameObject TwoThree;
    public GameObject TwoFour;
    public GameObject TwoFive;
    public GameObject ThreeOne;
    public GameObject ThreeTwo;
    public GameObject ThreeThree;
    public GameObject ThreeFour;
    public GameObject ThreeFive;
    public GameObject FourOne;
    public GameObject FourTwo;
    public GameObject FourThree;
    public GameObject FourFour;
    public GameObject FourFive;
    public GameObject FiveOne;
    public GameObject FiveTwo;
    public GameObject FiveThree;
    public GameObject FiveFour;
    public GameObject FiveFive;

    //for negative and negative
    public GameObject NOneNOne;
    public GameObject NOneNTwo;
    public GameObject NOneNThree;
    public GameObject NOneNFour;
    public GameObject NOneNFive;
    public GameObject NTwoNOne;
    public GameObject NTwoNTwo;
    public GameObject NTwoNThree;
    public GameObject NTwoNFour;
    public GameObject NTwoNFive;
    public GameObject NThreeNOne;
    public GameObject NThreeNTwo;
    public GameObject NThreeNThree;
    public GameObject NThreeNFour;
    public GameObject NThreeNFive;
    public GameObject NFourNOne;
    public GameObject NFourNTwo;
    public GameObject NFourNThree;
    public GameObject NFourNFour;
    public GameObject NFourNFive;
    public GameObject NFiveNOne;
    public GameObject NFiveNTwo;
    public GameObject NFiveNThree;
    public GameObject NFiveNFour;
    public GameObject NFiveNFive;

    //for negative and positive;
    public GameObject NOneOne;
    public GameObject NOneTwo;
    public GameObject NOneThree;
    public GameObject NOneFour;
    public GameObject NOneFive;
    public GameObject NTwoOne;
    public GameObject NTwoTwo;
    public GameObject NTwoThree;
    public GameObject NTwoFour;
    public GameObject NTwoFive;
    public GameObject NThreeOne;
    public GameObject NThreeTwo;
    public GameObject NThreeThree;
    public GameObject NThreeFour;
    public GameObject NThreeFive;
    public GameObject NFourOne;
    public GameObject NFourTwo;
    public GameObject NFourThree;
    public GameObject NFourFour;
    public GameObject NFourFive;
    public GameObject NFiveOne;
    public GameObject NFiveTwo;
    public GameObject NFiveThree;
    public GameObject NFiveFour;
    public GameObject NFiveFive;

    //positive and negative
    public GameObject OneNOne;
    public GameObject OnenTwo;
    public GameObject OneNThree;
    public GameObject OneNFour;
    public GameObject OneNFive;
    public GameObject TwoNOne;
    public GameObject TwoNTwo;
    public GameObject TwoNThree;
    public GameObject TwoNFour;
    public GameObject TwoNFive;
    public GameObject ThreeNOne;
    public GameObject ThreeNTwo;
    public GameObject ThreeNThree;
    public GameObject ThreeNFour;
    public GameObject ThreeNFive;
    public GameObject FourNOne;
    public GameObject FourNTwo;
    public GameObject FourNThree;
    public GameObject FourNFour;
    public GameObject FourNFive;
    public GameObject FiveNOne;
    public GameObject FiveNTwo;
    public GameObject FiveNThree;
    public GameObject FiveNFour;
    public GameObject FiveNFive;

    public int RadNum;
    void Start()
    {
        RadNum = Random.Range(1, 10);

        ball.transform.position = FourOne.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        int input = int.Parse(inputField.text);
        int top = int.Parse(inputTopField.text);
        int bottom = int.Parse(inputBottomField.text);
        int y;
        

        if (RadNum == 1)
        {
            star.transform.position = OneTwo.transform.position;
        }
        else if (RadNum == 2)
        {
            star.transform.position = TwoTwo.transform.position;
        }
        else if (RadNum == 3)
        {
            star.transform.position = TwoThree.transform.position;
        }
        else if (RadNum == 4)
        {
            star.transform.position = TwoFour.transform.position;
        }
        else if (RadNum == 5)
        {
            star.transform.position = TwoNFour.transform.position;
        }
        else if (RadNum == 6)
        {
            star.transform.position = OnenTwo.transform.position;
        }
        else if (RadNum == 7)
        {
            star.transform.position = OneNThree.transform.position;
        }
        else if (RadNum == 8)
        {
            star.transform.position = OneNFour.transform.position;
        }
        else if (RadNum == 9)
        {
            star.transform.position = OneNFive.transform.position;
        }
        else if (RadNum == 10)
        {
            star.transform.position = P3.transform.position;
        }


        if (input == 1)
        {
            start.transform.position = YP1.transform.position;
            y = 1;
        }
        else if (input == 2)
        {
            start.transform.position = YP2.transform.position;
            y = 2;
        }
        else if (input == 3)
        {
            start.transform.position = YP3.transform.position;
            y = 3;
        }
        else if(input == 4)
        {
            start.transform.position = YP4.transform.position;
            y = 4;
        }
        else if(input == 5)
        {
            start.transform.position = YP5.transform.position;
            y = 5;
        }
        else if(input == -1)
        {
            start.transform.position = YN1.transform.position;
            y = -1;
        }
        else if (input == -2)
        {
            start.transform.position = YN2.transform.position;
            y = -2;
        }
        else if (input == -3)
        {
            start.transform.position = YN3.transform.position;
            y = -3;
        }
        else if(input == -4)
        {
            start.transform.position = YN4.transform.position;
            y = -4;
        }
        else if(input == -5)
        {
            start.transform.position = YN5.transform.position;
            y = -5;
        }
        else if(input == 0)
        {
            start.transform.position = zero.transform.position;
            y = 0;
        }
        else
        {
            start.transform.position = zero.transform.position;
            y = 0;
        }

        //1 and 1
        if (y == -5 && top == 6 && bottom == 1)
        {
            end.transform.position = OneOne.transform.position;
        }
        else if (y == -4 && top == 5 && bottom == 1)
        {
            end.transform.position = OneOne.transform.position;
        }
        else if (y == -3 && top == 4 && bottom == 1)
        {
            end.transform.position = OneOne.transform.position;
        }
        else if (y == -2 && top == 3 && bottom == 1)
        {
            end.transform.position = OneOne.transform.position;
        }
        else if (y == -1 && top == 2 && bottom == 1)
        {
            end.transform.position = OneOne.transform.position;
        }
        else if (y == 0 && top == 1 && bottom == 1)
        {
            end.transform.position = OneOne.transform.position;
        }
        else if (y == 1 && top == 0 && bottom == 1)
        {
            end.transform.position = OneOne.transform.position;
        }
        else if (y == 2 && top == -1 && bottom == 1)
        {
            end.transform.position = OneOne.transform.position;
        }
        else if (y == 3 && top == -2 && bottom == 1)
        {
            end.transform.position = OneOne.transform.position;
        }
        else if (y == 4 && top == -3 && bottom == 1)
        {
            end.transform.position = OneOne.transform.position;
        }
        else if (y == 5 && top == -4 && bottom == 1)
        {
            end.transform.position = OneOne.transform.position;
        }

        //1 and 2
        if (y == -5 && top == 6 && bottom == 2)
        {
            end.transform.position = OneTwo.transform.position;
        }
        else if (y == -4 && top == 5 && bottom == 2)
        {
            end.transform.position = OneTwo.transform.position;
        }
        else if (y == -3 && top == 4 && bottom == 2)
        {
            end.transform.position = OneTwo.transform.position;
        }
        else if (y == -2 && top == 3 && bottom == 2)
        {
            end.transform.position = OneTwo.transform.position;
        }
        else if (y == -1 && top == 2 && bottom == 2)
        {
            end.transform.position = OneTwo.transform.position;
        }
        else if (y == 0 && top == 1 && bottom == 2)
        {
            end.transform.position = OneTwo.transform.position;
        }
        else if (y == 1 && top == 0 && bottom == 2)
        {
            end.transform.position = OneTwo.transform.position;
        }
        else if (y == 2 && top == -1 && bottom == 2)
        {
            end.transform.position = OneTwo.transform.position;
        }
        else if (y == 3 && top == -2 && bottom == 2)
        {
            end.transform.position = OneTwo.transform.position;
        }
        else if (y == 4 && top == -3 && bottom == 2)
        {
            end.transform.position = OneTwo.transform.position;
        }
        else if (y == 5 && top == -4 && bottom == 2)
        {
            end.transform.position = OneTwo.transform.position;
        }

        //1 and 3
        if (y == -5 && top == 6 && bottom == 3)
        {
            end.transform.position = OneThree.transform.position;
        }
        else if (y == -4 && top == 5 && bottom == 3)
        {
            end.transform.position = OneThree.transform.position;
        }
        else if (y == -3 && top == 4 && bottom == 3)
        {
            end.transform.position = OneThree.transform.position;
        }
        else if (y == -2 && top == 3 && bottom == 3)
        {
            end.transform.position = OneThree.transform.position;
        }
        else if (y == -1 && top == 2 && bottom == 3)
        {
            end.transform.position = OneThree.transform.position;
        }
        else if (y == 0 && top == 1 && bottom == 3)
        {
            end.transform.position = OneThree.transform.position;
        }
        else if (y == 1 && top == 0 && bottom == 3)
        {
            end.transform.position = OneThree.transform.position;
        }
        else if (y == 2 && top == -1 && bottom == 3)
        {
            end.transform.position = OneThree.transform.position;
        }
        else if (y == 3 && top == -2 && bottom == 3)
        {
            end.transform.position = OneThree.transform.position;
        }
        else if (y == 4 && top == -3 && bottom == 3)
        {
            end.transform.position = OneThree.transform.position;
        }
        else if (y == 5 && top == -4 && bottom == 3)
        {
            end.transform.position = OneThree.transform.position;
        }

        //1 and 4
        if (y == -5 && top == 6 && bottom == 4)
        {
            end.transform.position = OneFour.transform.position;
        }
        else if (y == -4 && top == 5 && bottom == 4)
        {
            end.transform.position = OneFour.transform.position;
        }
        else if (y == -3 && top == 4 && bottom == 4)
        {
            end.transform.position = OneFour.transform.position;
        }
        else if (y == -2 && top == 3 && bottom == 4)
        {
            end.transform.position = OneFour.transform.position;
        }
        else if (y == -1 && top == 2 && bottom == 4)
        {
            end.transform.position = OneFour.transform.position;
        }
        else if (y == 0 && top == 1 && bottom == 4)
        {
            end.transform.position = OneFour.transform.position;
        }
        else if (y == 1 && top == 0 && bottom == 4)
        {
            end.transform.position = OneFour.transform.position;
        }
        else if (y == 2 && top == -1 && bottom == 4)
        {
            end.transform.position = OneFour.transform.position;
        }
        else if (y == 3 && top == -2 && bottom == 4)
        {
            end.transform.position = OneFour.transform.position;
        }
        else if (y == 4 && top == -3 && bottom == 4)
        {
            end.transform.position = OneFour.transform.position;
        }
        else if (y == 5 && top == -4 && bottom == 4)
        {
            end.transform.position = OneFour.transform.position;
        }

        //1 and 5
        if (y == -5 && top == 6 && bottom == 5)
        {
            end.transform.position = OneFive.transform.position;
        }
        else if (y == -4 && top == 5 && bottom == 5)
        {
            end.transform.position = OneFive.transform.position;
        }
        else if (y == -3 && top == 4 && bottom == 5)
        {
            end.transform.position = OneFive.transform.position;
        }
        else if (y == -2 && top == 3 && bottom == 5)
        {
            end.transform.position = OneFive.transform.position;
        }
        else if (y == -1 && top == 2 && bottom == 5)
        {
            end.transform.position = OneFive.transform.position;
        }
        else if (y == 0 && top == 1 && bottom == 5)
        {
            end.transform.position = OneFive.transform.position;
        }
        else if (y == 1 && top == 0 && bottom == 5)
        {
            end.transform.position = OneFive.transform.position;
        }
        else if (y == 2 && top == -1 && bottom == 5)
        {
            end.transform.position = OneFive.transform.position;
        }
        else if (y == 3 && top == -2 && bottom == 5)
        {
            end.transform.position = OneFive.transform.position;
        }
        else if (y == 4 && top == -3 && bottom == 5)
        {
            end.transform.position = OneFive.transform.position;
        }
        else if (y == 5 && top == -4 && bottom == 5)
        {
            end.transform.position = OneFive.transform.position;
        }

        //2 and 1
        if (y == -5 && top == 7 && bottom == 1)
        {
            end.transform.position = TwoOne.transform.position;
        }
        else if (y == -4 && top == 6 && bottom == 1)
        {
            end.transform.position = TwoOne.transform.position;
        }
        else if (y == -3 && top == 5 && bottom == 1)
        {
            end.transform.position = TwoOne.transform.position;
        }
        else if (y == -2 && top == 4 && bottom == 1)
        {
            end.transform.position = TwoOne.transform.position;
        }
        else if (y == -1 && top == 3 && bottom == 1)
        {
            end.transform.position = TwoOne.transform.position;
        }
        else if (y == 0 && top == 2 && bottom == 1)
        {
            end.transform.position = TwoOne.transform.position;
        }
        else if (y == 1 && top == 1 && bottom == 1)
        {
            end.transform.position = TwoOne.transform.position;
        }
        else if (y == 2 && top == 0 && bottom == 1)
        {
            end.transform.position = TwoOne.transform.position;
        }
        else if (y == 3 && top == -1 && bottom == 1)
        {
            end.transform.position = TwoOne.transform.position;
        }
        else if (y == 4 && top == -2 && bottom == 1)
        {
            end.transform.position = TwoOne.transform.position;
        }
        else if (y == 5 && top == -3 && bottom == 1)
        {
            end.transform.position = TwoOne.transform.position;
        }

        //2 and 2
        if (y == -5 && top == 7 && bottom == 2)
        {
            end.transform.position = TwoTwo.transform.position;
        }
        else if (y == -4 && top == 6 && bottom == 2)
        {
            end.transform.position = TwoTwo.transform.position;
        }
        else if (y == -3 && top == 5 && bottom == 2)
        {
            end.transform.position = TwoTwo.transform.position;
        }
        else if (y == -2 && top == 4 && bottom == 2)
        {
            end.transform.position = TwoTwo.transform.position;
        }
        else if (y == -1 && top == 3 && bottom == 2)
        {
            end.transform.position = TwoTwo.transform.position;
        }
        else if (y == 0 && top == 2 && bottom == 2)
        {
            end.transform.position = TwoTwo.transform.position;
        }
        else if (y == 1 && top == 1 && bottom == 2)
        {
            end.transform.position = TwoTwo.transform.position;
        }
        else if (y == 2 && top == 0 && bottom == 2)
        {
            end.transform.position = TwoTwo.transform.position;
        }
        else if (y == 3 && top == -1 && bottom == 2)
        {
            end.transform.position = TwoTwo.transform.position;
        }
        else if (y == 4 && top == -2 && bottom == 2)
        {
            end.transform.position = TwoTwo.transform.position;
        }
        else if (y == 5 && top == -3 && bottom == 2)
        {
            end.transform.position = TwoTwo.transform.position;
        }

        //2 and 3
        if (y == -5 && top == 7 && bottom == 3)
        {
            end.transform.position = TwoThree.transform.position;
        }
        else if (y == -4 && top == 6 && bottom == 3)
        {
            end.transform.position = TwoThree.transform.position;
        }
        else if (y == -3 && top == 5 && bottom == 3)
        {
            end.transform.position = TwoThree.transform.position;
        }
        else if (y == -2 && top == 4 && bottom == 3)
        {
            end.transform.position = TwoThree.transform.position;
        }
        else if (y == -1 && top == 3 && bottom == 3)
        {
            end.transform.position = TwoThree.transform.position;
        }
        else if (y == 0 && top == 2 && bottom == 3)
        {
            end.transform.position = TwoThree.transform.position;
        }
        else if (y == 1 && top == 1 && bottom == 3)
        {
            end.transform.position = TwoThree.transform.position;
        }
        else if (y == 2 && top == 0 && bottom == 3)
        {
            end.transform.position = TwoThree.transform.position;
        }
        else if (y == 3 && top == -1 && bottom == 3)
        {
            end.transform.position = TwoThree.transform.position;
        }
        else if (y == 4 && top == -2 && bottom == 3)
        {
            end.transform.position = TwoThree.transform.position;
        }
        else if (y == 5 && top == -3 && bottom == 3)
        {
            end.transform.position = TwoThree.transform.position;
        }



        //2 and 4
        if (y == -5 && top == 7 && bottom == 4)
        {
            end.transform.position = TwoFour.transform.position;
        }
        else if (y == -4 && top == 6 && bottom == 4)
        {
            end.transform.position = TwoFour.transform.position;
        }
        else if (y == -3 && top == 5 && bottom == 4)
        {
            end.transform.position = TwoFour.transform.position;
        }
        else if (y == -2 && top == 4 && bottom == 4)
        {
            end.transform.position = TwoFour.transform.position;
        }
        else if (y == -1 && top == 3 && bottom == 4)
        {
            end.transform.position = TwoFour.transform.position;
        }
        else if (y == 0 && top == 2 && bottom == 4)
        {
            end.transform.position = TwoFour.transform.position;
        }
        else if (y == 1 && top == 1 && bottom == 4)
        {
            end.transform.position = TwoFour.transform.position;
        }
            else if (y == 2 && top == 0 && bottom == 4)
        {
            end.transform.position = TwoFour.transform.position;
        }
        else if (y == 3 && top == -1 && bottom == 4)
        {
            end.transform.position = TwoFour.transform.position;
        }
        else if (y == 4 && top == -2 && bottom == 4)
        {
            end.transform.position = TwoFour.transform.position;
        }
        else if (y == 5 && top == -3 && bottom == 4)
        {
            end.transform.position = TwoFour.transform.position;
        }



        //2 and 5
        if (y == -5 && top == 7 && bottom == 5)
        {
            end.transform.position = TwoFive.transform.position;
        }
        else if (y == -4 && top == 6 && bottom == 5)
        {
            end.transform.position = TwoFive.transform.position;
        }
        else if (y == -3 && top == 5 && bottom == 5)
        {
            end.transform.position = TwoFive.transform.position;
        }
        else if (y == -2 && top == 4 && bottom == 5)
        {
            end.transform.position = TwoFive.transform.position;
        }
        else if (y == -1 && top == 3 && bottom == 5)
        {
            end.transform.position = TwoFive.transform.position;
        }
        else if (y == 0 && top == 2 && bottom == 5)
        {
            end.transform.position = TwoFive.transform.position;
        }
        else if (y == 1 && top == 1 && bottom == 5)
        {
            end.transform.position = TwoFive.transform.position;
        }
        else if (y == 2 && top == 0 && bottom == 5)
        {
            end.transform.position = TwoFive.transform.position;
        }
        else if (y == 3 && top == -1 && bottom == 5)
        {
            end.transform.position = TwoFive.transform.position;
        }
        else if (y == 4 && top == -2 && bottom == 5)
        {
            end.transform.position = TwoFive.transform.position;
        }
        else if (y == 5 && top == -3 && bottom == 5)
        {
            end.transform.position = TwoFive.transform.position;
        }


        //3 and 1
        if (y == -5 && top == 8 && bottom == 1)
        {
            end.transform.position = ThreeOne.transform.position;
        }
        else if (y == -4 && top == 7 && bottom == 1)
        {
            end.transform.position = ThreeOne.transform.position;
        }
        else if (y == -3 && top == 6 && bottom == 1)
        {
            end.transform.position = ThreeOne.transform.position;
        }
        else if (y == -2 && top == 5 && bottom == 1)
        {
            end.transform.position = ThreeOne.transform.position;
        }
        else if (y == -1 && top == 4 && bottom == 1)
        {
            end.transform.position = ThreeOne.transform.position;
        }
        else if (y == 0 && top == 3 && bottom == 1)
        {
            end.transform.position = ThreeOne.transform.position;
        }
        else if (y == 1 && top == 2 && bottom == 1)
        {
            end.transform.position = ThreeOne.transform.position;
        }
        else if (y == 2 && top == 1 && bottom == 1)
        {
            end.transform.position = ThreeOne.transform.position;
        }
        else if (y == 3 && top == 0 && bottom == 1)
        {
            end.transform.position = ThreeOne.transform.position;
        }
        else if (y == 4 && top == -1 && bottom == 1)
        {
            end.transform.position = ThreeOne.transform.position;
        }
        else if (y == 5 && top == -2 && bottom == 1)
        {
            end.transform.position = ThreeOne.transform.position;
        }

        //3 and 2
        if (y == -5 && top == 8 && bottom == 2)
        {
            end.transform.position = ThreeTwo.transform.position;
        }
        else if (y == -4 && top == 7 && bottom == 2)
        {
            end.transform.position = ThreeTwo.transform.position;
        }
        else if (y == -3 && top == 6 && bottom == 2)
        {
            end.transform.position = ThreeTwo.transform.position;
        }
        else if (y == -2 && top == 5 && bottom == 2)
        {
            end.transform.position = ThreeTwo.transform.position;
        }
        else if (y == -1 && top == 4 && bottom == 2)
        {
            end.transform.position = ThreeTwo.transform.position;
        }
        else if (y == 0 && top == 3 && bottom == 2)
        {
            end.transform.position = ThreeTwo.transform.position;
        }
        else if (y == 1 && top == 2 && bottom == 2)
        {
            end.transform.position = ThreeTwo.transform.position;
        }
        else if (y == 2 && top == 1 && bottom == 2)
        {
            end.transform.position = ThreeTwo.transform.position;
        }
        else if (y == 3 && top == 0 && bottom == 2)
        {
            end.transform.position = ThreeTwo.transform.position;
        }
        else if (y == 4 && top == -1 && bottom == 2)
        {
            end.transform.position = ThreeTwo.transform.position;
        }
        else if (y == 5 && top == -2 && bottom == 2)
        {
            end.transform.position = ThreeTwo.transform.position;
        }




        //3 and 3
        if (y == -5 && top == 8 && bottom == 3)
        {
            end.transform.position = ThreeThree.transform.position;
        }
        else if (y == -4 && top == 7 && bottom == 3)
        {
            end.transform.position = ThreeThree.transform.position;
        }
        else if (y == -3 && top == 6 && bottom == 3)
        {
            end.transform.position = ThreeThree.transform.position;
        }
        else if (y == -2 && top == 5 && bottom == 3)
        {
            end.transform.position = ThreeThree.transform.position;
        }
        else if (y == -1 && top == 4 && bottom == 3)
        {
            end.transform.position = ThreeThree.transform.position;
        }
        else if (y == 0 && top == 3 && bottom == 3)
        {
            end.transform.position = ThreeThree.transform.position;
        }
        else if (y == 1 && top == 2 && bottom == 3)
        {
            end.transform.position = ThreeThree.transform.position;
        }
        else if (y == 2 && top == 1 && bottom == 3)
        {
            end.transform.position = ThreeThree.transform.position;
        }
        else if (y == 3 && top == 0 && bottom == 3)
        {
            end.transform.position = ThreeThree.transform.position;
        }
        else if (y == 4 && top == -1 && bottom == 3)
        {
            end.transform.position = ThreeThree.transform.position;
        }
        else if (y == 5 && top == -2 && bottom == 3)
        {
            end.transform.position = ThreeThree.transform.position;
        }



        //3 and 4
        if (y == -5 && top == 8 && bottom == 4)
        {
            end.transform.position = ThreeFour.transform.position;
        }
        else if (y == -4 && top == 7 && bottom == 4)
        {
            end.transform.position = ThreeFour.transform.position;
        }
        else if (y == -3 && top == 6 && bottom == 4)
        {
            end.transform.position = ThreeFour.transform.position;
        }
        else if (y == -2 && top == 5 && bottom == 4)
        {
            end.transform.position = ThreeFour.transform.position;
        }
        else if (y == -1 && top == 4 && bottom == 4)
        {
            end.transform.position = ThreeFour.transform.position;
        }
        else if (y == 0 && top == 3 && bottom == 4)
        {
            end.transform.position = ThreeFour.transform.position;
        }
        else if (y == 1 && top == 2 && bottom == 4)
        {
            end.transform.position = ThreeFour.transform.position;
        }
        else if (y == 2 && top == 1 && bottom == 4)
        {
            end.transform.position = ThreeFour.transform.position;
        }
        else if (y == 3 && top == 0 && bottom == 4)
        {
            end.transform.position = ThreeFour.transform.position;
        }
        else if (y == 4 && top == -1 && bottom == 4)
        {
            end.transform.position = ThreeFour.transform.position;
        }
        else if (y == 5 && top == -2 && bottom == 4)
        {
            end.transform.position = ThreeFour.transform.position;
        }




        //3 and 5
        if (y == -5 && top == 8 && bottom == 5)
        {
            end.transform.position = ThreeFive.transform.position;
        }
        else if (y == -4 && top == 7 && bottom == 5)
        {
            end.transform.position = ThreeFive.transform.position;
        }
        else if (y == -3 && top == 6 && bottom == 5)
        {
            end.transform.position = ThreeFive.transform.position;
        }
        else if (y == -2 && top == 5 && bottom == 5)
        {
            end.transform.position = ThreeFive.transform.position;
        }
        else if (y == -1 && top == 4 && bottom == 5)
        {
            end.transform.position = ThreeFive.transform.position;
        }
        else if (y == 0 && top == 3 && bottom == 5)
        {
            end.transform.position = ThreeFive.transform.position;
        }
        else if (y == 1 && top == 2 && bottom == 5)
        {
            end.transform.position = ThreeFive.transform.position;
        }
        else if (y == 2 && top == 1 && bottom == 5)
        {
            end.transform.position = ThreeFive.transform.position;
        }
        else if (y == 3 && top == 0 && bottom == 5)
        {
            end.transform.position = ThreeFive.transform.position;
        }
        else if (y == 4 && top == -1 && bottom == 5)
        {
            end.transform.position = ThreeFive.transform.position;
        }
        else if (y == 5 && top == -2 && bottom == 5)
        {
            end.transform.position = ThreeFive.transform.position;
        }




        //4 and 1
        if (y == -5 && top == 9 && bottom == 1)
        {
            end.transform.position = FourOne.transform.position;
        }
        else if (y == -4 && top == 8 && bottom == 1)
        {
            end.transform.position = FourOne.transform.position;
        }
        else if (y == -3 && top == 7 && bottom == 1)
        {
            end.transform.position = FourOne.transform.position;
        }
        else if (y == -2 && top == 6 && bottom == 1)
        {
            end.transform.position = FourOne.transform.position;
        }
        else if (y == -1 && top == 5 && bottom == 1)
        {
            end.transform.position = FourOne.transform.position;
        }
        else if (y == 0 && top == 4 && bottom == 1)
        {
            end.transform.position = FourOne.transform.position;
        }
        else if (y == 1 && top == 3 && bottom == 1)
        {
            end.transform.position = FourOne.transform.position;
        }
        else if (y == 2 && top == 2 && bottom == 1)
        {
            end.transform.position = FourOne.transform.position;
        }
        else if (y == 3 && top == 1 && bottom == 1)
        {
            end.transform.position = FourOne.transform.position;
        }
        else if (y == 4 && top == 0 && bottom == 1)
        {
            end.transform.position = FourOne.transform.position;
        }
        else if (y == 5 && top == -1 && bottom == 1)
        {
            end.transform.position = FourOne.transform.position;
        }





        //4 and 2
        if (y == -5 && top == 9 && bottom == 2)
        {
            end.transform.position = FourTwo.transform.position;
        }
        else if (y == -4 && top == 8 && bottom == 2)
        {
            end.transform.position = FourTwo.transform.position;
        }
        else if (y == -3 && top == 7 && bottom == 2)
        {
            end.transform.position = FourTwo.transform.position;
        }
        else if (y == -2 && top == 6 && bottom == 2)
        {
            end.transform.position = FourTwo.transform.position;
        }
        else if (y == -1 && top == 5 && bottom == 2)
        {
            end.transform.position = FourTwo.transform.position;
        }
        else if (y == 0 && top == 4 && bottom == 2)
        {
            end.transform.position = FourTwo.transform.position;
        }
        else if (y == 1 && top == 3 && bottom == 2)
        {
            end.transform.position = FourTwo.transform.position;
        }
        else if (y == 2 && top == 2 && bottom == 2)
        {
            end.transform.position = FourTwo.transform.position;
        }
        else if (y == 3 && top == 1 && bottom == 2)
        {
            end.transform.position = FourTwo.transform.position;
        }
        else if (y == 4 && top == 0 && bottom == 2)
        {
            end.transform.position = FourTwo.transform.position;
        }
        else if (y == 5 && top == -1 && bottom == 2)
        {
            end.transform.position = FourTwo.transform.position;
        }





        //4 and 3
        if (y == -5 && top == 9 && bottom == 3)
        {
            end.transform.position = FourThree.transform.position;
        }
        else if (y == -4 && top == 8 && bottom == 3)
        {
            end.transform.position = FourThree.transform.position;
        }
        else if (y == -3 && top == 7 && bottom == 3)
        {
            end.transform.position = FourThree.transform.position;
        }
        else if (y == -2 && top == 6 && bottom == 3)
        {
            end.transform.position = FourThree.transform.position;
        }
        else if (y == -1 && top == 5 && bottom == 3)
        {
            end.transform.position = FourThree.transform.position;
        }
        else if (y == 0 && top == 4 && bottom == 3)
        {
            end.transform.position = FourThree.transform.position;
        }
        else if (y == 1 && top == 3 && bottom == 3)
        {
            end.transform.position = FourThree.transform.position;
        }
        else if (y == 2 && top == 2 && bottom == 3)
        {
            end.transform.position = FourThree.transform.position;
        }
        else if (y == 3 && top == 1 && bottom == 3)
        {
            end.transform.position = FourThree.transform.position;
        }
        else if (y == 4 && top == 0 && bottom == 3)
        {
            end.transform.position = FourThree.transform.position;
        }
        else if (y == 5 && top == -1 && bottom == 3)
        {
            end.transform.position = FourThree.transform.position;
        }





        //4 and 4
        if (y == -5 && top == 9 && bottom == 4)
        {
            end.transform.position = FourFour.transform.position;
        }
        else if (y == -4 && top == 8 && bottom == 4)
        {
            end.transform.position = FourFour.transform.position;
        }
        else if (y == -3 && top == 7 && bottom == 4)
        {
            end.transform.position = FourFour.transform.position;
        }
        else if (y == -2 && top == 6 && bottom == 4)
        {
            end.transform.position = FourFour.transform.position;
        }
        else if (y == -1 && top == 5 && bottom == 4)
        {
            end.transform.position = FourFour.transform.position;
        }
        else if (y == 0 && top == 4 && bottom == 4)
        {
            end.transform.position = FourFour.transform.position;
        }
        else if (y == 1 && top == 3 && bottom == 4)
        {
            end.transform.position = FourFour.transform.position;
        }
        else if (y == 2 && top == 2 && bottom == 4)
        {
            end.transform.position = FourFour.transform.position;
        }
        else if (y == 3 && top == 1 && bottom == 4)
        {
            end.transform.position = FourFour.transform.position;
        }
        else if (y == 4 && top == 0 && bottom == 4)
        {
            end.transform.position = FourFour.transform.position;
        }
        else if (y == 5 && top == -1 && bottom == 4)
        {
            end.transform.position = FourFour.transform.position;
        }





        //4 and 5
        if (y == -5 && top == 9 && bottom == 5)
        {
            end.transform.position = FourFive.transform.position;
        }
        else if (y == -4 && top == 8 && bottom == 5)
        {
            end.transform.position = FourFive.transform.position;
        }
        else if (y == -3 && top == 7 && bottom == 5)
        {
            end.transform.position = FourFive.transform.position;
        }
        else if (y == -2 && top == 6 && bottom == 5)
        {
            end.transform.position = FourFive.transform.position;
        }
        else if (y == -1 && top == 5 && bottom == 5)
        {
            end.transform.position = FourFive.transform.position;
        }
        else if (y == 0 && top == 4 && bottom == 5)
        {
            end.transform.position = FourFive.transform.position;
        }
        else if (y == 1 && top == 3 && bottom == 5)
        {
            end.transform.position = FourFive.transform.position;
        }
        else if (y == 2 && top == 2 && bottom == 5)
        {
            end.transform.position = FourFive.transform.position;
        }
        else if (y == 3 && top == 1 && bottom == 5)
        {
            end.transform.position = FourFive.transform.position;
        }
        else if (y == 4 && top == 0 && bottom == 5)
        {
            end.transform.position = FourFive.transform.position;
        }
        else if (y == 5 && top == -1 && bottom == 5)
        {
            end.transform.position = FourFive.transform.position;
        }





        //5 and 1
        if (y == -5 && top == 10 && bottom == 1)
        {
            end.transform.position = FiveOne.transform.position;
        }
        else if (y == -4 && top == 9 && bottom == 1)
        {
            end.transform.position = FiveOne.transform.position;
        }
        else if (y == -3 && top == 8 && bottom == 1)
        {
            end.transform.position = FiveOne.transform.position;
        }
        else if (y == -2 && top == 7 && bottom == 1)
        {
            end.transform.position = FiveOne.transform.position;
        }
        else if (y == -1 && top == 6 && bottom == 1)
        {
            end.transform.position = FiveOne.transform.position;
        }
        else if (y == 0 && top == 5 && bottom == 1)
        {
            end.transform.position = FiveOne.transform.position;
        }
        else if (y == 1 && top == 4 && bottom == 1)
        {
            end.transform.position = FiveOne.transform.position;
        }
        else if (y == 2 && top == 3 && bottom == 1)
        {
            end.transform.position = FiveOne.transform.position;
        }
        else if (y == 3 && top == 2 && bottom == 1)
        {
            end.transform.position = FiveOne.transform.position;
        }
        else if (y == 4 && top == 1 && bottom == 1)
        {
            end.transform.position = FiveOne.transform.position;
        }
        else if (y == 5 && top == 0 && bottom == 1)
        {
            end.transform.position = FiveOne.transform.position;
        }





        //5 and 2
        if (y == -5 && top == 10 && bottom == 2)
        {
            end.transform.position = FiveTwo.transform.position;
        }
        else if (y == -4 && top == 9 && bottom == 2)
        {
            end.transform.position = FiveTwo.transform.position;
        }
        else if (y == -3 && top == 8 && bottom == 2)
        {
            end.transform.position = FiveTwo.transform.position;
        }
        else if (y == -2 && top == 7 && bottom == 2)
        {
            end.transform.position = FiveTwo.transform.position;
        }
        else if (y == -1 && top == 6 && bottom == 2)
        {
            end.transform.position = FiveTwo.transform.position;
        }
        else if (y == 0 && top == 5 && bottom == 2)
        {
            end.transform.position = FiveTwo.transform.position;
        }
        else if (y == 1 && top == 4 && bottom == 2)
        {
            end.transform.position = FiveTwo.transform.position;
        }
        else if (y == 2 && top == 3 && bottom == 2)
        {
            end.transform.position = FiveTwo.transform.position;
        }
        else if (y == 3 && top == 2 && bottom == 2)
        {
            end.transform.position = FiveTwo.transform.position;
        }
        else if (y == 4 && top == 1 && bottom == 2)
        {
            end.transform.position = FiveTwo.transform.position;
        }
        else if (y == 5 && top == 0 && bottom == 2)
        {
            end.transform.position = FiveTwo.transform.position;
        }





        //5 and 3
        if (y == -5 && top == 10 && bottom == 3)
        {
            end.transform.position = FiveThree.transform.position;
        }
        else if (y == -4 && top == 9 && bottom == 3)
        {
            end.transform.position = FiveThree.transform.position;
        }
        else if (y == -3 && top == 8 && bottom == 3)
        {
            end.transform.position = FiveThree.transform.position;
        }
        else if (y == -2 && top == 7 && bottom == 3)
        {
            end.transform.position = FiveThree.transform.position;
        }
        else if (y == -1 && top == 6 && bottom == 3)
        {
            end.transform.position = FiveThree.transform.position;
        }
        else if (y == 0 && top == 5 && bottom == 3)
        {
            end.transform.position = FiveThree.transform.position;
        }
        else if (y == 1 && top == 4 && bottom == 3)
        {
            end.transform.position = FiveThree.transform.position;
        }
        else if (y == 2 && top == 3 && bottom == 3)
        {
            end.transform.position = FiveThree.transform.position;
        }
        else if (y == 3 && top == 2 && bottom == 3)
        {
            end.transform.position = FiveThree.transform.position;
        }
        else if (y == 4 && top == 1 && bottom == 3)
        {
            end.transform.position = FiveThree.transform.position;
        }
        else if (y == 5 && top == 0 && bottom == 3)
        {
            end.transform.position = FiveThree.transform.position;
        }





        //5 and 4
        if (y == -5 && top == 10 && bottom == 4)
        {
            end.transform.position = FiveFour.transform.position;
        }
        else if (y == -4 && top == 9 && bottom == 4)
        {
            end.transform.position = FiveFour.transform.position;
        }
        else if (y == -3 && top == 8 && bottom == 4)
        {
            end.transform.position = FiveFour.transform.position;
        }
        else if (y == -2 && top == 7 && bottom == 4)
        {
            end.transform.position = FiveFour.transform.position;
        }
        else if (y == -1 && top == 6 && bottom == 4)
        {
            end.transform.position = FiveFour.transform.position;
        }
        else if (y == 0 && top == 5 && bottom == 4)
        {
            end.transform.position = FiveFour.transform.position;
        }
        else if (y == 1 && top == 4 && bottom == 4)
        {
            end.transform.position = FiveFour.transform.position;
        }
        else if (y == 2 && top == 3 && bottom == 4)
        {
            end.transform.position = FiveFour.transform.position;
        }
        else if (y == 3 && top == 2 && bottom == 4)
        {
            end.transform.position = FiveFour.transform.position;
        }
        else if (y == 4 && top == 1 && bottom == 4)
        {
            end.transform.position = FiveFour.transform.position;
        }
        else if (y == 5 && top == 0 && bottom == 4)
        {
            end.transform.position = FiveFour.transform.position;
        }





        //5 and 5
        if (y == -5 && top == 10 && bottom == 5)
        {
            end.transform.position = FiveFive.transform.position;
        }
        else if (y == -4 && top == 9 && bottom == 5)
        {
            end.transform.position = FiveFive.transform.position;
        }
        else if (y == -3 && top == 8 && bottom == 5)
        {
            end.transform.position = FiveFive.transform.position;
        }
        else if (y == -2 && top == 7 && bottom == 5)
        {
            end.transform.position = FiveFive.transform.position;
        }
        else if (y == -1 && top == 6 && bottom == 5)
        {
            end.transform.position = FiveFive.transform.position;
        }
        else if (y == 0 && top == 5 && bottom == 5)
        {
            end.transform.position = FiveFive.transform.position;
        }
        else if (y == 1 && top == 4 && bottom == 5)
        {
            end.transform.position = FiveFive.transform.position;
        }
        else if (y == 2 && top == 3 && bottom == 5)
        {
            end.transform.position = FiveFive.transform.position;
        }
        else if (y == 3 && top == 2 && bottom == 5)
        {
            end.transform.position = FiveFive.transform.position;
        }
        else if (y == 4 && top == 1 && bottom == 5)
        {
            end.transform.position = FiveFive.transform.position;
        }
        else if (y == 5 && top == 0 && bottom == 5)
        {
            end.transform.position = FiveFive.transform.position;
        }

        //-1 and -1
        if (y == -5 && top == 4 && bottom == -1 )
        {
            end.transform.position = NOneNOne.transform.position;
        }
        else if (y == -4 && top == 3 && bottom == -1)
        {
            end.transform.position = NOneNOne.transform.position;
        }
        else if (y == -3 && top == 2 && bottom == -1)
        {
            end.transform.position = NOneNOne.transform.position;
        }
        else if (y == -2 && top == 1 && bottom == -1)
        {
            end.transform.position = NOneNOne.transform.position;
        }
        else if (y == -1 && top == 0 && bottom == -1)
        {
            end.transform.position = NOneNOne.transform.position;
        }
        else if (y == 0 && top == -1 && bottom == -1)
        {
            end.transform.position = NOneNOne.transform.position;
        }
        else if (y == 1 && top == -2 && bottom == -1)
        {
            end.transform.position = NOneNOne.transform.position;
        }
        else if (y == 2 && top == -3 && bottom == -1)
        {
            end.transform.position = NOneNOne.transform.position;
        }
        else if (y == 3 && top == -4 && bottom == -1)
        {
            end.transform.position = NOneNOne.transform.position;
        }
        else if (y == 4 && top == -5 && bottom == -1)
        {
            end.transform.position = NOneNOne.transform.position;
        }
        else if (y == 5 && top == -6 && bottom == -1)
        {
            end.transform.position = NOneNOne.transform.position;
        }

        //-1 and -2
        if (y == -5 && top == 4 && bottom == -2)
        {
            end.transform.position = NOneNTwo.transform.position;
        }
        else if (y == -4 && top == 3 && bottom == -2)
        {
            end.transform.position = NOneNTwo.transform.position;
        }
        else if (y == -3 && top == 2 && bottom == -2)
        {
            end.transform.position = NOneNTwo.transform.position;
        }
        else if (y == -2 && top == 1 && bottom == -2)
        {
            end.transform.position = NOneNTwo.transform.position;
        }
        else if (y == -1 && top == 0 && bottom == -2)
        {
            end.transform.position = NOneNTwo.transform.position;
        }
        else if (y == 0 && top == -1 && bottom == -2)
        {
            end.transform.position = NOneNTwo.transform.position;
        }
        else if (y == 1 && top == -2 && bottom == -2)
        {
            end.transform.position = NOneNTwo.transform.position;
        }
        else if (y == 2 && top == -3 && bottom == -2)
        {
            end.transform.position = NOneNTwo.transform.position;
        }
        else if (y == 3 && top == -4 && bottom == -2)
        {
            end.transform.position = NOneNTwo.transform.position;
        }
        else if (y == 4 && top == -5 && bottom == -2)
        {
            end.transform.position = NOneNTwo.transform.position;
        }
        else if (y == 5 && top == -6 && bottom == -2)
        {
            end.transform.position = NOneNTwo.transform.position;
        }

        //-1 and -3
        if (y == -5 && top == 4 && bottom == -3)
        {
            end.transform.position = NOneNThree.transform.position;
        }
        else if (y == -4 && top == 3 && bottom == -3)
        {
            end.transform.position = NOneNThree.transform.position;
        }
        else if (y == -3 && top == 2 && bottom == -3)
        {
            end.transform.position = NOneNThree.transform.position;
        }
        else if (y == -2 && top == 1 && bottom == -3)
        {
            end.transform.position = NOneNThree.transform.position;
        }
        else if (y == -1 && top == 0 && bottom == -3)
        {
            end.transform.position = NOneNThree.transform.position;
        }
        else if (y == 0 && top == -1 && bottom == -3)
        {
            end.transform.position = NOneNThree.transform.position;
        }
        else if (y == 1 && top == -2 && bottom == -3)
        {
            end.transform.position = NOneNThree.transform.position;
        }
        else if (y == 2 && top == -3 && bottom == -3)
        {
            end.transform.position = NOneNThree.transform.position;
        }
        else if (y == 3 && top == -4 && bottom == -3)
        {
            end.transform.position = NOneNThree.transform.position;
        }
        else if (y == 4 && top == -5 && bottom == -3)
        {
            end.transform.position = NOneNThree.transform.position;
        }
        else if (y == 5 && top == -6 && bottom == -3)
        {
            end.transform.position = NOneNThree.transform.position;
        }

        //-1 and -4
        if (y == -5 && top == 4 && bottom == -4)
        {
            end.transform.position = NOneNFour.transform.position;
        }
        else if (y == -4 && top == 3 && bottom == -4)
        {
            end.transform.position = NOneNFour.transform.position;
        }
        else if (y == -3 && top == 2 && bottom == -4)
        {
            end.transform.position = NOneNFour.transform.position;
        }
        else if (y == -2 && top == 1 && bottom == -4)
        {
            end.transform.position = NOneNFour.transform.position;
        }
        else if (y == -1 && top == 0 && bottom == -4)
        {
            end.transform.position = NOneNFour.transform.position;
        }
        else if (y == 0 && top == -1 && bottom == -4)
        {
            end.transform.position = NOneNFour.transform.position;
        }
        else if (y == 1 && top == -2 && bottom == -4)
        {
            end.transform.position = NOneNFour.transform.position;
        }
        else if (y == 2 && top == -3 && bottom == -4)
        {
            end.transform.position = NOneNFour.transform.position;
        }
        else if (y == 3 && top == -4 && bottom == -4)
        {
            end.transform.position = NOneNFour.transform.position;
        }
        else if (y == 4 && top == -5 && bottom == -4)
        {
            end.transform.position = NOneNFour.transform.position;
        }
        else if (y == 5 && top == -6 && bottom == -4)
        {
            end.transform.position = NOneNFour.transform.position;
        }

        //-1 and -5
        if (y == -5 && top == 4 && bottom == -5)
        {
            end.transform.position = NOneNFive.transform.position;
        }
        else if (y == -4 && top == 3 && bottom == -5)
        {
            end.transform.position = NOneNFive.transform.position;
        }
        else if (y == -3 && top == 2 && bottom == -5)
        {
            end.transform.position = NOneNFive.transform.position;
        }
        else if (y == -2 && top == 1 && bottom == -5)
        {
            end.transform.position = NOneNFive.transform.position;
        }
        else if (y == -1 && top == 0 && bottom == -5)
        {
            end.transform.position = NOneNFive.transform.position;
        }
        else if (y == 0 && top == -1 && bottom == -5)
        {
            end.transform.position = NOneNFive.transform.position;
        }
        else if (y == 1 && top == -2 && bottom == -5)
        {
            end.transform.position = NOneNFive.transform.position;
        }
        else if (y == 2 && top == -3 && bottom == -5)
        {
            end.transform.position = NOneNFive.transform.position;
        }
        else if (y == 3 && top == -4 && bottom == -5)
        {
            end.transform.position = NOneNFive.transform.position;
        }
        else if (y == 4 && top == -5 && bottom == -5)
        {
            end.transform.position = NOneNFive.transform.position;
        }
        else if (y == 5 && top == -6 && bottom == -5)
        {
            end.transform.position = NOneNFive.transform.position;
        }

        //-2 and -1
        if (y == -5 && top == 3 && bottom == -1)
        {
            end.transform.position = NTwoNOne.transform.position;
        }
        else if (y == -4 && top == 2 && bottom == -1)
        {
            end.transform.position = NTwoNOne.transform.position;
        }
        else if (y == -3 && top == 1 && bottom == -1)
        {
            end.transform.position = NTwoNOne.transform.position;
        }
        else if (y == -2 && top == 0 && bottom == -1)
        {
            end.transform.position = NTwoNOne.transform.position;
        }
        else if (y == -1 && top == -1 && bottom == -1)
        {
            end.transform.position = NTwoNOne.transform.position;
        }
        else if (y == 0 && top == -2 && bottom == -1)
        {
            end.transform.position = NTwoNOne.transform.position;
        }
        else if (y == 1 && top == -3 && bottom == -1)
        {
            end.transform.position = NTwoNOne.transform.position;
        }
        else if (y == 2 && top == -4 && bottom == -1)
        {
            end.transform.position = NTwoNOne.transform.position;
        }
        else if (y == 3 && top == -5 && bottom == -1)
        {
            end.transform.position = NTwoNOne.transform.position;
        }
        else if (y == 4 && top == -6 && bottom == -1)
        {
            end.transform.position = NTwoNOne.transform.position;
        }
        else if (y == 5 && top == -7 && bottom == -1)
        {
            end.transform.position = NTwoNOne.transform.position;
        }

        //-2 and -2
        if (y == -5 && top == 3 && bottom == -2)
        {
            end.transform.position = NTwoNTwo.transform.position;
        }
        else if (y == -4 && top == 2 && bottom == -2)
        {
            end.transform.position = NTwoNTwo.transform.position;
        }
        else if (y == -3 && top == 1 && bottom == -2)
        {
            end.transform.position = NTwoNTwo.transform.position;
        }
        else if (y == -2 && top == 0 && bottom == -2)
        {
            end.transform.position = NTwoNTwo.transform.position;
        }
        else if (y == -1 && top == -1 && bottom == -2)
        {
            end.transform.position = NTwoNTwo.transform.position;
        }
        else if (y == 0 && top == -2 && bottom == -2)
        {
            end.transform.position = NTwoNTwo.transform.position;
        }
        else if (y == 1 && top == -3 && bottom == -2)
        {
            end.transform.position = NTwoNTwo.transform.position;
        }
        else if (y == 2 && top == -4 && bottom == -2)
        {
            end.transform.position = NTwoNTwo.transform.position;
        }
        else if (y == 3 && top == -5 && bottom == -2)
        {
            end.transform.position = NTwoNTwo.transform.position;
        }
        else if (y == 4 && top == -6 && bottom == -2)
        {
            end.transform.position = NTwoNTwo.transform.position;
        }
        else if (y == 5 && top == -7 && bottom == -2)
        {
            end.transform.position = NTwoNTwo.transform.position;
        }


        //-2 and -3
        if (y == -5 && top == 3 && bottom == -3)
        {
            end.transform.position = NTwoNThree.transform.position;
        }
        else if (y == -4 && top == 2 && bottom == -3)
        {
            end.transform.position = NTwoNThree.transform.position;
        }
        else if (y == -3 && top == 1 && bottom == -3)
        {
            end.transform.position = NTwoNThree.transform.position;
        }
        else if (y == -2 && top == 0 && bottom == -3)
        {
            end.transform.position = NTwoNThree.transform.position;
        }
        else if (y == -1 && top == -1 && bottom == -3)
        {
            end.transform.position = NTwoNThree.transform.position;
        }
        else if (y == 0 && top == -2 && bottom == -3)
        {
            end.transform.position = NTwoNThree.transform.position;
        }
        else if (y == 1 && top == -3 && bottom == -3)
        {
            end.transform.position = NTwoNThree.transform.position;
        }
        else if (y == 2 && top == -4 && bottom == -3)
        {
            end.transform.position = NTwoNThree.transform.position;
        }
        else if (y == 3 && top == -5 && bottom == -3)
        {
            end.transform.position = NTwoNThree.transform.position;
        }
        else if (y == 4 && top == -6 && bottom == -3)
        {
            end.transform.position = NTwoNThree.transform.position;
        }
        else if (y == 5 && top == -7 && bottom == -3)
        {
            end.transform.position = NTwoNThree.transform.position;
        }


        //-2 and -4
        if (y == -5 && top == 3 && bottom == -4)
        {
            end.transform.position = NTwoNFour.transform.position;
        }
        else if (y == -4 && top == 2 && bottom == -4)
        {
            end.transform.position = NTwoNFour.transform.position;
        }
        else if (y == -3 && top == 1 && bottom == -4)
        {
            end.transform.position = NTwoNFour.transform.position;
        }
        else if (y == -2 && top == 0 && bottom == -4)
        {
            end.transform.position = NTwoNFour.transform.position;
        }
        else if (y == -1 && top == -1 && bottom == -4)
        {
            end.transform.position = NTwoNFour.transform.position;
        }
        else if (y == 0 && top == -2 && bottom == -4)
        {
            end.transform.position = NTwoNFour.transform.position;
        }
        else if (y == 1 && top == -3 && bottom == -4)
        {
            end.transform.position = NTwoNFour.transform.position;
        }
        else if (y == 2 && top == -4 && bottom == -4)
        {
            end.transform.position = NTwoNFour.transform.position;
        }
        else if (y == 3 && top == -5 && bottom == -4)
        {
            end.transform.position = NTwoNFour.transform.position;
        }
        else if (y == 4 && top == -6 && bottom == -4)
        {
            end.transform.position = NTwoNFour.transform.position;
        }
        else if (y == 5 && top == -7 && bottom == -4)
        {
            end.transform.position = NTwoNFour.transform.position;
        }


        //-2 and -5
        if (y == -5 && top == 3 && bottom == -5)
        {
            end.transform.position = NTwoNFive.transform.position;
        }
        else if (y == -4 && top == 2 && bottom == -5)
        {
            end.transform.position = NTwoNFive.transform.position;
        }
        else if (y == -3 && top == 1 && bottom == -5)
        {
            end.transform.position = NTwoNFive.transform.position;
        }
        else if (y == -2 && top == 0 && bottom == -5)
        {
            end.transform.position = NTwoNFive.transform.position;
        }
        else if (y == -1 && top == -1 && bottom == -5)
        {
            end.transform.position = NTwoNFive.transform.position;
        }
        else if (y == 0 && top == -2 && bottom == -5)
        {
            end.transform.position = NTwoNFive.transform.position;
        }
        else if (y == 1 && top == -3 && bottom == -5)
        {
            end.transform.position = NTwoNFive.transform.position;
        }
        else if (y == 2 && top == -4 && bottom == -5)
        {
            end.transform.position = NTwoNFive.transform.position;
        }
        else if (y == 3 && top == -5 && bottom == -5)
        {
            end.transform.position = NTwoNFive.transform.position;
        }
        else if (y == 4 && top == -6 && bottom == -5)
        {
            end.transform.position = NTwoNFive.transform.position;
        }
        else if (y == 5 && top == -7 && bottom == -5)
        {
            end.transform.position = NTwoNFive.transform.position;
        }


        //-3 and -1
        if (y == -5 && top == 2 && bottom == -1)
        {
            end.transform.position = NThreeNOne.transform.position;
        }
        else if (y == -4 && top == 1 && bottom == -1)
        {
            end.transform.position = NThreeNOne.transform.position;
        }
        else if (y == -3 && top == 0 && bottom == -1)
        {
            end.transform.position = NThreeNOne.transform.position;
        }
        else if (y == -2 && top == -1 && bottom == -1)
        {
            end.transform.position = NThreeNOne.transform.position;
        }
        else if (y == -1 && top == -2 && bottom == -1)
        {
            end.transform.position = NThreeNOne.transform.position;
        }
        else if (y == 0 && top == -3 && bottom == -1)
        {
            end.transform.position = NThreeNOne.transform.position;
        }
        else if (y == 1 && top == -4 && bottom == -1)
        {
            end.transform.position = NThreeNOne.transform.position;
        }
        else if (y == 2 && top == -5 && bottom == -1)
        {
            end.transform.position = NThreeNOne.transform.position;
        }
        else if (y == 3 && top == -6 && bottom == -1)
        {
            end.transform.position = NThreeNOne.transform.position;
        }
        else if (y == 4 && top == -7 && bottom == -1)
        {
            end.transform.position = NThreeNOne.transform.position;
        }
        else if (y == 5 && top == -8 && bottom == -1)
        {
            end.transform.position = NThreeNOne.transform.position;
        }


        //-3 and -2
        if (y == -5 && top == 2 && bottom == -2)
        {
            end.transform.position = NThreeNTwo.transform.position;
        }
        else if (y == -4 && top == 1 && bottom == -2)
        {
            end.transform.position = NThreeNTwo.transform.position;
        }
        else if (y == -3 && top == 0 && bottom == -2)
        {
            end.transform.position = NThreeNTwo.transform.position;
        }
        else if (y == -2 && top == -1 && bottom == -2)
        {
            end.transform.position = NThreeNTwo.transform.position;
        }
        else if (y == -1 && top == -2 && bottom == -2)
        {
            end.transform.position = NThreeNTwo.transform.position;
        }
        else if (y == 0 && top == -3 && bottom == -2)
        {
            end.transform.position = NThreeNTwo.transform.position;
        }
        else if (y == 1 && top == -4 && bottom == -2)
        {
            end.transform.position = NThreeNTwo.transform.position;
        }
        else if (y == 2 && top == -5 && bottom == -2)
        {
            end.transform.position = NThreeNTwo.transform.position;
        }
        else if (y == 3 && top == -6 && bottom == -2)
        {
            end.transform.position = NThreeNTwo.transform.position;
        }
        else if (y == 4 && top == -7 && bottom == -2)
        {
            end.transform.position = NThreeNTwo.transform.position;
        }
        else if (y == 5 && top == -8 && bottom == -2)
        {
            end.transform.position = NThreeNTwo.transform.position;
        }


        //-3 and -3
        if (y == -5 && top == 2 && bottom == -3)
        {
            end.transform.position = NThreeNThree.transform.position;
        }
        else if (y == -4 && top == 1 && bottom == -3)
        {
            end.transform.position = NThreeNThree.transform.position;
        }
        else if (y == -3 && top == 0 && bottom == -3)
        {
            end.transform.position = NThreeNThree.transform.position;
        }
        else if (y == -2 && top == -1 && bottom == -3)
        {
            end.transform.position = NThreeNThree.transform.position;
        }
        else if (y == -1 && top == -2 && bottom == -3)
        {
            end.transform.position = NThreeNThree.transform.position;
        }
        else if (y == 0 && top == -3 && bottom == -3)
        {
            end.transform.position = NThreeNThree.transform.position;
        }
        else if (y == 1 && top == -4 && bottom == -3)
        {
            end.transform.position = NThreeNThree.transform.position;
        }
        else if (y == 2 && top == -5 && bottom == -3)
        {
            end.transform.position = NThreeNThree.transform.position;
        }
        else if (y == 3 && top == -6 && bottom == -3)
        {
            end.transform.position = NThreeNThree.transform.position;
        }
        else if (y == 4 && top == -7 && bottom == -3)
        {
            end.transform.position = NThreeNThree.transform.position;
        }
        else if (y == 5 && top == -8 && bottom == -3)
        {
            end.transform.position = NThreeNThree.transform.position;
        }


        //-3 and -4
        if (y == -5 && top == 2 && bottom == -4)
        {
            end.transform.position = NThreeNFour.transform.position;
        }
        else if (y == -4 && top == 1 && bottom == -4)
        {
            end.transform.position = NThreeNFour.transform.position;
        }
        else if (y == -3 && top == 0 && bottom == -4)
        {
            end.transform.position = NThreeNFour.transform.position;
        }
        else if (y == -2 && top == -1 && bottom == -4)
        {
            end.transform.position = NThreeNFour.transform.position;
        }
        else if (y == -1 && top == -2 && bottom == -4)
        {
            end.transform.position = NThreeNFour.transform.position;
        }
        else if (y == 0 && top == -3 && bottom == -4)
        {
            end.transform.position = NThreeNFour.transform.position;
        }
        else if (y == 1 && top == -4 && bottom == -4)
        {
            end.transform.position = NThreeNFour.transform.position;
        }
        else if (y == 2 && top == -5 && bottom == -4)
        {
            end.transform.position = NThreeNFour.transform.position;
        }
        else if (y == 3 && top == -6 && bottom == -4)
        {
            end.transform.position = NThreeNFour.transform.position;
        }
        else if (y == 4 && top == -7 && bottom == -4)
        {
            end.transform.position = NThreeNFour.transform.position;
        }
        else if (y == 5 && top == -8 && bottom == -4)
        {
            end.transform.position = NThreeNFour.transform.position;
        }


        //-3 and -5
        if (y == -5 && top == 2 && bottom == -5)
        {
            end.transform.position = NThreeNFive.transform.position;
        }
        else if (y == -4 && top == 1 && bottom == -5)
        {
            end.transform.position = NThreeNFive.transform.position;
        }
        else if (y == -3 && top == 0 && bottom == -5)
        {
            end.transform.position = NThreeNFive.transform.position;
        }
        else if (y == -2 && top == -1 && bottom == -5)
        {
            end.transform.position = NThreeNFive.transform.position;
        }
        else if (y == -1 && top == -2 && bottom == -5)
        {
            end.transform.position = NThreeNFive.transform.position;
        }
        else if (y == 0 && top == -3 && bottom == -5)
        {
            end.transform.position = NThreeNFive.transform.position;
        }
        else if (y == 1 && top == -4 && bottom == -5)
        {
            end.transform.position = NThreeNFive.transform.position;
        }
        else if (y == 2 && top == -5 && bottom == -5)
        {
            end.transform.position = NThreeNFive.transform.position;
        }
        else if (y == 3 && top == -6 && bottom == -5)
        {
            end.transform.position = NThreeNFive.transform.position;
        }
        else if (y == 4 && top == -7 && bottom == -5)
        {
            end.transform.position = NThreeNFive.transform.position;
        }
        else if (y == 5 && top == -8 && bottom == -5)
        {
            end.transform.position = NThreeNFive.transform.position;
        }


        //-4 and -1
        if (y == -5 && top == 1 && bottom == -1)
        {
            end.transform.position = NFourNOne.transform.position;
        }
        else if (y == -4 && top == 0 && bottom == -1)
        {
            end.transform.position = NFourNOne.transform.position;
        }
        else if (y == -3 && top == -1 && bottom == -1)
        {
            end.transform.position = NFourNOne.transform.position;
        }
        else if (y == -2 && top == -2 && bottom == -1)
        {
            end.transform.position = NFourNOne.transform.position;
        }
        else if (y == -1 && top == -3 && bottom == -1)
        {
            end.transform.position = NFourNOne.transform.position;
        }
        else if (y == 0 && top == -4 && bottom == -1)
        {
            end.transform.position = NFourNOne.transform.position;
        }
        else if (y == 1 && top == -5 && bottom == -1)
        {
            end.transform.position = NFourNOne.transform.position;
        }
        else if (y == 2 && top == -6 && bottom == -1)
        {
            end.transform.position = NFourNOne.transform.position;
        }
        else if (y == 3 && top == -7 && bottom == -1)
        {
            end.transform.position = NFourNOne.transform.position;
        }
        else if (y == 4 && top == -8 && bottom == -1)
        {
            end.transform.position = NFourNOne.transform.position;
        }
        else if (y == 5 && top == -9 && bottom == -1)
        {
            end.transform.position = NFourNOne.transform.position;
        }


        //-4 and -2
        if (y == -5 && top == 1 && bottom == -2)
        {
            end.transform.position = NFourNTwo.transform.position;
        }
        else if (y == -4 && top == 0 && bottom == -2)
        {
            end.transform.position = NFourNTwo.transform.position;
        }
        else if (y == -3 && top == -1 && bottom == -2)
        {
            end.transform.position = NFourNTwo.transform.position;
        }
        else if (y == -2 && top == -2 && bottom == -2)
        {
            end.transform.position = NFourNTwo.transform.position;
        }
        else if (y == -1 && top == -3 && bottom == -2)
        {
            end.transform.position = NFourNTwo.transform.position;
        }
        else if (y == 0 && top == -4 && bottom == -2)
        {
            end.transform.position = NFourNTwo.transform.position;
        }
        else if (y == 1 && top == -5 && bottom == -2)
        {
            end.transform.position = NFourNTwo.transform.position;
        }
        else if (y == 2 && top == -6 && bottom == -2)
        {
            end.transform.position = NFourNTwo.transform.position;
        }
        else if (y == 3 && top == -7 && bottom == -2)
        {
            end.transform.position = NFourNTwo.transform.position;
        }
        else if (y == 4 && top == -8 && bottom == -2)
        {
            end.transform.position = NFourNTwo.transform.position;
        }
        else if (y == 5 && top == -9 && bottom == -2)
        {
            end.transform.position = NFourNTwo.transform.position;
        }


        //-4 and -3
        if (y == -5 && top == 1 && bottom == -3)
        {
            end.transform.position = NFourNThree.transform.position;
        }
        else if (y == -4 && top == 0 && bottom == -3)
        {
            end.transform.position = NFourNThree.transform.position;
        }
        else if (y == -3 && top == -1 && bottom == -3)
        {
            end.transform.position = NFourNThree.transform.position;
        }
        else if (y == -2 && top == -2 && bottom == -3)
        {
            end.transform.position = NFourNThree.transform.position;
        }
        else if (y == -1 && top == -3 && bottom == -3)
        {
            end.transform.position = NFourNThree.transform.position;
        }
        else if (y == 0 && top == -4 && bottom == -3)
        {
            end.transform.position = NFourNThree.transform.position;
        }
        else if (y == 1 && top == -5 && bottom == -3)
        {
            end.transform.position = NFourNThree.transform.position;
        }
        else if (y == 2 && top == -6 && bottom == -3)
        {
            end.transform.position = NFourNThree.transform.position;
        }
        else if (y == 3 && top == -7 && bottom == -3)
        {
            end.transform.position = NFourNThree.transform.position;
        }
        else if (y == 4 && top == -8 && bottom == -3)
        {
            end.transform.position = NFourNThree.transform.position;
        }
        else if (y == 5 && top == -9 && bottom == -3)
        {
            end.transform.position = NFourNThree.transform.position;
        }


        //-4 and -4
        if (y == -5 && top == 1 && bottom == -4)
        {
            end.transform.position = NFourNFour.transform.position;
        }
        else if (y == -4 && top == 0 && bottom == -4)
        {
            end.transform.position = NFourNFour.transform.position;
        }
        else if (y == -3 && top == -1 && bottom == -4)
        {
            end.transform.position = NFourNFour.transform.position;
        }
        else if (y == -2 && top == -2 && bottom == -4)
        {
            end.transform.position = NFourNFour.transform.position;
        }
        else if (y == -1 && top == -3 && bottom == -4)
        {
            end.transform.position = NFourNFour.transform.position;
        }
        else if (y == 0 && top == -4 && bottom == -4)
        {
            end.transform.position = NFourNFour.transform.position;
        }
        else if (y == 1 && top == -5 && bottom == -4)
        {
            end.transform.position = NFourNFour.transform.position;
        }
        else if (y == 2 && top == -6 && bottom == -4)
        {
            end.transform.position = NFourNFour.transform.position;
        }
        else if (y == 3 && top == -7 && bottom == -4)
        {
            end.transform.position = NFourNFour.transform.position;
        }
        else if (y == 4 && top == -8 && bottom == -4)
        {
            end.transform.position = NFourNFour.transform.position;
        }
        else if (y == 5 && top == -9 && bottom == -4)
        {
            end.transform.position = NFourNFour.transform.position;
        }


        //-4 and -5
        if (y == -5 && top == 1 && bottom == -5)
        {
            end.transform.position = NFourNFive.transform.position;
        }
        else if (y == -4 && top == 0 && bottom == -5)
        {
            end.transform.position = NFourNFive.transform.position;
        }
        else if (y == -3 && top == -1 && bottom == -5)
        {
            end.transform.position = NFourNFive.transform.position;
        }
        else if (y == -2 && top == -2 && bottom == -5)
        {
            end.transform.position = NFourNFive.transform.position;
        }
        else if (y == -1 && top == -3 && bottom == -5)
        {
            end.transform.position = NFourNFive.transform.position;
        }
        else if (y == 0 && top == -4 && bottom == -5)
        {
            end.transform.position = NFourNFive.transform.position;
        }
        else if (y == 1 && top == -5 && bottom == -5)
        {
            end.transform.position = NFourNFive.transform.position;
        }
        else if (y == 2 && top == -6 && bottom == -5)
        {
            end.transform.position = NFourNFive.transform.position;
        }
        else if (y == 3 && top == -7 && bottom == -5)
        {
            end.transform.position = NFourNFive.transform.position;
        }
        else if (y == 4 && top == -8 && bottom == -5)
        {
            end.transform.position = NFourNFive.transform.position;
        }
        else if (y == 5 && top == -9 && bottom == -5)
        {
            end.transform.position = NFourNFive.transform.position;
        }


        //-5 and -1
        if (y == -5 && top == 0 && bottom == -1)
        {
            end.transform.position = NFiveNOne.transform.position;
        }
        else if (y == -4 && top == -1 && bottom == -1)
        {
            end.transform.position = NFiveNOne.transform.position;
        }
        else if (y == -3 && top == -2 && bottom == -1)
        {
            end.transform.position = NFiveNOne.transform.position;
        }
        else if (y == -2 && top == -3 && bottom == -1)
        {
            end.transform.position = NFiveNOne.transform.position;
        }
        else if (y == -1 && top == -4 && bottom == -1)
        {
            end.transform.position = NFiveNOne.transform.position;
        }
        else if (y == 0 && top == -5 && bottom == -1)
        {
            end.transform.position = NFiveNOne.transform.position;
        }
        else if (y == 1 && top == -6 && bottom == -1)
        {
            end.transform.position = NFiveNOne.transform.position;
        }
        else if (y == 2 && top == -7 && bottom == -1)
        {
            end.transform.position = NFiveNOne.transform.position;
        }
        else if (y == 3 && top == -8 && bottom == -1)
        {
            end.transform.position = NFiveNOne.transform.position;
        }
        else if (y == 4 && top == -9 && bottom == -1)
        {
            end.transform.position = NFiveNOne.transform.position;
        }
        else if (y == 5 && top == -10 && bottom == -1)
        {
            end.transform.position = NFiveNOne.transform.position;
        }


        //-5 and -2
        if (y == -5 && top == 0 && bottom == -2)
        {
            end.transform.position = NFiveNTwo.transform.position;
        }
        else if (y == -4 && top == -1 && bottom == -2)
        {
            end.transform.position = NFiveNTwo.transform.position;
        }
        else if (y == -3 && top == -2 && bottom == -2)
        {
            end.transform.position = NFiveNTwo.transform.position;
        }
        else if (y == -2 && top == -3 && bottom == -2)
        {
            end.transform.position = NFiveNTwo.transform.position;
        }
        else if (y == -1 && top == -4 && bottom == -2)
        {
            end.transform.position = NFiveNTwo.transform.position;
        }
        else if (y == 0 && top == -5 && bottom == -2)
        {
            end.transform.position = NFiveNTwo.transform.position;
        }
        else if (y == 1 && top == -6 && bottom == -2)
        {
            end.transform.position = NFiveNTwo.transform.position;
        }
        else if (y == 2 && top == -7 && bottom == -2)
        {
            end.transform.position = NFiveNTwo.transform.position;
        }
        else if (y == 3 && top == -8 && bottom == -2)
        {
            end.transform.position = NFiveNTwo.transform.position;
        }
        else if (y == 4 && top == -9 && bottom == -2)
        {
            end.transform.position = NFiveNTwo.transform.position;
        }
        else if (y == 5 && top == -10 && bottom == -2)
        {
            end.transform.position = NFiveNTwo.transform.position;
        }


        //-5 and -3
        if (y == -5 && top == 0 && bottom == -3)
        {
            end.transform.position = NFiveNThree.transform.position;
        }
        else if (y == -4 && top == -1 && bottom == -3)
        {
            end.transform.position = NFiveNThree.transform.position;
        }
        else if (y == -3 && top == -2 && bottom == -3)
        {
            end.transform.position = NFiveNThree.transform.position;
        }
        else if (y == -2 && top == -3 && bottom == -3)
        {
            end.transform.position = NFiveNThree.transform.position;
        }
        else if (y == -1 && top == -4 && bottom == -3)
        {
            end.transform.position = NFiveNThree.transform.position;
        }
        else if (y == 0 && top == -5 && bottom == -3)
        {
            end.transform.position = NFiveNThree.transform.position;
        }
        else if (y == 1 && top == -6 && bottom == -3)
        {
            end.transform.position = NFiveNThree.transform.position;
        }
        else if (y == 2 && top == -7 && bottom == -3)
        {
            end.transform.position = NFiveNThree.transform.position;
        }
        else if (y == 3 && top == -8 && bottom == -3)
        {
            end.transform.position = NFiveNThree.transform.position;
        }
        else if (y == 4 && top == -9 && bottom == -3)
        {
            end.transform.position = NFiveNThree.transform.position;
        }
        else if (y == 5 && top == -10 && bottom == -3)
        {
            end.transform.position = NFiveNThree.transform.position;
        }


        //-5 and -4
        if (y == -5 && top == 0 && bottom == -4)
        {
            end.transform.position = NFiveNFour.transform.position;
        }
        else if (y == -4 && top == -1 && bottom == -4)
        {
            end.transform.position = NFiveNFour.transform.position;
        }
        else if (y == -3 && top == -2 && bottom == -4)
        {
            end.transform.position = NFiveNFour.transform.position;
        }
        else if (y == -2 && top == -3 && bottom == -4)
        {
            end.transform.position = NFiveNFour.transform.position;
        }
        else if (y == -1 && top == -4 && bottom == -4)
        {
            end.transform.position = NFiveNFour.transform.position;
        }
        else if (y == 0 && top == -5 && bottom == -4)
        {
            end.transform.position = NFiveNFour.transform.position;
        }
        else if (y == 1 && top == -6 && bottom == -4)
        {
            end.transform.position = NFiveNFour.transform.position;
        }
        else if (y == 2 && top == -7 && bottom == -4)
        {
            end.transform.position = NFiveNFour.transform.position;
        }
        else if (y == 3 && top == -8 && bottom == -4)
        {
            end.transform.position = NFiveNFour.transform.position;
        }
        else if (y == 4 && top == -9 && bottom == -4)
        {
            end.transform.position = NFiveNFour.transform.position;
        }
        else if (y == 5 && top == -10 && bottom == -4)
        {
            end.transform.position = NFiveNFour.transform.position;
        }


        //-5 and -5
        if (y == -5 && top == 0 && bottom == -5)
        {
            end.transform.position = NFiveNFive.transform.position;
        }
        else if (y == -4 && top == -1 && bottom == -5)
        {
            end.transform.position = NFiveNFive.transform.position;
        }
        else if (y == -3 && top == -2 && bottom == -5)
        {
            end.transform.position = NFiveNFive.transform.position;
        }
        else if (y == -2 && top == -3 && bottom == -5)
        {
            end.transform.position = NFiveNFive.transform.position;
        }
        else if (y == -1 && top == -4 && bottom == -5)
        {
            end.transform.position = NFiveNFive.transform.position;
        }
        else if (y == 0 && top == -5 && bottom == -5)
        {
            end.transform.position = NFiveNFive.transform.position;
        }
        else if (y == 1 && top == -6 && bottom == -5)
        {
            end.transform.position = NFiveNFive.transform.position;
        }
        else if (y == 2 && top == -7 && bottom == -5)
        {
            end.transform.position = NFiveNFive.transform.position;
        }
        else if (y == 3 && top == -8 && bottom == -5)
        {
            end.transform.position = NFiveNFive.transform.position;
        }
        else if (y == 4 && top == -9 && bottom == -5)
        {
            end.transform.position = NFiveNFive.transform.position;
        }
        else if (y == 5 && top == -10 && bottom == -5)
        {
            end.transform.position = NFiveNFive.transform.position;
        }

        //-1 and 1
        if (y == -5 && top == 6 && bottom == -1)
        {
            end.transform.position = NOneOne.transform.position;
        }
        else if (y == -4 && top == 5 && bottom == -1)
        {
            end.transform.position = NOneOne.transform.position;
        }
        else if (y == -3 && top == 4 && bottom == -1)
        {
            end.transform.position = NOneOne.transform.position;
        }
        else if (y == -2 && top == 3 && bottom == -1)
        {
            end.transform.position = NOneOne.transform.position;
        }
        else if (y == -1 && top == 2 && bottom == -1)
        {
            end.transform.position = NOneOne.transform.position;
        }
        else if (y == 0 && top == 1 && bottom == -1)
        {
            end.transform.position = NOneOne.transform.position;
        }
        else if (y == 1 && top == 0 && bottom == -1)
        {
            end.transform.position = NOneOne.transform.position;
        }
        else if (y == 2 && top == -1 && bottom == -1)
        {
            end.transform.position = NOneOne.transform.position;
        }
        else if (y == 3 && top == -2 && bottom == -1)
        {
            end.transform.position = NOneOne.transform.position;
        }
        else if (y == 4 && top == -3 && bottom == -1)
        {
            end.transform.position = NOneOne.transform.position;
        }
        else if (y == 5 && top == -4 && bottom == -1)
        {
            end.transform.position = NOneOne.transform.position;
        }

        //1 and 2
        if (y == -5 && top == 6 && bottom == -2)
        {
            end.transform.position = NOneTwo.transform.position;
        }
        else if (y == -4 && top == 5 && bottom == -2)
        {
            end.transform.position = NOneTwo.transform.position;
        }
        else if (y == -3 && top == 4 && bottom == -2)
        {
            end.transform.position = NOneTwo.transform.position;
        }
        else if (y == -2 && top == 3 && bottom == -2)
        {
            end.transform.position = NOneTwo.transform.position;
        }
        else if (y == -1 && top == 2 && bottom == -2)
        {
            end.transform.position = NOneTwo.transform.position;
        }
        else if (y == 0 && top == 1 && bottom == -2)
        {
            end.transform.position = NOneTwo.transform.position;
        }
        else if (y == 1 && top == 0 && bottom == -2)
        {
            end.transform.position = NOneTwo.transform.position;
        }
        else if (y == 2 && top == -1 && bottom == -2)
        {
            end.transform.position = NOneTwo.transform.position;
        }
        else if (y == 3 && top == -2 && bottom == -2)
        {
            end.transform.position = NOneTwo.transform.position;
        }
        else if (y == 4 && top == -3 && bottom == -2)
        {
            end.transform.position = NOneTwo.transform.position;
        }
        else if (y == 5 && top == -4 && bottom == -2)
        {
            end.transform.position = NOneTwo.transform.position;
        }

        //1 and 3
        if (y == -5 && top == 6 && bottom == -3)
        {
            end.transform.position = NOneThree.transform.position;
        }
        else if (y == -4 && top == 5 && bottom == -3)
        {
            end.transform.position = NOneThree.transform.position;
        }
        else if (y == -3 && top == 4 && bottom == -3)
        {
            end.transform.position = NOneThree.transform.position;
        }
        else if (y == -2 && top == 3 && bottom == -3)
        {
            end.transform.position = NOneThree.transform.position;
        }
        else if (y == -1 && top == 2 && bottom == -3)
        {
            end.transform.position = NOneThree.transform.position;
        }
        else if (y == 0 && top == 1 && bottom == -3)
        {
            end.transform.position = NOneThree.transform.position;
        }
        else if (y == 1 && top == 0 && bottom == -3)
        {
            end.transform.position = NOneThree.transform.position;
        }
        else if (y == 2 && top == -1 && bottom == -3)
        {
            end.transform.position = NOneThree.transform.position;
        }
        else if (y == 3 && top == -2 && bottom == -3)
        {
            end.transform.position = NOneThree.transform.position;
        }
        else if (y == 4 && top == -3 && bottom == -3)
        {
            end.transform.position = NOneThree.transform.position;
        }
        else if (y == 5 && top == -4 && bottom == -3)
        {
            end.transform.position = NOneThree.transform.position;
        }

        //1 and 4
        if (y == -5 && top == 6 && bottom == -4)
        {
            end.transform.position = NOneFour.transform.position;
        }
        else if (y == -4 && top == 5 && bottom == -4)
        {
            end.transform.position = NOneFour.transform.position;
        }
        else if (y == -3 && top == 4 && bottom == -4)
        {
            end.transform.position = NOneFour.transform.position;
        }
        else if (y == -2 && top == 3 && bottom == -4)
        {
            end.transform.position = NOneFour.transform.position;
        }
        else if (y == -1 && top == 2 && bottom == -4)
        {
            end.transform.position = NOneFour.transform.position;
        }
        else if (y == 0 && top == 1 && bottom == -4)
        {
            end.transform.position = NOneFour.transform.position;
        }
        else if (y == 1 && top == 0 && bottom == -4)
        {
            end.transform.position = NOneFour.transform.position;
        }
        else if (y == 2 && top == -1 && bottom == -4)
        {
            end.transform.position = NOneFour.transform.position;
        }
        else if (y == 3 && top == -2 && bottom == -4)
        {
            end.transform.position = NOneFour.transform.position;
        }
        else if (y == 4 && top == -3 && bottom == -4)
        {
            end.transform.position = NOneFour.transform.position;
        }
        else if (y == 5 && top == -4 && bottom == -4)
        {
            end.transform.position = NOneFour.transform.position;
        }

        //1 and 5
        if (y == -5 && top == 6 && bottom == -5)
        {
            end.transform.position = NOneFive.transform.position;
        }
        else if (y == -4 && top == 5 && bottom == -5)
        {
            end.transform.position = NOneFive.transform.position;
        }
        else if (y == -3 && top == 4 && bottom == -5)
        {
            end.transform.position = NOneFive.transform.position;
        }
        else if (y == -2 && top == 3 && bottom == -5)
        {
            end.transform.position = NOneFive.transform.position;
        }
        else if (y == -1 && top == 2 && bottom == -5)
        {
            end.transform.position = NOneFive.transform.position;
        }
        else if (y == 0 && top == 1 && bottom == -5)
        {
            end.transform.position = NOneFive.transform.position;
        }
        else if (y == 1 && top == 0 && bottom == -5)
        {
            end.transform.position = NOneFive.transform.position;
        }
        else if (y == 2 && top == -1 && bottom == -5)
        {
            end.transform.position = NOneFive.transform.position;
        }
        else if (y == 3 && top == -2 && bottom == -5)
        {
            end.transform.position = NOneFive.transform.position;
        }
        else if (y == 4 && top == -3 && bottom == -5)
        {
            end.transform.position = NOneFive.transform.position;
        }
        else if (y == 5 && top == -4 && bottom == -5)
        {
            end.transform.position = NOneFive.transform.position;
        }

        //2 and 1
        if (y == -5 && top == 7 && bottom == -1)
        {
            end.transform.position = NTwoOne.transform.position;
        }
        else if (y == -4 && top == 6 && bottom == -1)
        {
            end.transform.position = NTwoOne.transform.position;
        }
        else if (y == -3 && top == 5 && bottom == -1)
        {
            end.transform.position = NTwoOne.transform.position;
        }
        else if (y == -2 && top == 4 && bottom == -1)
        {
            end.transform.position = NTwoOne.transform.position;
        }
        else if (y == -1 && top == 3 && bottom == -1)
        {
            end.transform.position = NTwoOne.transform.position;
        }
        else if (y == 0 && top == 2 && bottom == -1)
        {
            end.transform.position = NTwoOne.transform.position;
        }
        else if (y == 1 && top == 1 && bottom == -1)
        {
            end.transform.position = NTwoOne.transform.position;
        }
        else if (y == 2 && top == 0 && bottom == -1)
        {
            end.transform.position = NTwoOne.transform.position;
        }
        else if (y == 3 && top == -1 && bottom == -1)
        {
            end.transform.position = NTwoOne.transform.position;
        }
        else if (y == 4 && top == -2 && bottom == -1)
        {
            end.transform.position = NTwoOne.transform.position;
        }
        else if (y == 5 && top == -3 && bottom == -1)
        {
            end.transform.position = NTwoOne.transform.position;
        }

        //2 and 2
        if (y == -5 && top == 7 && bottom == -2)
        {
            end.transform.position = NTwoTwo.transform.position;
        }
        else if (y == -4 && top == 6 && bottom == -2)
        {
            end.transform.position = NTwoTwo.transform.position;
        }
        else if (y == -3 && top == 5 && bottom == -2)
        {
            end.transform.position = NTwoTwo.transform.position;
        }
        else if (y == -2 && top == 4 && bottom == -2)
        {
            end.transform.position = NTwoTwo.transform.position;
        }
        else if (y == -1 && top == 3 && bottom == -2)
        {
            end.transform.position = NTwoTwo.transform.position;
        }
        else if (y == 0 && top == 2 && bottom == -2)
        {
            end.transform.position = NTwoTwo.transform.position;
        }
        else if (y == 1 && top == 1 && bottom == -2)
        {
            end.transform.position = NTwoTwo.transform.position;
        }
        else if (y == 2 && top == 0 && bottom == -2)
        {
            end.transform.position = NTwoTwo.transform.position;
        }
        else if (y == 3 && top == -1 && bottom == -2)
        {
            end.transform.position = NTwoTwo.transform.position;
        }
        else if (y == 4 && top == -2 && bottom == -2)
        {
            end.transform.position = NTwoTwo.transform.position;
        }
        else if (y == 5 && top == -3 && bottom == -2)
        {
            end.transform.position = NTwoTwo.transform.position;
        }

        //2 and 3
        if (y == -5 && top == 7 && bottom == -3)
        {
            end.transform.position = NTwoThree.transform.position;
        }
        else if (y == -4 && top == 6 && bottom == -3)
        {
            end.transform.position = NTwoThree.transform.position;
        }
        else if (y == -3 && top == 5 && bottom == -3)
        {
            end.transform.position = NTwoThree.transform.position;
        }
        else if (y == -2 && top == 4 && bottom == -3)
        {
            end.transform.position = NTwoThree.transform.position;
        }
        else if (y == -1 && top == 3 && bottom == -3)
        {
            end.transform.position = NTwoThree.transform.position;
        }
        else if (y == 0 && top == 2 && bottom == -3)
        {
            end.transform.position = NTwoThree.transform.position;
        }
        else if (y == 1 && top == 1 && bottom == -3)
        {
            end.transform.position = NTwoThree.transform.position;
        }
        else if (y == 2 && top == 0 && bottom == -3)
        {
            end.transform.position = NTwoThree.transform.position;
        }
        else if (y == 3 && top == -1 && bottom == -3)
        {
            end.transform.position = NTwoThree.transform.position;
        }
        else if (y == 4 && top == -2 && bottom == -3)
        {
            end.transform.position = NTwoThree.transform.position;
        }
        else if (y == 5 && top == -3 && bottom == -3)
        {
            end.transform.position = NTwoThree.transform.position;
        }


        //2 and 4
        if (y == -5 && top == 7 && bottom == -4)
        {
            end.transform.position = NTwoFour.transform.position;
        }
        else if (y == -4 && top == 6 && bottom == -4)
        {
            end.transform.position = NTwoFour.transform.position;
        }
        else if (y == -3 && top == 5 && bottom == -4)
        {
            end.transform.position = NTwoFour.transform.position;
        }
        else if (y == -2 && top == 4 && bottom == -4)
        {
            end.transform.position = NTwoFour.transform.position;
        }
        else if (y == -1 && top == 3 && bottom == -4)
        {
            end.transform.position = NTwoFour.transform.position;
        }
        else if (y == 0 && top == 2 && bottom == -4)
        {
            end.transform.position = NTwoFour.transform.position;
        }
        else if (y == 1 && top == 1 && bottom == -4)
        {
            end.transform.position = NTwoFour.transform.position;
        }
        else if (y == 2 && top == 0 && bottom == -4)
        {
            end.transform.position = NTwoFour.transform.position;
        }
        else if (y == 3 && top == -1 && bottom == -4)
        {
            end.transform.position = NTwoFour.transform.position;
        }
        else if (y == 4 && top == -2 && bottom == -4)
        {
            end.transform.position = NTwoFour.transform.position;
        }
        else if (y == 5 && top == -3 && bottom == -4)
        {
            end.transform.position = NTwoFour.transform.position;
        }



        //2 and 5
        if (y == -5 && top == 7 && bottom == -5)
        {
            end.transform.position = NTwoFive.transform.position;
        }
        else if (y == -4 && top == 6 && bottom == -5)
        {
            end.transform.position = NTwoFive.transform.position;
        }
        else if (y == -3 && top == 5 && bottom == -5)
        {
            end.transform.position = NTwoFive.transform.position;
        }
        else if (y == -2 && top == 4 && bottom == -5)
        {
            end.transform.position = NTwoFive.transform.position;
        }
        else if (y == -1 && top == 3 && bottom == -5)
        {
            end.transform.position = NTwoFive.transform.position;
        }
        else if (y == 0 && top == 2 && bottom == -5)
        {
            end.transform.position = NTwoFive.transform.position;
        }
        else if (y == 1 && top == 1 && bottom == -5)
        {
            end.transform.position = NTwoFive.transform.position;
        }
        else if (y == 2 && top == 0 && bottom == -5)
        {
            end.transform.position = NTwoFive.transform.position;
        }
        else if (y == 3 && top == -1 && bottom == -5)
        {
            end.transform.position = NTwoFive.transform.position;
        }
        else if (y == 4 && top == -2 && bottom == -5)
        {
            end.transform.position = NTwoFive.transform.position;
        }
        else if (y == 5 && top == -3 && bottom == -5)
        {
            end.transform.position = NTwoFive.transform.position;
        }


        //3 and 1
        if (y == -5 && top == 8 && bottom == -1)
        {
            end.transform.position = NThreeOne.transform.position;
        }
        else if (y == -4 && top == 7 && bottom == -1)
        {
            end.transform.position = NThreeOne.transform.position;
        }
        else if (y == -3 && top == 6 && bottom == -1)
        {
            end.transform.position = NThreeOne.transform.position;
        }
        else if (y == -2 && top == 5 && bottom == -1)
        {
            end.transform.position = NThreeOne.transform.position;
        }
        else if (y == -1 && top == 4 && bottom == -1)
        {
            end.transform.position = NThreeOne.transform.position;
        }
        else if (y == 0 && top == 3 && bottom == -1)
        {
            end.transform.position = NThreeOne.transform.position;
        }
        else if (y == 1 && top == 2 && bottom == -1)
        {
            end.transform.position = NThreeOne.transform.position;
        }
        else if (y == 2 && top == 1 && bottom == -1)
        {
            end.transform.position = NThreeOne.transform.position;
        }
        else if (y == 3 && top == 0 && bottom == -1)
        {
            end.transform.position = NThreeOne.transform.position;
        }
        else if (y == 4 && top == -1 && bottom == -1)
        {
            end.transform.position = NThreeOne.transform.position;
        }
        else if (y == 5 && top == -2 && bottom == -1)
        {
            end.transform.position = NThreeOne.transform.position;
        }

        //3 and 2
        if (y == -5 && top == 8 && bottom == -2)
        {
            end.transform.position = NThreeTwo.transform.position;
        }
        else if (y == -4 && top == 7 && bottom == -2)
        {
            end.transform.position = NThreeTwo.transform.position;
        }
        else if (y == -3 && top == 6 && bottom == -2)
        {
            end.transform.position = NThreeTwo.transform.position;
        }
        else if (y == -2 && top == 5 && bottom == -2)
        {
            end.transform.position = NThreeTwo.transform.position;
        }
        else if (y == -1 && top == 4 && bottom == -2)
        {
            end.transform.position = NThreeTwo.transform.position;
        }
        else if (y == 0 && top == 3 && bottom == -2)
        {
            end.transform.position = NThreeTwo.transform.position;
        }
        else if (y == 1 && top == 2 && bottom == -2)
        {
            end.transform.position = NThreeTwo.transform.position;
        }
        else if (y == 2 && top == 1 && bottom == -2)
        {
            end.transform.position = NThreeTwo.transform.position;
        }
        else if (y == 3 && top == 0 && bottom == -2)
        {
            end.transform.position = NThreeTwo.transform.position;
        }
        else if (y == 4 && top == -1 && bottom == -2)
        {
            end.transform.position = NThreeTwo.transform.position;
        }
        else if (y == 5 && top == -2 && bottom == -2)
        {
            end.transform.position = NThreeTwo.transform.position;
        }




        //3 and 3
        if (y == -5 && top == 8 && bottom == -3)
        {
            end.transform.position = NThreeThree.transform.position;
        }
        else if (y == -4 && top == 7 && bottom == -3)
        {
            end.transform.position = NThreeThree.transform.position;
        }
        else if (y == -3 && top == 6 && bottom == -3)
        {
            end.transform.position = NThreeThree.transform.position;
        }
        else if (y == -2 && top == 5 && bottom == -3)
        {
            end.transform.position = NThreeThree.transform.position;
        }
        else if (y == -1 && top == 4 && bottom == -3)
        {
            end.transform.position = NThreeThree.transform.position;
        }
        else if (y == 0 && top == 3 && bottom == -3)
        {
            end.transform.position = NThreeThree.transform.position;
        }
        else if (y == 1 && top == 2 && bottom == -3)
        {
            end.transform.position = NThreeThree.transform.position;
        }
        else if (y == 2 && top == 1 && bottom == -3)
        {
            end.transform.position = NThreeThree.transform.position;
        }
        else if (y == 3 && top == 0 && bottom == -3)
        {
            end.transform.position = NThreeThree.transform.position;
        }
        else if (y == 4 && top == -1 && bottom == -3)
        {
            end.transform.position = NThreeThree.transform.position;
        }
        else if (y == 5 && top == -2 && bottom == -3)
        {
            end.transform.position = NThreeThree.transform.position;
        }



        //3 and 4
        if (y == -5 && top == 8 && bottom == -4)
        {
            end.transform.position = NThreeFour.transform.position;
        }
        else if (y == -4 && top == 7 && bottom == -4)
        {
            end.transform.position = NThreeFour.transform.position;
        }
        else if (y == -3 && top == 6 && bottom == -4)
        {
            end.transform.position = NThreeFour.transform.position;
        }
        else if (y == -2 && top == 5 && bottom == -4)
        {
            end.transform.position = NThreeFour.transform.position;
        }
        else if (y == -1 && top == 4 && bottom == -4)
        {
            end.transform.position = NThreeFour.transform.position;
        }
        else if (y == 0 && top == 3 && bottom == -4)
        {
            end.transform.position = NThreeFour.transform.position;
        }
        else if (y == 1 && top == 2 && bottom == -4)
        {
            end.transform.position = NThreeFour.transform.position;
        }
        else if (y == 2 && top == 1 && bottom == -4)
        {
            end.transform.position = NThreeFour.transform.position;
        }
        else if (y == 3 && top == 0 && bottom == -4)
        {
            end.transform.position = NThreeFour.transform.position;
        }
        else if (y == 4 && top == -1 && bottom == -4)
        {
            end.transform.position = NThreeFour.transform.position;
        }
        else if (y == 5 && top == -2 && bottom == -4)
        {
            end.transform.position = NThreeFour.transform.position;
        }




        //3 and 5
        if (y == -5 && top == 8 && bottom == -5)
        {
            end.transform.position = NThreeFive.transform.position;
        }
        else if (y == -4 && top == 7 && bottom == -5)
        {
            end.transform.position = NThreeFive.transform.position;
        }
        else if (y == -3 && top == 6 && bottom == -5)
        {
            end.transform.position = NThreeFive.transform.position;
        }
        else if (y == -2 && top == 5 && bottom == -5)
        {
            end.transform.position = NThreeFive.transform.position;
        }
        else if (y == -1 && top == 4 && bottom == -5)
        {
            end.transform.position = NThreeFive.transform.position;
        }
        else if (y == 0 && top == 3 && bottom == -5)
        {
            end.transform.position = NThreeFive.transform.position;
        }
        else if (y == 1 && top == 2 && bottom == -5)
        {
            end.transform.position = NThreeFive.transform.position;
        }
        else if (y == 2 && top == 1 && bottom == -5)
        {
            end.transform.position = NThreeFive.transform.position;
        }
        else if (y == 3 && top == 0 && bottom == -5)
        {
            end.transform.position = NThreeFive.transform.position;
        }
        else if (y == 4 && top == -1 && bottom == -5)
        {
            end.transform.position = NThreeFive.transform.position;
        }
        else if (y == 5 && top == -2 && bottom == -5)
        {
            end.transform.position = NThreeFive.transform.position;
        }




        //4 and 1
        if (y == -5 && top == 9 && bottom == -1)
        {
            end.transform.position = NFourOne.transform.position;
        }
        else if (y == -4 && top == 8 && bottom == -1)
        {
            end.transform.position = NFourOne.transform.position;
        }
        else if (y == -3 && top == 7 && bottom == -1)
        {
            end.transform.position = NFourOne.transform.position;
        }
        else if (y == -2 && top == 6 && bottom == -1)
        {
            end.transform.position = NFourOne.transform.position;
        }
        else if (y == -1 && top == 5 && bottom == -1)
        {
            end.transform.position = NFourOne.transform.position;
        }
        else if (y == 0 && top == 4 && bottom == -1)
        {
            end.transform.position = NFourOne.transform.position;
        }
        else if (y == 1 && top == 3 && bottom == -1)
        {
            end.transform.position = NFourOne.transform.position;
        }
        else if (y == 2 && top == 2 && bottom == -1)
        {
            end.transform.position = NFourOne.transform.position;
        }
        else if (y == 3 && top == 1 && bottom == -1)
        {
            end.transform.position = NFourOne.transform.position;
        }
        else if (y == 4 && top == 0 && bottom == -1)
        {
            end.transform.position = NFourOne.transform.position;
        }
        else if (y == 5 && top == -1 && bottom == -1)
        {
            end.transform.position = NFourOne.transform.position;
        }





        //4 and 2
        if (y == -5 && top == 9 && bottom == -2)
        {
            end.transform.position = NFourTwo.transform.position;
        }
        else if (y == -4 && top == 8 && bottom == -2)
        {
            end.transform.position = NFourTwo.transform.position;
        }
        else if (y == -3 && top == 7 && bottom == -2)
        {
            end.transform.position = NFourTwo.transform.position;
        }
        else if (y == -2 && top == 6 && bottom == -2)
        {
            end.transform.position = NFourTwo.transform.position;
        }
        else if (y == -1 && top == 5 && bottom == -2)
        {
            end.transform.position = NFourTwo.transform.position;
        }
        else if (y == 0 && top == 4 && bottom == -2)
        {
            end.transform.position = NFourTwo.transform.position;
        }
        else if (y == 1 && top == 3 && bottom == -2)
        {
            end.transform.position = NFourTwo.transform.position;
        }
        else if (y == 2 && top == 2 && bottom == -2)
        {
            end.transform.position = NFourTwo.transform.position;
        }
        else if (y == 3 && top == 1 && bottom == -2)
        {
            end.transform.position = NFourTwo.transform.position;
        }
        else if (y == 4 && top == 0 && bottom == -2)
        {
            end.transform.position = NFourTwo.transform.position;
        }
        else if (y == 5 && top == -1 && bottom == -2)
        {
            end.transform.position = NFourTwo.transform.position;
        }





        //4 and 3
        if (y == -5 && top == 9 && bottom == -3)
        {
            end.transform.position = NFourThree.transform.position;
        }
        else if (y == -4 && top == 8 && bottom == -3)
        {
            end.transform.position = NFourThree.transform.position;
        }
        else if (y == -3 && top == 7 && bottom == -3)
        {
            end.transform.position = NFourThree.transform.position;
        }
        else if (y == -2 && top == 6 && bottom == -3)
        {
            end.transform.position = NFourThree.transform.position;
        }
        else if (y == -1 && top == 5 && bottom == -3)
        {
            end.transform.position = NFourThree.transform.position;
        }
        else if (y == 0 && top == 4 && bottom == -3)
        {
            end.transform.position = NFourThree.transform.position;
        }
        else if (y == 1 && top == 3 && bottom == -3)
        {
            end.transform.position = NFourThree.transform.position;
        }
        else if (y == 2 && top == 2 && bottom == -3)
        {
            end.transform.position = NFourThree.transform.position;
        }
        else if (y == 3 && top == 1 && bottom == -3)
        {
            end.transform.position = NFourThree.transform.position;
        }
        else if (y == 4 && top == 0 && bottom == -3)
        {
            end.transform.position = NFourThree.transform.position;
        }
        else if (y == 5 && top == -1 && bottom == -3)
        {
            end.transform.position = NFourThree.transform.position;
        }





        //4 and 4
        if (y == -5 && top == 9 && bottom == -4)
        {
            end.transform.position = NFourFour.transform.position;
        }
        else if (y == -4 && top == 8 && bottom == -4)
        {
            end.transform.position = NFourFour.transform.position;
        }
        else if (y == -3 && top == 7 && bottom == -4)
        {
            end.transform.position = NFourFour.transform.position;
        }
        else if (y == -2 && top == 6 && bottom == -4)
        {
            end.transform.position = NFourFour.transform.position;
        }
        else if (y == -1 && top == 5 && bottom == -4)
        {
            end.transform.position = NFourFour.transform.position;
        }
        else if (y == 0 && top == 4 && bottom == -4)
        {
            end.transform.position = NFourFour.transform.position;
        }
        else if (y == 1 && top == 3 && bottom == -4)
        {
            end.transform.position = NFourFour.transform.position;
        }
        else if (y == 2 && top == 2 && bottom == -4)
        {
            end.transform.position = NFourFour.transform.position;
        }
        else if (y == 3 && top == 1 && bottom == -4)
        {
            end.transform.position = NFourFour.transform.position;
        }
        else if (y == 4 && top == 0 && bottom == -4)
        {
            end.transform.position = NFourFour.transform.position;
        }
        else if (y == 5 && top == -1 && bottom == -4)
        {
            end.transform.position = NFourFour.transform.position;
        }





        //4 and 5
        if (y == -5 && top == 9 && bottom == -5)
        {
            end.transform.position = NFourFive.transform.position;
        }
        else if (y == -4 && top == 8 && bottom == -5)
        {
            end.transform.position = NFourFive.transform.position;
        }
        else if (y == -3 && top == 7 && bottom == -5)
        {
            end.transform.position = NFourFive.transform.position;
        }
        else if (y == -2 && top == 6 && bottom == -5)
        {
            end.transform.position = NFourFive.transform.position;
        }
        else if (y == -1 && top == 5 && bottom == -5)
        {
            end.transform.position = NFourFive.transform.position;
        }
        else if (y == 0 && top == 4 && bottom == -5)
        {
            end.transform.position = NFourFive.transform.position;
        }
        else if (y == 1 && top == 3 && bottom == -5)
        {
            end.transform.position = NFourFive.transform.position;
        }
        else if (y == 2 && top == 2 && bottom == -5)
        {
            end.transform.position = NFourFive.transform.position;
        }
        else if (y == 3 && top == 1 && bottom == -5)
        {
            end.transform.position = NFourFive.transform.position;
        }
        else if (y == 4 && top == 0 && bottom == -5)
        {
            end.transform.position = NFourFive.transform.position;
        }
        else if (y == 5 && top == -1 && bottom == -5)
        {
            end.transform.position = NFourFive.transform.position;
        }





        //5 and 1
        if (y == -5 && top == 10 && bottom == -1)
        {
            end.transform.position = NFiveOne.transform.position;
        }
        else if (y == -4 && top == 9 && bottom == -1)
        {
            end.transform.position = NFiveOne.transform.position;
        }
        else if (y == -3 && top == 8 && bottom == -1)
        {
            end.transform.position = NFiveOne.transform.position;
        }
        else if (y == -2 && top == 7 && bottom == -1)
        {
            end.transform.position = NFiveOne.transform.position;
        }
        else if (y == -1 && top == 6 && bottom == -1)
        {
            end.transform.position = NFiveOne.transform.position;
        }
        else if (y == 0 && top == 5 && bottom == -1)
        {
            end.transform.position = NFiveOne.transform.position;
        }
        else if (y == 1 && top == 4 && bottom == -1)
        {
            end.transform.position = NFiveOne.transform.position;
        }
        else if (y == 2 && top == 3 && bottom == -1)
        {
            end.transform.position = NFiveOne.transform.position;
        }
        else if (y == 3 && top == 2 && bottom == -1)
        {
            end.transform.position = NFiveOne.transform.position;
        }
        else if (y == 4 && top == 1 && bottom == -1)
        {
            end.transform.position = NFiveOne.transform.position;
        }
        else if (y == 5 && top == 0 && bottom == -1)
        {
            end.transform.position = NFiveOne.transform.position;
        }





        //5 and 2
        if (y == -5 && top == 10 && bottom == -2)
        {
            end.transform.position = NFiveTwo.transform.position;
        }
        else if (y == -4 && top == 9 && bottom == -2)
        {
            end.transform.position = NFiveTwo.transform.position;
        }
        else if (y == -3 && top == 8 && bottom == -2)
        {
            end.transform.position = NFiveTwo.transform.position;
        }
        else if (y == -2 && top == 7 && bottom == -2)
        {
            end.transform.position = NFiveTwo.transform.position;
        }
        else if (y == -1 && top == 6 && bottom == -2)
        {
            end.transform.position = NFiveTwo.transform.position;
        }
        else if (y == 0 && top == 5 && bottom == -2)
        {
            end.transform.position = NFiveTwo.transform.position;
        }
        else if (y == 1 && top == 4 && bottom == -2)
        {
            end.transform.position = NFiveTwo.transform.position;
        }
        else if (y == 2 && top == 3 && bottom == -2)
        {
            end.transform.position = NFiveTwo.transform.position;
        }
        else if (y == 3 && top == 2 && bottom == -2)
        {
            end.transform.position = NFiveTwo.transform.position;
        }
        else if (y == 4 && top == 1 && bottom == -2)
        {
            end.transform.position = NFiveTwo.transform.position;
        }
        else if (y == 5 && top == 0 && bottom == -2)
        {
            end.transform.position = NFiveTwo.transform.position;
        }





        //5 and 3
        if (y == -5 && top == 10 && bottom == -3)
        {
            end.transform.position = NFiveThree.transform.position;
        }
        else if (y == -4 && top == 9 && bottom == -3)
        {
            end.transform.position = NFiveThree.transform.position;
        }
        else if (y == -3 && top == 8 && bottom == -3)
        {
            end.transform.position = NFiveThree.transform.position;
        }
        else if (y == -2 && top == 7 && bottom == -3)
        {
            end.transform.position = NFiveThree.transform.position;
        }
        else if (y == -1 && top == 6 && bottom == -3)
        {
            end.transform.position = NFiveThree.transform.position;
        }
        else if (y == 0 && top == 5 && bottom == -3)
        {
            end.transform.position = NFiveThree.transform.position;
        }
        else if (y == 1 && top == 4 && bottom == -3)
        {
            end.transform.position = NFiveThree.transform.position;
        }
        else if (y == 2 && top == 3 && bottom == -3)
        {
            end.transform.position = NFiveThree.transform.position;
        }
        else if (y == 3 && top == 2 && bottom == -3)
        {
            end.transform.position = NFiveThree.transform.position;
        }
        else if (y == 4 && top == 1 && bottom == -3)
        {
            end.transform.position = NFiveThree.transform.position;
        }
        else if (y == 5 && top == 0 && bottom == -3)
        {
            end.transform.position = NFiveThree.transform.position;
        }





        //5 and 4
        if (y == -5 && top == 10 && bottom == -4)
        {
            end.transform.position = NFiveFour.transform.position;
        }
        else if (y == -4 && top == 9 && bottom == -4)
        {
            end.transform.position = NFiveFour.transform.position;
        }
        else if (y == -3 && top == 8 && bottom == -4)
        {
            end.transform.position = NFiveFour.transform.position;
        }
        else if (y == -2 && top == 7 && bottom == -4)
        {
            end.transform.position = NFiveFour.transform.position;
        }
        else if (y == -1 && top == 6 && bottom == -4)
        {
            end.transform.position = NFiveFour.transform.position;
        }
        else if (y == 0 && top == 5 && bottom == -4)
        {
            end.transform.position = NFiveFour.transform.position;
        }
        else if (y == 1 && top == 4 && bottom == -4)
        {
            end.transform.position = NFiveFour.transform.position;
        }
        else if (y == 2 && top == 3 && bottom == -4)
        {
            end.transform.position = NFiveFour.transform.position;
        }
        else if (y == 3 && top == 2 && bottom == -4)
        {
            end.transform.position = NFiveFour.transform.position;
        }
        else if (y == 4 && top == 1 && bottom == -4)
        {
            end.transform.position = NFiveFour.transform.position;
        }
        else if (y == 5 && top == 0 && bottom == -4)
        {
            end.transform.position = NFiveFour.transform.position;
        }





        //5 and 5
        if (y == -5 && top == 10 && bottom == -5)
        {
            end.transform.position = NFiveFive.transform.position;
        }
        else if (y == -4 && top == 9 && bottom == -5)
        {
            end.transform.position = NFiveFive.transform.position;
        }
        else if (y == -3 && top == 8 && bottom == -5)
        {
            end.transform.position = NFiveFive.transform.position;
        }
        else if (y == -2 && top == 7 && bottom == -5)
        {
            end.transform.position = NFiveFive.transform.position;
        }
        else if (y == -1 && top == 6 && bottom == -5)
        {
            end.transform.position = NFiveFive.transform.position;
        }
        else if (y == 0 && top == 5 && bottom == -5)
        {
            end.transform.position = NFiveFive.transform.position;
        }
        else if (y == 1 && top == 4 && bottom == -5)
        {
            end.transform.position = NFiveFive.transform.position;
        }
        else if (y == 2 && top == 3 && bottom == -5)
        {
            end.transform.position = NFiveFive.transform.position;
        }
        else if (y == 3 && top == 2 && bottom == -5)
        {
            end.transform.position = NFiveFive.transform.position;
        }
        else if (y == 4 && top == 1 && bottom == -5)
        {
            end.transform.position = NFiveFive.transform.position;
        }
        else if (y == 5 && top == 0 && bottom == -5)
        {
            end.transform.position = NFiveFive.transform.position;
        }



        //-1 and -1
        if (y == -5 && top == 4 && bottom == 1)
        {
            end.transform.position = OneNOne.transform.position;
        }
        else if (y == -4 && top == 3 && bottom == 1)
        {
            end.transform.position = OneNOne.transform.position;
        }
        else if (y == -3 && top == 2 && bottom == 1)
        {
            end.transform.position = OneNOne.transform.position;
        }
        else if (y == -2 && top == 1 && bottom == 1)
        {
            end.transform.position = OneNOne.transform.position;
        }
        else if (y == -1 && top == 0 && bottom == 1)
        {
            end.transform.position = OneNOne.transform.position;
        }
        else if (y == 0 && top == -1 && bottom == 1)
        {
            end.transform.position = OneNOne.transform.position;
        }
        else if (y == 1 && top == -2 && bottom == 1)
        {
            end.transform.position = OneNOne.transform.position;
        }
        else if (y == 2 && top == -3 && bottom == 1)
        {
            end.transform.position = OneNOne.transform.position;
        }
        else if (y == 3 && top == -4 && bottom == 1)
        {
            end.transform.position = OneNOne.transform.position;
        }
        else if (y == 4 && top == -5 && bottom == 1)
        {
            end.transform.position = OneNOne.transform.position;
        }
        else if (y == 5 && top == -6 && bottom == 1)
        {
            end.transform.position = OneNOne.transform.position;
        }

        //-1 and -2
        if (y == -5 && top == 4 && bottom == 2)
        {
            end.transform.position = OnenTwo.transform.position;
        }
        else if (y == -4 && top == 3 && bottom == 2)
        {
            end.transform.position = OnenTwo.transform.position;
        }
        else if (y == -3 && top == 2 && bottom == 2)
        {
            end.transform.position = OnenTwo.transform.position;
        }
        else if (y == -2 && top == 1 && bottom == 2)
        {
            end.transform.position = OnenTwo.transform.position;
        }
        else if (y == -1 && top == 0 && bottom == 2)
        {
            end.transform.position = OnenTwo.transform.position;
        }
        else if (y == 0 && top == -1 && bottom == 2)
        {
            end.transform.position = OnenTwo.transform.position;
        }
        else if (y == 1 && top == -2 && bottom == 2)
        {
            end.transform.position = OnenTwo.transform.position;
        }
        else if (y == 2 && top == -3 && bottom == 2)
        {
            end.transform.position = OnenTwo.transform.position;
        }
        else if (y == 3 && top == -4 && bottom == 2)
        {
            end.transform.position = OnenTwo.transform.position;
        }
        else if (y == 4 && top == -5 && bottom == 2)
        {
            end.transform.position = OnenTwo.transform.position;
        }
        else if (y == 5 && top == -6 && bottom == 2)
        {
            end.transform.position = OnenTwo.transform.position;
        }

        //-1 and -3
        if (y == -5 && top == 4 && bottom == 3)
        {
            end.transform.position = OneNThree.transform.position;
        }
        else if (y == -4 && top == 3 && bottom == 3)
        {
            end.transform.position = OneNThree.transform.position;
        }
        else if (y == -3 && top == 2 && bottom == 3)
        {
            end.transform.position = OneNThree.transform.position;
        }
        else if (y == -2 && top == 1 && bottom == 3)
        {
            end.transform.position = OneNThree.transform.position;
        }
        else if (y == -1 && top == 0 && bottom == 3)
        {
            end.transform.position = OneNThree.transform.position;
        }
        else if (y == 0 && top == -1 && bottom == 3)
        {
            end.transform.position = OneNThree.transform.position;
        }
        else if (y == 1 && top == -2 && bottom == 3)
        {
            end.transform.position = OneNThree.transform.position;
        }
        else if (y == 2 && top == -3 && bottom == 3)
        {
            end.transform.position = OneNThree.transform.position;
        }
        else if (y == 3 && top == -4 && bottom == 3)
        {
            end.transform.position = OneNThree.transform.position;
        }
        else if (y == 4 && top == -5 && bottom == 3)
        {
            end.transform.position = OneNThree.transform.position;
        }
        else if (y == 5 && top == -6 && bottom == 3)
        {
            end.transform.position = OneNThree.transform.position;
        }

        //-1 and -4
        if (y == -5 && top == 4 && bottom == 4)
        {
            end.transform.position = OneNFour.transform.position;
        }
        else if (y == -4 && top == 3 && bottom == 4)
        {
            end.transform.position = OneNFour.transform.position;
        }
        else if (y == -3 && top == 2 && bottom == 4)
        {
            end.transform.position = OneNFour.transform.position;
        }
        else if (y == -2 && top == 1 && bottom == 4)
        {
            end.transform.position = OneNFour.transform.position;
        }
        else if (y == -1 && top == 0 && bottom == 4)
        {
            end.transform.position = OneNFour.transform.position;
        }
        else if (y == 0 && top == -1 && bottom == 4)
        {
            end.transform.position = OneNFour.transform.position;
        }
        else if (y == 1 && top == -2 && bottom == 4)
        {
            end.transform.position = OneNFour.transform.position;
        }
        else if (y == 2 && top == -3 && bottom == 4)
        {
            end.transform.position = OneNFour.transform.position;
        }
        else if (y == 3 && top == -4 && bottom == 4)
        {
            end.transform.position = OneNFour.transform.position;
        }
        else if (y == 4 && top == -5 && bottom == 4)
        {
            end.transform.position = OneNFour.transform.position;
        }
        else if (y == 5 && top == -6 && bottom == 4)
        {
            end.transform.position = OneNFour.transform.position;
        }

        //-1 and -5
        if (y == -5 && top == 4 && bottom == 5)
        {
            end.transform.position = OneNFive.transform.position;
        }
        else if (y == -4 && top == 3 && bottom == 5)
        {
            end.transform.position = OneNFive.transform.position;
        }
        else if (y == -3 && top == 2 && bottom == 5)
        {
            end.transform.position = OneNFive.transform.position;
        }
        else if (y == -2 && top == 1 && bottom == 5)
        {
            end.transform.position = OneNFive.transform.position;
        }
        else if (y == -1 && top == 0 && bottom == 5)
        {
            end.transform.position = OneNFive.transform.position;
        }
        else if (y == 0 && top == -1 && bottom == 5)
        {
            end.transform.position = OneNFive.transform.position;
        }
        else if (y == 1 && top == -2 && bottom == 5)
        {
            end.transform.position = OneNFive.transform.position;
        }
        else if (y == 2 && top == -3 && bottom == 5)
        {
            end.transform.position = OneNFive.transform.position;
        }
        else if (y == 3 && top == -4 && bottom == 5)
        {
            end.transform.position = OneNFive.transform.position;
        }
        else if (y == 4 && top == -5 && bottom == 5)
        {
            end.transform.position = OneNFive.transform.position;
        }
        else if (y == 5 && top == -6 && bottom == 5)
        {
            end.transform.position = OneNFive.transform.position;
        }

        //-2 and -1
        if (y == -5 && top == 3 && bottom == 1)
        {
            end.transform.position = TwoNOne.transform.position;
        }
        else if (y == -4 && top == 2 && bottom == 1)
        {
            end.transform.position = TwoNOne.transform.position;
        }
        else if (y == -3 && top == 1 && bottom == 1)
        {
            end.transform.position = TwoNOne.transform.position;
        }
        else if (y == -2 && top == 0 && bottom == 1)
        {
            end.transform.position = TwoNOne.transform.position;
        }
        else if (y == -1 && top == -1 && bottom == 1)
        {
            end.transform.position = TwoNOne.transform.position;
        }
        else if (y == 0 && top == -2 && bottom == 1)
        {
            end.transform.position = TwoNOne.transform.position;
        }
        else if (y == 1 && top == -3 && bottom == 1)
        {
            end.transform.position = TwoNOne.transform.position;
        }
        else if (y == 2 && top == -4 && bottom == 1)
        {
            end.transform.position = TwoNOne.transform.position;
        }
        else if (y == 3 && top == -5 && bottom == 1)
        {
            end.transform.position = TwoNOne.transform.position;
        }
        else if (y == 4 && top == -6 && bottom == 1)
        {
            end.transform.position = TwoNOne.transform.position;
        }
        else if (y == 5 && top == -7 && bottom == 1)
        {
            end.transform.position = TwoNOne.transform.position;
        }

        //-2 and -2
        if (y == -5 && top == 3 && bottom == 2)
        {
            end.transform.position = TwoNTwo.transform.position;
        }
        else if (y == -4 && top == 2 && bottom == 2)
        {
            end.transform.position = TwoNTwo.transform.position;
        }
        else if (y == -3 && top == 1 && bottom == 2)
        {
            end.transform.position = TwoNTwo.transform.position;
        }
        else if (y == -2 && top == 0 && bottom == 2)
        {
            end.transform.position = TwoNTwo.transform.position;
        }
        else if (y == -1 && top == -1 && bottom == 2)
        {
            end.transform.position = TwoNTwo.transform.position;
        }
        else if (y == 0 && top == -2 && bottom == 2)
        {
            end.transform.position = TwoNTwo.transform.position;
        }
        else if (y == 1 && top == -3 && bottom == 2)
        {
            end.transform.position = TwoNTwo.transform.position;
        }
        else if (y == 2 && top == -4 && bottom == 2)
        {
            end.transform.position = TwoNTwo.transform.position;
        }
        else if (y == 3 && top == -5 && bottom == 2)
        {
            end.transform.position = TwoNTwo.transform.position;
        }
        else if (y == 4 && top == -6 && bottom == 2)
        {
            end.transform.position = TwoNTwo.transform.position;
        }
        else if (y == 5 && top == -7 && bottom == 2)
        {
            end.transform.position = TwoNTwo.transform.position;
        }


        //-2 and -3
        if (y == -5 && top == 3 && bottom == 3)
        {
            end.transform.position = TwoNThree.transform.position;
        }
        else if (y == -4 && top == 2 && bottom == 3)
        {
            end.transform.position = TwoNThree.transform.position;
        }
        else if (y == -3 && top == 1 && bottom == 3)
        {
            end.transform.position = TwoNThree.transform.position;
        }
        else if (y == -2 && top == 0 && bottom == 3)
        {
            end.transform.position = TwoNThree.transform.position;
        }
        else if (y == -1 && top == -1 && bottom == 3)
        {
            end.transform.position = TwoNThree.transform.position;
        }
        else if (y == 0 && top == -2 && bottom == 3)
        {
            end.transform.position = TwoNThree.transform.position;
        }
        else if (y == 1 && top == -3 && bottom == 3)
        {
            end.transform.position = TwoNThree.transform.position;
        }
        else if (y == 2 && top == -4 && bottom == 3)
        {
            end.transform.position = TwoNThree.transform.position;
        }
        else if (y == 3 && top == -5 && bottom == 3)
        {
            end.transform.position = TwoNThree.transform.position;
        }
        else if (y == 4 && top == -6 && bottom == 3)
        {
            end.transform.position = TwoNThree.transform.position;
        }
        else if (y == 5 && top == -7 && bottom == 3)
        {
            end.transform.position = TwoNThree.transform.position;
        }


        //-2 and -4
        if (y == -5 && top == 3 && bottom == 4)
        {
            end.transform.position = TwoNFour.transform.position;
        }
        else if (y == -4 && top == 2 && bottom == 4)
        {
            end.transform.position = TwoNFour.transform.position;
        }
        else if (y == -3 && top == 1 && bottom == 4)
        {
            end.transform.position = TwoNFour.transform.position;
        }
        else if (y == -2 && top == 0 && bottom == 4)
        {
            end.transform.position = TwoNFour.transform.position;
        }
        else if (y == -1 && top == -1 && bottom == 4)
        {
            end.transform.position = TwoNFour.transform.position;
        }
        else if (y == 0 && top == -2 && bottom == 4)
        {
            end.transform.position = TwoNFour.transform.position;
        }
        else if (y == 1 && top == -3 && bottom == 4)
        {
            end.transform.position = TwoNFour.transform.position;
        }
        else if (y == 2 && top == -4 && bottom == 4)
        {
            end.transform.position = TwoNFour.transform.position;
        }
        else if (y == 3 && top == -5 && bottom == 4)
        {
            end.transform.position = TwoNFour.transform.position;
        }
        else if (y == 4 && top == -6 && bottom == 4)
        {
            end.transform.position = TwoNFour.transform.position;
        }
        else if (y == 5 && top == -7 && bottom == 4)
        {
            end.transform.position = TwoNFour.transform.position;
        }


        //-2 and -5
        if (y == -5 && top == 3 && bottom == 5)
        {
            end.transform.position = TwoNFive.transform.position;
        }
        else if (y == -4 && top == 2 && bottom == 5)
        {
            end.transform.position = TwoNFive.transform.position;
        }
        else if (y == -3 && top == 1 && bottom == 5)
        {
            end.transform.position = TwoNFive.transform.position;
        }
        else if (y == -2 && top == 0 && bottom == 5)
        {
            end.transform.position = TwoNFive.transform.position;
        }
        else if (y == -1 && top == -1 && bottom == 5)
        {
            end.transform.position = TwoNFive.transform.position;
        }
        else if (y == 0 && top == -2 && bottom == 5)
        {
            end.transform.position = TwoNFive.transform.position;
        }
        else if (y == 1 && top == -3 && bottom == 5)
        {
            end.transform.position = TwoNFive.transform.position;
        }
        else if (y == 2 && top == -4 && bottom == 5)
        {
            end.transform.position = TwoNFive.transform.position;
        }
        else if (y == 3 && top == -5 && bottom == 5)
        {
            end.transform.position = TwoNFive.transform.position;
        }
        else if (y == 4 && top == -6 && bottom == 5)
        {
            end.transform.position = TwoNFive.transform.position;
        }
        else if (y == 5 && top == -7 && bottom == 5)
        {
            end.transform.position = TwoNFive.transform.position;
        }


        //-3 and -1
        if (y == -5 && top == 2 && bottom == 1)
        {
            end.transform.position = ThreeNOne.transform.position;
        }
        else if (y == -4 && top == 1 && bottom == 1)
        {
            end.transform.position = ThreeNOne.transform.position;
        }
        else if (y == -3 && top == 0 && bottom == 1)
        {
            end.transform.position = ThreeNOne.transform.position;
        }
        else if (y == -2 && top == -1 && bottom == 1)
        {
            end.transform.position = ThreeNOne.transform.position;
        }
        else if (y == -1 && top == -2 && bottom == 1)
        {
            end.transform.position = ThreeNOne.transform.position;
        }
        else if (y == 0 && top == -3 && bottom == 1)
        {
            end.transform.position = ThreeNOne.transform.position;
        }
        else if (y == 1 && top == -4 && bottom == 1)
        {
            end.transform.position = ThreeNOne.transform.position;
        }
        else if (y == 2 && top == -5 && bottom == 1)
        {
            end.transform.position = ThreeNOne.transform.position;
        }
        else if (y == 3 && top == -6 && bottom == 1)
        {
            end.transform.position = ThreeNOne.transform.position;
        }
        else if (y == 4 && top == -7 && bottom == 1)
        {
            end.transform.position = ThreeNOne.transform.position;
        }
        else if (y == 5 && top == -8 && bottom == 1)
        {
            end.transform.position = ThreeNOne.transform.position;
        }


        //-3 and -2
        if (y == -5 && top == 2 && bottom == 2)
        {
            end.transform.position = ThreeNTwo.transform.position;
        }
        else if (y == -4 && top == 1 && bottom == 2)
        {
            end.transform.position = ThreeNTwo.transform.position;
        }
        else if (y == -3 && top == 0 && bottom == 2)
        {
            end.transform.position = ThreeNTwo.transform.position;
        }
        else if (y == -2 && top == -1 && bottom == 2)
        {
            end.transform.position = ThreeNTwo.transform.position;
        }
        else if (y == -1 && top == -2 && bottom == 2)
        {
            end.transform.position = ThreeNTwo.transform.position;
        }
        else if (y == 0 && top == -3 && bottom == 2)
        {
            end.transform.position = ThreeNTwo.transform.position;
        }
        else if (y == 1 && top == -4 && bottom == 2)
        {
            end.transform.position = ThreeNTwo.transform.position;
        }
        else if (y == 2 && top == -5 && bottom == 2)
        {
            end.transform.position = ThreeNTwo.transform.position;
        }
        else if (y == 3 && top == -6 && bottom == 2)
        {
            end.transform.position = ThreeNTwo.transform.position;
        }
        else if (y == 4 && top == -7 && bottom == 2)
        {
            end.transform.position = ThreeNTwo.transform.position;
        }
        else if (y == 5 && top == -8 && bottom == 2)
        {
            end.transform.position = ThreeNTwo.transform.position;
        }


        //-3 and -3
        if (y == -5 && top == 2 && bottom == 3)
        {
            end.transform.position = ThreeNThree.transform.position;
        }
        else if (y == -4 && top == 1 && bottom == 3)
        {
            end.transform.position = ThreeNThree.transform.position;
        }
        else if (y == -3 && top == 0 && bottom == 3)
        {
            end.transform.position = ThreeNThree.transform.position;
        }
        else if (y == -2 && top == -1 && bottom == 3)
        {
            end.transform.position = ThreeNThree.transform.position;
        }
        else if (y == -1 && top == -2 && bottom == 3)
        {
            end.transform.position = ThreeNThree.transform.position;
        }
        else if (y == 0 && top == -3 && bottom == 3)
        {
            end.transform.position = ThreeNThree.transform.position;
        }
        else if (y == 1 && top == -4 && bottom == 3)
        {
            end.transform.position = ThreeNThree.transform.position;
        }
        else if (y == 2 && top == -5 && bottom == 3)
        {
            end.transform.position = ThreeNThree.transform.position;
        }
        else if (y == 3 && top == -6 && bottom == 3)
        {
            end.transform.position = ThreeNThree.transform.position;
        }
        else if (y == 4 && top == -7 && bottom == 3)
        {
            end.transform.position = ThreeNThree.transform.position;
        }
        else if (y == 5 && top == -8 && bottom == 3)
        {
            end.transform.position = ThreeNThree.transform.position;
        }


        //-3 and -4
        if (y == -5 && top == 2 && bottom == 4)
        {
            end.transform.position = ThreeNFour.transform.position;
        }
        else if (y == -4 && top == 1 && bottom == 4)
        {
            end.transform.position = ThreeNFour.transform.position;
        }
        else if (y == -3 && top == 0 && bottom == 4)
        {
            end.transform.position = ThreeNFour.transform.position;
        }
        else if (y == -2 && top == -1 && bottom == 4)
        {
            end.transform.position = ThreeNFour.transform.position;
        }
        else if (y == -1 && top == -2 && bottom == 4)
        {
            end.transform.position = ThreeNFour.transform.position;
        }
        else if (y == 0 && top == -3 && bottom == 4)
        {
            end.transform.position = ThreeNFour.transform.position;
        }
        else if (y == 1 && top == -4 && bottom == 4)
        {
            end.transform.position = ThreeNFour.transform.position;
        }
        else if (y == 2 && top == -5 && bottom == 4)
        {
            end.transform.position = ThreeNFour.transform.position;
        }
        else if (y == 3 && top == -6 && bottom == 4)
        {
            end.transform.position = ThreeNFour.transform.position;
        }
        else if (y == 4 && top == -7 && bottom == 4)
        {
            end.transform.position = ThreeNFour.transform.position;
        }
        else if (y == 5 && top == -8 && bottom == 4)
        {
            end.transform.position = ThreeNFour.transform.position;
        }


        //-3 and -5
        if (y == -5 && top == 2 && bottom == 5)
        {
            end.transform.position = ThreeNFive.transform.position;
        }
        else if (y == -4 && top == 1 && bottom == 5)
        {
            end.transform.position = ThreeNFive.transform.position;
        }
        else if (y == -3 && top == 0 && bottom == 5)
        {
            end.transform.position = ThreeNFive.transform.position;
        }
        else if (y == -2 && top == -1 && bottom == 5)
        {
            end.transform.position = ThreeNFive.transform.position;
        }
        else if (y == -1 && top == -2 && bottom == 5)
        {
            end.transform.position = ThreeNFive.transform.position;
        }
        else if (y == 0 && top == -3 && bottom == 5)
        {
            end.transform.position = ThreeNFive.transform.position;
        }
        else if (y == 1 && top == -4 && bottom == 5)
        {
            end.transform.position = ThreeNFive.transform.position;
        }
        else if (y == 2 && top == -5 && bottom == 5)
        {
            end.transform.position = ThreeNFive.transform.position;
        }
        else if (y == 3 && top == -6 && bottom == 5)
        {
            end.transform.position = ThreeNFive.transform.position;
        }
        else if (y == 4 && top == -7 && bottom == 5)
        {
            end.transform.position = ThreeNFive.transform.position;
        }
        else if (y == 5 && top == -8 && bottom == 5)
        {
            end.transform.position = ThreeNFive.transform.position;
        }


        //-4 and -1
        if (y == -5 && top == 1 && bottom == 1)
        {
            end.transform.position = FourNOne.transform.position;
        }
        else if (y == -4 && top == 0 && bottom == 1)
        {
            end.transform.position = FourNOne.transform.position;
        }
        else if (y == -3 && top == -1 && bottom == 1)
        {
            end.transform.position = FourNOne.transform.position;
        }
        else if (y == -2 && top == -2 && bottom == 1)
        {
            end.transform.position = FourNOne.transform.position;
        }
        else if (y == -1 && top == -3 && bottom == 1)
        {
            end.transform.position = FourNOne.transform.position;
        }
        else if (y == 0 && top == -4 && bottom == 1)
        {
            end.transform.position = FourNOne.transform.position;
        }
        else if (y == 1 && top == -5 && bottom == 1)
        {
            end.transform.position = FourNOne.transform.position;
        }
        else if (y == 2 && top == -6 && bottom == 1)
        {
            end.transform.position = FourNOne.transform.position;
        }
        else if (y == 3 && top == -7 && bottom == 1)
        {
            end.transform.position = FourNOne.transform.position;
        }
        else if (y == 4 && top == -8 && bottom == 1)
        {
            end.transform.position = FourNOne.transform.position;
        }
        else if (y == 5 && top == -9 && bottom == 1)
        {
            end.transform.position = FourNOne.transform.position;
        }


        //-4 and -2
        if (y == -5 && top == 1 && bottom == 2)
        {
            end.transform.position = FourNTwo.transform.position;
        }
        else if (y == -4 && top == 0 && bottom == 2)
        {
            end.transform.position = FourNTwo.transform.position;
        }
        else if (y == -3 && top == -1 && bottom == 2)
        {
            end.transform.position = FourNTwo.transform.position;
        }
        else if (y == -2 && top == -2 && bottom == 2)
        {
            end.transform.position = FourNTwo.transform.position;
        }
        else if (y == -1 && top == -3 && bottom == 2)
        {
            end.transform.position = FourNTwo.transform.position;
        }
        else if (y == 0 && top == -4 && bottom == 2)
        {
            end.transform.position = FourNTwo.transform.position;
        }
        else if (y == 1 && top == -5 && bottom == 2)
        {
            end.transform.position = FourNTwo.transform.position;
        }
        else if (y == 2 && top == -6 && bottom == 2)
        {
            end.transform.position = FourNTwo.transform.position;
        }
        else if (y == 3 && top == -7 && bottom == 2)
        {
            end.transform.position = FourNTwo.transform.position;
        }
        else if (y == 4 && top == -8 && bottom == 2)
        {
            end.transform.position = FourNTwo.transform.position;
        }
        else if (y == 5 && top == -9 && bottom == 2)
        {
            end.transform.position = FourNTwo.transform.position;
        }


        //-4 and -3
        if (y == -5 && top == 1 && bottom == -3)
        {
            end.transform.position = FourNThree.transform.position;
        }
        else if (y == -4 && top == 0 && bottom == -3)
        {
            end.transform.position = FourNThree.transform.position;
        }
        else if (y == -3 && top == -1 && bottom == -3)
        {
            end.transform.position = FourNThree.transform.position;
        }
        else if (y == -2 && top == -2 && bottom == -3)
        {
            end.transform.position = FourNThree.transform.position;
        }
        else if (y == -1 && top == -3 && bottom == -3)
        {
            end.transform.position = FourNThree.transform.position;
        }
        else if (y == 0 && top == -4 && bottom == -3)
        {
            end.transform.position = FourNThree.transform.position;
        }
        else if (y == 1 && top == -5 && bottom == -3)
        {
            end.transform.position = FourNThree.transform.position;
        }
        else if (y == 2 && top == -6 && bottom == -3)
        {
            end.transform.position = FourNThree.transform.position;
        }
        else if (y == 3 && top == -7 && bottom == -3)
        {
            end.transform.position = FourNThree.transform.position;
        }
        else if (y == 4 && top == -8 && bottom == -3)
        {
            end.transform.position = FourNThree.transform.position;
        }
        else if (y == 5 && top == -9 && bottom == -3)
        {
            end.transform.position = FourNThree.transform.position;
        }


        //-4 and -4
        if (y == -5 && top == 1 && bottom == 4)
        {
            end.transform.position = FourNFour.transform.position;
        }
        else if (y == -4 && top == 0 && bottom == 4)
        {
            end.transform.position = FourNFour.transform.position;
        }
        else if (y == -3 && top == -1 && bottom == 4)
        {
            end.transform.position = FourNFour.transform.position;
        }
        else if (y == -2 && top == -2 && bottom == 4)
        {
            end.transform.position = FourNFour.transform.position;
        }
        else if (y == -1 && top == -3 && bottom == 4)
        {
            end.transform.position = FourNFour.transform.position;
        }
        else if (y == 0 && top == -4 && bottom == 4)
        {
            end.transform.position = FourNFour.transform.position;
        }
        else if (y == 1 && top == -5 && bottom == 4)
        {
            end.transform.position = FourNFour.transform.position;
        }
        else if (y == 2 && top == -6 && bottom == 4)
        {
            end.transform.position = FourNFour.transform.position;
        }
        else if (y == 3 && top == -7 && bottom == 4)
        {
            end.transform.position = FourNFour.transform.position;
        }
        else if (y == 4 && top == -8 && bottom == 4)
        {
            end.transform.position = FourNFour.transform.position;
        }
        else if (y == 5 && top == -9 && bottom == 4)
        {
            end.transform.position = FourNFour.transform.position;
        }


        //-4 and -5
        if (y == -5 && top == 1 && bottom == 5)
        {
            end.transform.position = FourNFive.transform.position;
        }
        else if (y == -4 && top == 0 && bottom == 5)
        {
            end.transform.position = FourNFive.transform.position;
        }
        else if (y == -3 && top == -1 && bottom == 5)
        {
            end.transform.position = FourNFive.transform.position;
        }
        else if (y == -2 && top == -2 && bottom == 5)
        {
            end.transform.position = FourNFive.transform.position;
        }
        else if (y == -1 && top == -3 && bottom == 5)
        {
            end.transform.position = FourNFive.transform.position;
        }
        else if (y == 0 && top == -4 && bottom == 5)
        {
            end.transform.position = FourNFive.transform.position;
        }
        else if (y == 1 && top == -5 && bottom == 5)
        {
            end.transform.position = FourNFive.transform.position;
        }
        else if (y == 2 && top == -6 && bottom == 5)
        {
            end.transform.position = FourNFive.transform.position;
        }
        else if (y == 3 && top == -7 && bottom == 5)
        {
            end.transform.position = FourNFive.transform.position;
        }
        else if (y == 4 && top == -8 && bottom == 5)
        {
            end.transform.position = FourNFive.transform.position;
        }
        else if (y == 5 && top == -9 && bottom == 5)
        {
            end.transform.position = FourNFive.transform.position;
        }


        //-5 and -1
        if (y == -5 && top == 0 && bottom == 1)
        {
            end.transform.position = FiveNOne.transform.position;
        }
        else if (y == -4 && top == -1 && bottom == 1)
        {
            end.transform.position = FiveNOne.transform.position;
        }
        else if (y == -3 && top == -2 && bottom == 1)
        {
            end.transform.position = FiveNOne.transform.position;
        }
        else if (y == -2 && top == -3 && bottom == 1)
        {
            end.transform.position = FiveNOne.transform.position;
        }
        else if (y == -1 && top == -4 && bottom == 1)
        {
            end.transform.position = FiveNOne.transform.position;
        }
        else if (y == 0 && top == -5 && bottom == 1)
        {
            end.transform.position = FiveNOne.transform.position;
        }
        else if (y == 1 && top == -6 && bottom == 1)
        {
            end.transform.position = FiveNOne.transform.position;
        }
        else if (y == 2 && top == -7 && bottom == 1)
        {
            end.transform.position = FiveNOne.transform.position;
        }
        else if (y == 3 && top == -8 && bottom == 1)
        {
            end.transform.position = FiveNOne.transform.position;
        }
        else if (y == 4 && top == -9 && bottom == 1)
        {
            end.transform.position = FiveNOne.transform.position;
        }
        else if (y == 5 && top == -10 && bottom == 1)
        {
            end.transform.position = FiveNOne.transform.position;
        }


        //-5 and -2
        if (y == -5 && top == 0 && bottom == 2)
        {
            end.transform.position = FiveNTwo.transform.position;
        }
        else if (y == -4 && top == -1 && bottom == 2)
        {
            end.transform.position = FiveNTwo.transform.position;
        }
        else if (y == -3 && top == -2 && bottom == 2)
        {
            end.transform.position = FiveNTwo.transform.position;
        }
        else if (y == -2 && top == -3 && bottom == 2)
        {
            end.transform.position = FiveNTwo.transform.position;
        }
        else if (y == -1 && top == -4 && bottom == 2)
        {
            end.transform.position = FiveNTwo.transform.position;
        }
        else if (y == 0 && top == -5 && bottom == 2)
        {
            end.transform.position = FiveNTwo.transform.position;
        }
        else if (y == 1 && top == -6 && bottom == 2)
        {
            end.transform.position = FiveNTwo.transform.position;
        }
        else if (y == 2 && top == -7 && bottom == 2)
        {
            end.transform.position = FiveNTwo.transform.position;
        }
        else if (y == 3 && top == -8 && bottom == 2)
        {
            end.transform.position = FiveNTwo.transform.position;
        }
        else if (y == 4 && top == -9 && bottom == 2)
        {
            end.transform.position = FiveNTwo.transform.position;
        }
        else if (y == 5 && top == -10 && bottom == 2)
        {
            end.transform.position = FiveNTwo.transform.position;
        }


        //-5 and -3
        if (y == -5 && top == 0 && bottom == 3)
        {
            end.transform.position = FiveNThree.transform.position;
        }
        else if (y == -4 && top == -1 && bottom == 3)
        {
            end.transform.position = FiveNThree.transform.position;
        }
        else if (y == -3 && top == -2 && bottom == 3)
        {
            end.transform.position = FiveNThree.transform.position;
        }
        else if (y == -2 && top == -3 && bottom == 3)
        {
            end.transform.position = FiveNThree.transform.position;
        }
        else if (y == -1 && top == -4 && bottom == 3)
        {
            end.transform.position = FiveNThree.transform.position;
        }
        else if (y == 0 && top == -5 && bottom == 3)
        {
            end.transform.position = FiveNThree.transform.position;
        }
        else if (y == 1 && top == -6 && bottom == 3)
        {
            end.transform.position = FiveNThree.transform.position;
        }
        else if (y == 2 && top == -7 && bottom == 3)
        {
            end.transform.position = FiveNThree.transform.position;
        }
        else if (y == 3 && top == -8 && bottom == 3)
        {
            end.transform.position = FiveNThree.transform.position;
        }
        else if (y == 4 && top == -9 && bottom == 3)
        {
            end.transform.position = FiveNThree.transform.position;
        }
        else if (y == 5 && top == -10 && bottom == 3)
        {
            end.transform.position = FiveNThree.transform.position;
        }


        //-5 and -4
        if (y == -5 && top == 0 && bottom == 4)
        {
            end.transform.position = FiveNFour.transform.position;
        }
        else if (y == -4 && top == -1 && bottom == 4)
        {
            end.transform.position = FiveNFour.transform.position;
        }
        else if (y == -3 && top == -2 && bottom == 4)
        {
            end.transform.position = FiveNFour.transform.position;
        }
        else if (y == -2 && top == -3 && bottom == 4)
        {
            end.transform.position = FiveNFour.transform.position;
        }
        else if (y == -1 && top == -4 && bottom == 4)
        {
            end.transform.position = FiveNFour.transform.position;
        }
        else if (y == 0 && top == -5 && bottom == 4)
        {
            end.transform.position = FiveNFour.transform.position;
        }
        else if (y == 1 && top == -6 && bottom == 4)
        {
            end.transform.position = FiveNFour.transform.position;
        }
        else if (y == 2 && top == -7 && bottom == 4)
        {
            end.transform.position = FiveNFour.transform.position;
        }
        else if (y == 3 && top == -8 && bottom == 4)
        {
            end.transform.position = FiveNFour.transform.position;
        }
        else if (y == 4 && top == -9 && bottom == 4)
        {
            end.transform.position = FiveNFour.transform.position;
        }
        else if (y == 5 && top == -10 && bottom == 4)
        {
            end.transform.position = FiveNFour.transform.position;
        }


        //-5 and -5
        if (y == -5 && top == 0 && bottom == 5)
        {
            end.transform.position = FiveNFive.transform.position;
        }
        else if (y == -4 && top == -1 && bottom == 5)
        {
            end.transform.position = FiveNFive.transform.position;
        }
        else if (y == -3 && top == -2 && bottom == 5)
        {
            end.transform.position = FiveNFive.transform.position;
        }
        else if (y == -2 && top == -3 && bottom == 5)
        {
            end.transform.position = FiveNFive.transform.position;
        }
        else if (y == -1 && top == -4 && bottom == 5)
        {
            end.transform.position = FiveNFive.transform.position;
        }
        else if (y == 0 && top == -5 && bottom == 5)
        {
            end.transform.position = FiveNFive.transform.position;
        }
        else if (y == 1 && top == -6 && bottom == 5)
        {
            end.transform.position = FiveNFive.transform.position;
        }
        else if (y == 2 && top == -7 && bottom == 5)
        {
            end.transform.position = FiveNFive.transform.position;
        }
        else if (y == 3 && top == -8 && bottom == 5)
        {
            end.transform.position = FiveNFive.transform.position;
        }
        else if (y == 4 && top == -9 && bottom == 5)
        {
            end.transform.position = FiveNFive.transform.position;
        }
        else if (y == 5 && top == -10 && bottom == 5)
        {
            end.transform.position = FiveNFive.transform.position;
        }
    }
}
