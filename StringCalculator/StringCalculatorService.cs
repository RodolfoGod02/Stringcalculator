namespace StringCalculator
{
    public class StringCalculatorService
    {
        public int Add(string numbers)
        {
            char[] separadores = { ',', '\n' };

            if (String.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            var parts = numbers.Split(separadores);

            int suma = 0;
            int delimitadorI = numbers.IndexOf('\n');
            if (delimitadorI != -1)
            {
                string del = numbers.Substring(2, delimitadorI - 2);
                string numberspart = numbers.Substring(delimitadorI + 1);
                string[] numbersArray = numberspart.Split(new string[] { del }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string number in numbersArray)
                {
                    if (int.TryParse(number, out int num))
                    {
                        if (num <= -1)
                        {
                            Console.WriteLine("El metodo add no permite numeros negativos" + num);
                            num = 0;
                        }
                        suma += num;

                    }
                }
            }

            _ = numbers.Split(',', '\n');
            //if (parts.Length == 1 ) {
            //return int.Parse(parts[0]);
            //}
            var contador = parts.Length;
            for (int i = 0; i < parts.Length; i++)
            {
                suma = suma + int.Parse(parts[i]);
            }
            return suma;

        }
    }
}