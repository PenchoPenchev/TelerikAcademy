namespace ConvertsNumbersInText
{
    using System;
    class ConvertsNumbersInText
    {
        static void Main(string[] args)
        {
            /** Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation.                     Examples:
             * 0  "Zero"
             * 273  "Two hundred seventy three"
             * 400  "Four hundred"
             * 501  "Five hundred and one"
             * 711  "Seven hundred and eleven"*/

            Console.Write("Type a number [0..999]: ");
            int num = Int16.Parse(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.Write("Zero");
                    break;
                case 1:
                    Console.Write("One");
                    break;
                case 2:
                    Console.Write("Two");
                    break;
                case 3:
                    Console.Write("Three");
                    break;
                case 4:
                    Console.Write("Four");
                    break;
                case 5:
                    Console.Write("Five");
                    break;
                case 6:
                    Console.Write("Six");
                    break;
                case 7:
                    Console.Write("Seven");
                    break;
                case 8:
                    Console.Write("Eight");
                    break;
                case 9:
                    Console.Write("Nine");
                    break;
                case 10:
                    Console.Write("Ten");
                    break;
                case 11:
                    Console.Write("Eleven");
                    break;
                case 12:
                    Console.Write("Twelve");
                    break;
                case 13:
                    Console.Write("Thirteen");
                    break;
                case 14:
                    Console.Write("Fourteen");
                    break;
                case 15:
                    Console.Write("Fifteen");
                    break;
                case 16:
                    Console.Write("Sixteen");
                    break;
                case 17:
                    Console.Write("Seventeen");
                    break;
                case 18:
                    Console.Write("Eighteen");
                    break;
                case 19:
                    Console.Write("Nineteen");
                    break;
                default:
                    break;
            }

            int firstDigit;
            int secondDigit;
            int thirdDigit;

            if (num > 19 && num < 100)
            {
                firstDigit = num / 10;
                secondDigit = num % 10;

                if (secondDigit != 0)
                {
                    switch (firstDigit)
                    {
                        case 2:
                            Console.Write("Twenty ");
                            break;
                        case 3:
                            Console.Write("Thirty ");
                            break;
                        case 4:
                            Console.Write("Fourty ");
                            break;
                        case 5:
                            Console.Write("Fifty ");
                            break;
                        case 6:
                            Console.Write("Sixty ");
                            break;
                        case 7:
                            Console.Write("Seventy ");
                            break;
                        case 8:
                            Console.Write("Eighty ");
                            break;
                        case 9:
                            Console.Write("Ninety ");
                            break;
                        default:
                            break;
                    }

                    switch (secondDigit)
                    {
                        case 1:
                            Console.Write("One");
                            break;
                        case 2:
                            Console.Write("Two");
                            break;
                        case 3:
                            Console.Write("Three");
                            break;
                        case 4:
                            Console.Write("Four");
                            break;
                        case 5:
                            Console.Write("Five");
                            break;
                        case 6:
                            Console.Write("Six");
                            break;
                        case 7:
                            Console.Write("Seven");
                            break;
                        case 8:
                            Console.Write("Eight");
                            break;
                        case 9:
                            Console.Write("Nine");
                            break;
                        case 10:
                            Console.Write("Ten");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (firstDigit)
                    {
                        case 2:
                            Console.Write("Twenty");
                            break;
                        case 3:
                            Console.Write("Thirty");
                            break;
                        case 4:
                            Console.Write("Fourty");
                            break;
                        case 5:
                            Console.Write("Fifty");
                            break;
                        case 6:
                            Console.Write("Sixty");
                            break;
                        case 7:
                            Console.Write("Seventy");
                            break;
                        case 8:
                            Console.Write("Eighty");
                            break;
                        case 9:
                            Console.Write("Ninety");
                            break;
                        default:
                            break;
                    }
                }
            }
            else if (num > 99 && num < 1000)
            {
                firstDigit = num / 100;
                secondDigit = (num / 10) % 10;
                thirdDigit = (num % 100) % 10;

                if (secondDigit == 0 && thirdDigit == 0)
                {
                    switch (firstDigit)
                    {
                        case 1:
                            Console.Write("One hundred");
                            break;
                        case 2:
                            Console.Write("Two hundred");
                            break;
                        case 3:
                            Console.Write("Three hundred");
                            break;
                        case 4:
                            Console.Write("Four hunderd");
                            break;
                        case 5:
                            Console.Write("Five hundred");
                            break;
                        case 6:
                            Console.Write("Six hundred");
                            break;
                        case 7:
                            Console.Write("Seven hundred");
                            break;
                        case 8:
                            Console.Write("Eight hundred");
                            break;
                        case 9:
                            Console.Write("Nine hundred");
                            break;
                        default:
                            break;
                    }
                }
                else if (thirdDigit == 0)
                {
                    switch (firstDigit)
                    {
                        case 1:
                            Console.Write("One hundred and");
                            break;
                        case 2:
                            Console.Write("Two hundred and ");
                            break;
                        case 3:
                            Console.Write("Three hundred and ");
                            break;
                        case 4:
                            Console.Write("Four hunderd and ");
                            break;
                        case 5:
                            Console.Write("Five hundred and ");
                            break;
                        case 6:
                            Console.Write("Six hundred and ");
                            break;
                        case 7:
                            Console.Write("Seven hundred and ");
                            break;
                        case 8:
                            Console.Write("Eight hundred and ");
                            break;
                        case 9:
                            Console.Write("Nine hundred and ");
                            break;
                        default:
                            break;
                    }

                    switch (secondDigit)
                    {
                        case 1:
                            Console.Write("Ten");
                            break;
                        case 2:
                            Console.Write("Twenty");
                            break;
                        case 3:
                            Console.Write("Thirty");
                            break;
                        case 4:
                            Console.Write("Fourty");
                            break;
                        case 5:
                            Console.Write("Fifty");
                            break;
                        case 6:
                            Console.Write("Sixty");
                            break;
                        case 7:
                            Console.Write("Seventy");
                            break;
                        case 8:
                            Console.Write("Eighty");
                            break;
                        case 9:
                            Console.Write("Ninety");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    if (secondDigit == 0)
                    {
                        switch (firstDigit)
                        {
                            case 1:
                                Console.Write("One hundred ");
                                break;
                            case 2:
                                Console.Write("Two hundred ");
                                break;
                            case 3:
                                Console.Write("Three hundred ");
                                break;
                            case 4:
                                Console.Write("Four hunderd ");
                                break;
                            case 5:
                                Console.Write("Five hundred ");
                                break;
                            case 6:
                                Console.Write("Six hundred ");
                                break;
                            case 7:
                                Console.Write("Seven hundred ");
                                break;
                            case 8:
                                Console.Write("Eight hundred ");
                                break;
                            case 9:
                                Console.Write("Nine hundred ");
                                break;
                            default:
                                break;
                        }

                        switch (thirdDigit)
                        {
                            case 1:
                                Console.Write("One");
                                break;
                            case 2:
                                Console.Write("Two");
                                break;
                            case 3:
                                Console.Write("Three");
                                break;
                            case 4:
                                Console.Write("Four");
                                break;
                            case 5:
                                Console.Write("Five");
                                break;
                            case 6:
                                Console.Write("Six");
                                break;
                            case 7:
                                Console.Write("Seven");
                                break;
                            case 8:
                                Console.Write("Eight");
                                break;
                            case 9:
                                Console.Write("Nine");
                                break;
                            default:
                                break;
                        }
                    }
                    else if (secondDigit == 1)
                    {
                        switch (firstDigit)
                        {
                            case 1:
                                Console.Write("One hundred and ");
                                break;
                            case 2:
                                Console.Write("Two hundred and ");
                                break;
                            case 3:
                                Console.Write("Three hundred and ");
                                break;
                            case 4:
                                Console.Write("Four hunderd and ");
                                break;
                            case 5:
                                Console.Write("Five hundred and ");
                                break;
                            case 6:
                                Console.Write("Six hundred and ");
                                break;
                            case 7:
                                Console.Write("Seven hundred and ");
                                break;
                            case 8:
                                Console.Write("Eight hundred and ");
                                break;
                            case 9:
                                Console.Write("Nine hundred and ");
                                break;
                            default:
                                break;
                        }

                        switch (thirdDigit)
                        {
                            case 1:
                                Console.Write("Eleven");
                                break;
                            case 2:
                                Console.Write("Twelve");
                                break;
                            case 3:
                                Console.Write("Thirteen");
                                break;
                            case 4:
                                Console.Write("Fourteen");
                                break;
                            case 5:
                                Console.Write("Fifteen");
                                break;
                            case 6:
                                Console.Write("Sixteen");
                                break;
                            case 7:
                                Console.Write("Seventeen");
                                break;
                            case 8:
                                Console.Write("Eighteen");
                                break;
                            case 9:
                                Console.Write("Nineteen");
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (firstDigit)
                        {
                            case 1:
                                Console.Write("One hundred ");
                                break;
                            case 2:
                                Console.Write("Two hundred ");
                                break;
                            case 3:
                                Console.Write("Three hundred ");
                                break;
                            case 4:
                                Console.Write("Four hunderd ");
                                break;
                            case 5:
                                Console.Write("Five hundred ");
                                break;
                            case 6:
                                Console.Write("Six hundred ");
                                break;
                            case 7:
                                Console.Write("Seven hundred ");
                                break;
                            case 8:
                                Console.Write("Eight hundred ");
                                break;
                            case 9:
                                Console.Write("Nine hundred ");
                                break;
                            default:
                                break;
                        }

                        switch (secondDigit)
                        {
                            case 2:
                                Console.Write(" Twenty-");
                                break;
                            case 3:
                                Console.Write(" Thirty-");
                                break;
                            case 4:
                                Console.Write(" Fourty-");
                                break;
                            case 5:
                                Console.Write(" Fifty-");
                                break;
                            case 6:
                                Console.Write(" Sixty-");
                                break;
                            case 7:
                                Console.Write(" Seventy-");
                                break;
                            case 8:
                                Console.Write(" Eighty-");
                                break;
                            case 9:
                                Console.Write(" Ninety-");
                                break;
                            default:
                                break;
                        }

                        switch (thirdDigit)
                        {
                            case 1:
                                Console.Write("One");
                                break;
                            case 2:
                                Console.Write("Two");
                                break;
                            case 3:
                                Console.Write("Three");
                                break;
                            case 4:
                                Console.Write("Four");
                                break;
                            case 5:
                                Console.Write("Five");
                                break;
                            case 6:
                                Console.Write("Six");
                                break;
                            case 7:
                                Console.Write("Seven");
                                break;
                            case 8:
                                Console.Write("Eight");
                                break;
                            case 9:
                                Console.Write("Nine");
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
