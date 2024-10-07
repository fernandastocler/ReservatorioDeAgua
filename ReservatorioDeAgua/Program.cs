
		int boia1, boia2, boia3;
		bool valvulaLigada, bombaLigada;
		Console.Write("Informe o estado da Boia 1 (0 ou 1): ");
		boia1 = int.Parse(Console.ReadLine());
		Console.Write("Informe o estado da Boia 2 (0 ou 1): ");
		boia2 = int.Parse(Console.ReadLine());
		Console.Write("Informe o estado da Boia 3 (0 ou 1): ");
		boia3 = int.Parse(Console.ReadLine());
		if (boia1 == 0 || boia2 == 0 || boia3 == 0)
		{
			Console.WriteLine("\nLigar válvula e desligar bomba.");
		}

		if (boia1 == 0 || boia2 == 0 || boia3 == 1)
		{
			Console.WriteLine("\nLigar válvula e desligar bomba.");
		}

		if (boia1 == 0 || boia2 == 1 || boia3 == 0)
		{
			Console.WriteLine("\nFalha na válvula e na bomba.");
		}

		if (boia1 == 0 || boia2 == 1 || boia3 == 1)
		{
			Console.WriteLine("\nFalha na válvula e na bomba.");
		}

		if (boia1 == 1 || boia2 == 0 || boia3 == 0)
		{
			Console.WriteLine("\nLigar válvula e ligar bomba.");
		}

		if (boia1 == 1 || boia2 == 0 || boia3 == 1)
		{
			Console.WriteLine("\nLigar válvula e desligar bomba.");
		}

		if (boia1 == 1 || boia2 == 1 || boia3 == 0)
		{
			Console.WriteLine("\nDesligar válvula e ligar bomba.");
		}

		if (boia1 == 1 && boia2 == 1 && boia3 == 1)
		{
			Console.WriteLine("\nDesligar válvula e desligar bomba.");
		}
