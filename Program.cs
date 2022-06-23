// See https://aka.ms/new-console-template for more information

using BE5.Classes;

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco ();
/*
novaPf.ValidarDataNascimento (new DateTime (2000,01,01));
novaPf.ValidarDataNascimento("01/01/2000");

novaPf.nome = "Luiz";
novaPf.dataNascimento = "18/02/1984";
novaPf.cpf = "12345678901";
novaPf.rendimento = 500f;
novoEnd.logadouro = "Alameda Barão de Limerira";
novoEnd.numero = 539;
novoEnd.complemento = "Senai de informatica";
novoEnd.endComercial  = true;
novaPf.endereco = novoEnd;

Console.WriteLine($"{novaPf.nome}");
Console.WriteLine($"{novaPf.dataNascimento}");
Console.WriteLine($"{novaPf.cpf}");
Console.WriteLine($"{novaPf.rendimento}");
Console.WriteLine($"{novaPf.endereco.logadouro}");
Console.WriteLine($"{novaPf.endereco.numero}");
Console.WriteLine($"{novaPf.endereco.complemento}");
Console.WriteLine($"{novaPf.endereco.endComercial}");


Console.WriteLine (@$"
Nome: {novaPf.nome}
Endereco: {novaPf.endereco.logadouro},{novaPf.endereco.numero}
Maior de Idade: {novaPf.ValidarDataNascimento(novaPf.dataNascimento)}");
*/

PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPJ = new PessoaJuridica();
Endereco novoEndpj = new Endereco();
novaPJ.nome = "Nome Pj";
novaPJ.cnpj = "00.000.000/0001-00";
novaPJ.razao = "Razap social PJ";
novaPJ.rendimento = 8000.5f;
novoEndpj.logadouro ="Alamedabarao de limeira";
novoEndpj.numero = 539;
novoEndpj.complemento = "Senai Innformatica";
novoEndpj.endComercial = true;
novaPJ.endereco = novoEndpj;

Console.WriteLine(@$"
Nome: {novaPJ.nome}
Razao social: {novaPJ.razao}
CNPJ: {novaPJ.cnpj}
CNPJ Válido? {metodoPj.ValidarCnpj(novaPJ.cnpj)}
");


//Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0001-00")}");
//Console.WriteLine($"{metodoPj.ValidarCnpj("00000000000000")}");
//Console.WriteLine($"{metodoPj.ValidarCnpj("00000000000100")}");
//Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0001-00")}");



