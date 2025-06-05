class exerc3

{
    static void Main()
    {
        bool final = false;
        while (!final)
        {
            int[,] cidades =
        {  //V,  B,   R,   S
            {0, 524, 521, 882}, //Vitoria
            {524, 0, 434, 586}, //BH
            {521, 434, 0, 429}, //Rio
            { 882, 586, 429, 0} //SP
        };

            Console.WriteLine("Digite a cidade origem: \n->Vitória<-\n->Belo Horizonte<-\n->Rio de Janeiro<-\n->São Paulo<-");
            string origem = Console.ReadLine();
            origem.ToUpper();

            int indiceOrigem = 0;
            switch (origem)
            {
                case "VITÓRIA":
                    indiceOrigem = 0;
                    break;
                case "BELO HORIZONTE":
                    indiceOrigem = 1;
                    break;
                case "RIO DE JANEIRO":
                    indiceOrigem = 2;
                    break;
                case "SÃO PAULO":
                    indiceOrigem = 3;
                    break;
            }


            Console.WriteLine("Digite a cidade origem: \n->Vitória<-\n->Belo Horizonte<-\n->Rio de Janeiro<-\n->São Paulo<-");
            string destino = Console.ReadLine();
            destino.ToUpper();

            int indiceDestino = 0;
            switch (destino)
            {
                case "VITÓRIA":
                    indiceDestino = 0;
                    break;
                case "BELO HORIZONTE":
                    indiceDestino = 1;
                    break;
                case "RIO DE JANEIRO":
                    indiceDestino = 2;
                    break;
                case "SÃO PAULO":
                    indiceDestino = 3;
                    break;
            }

            Console.WriteLine($"A distancia entre {origem} para {destino} é: {cidades[indiceOrigem, indiceDestino]}");

            if (indiceDestino == indiceOrigem)
            {
                final = true;
            }
        }
    }
}