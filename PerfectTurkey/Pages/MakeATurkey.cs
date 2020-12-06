using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectTurkey.Pages
{
    public class MakeATurkey
    {
        public string Recipe(double weight)
        {
            //cups
            double salted = weight * .05;
            //gallons
            double water = weight * .66;
            //cups
            double brwnSugar = weight * .13;

            double shallots = weight * .2;

            double garlic = weight * .4;
            //tbs
            double peppercorns = weight * .13;
            //tbs
            double juniper = weight * .13;
            //tbs
            double rosemary = weight * .13;
            //tbs
            double thyme = weight * .06;
            //hours
            double brineTime = weight * 2.4;
            //minutes
            double cookTime = weight * 15;

            return $" * For a {weight} lb turkey, you'll need: \n - {salted:N} cups of Salt \n - {water:N} gallons of water \n - {brwnSugar:N} cups of brown sugar \n - {shallots:N} shallots \n" +
                $" - {garlic:N} cloves of garlic \n - {peppercorns:N} tablespoons of whole black peppercorns \n - {juniper:N} tablespoons of dried juniper berries \n" +
                $" - {rosemary:N} tablespoons of fresh rosemary \n" +
                $"- {thyme:N} tablespoons of thyme \n - {brineTime:N} hours soaked in brine \n - {(cookTime / 60):N} hours of cook time.";
        }
    }
}
