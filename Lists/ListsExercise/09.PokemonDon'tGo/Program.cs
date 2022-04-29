using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;

            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int pokemon = pokemons[0];
                    sum += pokemon;
                    pokemons[0] = pokemons[pokemons.Count - 1];
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= pokemon)
                        {
                            pokemons[i] += pokemon;
                        }
                        else if (pokemons[i] > pokemon)
                        {
                            pokemons[i] -= pokemon;
                        }
                    }
                }
                else if (index > pokemons.Count - 1)
                {
                    int pokemon = pokemons[pokemons.Count - 1];
                    sum += pokemon;
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= pokemon)
                        {
                            pokemons[i] += pokemon;
                        }
                        else if (pokemons[i] > pokemon)
                        {
                            pokemons[i] -= pokemon;
                        }
                    }
                }
                else
                {
                    int pokemon = pokemons[index];
                    sum += pokemon;
                    pokemons.RemoveAt(index);

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= pokemon)
                        {
                            pokemons[i] += pokemon;
                        }
                        else if (pokemons[i] > pokemon)
                        {
                            pokemons[i] -= pokemon;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
