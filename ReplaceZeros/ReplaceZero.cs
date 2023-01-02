using System.Text;

namespace ReplaceZeros
{
    public class ReplaceZero
    {
        public string replaceZeros_1(string numbers)
        {
            var result = new StringBuilder();
            var zeroCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == '0')
                {
                    zeroCount++;
                    if (zeroCount > 1)
                    {
                        string currentValue = result[^1].ToString();
                        result.Remove(result.Length - 1, 1);
                        int parsedCurrentValue = int.Parse(currentValue);
                        parsedCurrentValue++;

                        result.Append(parsedCurrentValue);
                    }
                    else
                    {
                        result.Append(zeroCount);
                    }
                }
                else
                {
                    result.Append(numbers[i]);
                    zeroCount = 0;
                }
            }

            return result.ToString();
        }

        public string replaceZeros_2(string numbers)
        {
            var result = new StringBuilder();
            var zeroCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == '0')
                {
                    zeroCount++;
                }
                else
                {
                    if (zeroCount > 0)
                    {
                        result.Append(zeroCount);
                    }

                    result.Append(numbers[i]);
                    zeroCount = 0;
                }
            }

            if (zeroCount > 0)
            {
                result.Append(zeroCount);
            }

            return result.ToString();
        }

    }
}
