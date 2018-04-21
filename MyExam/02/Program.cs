using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            long dnaLength = long.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            List<List<long>> dnaSequences = new List<List<long>>();
            Dictionary<long, long> qntyOnesInDnaSequences = new Dictionary<long, long>();
            Dictionary<long, long> sumsInDnaSequences = new Dictionary<long, long>();
            Dictionary<long, long> startIndexInDnaSequences = new Dictionary<long, long>();

            long counterForDna = 0;
            long counterForOnes = 0;

            while (command != "Clone them!")
            {
                List<long> currentDnaSeq = command.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
                dnaSequences.Add(currentDnaSeq);

                command = Console.ReadLine();
            }

            foreach (var dnaseq in dnaSequences)
            {
                long currentCounter = 0;
                counterForDna++;

                if (dnaseq[0] == 1)
                {
                    currentCounter++;
                    counterForOnes = currentCounter;
                    qntyOnesInDnaSequences.Add(counterForDna, counterForOnes);
                    startIndexInDnaSequences.Add(counterForDna, 0);
                }

                for (int i = 1; i < dnaseq.Count; i++)
                {
                    if (dnaseq[i] == 1 && dnaseq[i - 1] == 1)
                    {
                        currentCounter++;

                        if (i == dnaseq.Count - 1)
                        {
                            if (currentCounter > counterForOnes)
                            {
                                counterForOnes = currentCounter;
                            }
                        }
                    }
                    else
                    {
                        if (currentCounter > counterForOnes)
                        {
                            counterForOnes = currentCounter;
                        }

                        if (i == dnaseq.Count - 1)
                        {
                            if (currentCounter > counterForOnes)
                            {
                                counterForOnes = currentCounter;
                            }
                        }
                        currentCounter = 1;
                    }                   
                }

                try
                {
                    qntyOnesInDnaSequences[counterForDna] = counterForOnes;
                }
                catch
                {
                    qntyOnesInDnaSequences.Add(counterForDna, counterForOnes);
                }

                if (counterForOnes >= qntyOnesInDnaSequences.Values.Max())
                {
                    sumsInDnaSequences.Add(counterForDna, dnaseq.Sum());
                }
                else
                {
                    sumsInDnaSequences.Add(counterForDna, 0);
                }

                counterForOnes = 0;
            }

            qntyOnesInDnaSequences = qntyOnesInDnaSequences.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            sumsInDnaSequences = sumsInDnaSequences.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            long counter;
            string dnaSequence;
            long dnaSeqSum;

            if (qntyOnesInDnaSequences.Count() > 1)
            {
                if (qntyOnesInDnaSequences.Values.First() == qntyOnesInDnaSequences.Values.Skip(1).First())
                {
                    dnaSeqSum = sumsInDnaSequences.Values.First();
                    counter = sumsInDnaSequences.Keys.First();
                    dnaSequence = string.Join(" ", dnaSequences[(int)counter - 1]);
                }
                else
                {
                    counter = qntyOnesInDnaSequences.Keys.First();
                    dnaSequence = string.Join(" ", dnaSequences[(int)counter - 1]);
                    dnaSeqSum = sumsInDnaSequences[counter];
                }
            }
            else
            {
                counter = qntyOnesInDnaSequences.Keys.First();
                dnaSequence = string.Join(" ", dnaSequences[(int)counter - 1]);
                dnaSeqSum = sumsInDnaSequences[counter];
            }

            Console.WriteLine($"Best DNA sample {counter} with sum: {dnaSeqSum:f0}.");
            Console.WriteLine(dnaSequence);
        }
    }
}
