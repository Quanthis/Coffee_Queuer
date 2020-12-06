using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms;

namespace Coffee_Query
{
    public class CoffeeCounter
    {
        public enum Coffees
        {
            Cappucino,
            LatteMachiatio,
            Milk,
            Espresso,
            Black,
            Long
        };

        private CoffeesAmount cappucinoAmount;
        private CoffeesAmount latteMacchiatioAmount;
        private CoffeesAmount milkAmount;
        private CoffeesAmount espressoAmount;
        private CoffeesAmount blackAmount;
        private CoffeesAmount longAmount;

        private List<CoffeesAmount> allCoffees;   //what is this?? 2d list?? 1,5d list?? XD

        /*public uint cappucinoAmount;
        public uint latteMacchiatioAmount;
        public uint milkAmount;
        public uint espressoAmount;
        public uint blackAmount;
        public uint longAmount;

        private List<uint> allCoffees;*/


        public CoffeeCounter()
        {
            allCoffees = new List<CoffeesAmount>();

            cappucinoAmount = new CoffeesAmount();
            latteMacchiatioAmount = new CoffeesAmount();
            milkAmount = new CoffeesAmount();
            espressoAmount = new CoffeesAmount();
            blackAmount = new CoffeesAmount();
            longAmount = new CoffeesAmount();

            allCoffees.Add(cappucinoAmount);
            allCoffees.Add(latteMacchiatioAmount);
            allCoffees.Add(milkAmount);
            allCoffees.Add(espressoAmount);
            allCoffees.Add(blackAmount);
            allCoffees.Add(longAmount);
        }

        #region Getting
        public Label ReturnCheckedAmount(Coffees coffeToChange, Label resultLabel)
        {
            string[] result = GetAmount(coffeToChange);
            resultLabel.FontSize = 17;
            resultLabel.Text = "Amount: ";
            resultLabel.VerticalTextAlignment = Xamarin.Forms.TextAlignment.Center;

            resultLabel.Text += result[1];

            return resultLabel;
        }

        private string[] GetAmount(Coffees coffeToChange)
        {
            string[] result = new string[2];

            switch (coffeToChange)
            {
                case Coffees.Cappucino:
                    result[0] = "Cappucino Amount: ";
                    result[1] = cappucinoAmount.amount.ToString();
                    return result;

                case Coffees.LatteMachiatio:
                    result[0] = "Latte Machiato Amount: ";
                    result[1] = latteMacchiatioAmount.amount.ToString();
                    return result;

                case Coffees.Milk:
                    result[0] = "Milk amount: ";
                    result[1] = milkAmount.amount.ToString();
                    return result;

                case Coffees.Espresso:
                    result[0] = "Espresso amount: ";
                    result[1] = espressoAmount.amount.ToString();
                    return result;

                case Coffees.Black:
                    result[0] = "Black amount: ";
                    result[1] = blackAmount.amount.ToString();
                    return result;

                case Coffees.Long:
                    result[0] = "Long amount: ";
                    result[1] = longAmount.amount.ToString();
                    return result;
            }
            

            result[0] = "Wrong coffe choice: ";
            result[1] = "0";
            return result;
        }
        #endregion


        #region Changing
        public Label ReturnCheckedAmount(bool decrease_increase, Coffees coffeToChange, Label resultLabel)
        {
            string[] result = ChangeAmount(decrease_increase, coffeToChange);
            resultLabel.FontSize = 17;
            resultLabel.Text = "Amount: ";
            resultLabel.VerticalTextAlignment = Xamarin.Forms.TextAlignment.Center;
            

            if(Convert.ToInt32(result[1]) < 0)
            {
                resultLabel.Text += "Requested amount of coffees has dropped below 0!";
            }
            else
            {
                resultLabel.Text += result[1];
            }

            return resultLabel;
        }

        private string[] ChangeAmount(bool decrease_increase, Coffees coffeToChange)
        {
            string[] result = new string[2];

            if(decrease_increase)           //case true - decrease
            {
                switch(coffeToChange)
                {
                    case Coffees.Cappucino:
                        --cappucinoAmount.amount;
                        result[0] = "Cappucino Amount: ";
                        result[1] = cappucinoAmount.amount.ToString();
                        return result;

                    case Coffees.LatteMachiatio:
                        --latteMacchiatioAmount.amount;
                        result[0] = "Latte Machiato Amount: ";
                        result[1] = latteMacchiatioAmount.amount.ToString();
                        return result;

                    case Coffees.Milk:
                        --milkAmount.amount;
                        result[0] = "Milk amount: ";
                        result[1] = milkAmount.amount.ToString();
                        return result;

                    case Coffees.Espresso:
                        --espressoAmount.amount;
                        result[0] = "Espresso amount: ";
                        result[1] = espressoAmount.amount.ToString();
                        return result;

                    case Coffees.Black:
                        --blackAmount.amount;
                        result[0] = "Black amount: ";
                        result[1] = blackAmount.amount.ToString();
                        return result;

                    case Coffees.Long:
                        --longAmount.amount;
                        result[0] = "Long amount: ";
                        result[1] = longAmount.amount.ToString();
                        return result;

                }
            }
            else                                                    //case false - increase
            {
                switch (coffeToChange)
                {
                    case Coffees.Cappucino:
                        ++cappucinoAmount.amount;
                        result[0] = "Cappucino Amount: ";
                        result[1] = cappucinoAmount.amount.ToString();
                        return result;

                    case Coffees.LatteMachiatio:
                        ++latteMacchiatioAmount.amount;
                        result[0] = "Latte Machiato Amount: ";
                        result[1] = latteMacchiatioAmount.amount.ToString();
                        return result;

                    case Coffees.Milk:
                        ++milkAmount.amount;
                        result[0] = "Milk amount: ";
                        result[1] = milkAmount.amount.ToString();
                        return result;

                    case Coffees.Espresso:
                        ++espressoAmount.amount;
                        result[0] = "Espresso amount: ";
                        result[1] = espressoAmount.amount.ToString();
                        return result;

                    case Coffees.Black:
                        ++blackAmount.amount;
                        result[0] = "Black amount: ";
                        result[1] = blackAmount.amount.ToString();
                        return result;

                    case Coffees.Long:
                        ++longAmount.amount;
                        result[0] = "Long amount: ";
                        result[1] = longAmount.amount.ToString();
                        return result;
                }
            }

            result[0] = "Wrong coffe choice: ";
            result[1] = "0";
            return result;
        }
        #endregion
    }
}
