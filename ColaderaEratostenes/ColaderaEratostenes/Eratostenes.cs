namespace ColaderaEratostenes
{
    class Eratostenes
    {
        public static string NumerosPrimos(int limite)
        {
            string num = "";
            int[] numeros = new int[limite];

            for (int i = 0; i < limite; i++)
                numeros[i] = 1;

            for (int primo = 2; primo < limite; primo++)
            {
                for (int i = primo + 1; i < limite; i++)
                {
                    if (numeros[i] == 1)
                    {
                        if (i % primo == 0)
                        {
                            numeros[i] = 0;
                        }
                    }
                }
            }
            for (int i = 1; i < limite; i++ )
            {
                if (numeros[i] == 1)
                {
                    num += i + ", ";
                }
            }

            return num;
        }
    }
}
