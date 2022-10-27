// Jasmine Leek
// 25oct2022
// Greater Than Less Than - Endpoints
// this is an api that takes in two numbers and compares them
// peer review: Lerissa Lazar: The program works well, I like that you added the data validation :) good job!

using Microsoft.AspNetCore.Mvc;

namespace LeekJGreaterThanEP.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterThanController : ControllerBase
{
    [HttpGet]
    [Route ("Numbers/{number1}/{number2}")]

    public string GreaterThan(string number1, string number2)
    {
        int validNum1 = 0; 
        int validNum2 = 0;
        bool res1 = true;
        bool res2 = true;

        res1 = Int32.TryParse(number1, out validNum1);
        res2 = Int32.TryParse(number2, out validNum2);

        if (res1 == true && res2 == true)
        {
            if (validNum1 > validNum2)
            {
                return $"{validNum1} is greater than {validNum2}. \n{validNum2} is less than {validNum1}.";
            }
            else if (validNum1 < validNum2)
            {
                return $"{validNum1} is less than {validNum2}. \n{validNum2} is greater than {validNum1}.";
            }
            else
            {
                return $"{validNum1} is equal to {validNum2}.";
            }
        }
        else
        {
            return "Invalid entry - please try again using numbers.";
        }
    }
}