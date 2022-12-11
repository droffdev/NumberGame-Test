using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Generator
    {
        int number;
        int inputNumber;
        string result;
        bool success;

        public Generator(int input)
        {
            inputNumber = input;
        }

        public void UserUpdate(int number) 
        {
            this.number = number;
            success = false;
            Game();
        }
        
        public string ReturnResult()
        {
            return result;
        }

        public bool GetSuccess() 
        {
            return success;
        }

        private void Game()
        {
            if (inputNumber == number ) 
            {
                result = "Числа равны!";
                success = true;
            }
            else 
            {
                if (number > inputNumber) 
                {
                    if (number / inputNumber >= 10)
                    {
                        result = "Много больше!";
                        
                    }
                    if (number / inputNumber >= 2 && number / inputNumber < 10 ) 
                    {
                        result = "Больше!";
                    }
                    if (number / inputNumber < 2) 
                    {
                        result = "Немного больше!";
                    }
                }
                else 
                {
                    if (inputNumber / number >= 10)
                    {
                        result = "Много меньше!";
                        
                    }
                    if (inputNumber / number >= 2 && inputNumber / number < 10 ) 
                    {
                        result = "Меньше!";
                    }
                    if (inputNumber / number < 2)
                    {
                        result = "Немного меньше!";
                    }
                }
            }
        }

        
    }
}
