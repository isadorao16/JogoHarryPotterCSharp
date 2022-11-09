using System;
using System.Globalization;

namespace curso
{
    class Program
    {


        static void Main(string[] args)
        {

         //ATIVIDADE AULA DE PROGRAMAÇÃO DS
            Console.WriteLine("Pense em algum personagem dentre os pricipais do universo de Harry Potter!");
            string ok = "ok";
            Console.WriteLine("Após pensar, digite 'ok': ");
            ok = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Então vamos lá!");

            bool feminino= false, masculino=false, sim=false, professor=false, aluno=false, diretor=false, nenhum=false, funcionario=false, bom=false, mau=false, tem=false, comensal=false, participou=false, faz=false, vivo=false, morto=false, não = false, ntem = false, nao= false, npart=false, nfaz= false, irmao = false, ordem = false;
        
            Console.WriteLine("O seu personagem é do gênero feminino ou masculino?");
            if (Console.ReadLine() == "feminino")
            {
                feminino = true;
            }
            else
            {
                masculino = true;
            }
            
            Console.Clear();

            Console.WriteLine("O seu personagem tem irmão/irmã?");
            if (Console.ReadLine() == "sim")
            {
                irmao = true;
            }
            else
            {
                irmao = false;
            }

            Console.Clear();

            Console.WriteLine("O seu personagem é jogador de quadribol?");
            if (Console.ReadLine() == "sim")
            {
                sim = true;
            }
            else
            {
                não = true;
            }
            Console.Clear();


            Console.WriteLine("O seu personagem é aluno, diretor, professor ou funcionário de Hogwarts? (pode ser nenhum ou ex-professor/funcionário)");
            String resposta = Console.ReadLine();

            switch (resposta)
            {
                case "diretor":

                        diretor = true;

                    break;

                case "professor":
                    
                        professor = true;
                    
                    break;

                case "aluno":
                  
                        aluno = true;

                    break;

                case "funcionario":
                   
                        funcionario = true;

                  
                    break;

                case "nenhum":
                   
                        nenhum = true;

                    break;

            }
            
            Console.Clear();

            Console.WriteLine("O seu personagem é bom ou mau?");
            if(Console.ReadLine() == "bom")
            {
                bom = true;
            }
            else
            {
                mau = true;
            }

            Console.Clear();
            Console.WriteLine("O seu personagem faz/fez parte da Ordem da Fênix? (MEMBROS OFICIAIS)");
            if (Console.ReadLine() == "sim")
            {
                ordem = true;
            }
            else
            {
                ordem = false;
            }

            Console.Clear();

            Console.WriteLine("O seu personagem tem medo de aranha?");

            if(Console.ReadLine() == "não")
            {
                ntem = true;
            }
            else
            {
                tem = true;
            }

            Console.Clear();

            Console.WriteLine("HMMM...DIFÍCIL");

            Console.WriteLine("O seu personagem é/era um comensal da morte?");
            if (Console.ReadLine() == "sim")
            {
                comensal = true;
            }
            else
            {
                nao = true;
            }

            Console.Clear();

            Console.WriteLine("HMMMM... ESTOU PENSANDO");

            Console.WriteLine("O seu personagem participou do torneio tribruxo?");
            if(Console.ReadLine() == "sim")
            {
                participou = true;
            }
            else
            {
                npart = true;
            }

            Console.Clear();

            Console.WriteLine("O seu personagem faz parte do trio de ouro?");
            if (Console.ReadLine() == "faz")
            {
                faz = true;
            }
            else
            {
                nfaz = true;
            }

            Console.Clear();

            Console.WriteLine("O seu personagem está vivo ou morto?");
            if (Console.ReadLine() == "vivo")
            {
                vivo = true;
            }
            else
            {
                morto = true;
            }

            Console.Clear();

            if (masculino == true && funcionario == true && bom == true && vivo == true && ordem == true)
            {
               
                Console.WriteLine("O seu personagem é Rúbio Hagrid");
            }

            if (masculino == true && sim == true && faz == true && bom == true && vivo == true && aluno == true && participou == true)
            {
                Console.WriteLine("O seu personagem é Harry Potter");
            }
            if (feminino == true && faz == true && bom == true && vivo == true && aluno == true)
            {
                Console.WriteLine("O seu personagem é Hermione Granger");
            }

            if (masculino == true && sim == true && faz == true && bom == true && vivo == true && aluno == true && tem == true && irmao == true)
            {
                Console.WriteLine("O seu personagem é Ronald Weasley");
            }

            if (masculino == true && não == true  && bom == true && morto == true && diretor == true && ordem == true)
            {
                Console.WriteLine("O seu personagem é Alvo Dumbledore");
            }

            if (masculino == true && mau == true && morto == true && professor == true && comensal == true && ordem == true)
            {
                Console.WriteLine("O seu personagem é Severo Snape");
            }

            if (masculino == true && mau == true && morto == true && nenhum == true && comensal == true)
            {
                Console.WriteLine("O seu personagem é Voldemort");
            }

            if (masculino == true && mau == true && vivo == true && nenhum == true && comensal == true)
            {
                Console.WriteLine("O seu personagem é Lúcio Malfoy");
            }

            if (masculino == true && mau == true && vivo == true && aluno == true && comensal == true && sim == true)
            {
                Console.WriteLine("O seu personagem é Draco Malfoy");
            }

            if (masculino == true && mau == true && vivo == true && aluno == true && comensal == true)
            {
                Console.WriteLine("Os seus personagens são Crabbe e Goyle");
            }

            if (feminino == true && nfaz == true && bom == true && vivo == true && aluno == true && irmao == false)
            {
                Console.WriteLine("O seu personagem é Luna Lovegood");
            }

            if (masculino == true && nfaz == true && bom == true && vivo == true && aluno == true && irmao == false)
            {
                Console.WriteLine("O seu personagem é Neville Longbottom");
            }
            if (feminino == true && nfaz == true && bom == true && vivo == true && aluno == true && sim == true && irmao == true)
            {
                Console.WriteLine("O seu personagem é Gina Weasley");
            }
            if (masculino == true && nfaz == true && bom == true && morto == true && professor == true && ordem == true)
            {
                Console.WriteLine("O seu personagem é Remus Lupin");
            }
            if (masculino == true && nfaz == true && bom == true && morto == true && aluno == true && sim == true && irmao == true)
            {
                Console.WriteLine("O seu personagem é Fred Weasley");
            }
            if (masculino == true && nfaz == true && bom == true && vivo == true && aluno == true && sim == true && irmao == true)
            {
                Console.WriteLine("O seu personagem é George Weasley");
            }
            if (feminino == true && nfaz == true && bom == true && vivo == true && professor == true && ordem == true )
            {
                Console.WriteLine("O seu personagem é Minerva Mcgonagall ");
            }
            if (masculino == true && nfaz == true && bom == true && morto == true && aluno == true && participou == true)
            {
                Console.WriteLine("O seu personagem é Cedrico Diggory");
            }
            if (masculino == true && nfaz == true && bom == true && morto == true && nenhum == true && ordem == true)
            {
                Console.WriteLine("O seu personagem é Sirius Black ");
            }
            if (feminino == true && nfaz == true && mau == true && morto == true && nenhum == true && comensal == true)
            {
                Console.WriteLine("O seu personagem é Bellatrix Lestrange");
            }
            if (masculino == true && nfaz == true && bom == true && morto == true && funcionario == true )
            {
                Console.WriteLine("O seu personagem é Dobby");
            }
            if (feminino == true && nfaz == true && bom == true && vivo == true && professor == true)
            {
                Console.WriteLine("O seu personagem é Sibila Trelawney");
            }





















        }
    }
}

