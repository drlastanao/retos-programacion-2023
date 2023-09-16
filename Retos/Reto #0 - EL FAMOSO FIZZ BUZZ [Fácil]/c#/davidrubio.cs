public class Fizzbuzz{

    boolean multiplo(int candidato, int valor)
    {
        return candidato % valor == 0;
    }

    void mensaje(string cadena)
    {
        System.out.println(cadena);
    }

    public static void Main(string args[])
    {
        for (int i=1;i<=100;i++)
        {
            if (multiplo(i,3) && multiplo(i,5)) {
                mensaje("fizzbuz");
            }
            else
            {
                if (multiplo(i,3))
                {
                    mensaje("fizz");
                }
                else
                {
                    if (multiplo(i,5))
                    {
                        mensaje("buzz");
                    }
                    else
                    {
                        mensaje(i.ToString());
                    }
                }
            }
        }
    }
}