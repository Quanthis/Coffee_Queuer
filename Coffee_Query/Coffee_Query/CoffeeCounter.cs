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
            Long,

            DoppioPlus,
            Americano,
            Espressox2,
            CappuccinoPlus,
            CappuccinoMix,
            Latte,
            FlatWhite,
            EspressoMacchiato
        };

        private CoffeesAmount cappucinoAmount;
        private CoffeesAmount latteMacchiatioAmount;
        private CoffeesAmount milkAmount;
        private CoffeesAmount espressoAmount;
        private CoffeesAmount blackAmount;
        private CoffeesAmount longAmount;

        private CoffeesAmount doppioPlusAmount;
        private CoffeesAmount americanoAmount;
        private CoffeesAmount espressox2Amount;
        private CoffeesAmount cappuccinoPlusAmount;
        private CoffeesAmount cappuccinoMixAmount;
        private CoffeesAmount latteAmount;
        private CoffeesAmount flatWhiteAmount;
        private CoffeesAmount espressoMacchiatoAmount;

        private List<CoffeesAmount> allCoffees;   //what is this?? 2d list?? 1,5d list?? XD


        public CoffeeCounter()
        {
            allCoffees = new List<CoffeesAmount>();

            cappucinoAmount = new CoffeesAmount();
            latteMacchiatioAmount = new CoffeesAmount();
            milkAmount = new CoffeesAmount();
            espressoAmount = new CoffeesAmount();
            blackAmount = new CoffeesAmount();
            longAmount = new CoffeesAmount();
            
            doppioPlusAmount = new CoffeesAmount();
            americanoAmount = new CoffeesAmount();
            espressox2Amount = new CoffeesAmount();
            cappuccinoPlusAmount = new CoffeesAmount();
            cappuccinoMixAmount = new CoffeesAmount();
            latteAmount = new CoffeesAmount();
            flatWhiteAmount = new CoffeesAmount();
            espressoMacchiatoAmount = new CoffeesAmount();

            allCoffees.Add(cappucinoAmount);
            allCoffees.Add(latteMacchiatioAmount);
            allCoffees.Add(milkAmount);
            allCoffees.Add(espressoAmount);
            allCoffees.Add(blackAmount);
            allCoffees.Add(longAmount);
            
            allCoffees.Add(doppioPlusAmount);
            allCoffees.Add(americanoAmount);
            allCoffees.Add(espressox2Amount);
            allCoffees.Add(cappuccinoPlusAmount);
            allCoffees.Add(cappuccinoMixAmount);
            allCoffees.Add(latteAmount);
            allCoffees.Add(flatWhiteAmount);
            allCoffees.Add(espressoMacchiatoAmount);
        }

        #region Getting
        public Label ReturnCheckedAmount(Coffees coffeToChange, Label resultLabel)
        {
            string[] result = GetAmount(coffeToChange);
            resultLabel.FontSize = 17;
            resultLabel.Text = "Amount: ";
            resultLabel.TextColor = Xamarin.Forms.Color.White;
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

                case Coffees.DoppioPlus:
                    result[0] = "Doppio+ amount: ";
                    result[1] = doppioPlusAmount.amount.ToString();
                    return result;

                case Coffees.Americano:
                    result[0] = "Americano amount: ";
                    result[1] = americanoAmount.amount.ToString();
                    return result;

                case Coffees.Espressox2:
                    result[0] = "Double espresso amount: ";
                    result[1] = espressox2Amount.amount.ToString();
                    return result;

                case Coffees.CappuccinoPlus:
                    result[0] = "Cappuccino+ amount: ";
                    result[1] = cappuccinoPlusAmount.amount.ToString();
                    return result;

                case Coffees.CappuccinoMix:
                    result[0] = "Cappuccino Mix amount: ";
                    result[1] = cappuccinoMixAmount.amount.ToString();
                    return result;

                case Coffees.Latte:
                    result[0] = "Latte amount: ";
                    result[1] = latteAmount.amount.ToString();
                    return result;

                case Coffees.FlatWhite:
                    result[0] = "Flat white amount: ";
                    result[1] = flatWhiteAmount.amount.ToString();
                    return result;

                case Coffees.EspressoMacchiato:
                    result[0] = "Espresso Macchiato amount: ";
                    result[1] = espressoMacchiatoAmount.amount.ToString();
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
            resultLabel.TextColor = Xamarin.Forms.Color.White;
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

                    case Coffees.DoppioPlus:
                        --doppioPlusAmount.amount;
                        result[0] = "Doppio+ amount: ";
                        result[1] = doppioPlusAmount.amount.ToString();
                        return result;

                    case Coffees.Americano:
                        --americanoAmount.amount;
                        result[0] = "Americano amount: ";
                        result[1] = americanoAmount.amount.ToString();
                        return result;

                    case Coffees.Espressox2:
                        --espressox2Amount.amount;
                        result[0] = "Double espresso amount: ";
                        result[1] = espressox2Amount.amount.ToString();
                        return result;

                    case Coffees.CappuccinoPlus:
                        --cappuccinoPlusAmount.amount;
                        result[0] = "Cappuccino+ amount: ";
                        result[1] = cappuccinoPlusAmount.amount.ToString();
                        return result;

                    case Coffees.CappuccinoMix:
                        --cappuccinoMixAmount.amount;
                        result[0] = "Cappuccino Mix amount: ";
                        result[1] = cappuccinoMixAmount.amount.ToString();
                        return result;

                    case Coffees.Latte:
                        --latteAmount.amount;
                        result[0] = "Latte amount: ";
                        result[1] = latteAmount.amount.ToString();
                        return result;

                    case Coffees.FlatWhite:
                        --flatWhiteAmount.amount;
                        result[0] = "Flat white amount: ";
                        result[1] = flatWhiteAmount.amount.ToString();
                        return result;

                    case Coffees.EspressoMacchiato:
                        --espressoMacchiatoAmount.amount;
                        result[0] = "Espresso Macchiato amount: ";
                        result[1] = espressoMacchiatoAmount.amount.ToString();
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

                    case Coffees.DoppioPlus:
                        ++doppioPlusAmount.amount;
                        result[0] = "Doppio+ amount: ";
                        result[1] = doppioPlusAmount.amount.ToString();
                        return result;

                    case Coffees.Americano:
                        ++americanoAmount.amount;
                        result[0] = "Americano amount: ";
                        result[1] = americanoAmount.amount.ToString();
                        return result;

                    case Coffees.Espressox2:
                        ++espressox2Amount.amount;
                        result[0] = "Double espresso amount: ";
                        result[1] = espressox2Amount.amount.ToString();
                        return result;

                    case Coffees.CappuccinoPlus:
                        ++cappuccinoPlusAmount.amount;
                        result[0] = "Cappuccino+ amount: ";
                        result[1] = cappuccinoPlusAmount.amount.ToString();
                        return result;

                    case Coffees.CappuccinoMix:
                        ++cappuccinoMixAmount.amount;
                        result[0] = "Cappuccino Mix amount: ";
                        result[1] = cappuccinoMixAmount.amount.ToString();
                        return result;

                    case Coffees.Latte:
                        ++latteAmount.amount;
                        result[0] = "Latte amount: ";
                        result[1] = latteAmount.amount.ToString();
                        return result;

                    case Coffees.FlatWhite:
                        ++flatWhiteAmount.amount;
                        result[0] = "Flat white amount: ";
                        result[1] = flatWhiteAmount.amount.ToString();
                        return result;

                    case Coffees.EspressoMacchiato:
                        ++espressoMacchiatoAmount.amount;
                        result[0] = "Espresso Macchiato amount: ";
                        result[1] = espressoMacchiatoAmount.amount.ToString();
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
