double semiperimetro, area, lado1, lado2, lado3;

Console.Write("Insira o primeiro lado do triângulo: ");
lado1 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Insira o segundo lado do triângulo: ");
lado2 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Insira o terceiro lado do triângulo: ");
lado3 = Convert.ToDouble(Console.ReadLine()!);

semiperimetro = (lado1 + lado2 + lado3) / 2;
area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));

Console.WriteLine($"\nSemiperímetro: {semiperimetro}\nÁrea.........: {area}");