using System;

namespace Api.VendaVeiculo.Application.ViewModels.Validators
{
    public class StatusExists
    {
        public string Item { get; set; }

        public StatusExists(string item)
        {
            Item = item;
        }

        public bool enumValue()
        {
            var checkEnum = numberRange(Convert.ToInt32(Item));

            return checkEnum;
        }

        public bool numberRange(int number)
        {
            int[] intEnum = new int[] { 0, 1, 2, 3, 4 };


            foreach (var i in intEnum)
            {
                if (i == number)
                    return true;
            }

            return false;
        }
    }
}
